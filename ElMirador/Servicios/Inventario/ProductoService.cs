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
    /// Clase encargada de proveer los servicios a los Productos.
    /// </summary>
    internal class ProductoService : ServicioBase
    {
        /// <summary>
        /// DAO para los Productos.
        /// </summary>
        private readonly IProductoDao productoDao;

        public ProductoService()
        {
            productoDao = DaoFactory.Get<IProductoDao>(Handler);
        }

        /// <summary>
        /// Crea un Producto en la base de datos dada una colección de pares clave-valor que corresponden a las propiedades del objeto.
        /// </summary>
        /// <param name="properties">Propiedades del Producto.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando las propiedades no se proporcionan.</exception>
        public void Create(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "Las propiedades del objeto no pueden ser nulas.");

            Producto producto = productoDao.Create(new Producto
            {
                Descripcion = properties["Descripcion"].ToString(),
                Precio = Convert.ToDecimal(properties["Precio"]),
                Cantidad = Convert.ToDouble(properties["Cantidad"]),
                Foto = (Image)properties["Foto"]
            });

            if (producto.Id.Equals(default)) Handler.Add("MODELO_DEFAULT");
        }

        /// <inheritdoc cref="IProductoDao.GetById(int)"/>
        public Producto GetById(int id) => productoDao.GetById(id);

        /// <summary>
        /// Busca dentro de la base de datos los Productos que coincidan con la Descripcion a filtrar.
        /// </summary>
        /// <param name="descripcion">Descripción del Producto.</param>
        /// <returns>Colección de objetos de tipo Producto desde una vista personalizada.</returns>
        public IEnumerable<ProductoView> GetProductos(string descripcion)
        {
            IEnumerable<Producto> productos = productoDao.Read(descripcion);

            return productos.Select(producto =>
            {
                return new ProductoView
                {
                    Id = producto.Id,
                    Descripcion = producto.Descripcion,
                    Precio = producto.Precio,
                    Cantidad = producto.Cantidad
                };
            });
        }

        /// <summary>
        /// Crea un Producto en la base de datos dada una colección de pares clave-valor que corresponden a las propiedades del objeto.
        /// </summary>
        /// <param name="properties">Propiedades del Producto.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando las propiedades no se proporcionan.</exception>
        public void Update(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "Las propiedades del objeto no pueden ser nulas.");

            Producto producto = productoDao.Update(new Producto
            {
                Id = (int)properties["Id"],
                Descripcion = properties["Descripcion"].ToString(),
                Precio = Convert.ToDecimal(properties["Precio"]),
                Cantidad = Convert.ToDouble(properties["Cantidad"]),
                Foto = (Image)properties["Foto"],
                Estado = (bool)properties["Estado"]
            });

            if (producto.Id.Equals(default)) Handler.Add("MODELO_DEFAULT");
        }

        /// <summary>
        /// Elimina un Producto de la base de datos dado su ID.
        /// </summary>
        /// <param name="id">Identificador único del Producto.</param>
        public void Delete(int id)
        {
            Producto producto = productoDao.Delete(GetById(id));

            if (producto.Id.Equals(default)) Handler.Add("MODELO_DEFAULT");
        }

        public override void Dispose() => Handler.Clear();

        public override string GetErrorMessage() => Handler.GetErrorMessage();

        public override bool HasError() => Handler.HasError();
    }
}
