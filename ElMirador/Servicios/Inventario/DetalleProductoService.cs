using Connection.Interfaces.Inventario;
using ElMirador.Servicios.Base;
using ElMirador.ViewModels.Inventario;
using Models.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElMirador.Servicios.Inventario
{
    /// <summary>
    /// Clase encargada de proveer los servicios para los Detalle de Producto.
    /// </summary>
    internal class DetalleProductoService : ServicioBase
    {
        #region Private Fields

        /// <summary>
        /// Proveedor de servicios para los Productos.
        /// </summary>
        private readonly ProductoService productoService;

        /// <summary>
        /// Proveedor de servicios para las Materias Primas.
        /// </summary>
        private readonly MateriaPrimaService materiaPrimaService;

        /// <summary>
        /// DAO para el Detalle de Producto.
        /// </summary>
        private readonly IDetalleProductoDao detalleProductoDao;

        #endregion

        public DetalleProductoService()
        {
            detalleProductoDao = DaoFactory.Get<IDetalleProductoDao>(Handler);
            productoService = new ProductoService();
            materiaPrimaService = new MateriaPrimaService();
        }

        /// <summary>
        /// Crea un Detalle de Producto en la base de datos dada una colección de pares clave-valor que corresponden a las propiedades del objeto.
        /// </summary>
        /// <param name="properties">Propiedades del Detalle de Producto.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando las propiedades del objeto no se proporcionan.</exception>
        public void Create(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "Las propiedades del objeto no pueden ser nulas.");

            DetalleProducto detalleProducto = detalleProductoDao.Create(new DetalleProducto
            {
                IdProducto = (int)properties["IdProducto"],
                IdMateriaPrima = (int)properties["IdMateriaPrima"],
                Cantidad = Convert.ToDouble(properties["Cantidad"])
            });

            if (detalleProducto.IdProducto.Equals(default)) Handler.Add("MODELO_DEFAULT");
        }

        /// <inheritdoc cref="IDetalleProductoDao.Read(int, int)"/>
        public DetalleProducto Read(int idProducto, int idMateriaPrima) => detalleProductoDao.Read(idProducto, idMateriaPrima);

        /// <summary>
        /// Obtiene las Materias Primas desde una vista personalizada a partir del ID de Producto que está relacionado en el Detalle de Producto correspondiente.
        /// </summary>
        /// <param name="idProducto">Identificador único del Producto.</param>
        /// <returns>Colección de objetos de tipo Materia Prima desde una vista personalizada que resulten de la búsqueda.</returns>
        public IEnumerable<MateriaPrimaView> GetMateriasPrimas(int idProducto)
        {
            Producto producto = productoService.GetById(idProducto);

            if (producto.Id.Equals(default))
            {
                Handler.Add("MODELO_DEFAULT");
                return Enumerable.Empty<MateriaPrimaView>();
            }

            IEnumerable<DetalleProducto> detallesProductos = detalleProductoDao.GetByIdProducto(producto.Id);

            return detallesProductos.Select(detalleProducto =>
            {
                MateriaPrima materiaPrima = materiaPrimaService.GetById(detalleProducto.IdMateriaPrima);

                return new MateriaPrimaView
                {
                    Id = materiaPrima.Id,
                    Descripcion = materiaPrima.Descripcion,
                    Cantidad = detalleProducto.Cantidad,
                    Medida = materiaPrima.UnidadMedida,
                    Precio = materiaPrima.Precio
                };
            });
        }

        /// <summary>
        /// Actualiza un Detalle de Producto en la base de datos dada una colección de pares clave-valor que corresponden a las propiedades del objeto.
        /// </summary>
        /// <param name="properties">Propiedades del Detalle de Producto.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando las propiedades del objeto no se proporcionan.</exception>
        public void Update(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "Las propiedades del objeto no pueden ser nulas.");

            DetalleProducto detalleProducto = detalleProductoDao.Create(new DetalleProducto
            {
                IdProducto = (int)properties["IdProducto"],
                IdMateriaPrima = (int)properties["IdMateriaPrima"],
                Cantidad = Convert.ToDouble(properties["Cantidad"])
            });

            if (detalleProducto.IdProducto.Equals(default)) Handler.Add("MODELO_DEFAULT");
        }

        /// <summary>
        /// Elimina un Detalle de Producto de la base de datos dado el ID del Producto y de Materia Prima respectivamente.
        /// </summary>
        /// <param name="idProducto">Identificador único del Producto asociado al Detalle.</param>
        /// <param name="idMateriaPrima">Identificador único de la Materia Prima asociado al Detalle.</param>
        public void Delete(int idProducto, int idMateriaPrima)
        {
            DetalleProducto detalleProducto = detalleProductoDao.Delete(Read(idProducto, idMateriaPrima));

            if (detalleProducto.IdProducto.Equals(default)) Handler.Add("MODELO_DEFAULT");
        }



        public override void Dispose()
        {
            Handler.Clear();
            productoService.Dispose();
            materiaPrimaService.Dispose();
        }

        public override string GetErrorMessage()
        {
            StringBuilder builder = new StringBuilder();

            if (Handler != null && Handler.HasError())
            {
                builder.AppendLine(Handler.GetErrorMessage());
            }

            if (productoService != null && productoService.HasError())
            {
                builder.AppendLine(productoService.GetErrorMessage());
            }

            if (materiaPrimaService != null && materiaPrimaService.HasError())
            {
                builder.AppendLine(materiaPrimaService.GetErrorMessage());
            }

            return builder.ToString();
        }

        public override bool HasError() => Handler.HasError() || productoService.HasError() || materiaPrimaService.HasError();
    }
}
