using Connection.Interfaces.Inventario;
using ElMirador.Servicios.Base;
using ElMirador.ViewModels.Inventario;
using Models.Inventario;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace ElMirador.Servicios.Inventario
{
    /// <summary>
    /// Clase encargada de Proveer los servicios a las Materias Primas.
    /// </summary>
    internal class MateriaPrimaService : ServicioBase
    {
        /// <summary>
        /// DAO de la Materia Prima.
        /// </summary>
        private readonly IMateriaPrimaDao materiaPrimaDao;

        public MateriaPrimaService()
        {
            materiaPrimaDao = DaoFactory.Get<IMateriaPrimaDao>(Handler);
        }

        /// <summary>
        /// Crea una Materia Prima en la base de datos dada una colección de pares clave-valor que corresponden a las propiedades del objeto.
        /// </summary>
        /// <param name="properties">Propiedades de la Materia Prima.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando las propiedades no se proporcionan.</exception>
        public void Create(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "Las propiedades del objeto no pueden ser nulas.");

            MateriaPrima materiaPrima = materiaPrimaDao.Create(new MateriaPrima
            {
                Descripcion = properties["Descripcion"].ToString(),
                UnidadMedida = properties["UnidadMedida"].ToString(),
                Cantidad = Convert.ToDouble(properties["Cantidad"]),
                Precio = Convert.ToDecimal(properties["Precio"]),
                Foto = (Image)properties["Foto"]
            });

            if (materiaPrima.Id.Equals(default)) Handler.Add("MODELO_DEFAULT");
        }

        /// <inheritdoc cref="IMateriaPrimaDao.GetById(int)"/>
        public MateriaPrima GetById(int id) => materiaPrimaDao.GetById(id);

        /// <summary>
        /// Obtiene las materias primas que coincidan con el valor a filtrar. Puede ser por: descripción o unidad de medida.
        /// </summary>
        /// <param name="value">Valor a filtrar la búsqueda.</param>
        /// <returns>Colección de objetos de tipo Materia Prima desde una vista personalizada.</returns>
        public IEnumerable<MateriaPrimaView> GetMateriasPrimas(string value)
        {
            IEnumerable<MateriaPrima> materiasPrimas = materiaPrimaDao.Read(value);

            return materiasPrimas.Select(materiaPrima =>
            {
                return new MateriaPrimaView
                {
                    Id = materiaPrima.Id,
                    Descripcion = materiaPrima.Descripcion,
                    Medida = materiaPrima.UnidadMedida,
                    Cantidad = materiaPrima.Cantidad,
                    Precio = materiaPrima.Precio
                };
            });
        }

        /// <summary>
        /// Actualiza una Materia Prima en la base de datos dada una colección de pares clave-valor que corresponden a las propiedades del objeto.
        /// </summary>
        /// <param name="properties">Propiedades de la Materia Prima.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando las propiedades no se proporcionan.</exception>
        public void Update(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "Las propiedades del objeto no pueden ser nulas.");

            MateriaPrima materiaPrima = materiaPrimaDao.Update(new MateriaPrima
            {
                Id = (int)properties["Id"],
                Descripcion = properties["Descripcion"].ToString(),
                UnidadMedida = properties["UnidadMedida"].ToString(),
                Cantidad = Convert.ToDouble(properties["Cantidad"]),
                Precio = Convert.ToDecimal(properties["Precio"]),
                Foto = (Image)properties["Foto"],
                Estado = (bool)properties["Estado"]
            });

            if (materiaPrima.Id.Equals(default)) Handler.Add("MODELO_DEFAULT");
        }

        /// <summary>
        /// Elimina una Materia Prima dado su ID.
        /// </summary>
        /// <param name="id">Identificador único de la Materia Prima a eliminar.</param>
        public void Delete(int id)
        {
            MateriaPrima materiaPrima = materiaPrimaDao.Delete(GetById(id));

            if (materiaPrima.Id.Equals(default)) Handler.Add("MODELO_DEFAULT");
        }

        public override void Dispose() => Handler.Clear();

        public override string GetErrorMessage() => Handler.GetErrorMessage();

        public override bool HasError() => Handler.HasError();
    }
}
