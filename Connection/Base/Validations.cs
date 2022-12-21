using Common.Util;
using Models.Interfaces;

namespace Connection.Base
{
    /// <summary>
    /// Clase encargada de realizar las validaciones a los modelos en dependencia de la operación a realizar
    /// dentro de la base de datos.
    /// </summary>
    internal class Validations
    {
        /// <summary>
        /// Valida si un modelo de tipo especificado contiene problemas en el valor de sus propiedades para realizar la acción determinada.
        /// </summary>
        /// <typeparam name="TModel">Tipo de modelo a evaluar.</typeparam>
        /// <param name="model">Modelo a evaluar.</param>
        /// <param name="handler">Administrador de errores.</param>
        /// <param name="operacion">Operación a realizar dentro de la base de datos.</param>
        /// <returns>Verdadedor si el modelo contiene algún error; de lo contrario, Falso.</returns>
        public static bool HasError<TModel>(TModel model, ErrorHandler handler, Operaciones operacion = Operaciones.DEFAULT) where TModel : new()
        {
            if (model == null) return true;

            if ((operacion.Equals(Operaciones.UPDATE) || operacion.Equals(Operaciones.DELETE)) && model is IActivable activable)
            {
                if (!activable.Estado)
                {
                    handler.Add("MODELO_DESACTIVADO");
                }
            }

            if ((operacion.Equals(Operaciones.UPDATE) || operacion.Equals(Operaciones.DELETE)) && model is IIdentity identity)
            {
                if (identity.Id.Equals(default))
                {
                    handler.Add("ID_DEFAULT");
                }
            }

            if ((operacion.Equals(Operaciones.CREATE) || operacion.Equals(Operaciones.UPDATE)) && model is INameable nameable)
            {
                if (string.IsNullOrWhiteSpace(nameable.Nombre))
                {
                    handler.Add("NOMBRE_VACIO");
                }

                if (nameable.Nombre.Length > 50)
                {
                    handler.Add("LONGITUD_NOMBRE_EXCEDIDA");
                }
            }

            if ((operacion.Equals(Operaciones.CREATE) || operacion.Equals(Operaciones.UPDATE)) && model is IPerson person)
            {
                if (string.IsNullOrWhiteSpace(person.PrimerNombre))
                {
                    handler.Add("PRIMER_NOMBRE_VACIO");
                }

                if (person.PrimerNombre.Length > 50)
                {
                    handler.Add("LONGITUD_PRIMER_NOMBRE_EXCEDIDA");
                }

                if (person.SegundoNombre.Length > 50)
                {
                    handler.Add("LONGITUD_SEGUNDO_NOMBRE_EXCEDIDA");
                }

                if (string.IsNullOrWhiteSpace(person.PrimerApellido))
                {
                    handler.Add("PRIMER_APELLIDO_VACIO");
                }

                if (person.PrimerApellido.Length > 50)
                {
                    handler.Add("LONGITUD_PRIMER_APELLIDO_EXCEDIDA");
                }

                if (person.SegundoApellido.Length > 50)
                {
                    handler.Add("LONGITUD_SEGUNDO_APELLIDO_EXCEDIDA");
                }

                if (!string.IsNullOrWhiteSpace(person.Telefono) && person.Telefono.Length != 8)
                {
                    handler.Add("LONGITUD_TELEFONO_EXCEDIDA");
                }

                if (!string.IsNullOrWhiteSpace(person.Direccion) && person.Direccion.Length > 200)
                {
                    handler.Add("LONGITUD_DIRECCION_EXCEDIDA");
                }

                if (person.IdMunicipio.Equals(default))
                {
                    handler.Add("ID_MUNICIPIO_DEFAULT");
                }
            }

            if ((operacion.Equals(Operaciones.CREATE) || operacion.Equals(Operaciones.UPDATE)) && model is IProduct product)
            {
                if (string.IsNullOrWhiteSpace(product.Descripcion))
                {
                    handler.Add("DESCRIPCION_PRODUCTO_VACIO");
                }

                if (product.Descripcion.Length > 200)
                {
                    handler.Add("LONGITUD_DESCRIPCION_PRODUCTO_EXCEDIDA");
                }

                if (product.Cantidad.Equals(default))
                {
                    handler.Add("CANTIDAD_PRODUCTO_DEFAULT");
                }

                if (product.Precio.Equals(default))
                {
                    handler.Add("PRECIO_PRODUCTO_DEFAULT");
                }
            }

            if ((operacion.Equals(Operaciones.CREATE) || operacion.Equals(Operaciones.UPDATE)) && model is ISecurity security)
            {
                if (string.IsNullOrWhiteSpace(security.Clave))
                {
                    handler.Add("CLAVE_VACIO");
                }
                else if (security.Clave.Length < 6)
                {
                    handler.Add("LONGITUD_CLAVE_MINIMA");
                }
            }

            if ((operacion.Equals(Operaciones.CREATE) || operacion.Equals(Operaciones.UPDATE)) && model is ITransaction transaction)
            {
                if (transaction.Fecha.Equals(default))
                {
                    handler.Add("FECHA_DEFAULT");
                }

                if (transaction.IdEmpleado.Equals(default))
                {
                    handler.Add("ID_EMPLEADO_DEFAULT");
                }
            }

            if ((operacion.Equals(Operaciones.CREATE) || operacion.Equals(Operaciones.UPDATE)) && model is ITransactionDetail transactionDetail)
            {
                if (transactionDetail.Cantidad.Equals(default))
                {
                    handler.Add("CANTIDAD_DEFAULT");
                }

                if (transactionDetail.Descuento.Equals(default))
                {
                    handler.Add("DESCUENTO_DEFAULT");
                }
            }

            return handler.HasError();
        }

        /// <summary>
        /// Operaciones que son posibles realizar en la base de datos y requieren validar la información
        /// involucrada.
        /// </summary>
        internal enum Operaciones
        {
            DEFAULT = 0,
            CREATE = 1,
            UPDATE = 2,
            DELETE = 3
        }
    }
}
