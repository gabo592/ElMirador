using Common.Util;
using System.Data.SqlClient;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Reflection;
using System.IO;

namespace Connection
{
    /// <summary>
    /// Clase encargada de comunicarse directamente con la base de datos.
    /// </summary>
    public class Database
    {
        #region Private Fields

        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        /// <summary>
        /// Cadena de conexión para la base de datos.
        /// </summary>
        private readonly string Connection;

        #endregion

        public Database(ErrorHandler handler, string connection)
        {
            if (string.IsNullOrWhiteSpace(connection)) throw new ArgumentNullException(nameof(connection), "La cadena de conexión no puede estar vacía.");

            Handler = handler;
            Connection = connection;
        }

        /// <summary>
        /// Método encargado de realizar lectura y ejecución de un procedimiento almacenado tomando en cuenta su nombre y una colección de valores siendo los parámetros del procedimiento.
        /// </summary>
        /// <typeparam name="TModel">Tipo de modelo resultante de la ejecución del procedimiento.</typeparam>
        /// <param name="procedure">Nombre del procedimiento almacenado.</param>
        /// <param name="parameters">Colección genérica de pares clave-valor que conforman los parámetros del procedimiento.</param>
        /// <returns>Colección de objetos del tipo especificado como resultado de la ejecución del procedimiento.</returns>
        /// <exception cref="NullReferenceException">Se dispara cuando el nombre del procedimiento almacenado no se especifica.</exception>
        /// <exception cref="ArgumentException">Se dispara cuando no se logra establecer la conexión.</exception>
        public IEnumerable<TModel> Read<TModel>(string procedure, IDictionary<string, object> parameters) where TModel : new()
        {
            if (string.IsNullOrWhiteSpace(procedure)) throw new ArgumentNullException(nameof(procedure), "El nombre del procedimiento almacenado no puede estar vacío.");

            if (parameters is null) parameters = new Dictionary<string, object>();

            using (SqlConnection connection = new SqlConnection(Connection))
            {
                try
                {
                    connection.Open();
                }
                catch
                {
                    throw new ArgumentException("No se logró establecer la conexión.");
                }

                using (SqlCommand command = new SqlCommand(procedure, connection)
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandTimeout = 20
                })
                {
                    SqlCommandBuilder.DeriveParameters(command);

                    foreach (SqlParameter parameter in command.Parameters)
                    {
                        parameters.TryGetValue(RemoveSign(parameter.ParameterName), out object value);

                        if (value is null)
                        {
                            parameter.Value = DBNull.Value;
                            continue;
                        }

                        if (value is Image image)
                        {
                            parameter.Value = ConvertImageToByteArray(image);
                            continue;
                        }

                        parameter.Value = value;
                    }

                    try
                    {
                        IDataReader reader = command.ExecuteReader();
                        return MapToObject<TModel>(reader);
                    }
                    catch (Exception ex)
                    {
                        Handler.Add(ex);
                        return Enumerable.Empty<TModel>();
                    }
                }
            }
        }

        /// <summary>
        /// Construye nuevos objetos del tipo especificado a partir de un lector de datos proveniente de la base de datos.
        /// </summary>
        /// <typeparam name="TModel">Tipo de modelo a convertir.</typeparam>
        /// <param name="reader">Lector de datos.</param>
        /// <returns>Colección de objetos del tipo especificado.</returns>
        public IEnumerable<TModel> MapToObject<TModel>(IDataReader reader) where TModel : new()
        {
            Type type = typeof(TModel);

            while (reader.Read())
            {
                TModel model = new TModel();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    string name = reader.GetName(i);
                    PropertyInfo propertyInfo = type.GetProperty(name);

                    if (propertyInfo is null) continue;

                    object value = reader.IsDBNull(i) ? null : reader.GetValue(i);

                    ConvertTypeOfValue(ref value, propertyInfo);

                    propertyInfo.SetValue(model, value);
                }

                yield return model;
            }
        }

        #region Private Methods

        private void ConvertTypeOfValue(ref object value, PropertyInfo propertyInfo)
        {
            if (value is decimal && propertyInfo.PropertyType == typeof(double)) value = Convert.ToDouble(value);
            if (value is decimal && propertyInfo.PropertyType == typeof(float)) value = Convert.ToSingle(value);
            if (value is double && propertyInfo.PropertyType == typeof(decimal)) value = Convert.ToDecimal(value);
            if (value is double && propertyInfo.PropertyType == typeof(float)) value = Convert.ToSingle(value);
            if (value is float && propertyInfo.PropertyType == typeof(decimal)) value = Convert.ToDecimal(value);
            if (value is float && propertyInfo.PropertyType == typeof(double)) value = Convert.ToDouble(value);
            if (value is byte[] && propertyInfo.PropertyType == typeof(string)) value = string.Empty;
            if (value is byte[] && propertyInfo.PropertyType == typeof(Image)) value = ConvertToImage(value as byte[]);
            if (value is null && propertyInfo.PropertyType == typeof(DateTime)) value = DateTime.Now;
        }

        /// <summary>
        /// Convierte un arreglo de bytes a su representación gráfica; obteniendo así una imagen.
        /// </summary>
        /// <param name="imageBytes">Arreglo de bytes de la figura.</param>
        /// <returns>Imagen representativa del arreglo de bytes.</returns>
        private Image ConvertToImage(byte[] imageBytes)
        {
            if (imageBytes is null) return null;

            MemoryStream stream = new MemoryStream(imageBytes);

            return new Bitmap(stream);
        }

        /// <summary>
        /// Convierte una imagen a su respectivo arreglo de bytes.
        /// </summary>
        /// <param name="image">Imagen a convertir.</param>
        /// <returns>Arreglo de bytes de la imagen.</returns>
        private byte[] ConvertImageToByteArray(Image image)
        {
            if (image is null) return null;

            MemoryStream stream = new MemoryStream();
            image.Save(stream, image.RawFormat);

            return stream.ToArray();
        }

        /// <summary>
        /// Elimina el primer caracter de una cadena de parámetro, suponiendo que se trata de un arroba.
        /// </summary>
        /// <param name="parameter">Parámetro a editar.</param>
        /// <returns>Nombre del parámetro sin el arroba.</returns>
        private string RemoveSign(string parameter) => parameter.Substring(1);

        #endregion
    }
}
