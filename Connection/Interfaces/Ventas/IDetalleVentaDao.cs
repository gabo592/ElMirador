using Connection.Base;
using Models.Ventas;
using System.Collections.Generic;

namespace Connection.Interfaces.Ventas
{
    /// <summary>
    /// Indica que una clase implementará los métodos de acceso a datos para el objeto Detalle de Venta.
    /// </summary>
    public interface IDetalleVentaDao : IDao<DetalleVenta>
    {
        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un Detalle de Venta que coincida con el ID de Venta y Producto
        /// especificados.
        /// </summary>
        /// <param name="idVenta">Identificador único de la Venta asociada al Detalle.</param>
        /// <param name="idProducto">Identificador único del Producto asociado al Detalle.</param>
        /// <returns>Objeto de tipo Detalle de Venta que resulte de la búsqueda; en caso de no encontrar, retorna una nueva instancia.</returns>
        DetalleVenta Read(int idVenta, int idProducto);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de Detalles de Venta que coincidan con el ID de Venta
        /// especificado.
        /// </summary>
        /// <param name="idVenta">Identificador único de la Venta asociada al Detalle.</param>
        /// <returns>Colección de objetos de tipo Detalle de Venta que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<DetalleVenta> GetByIdVenta(int idVenta);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de Detalles de Venta que coincidan con el ID de Producto
        /// especificado.
        /// </summary>
        /// <param name="idProducto">Identificador único del Producto asociado al Detalle.</param>
        /// <returns>Colección de objetos de tipo Detalle de Venta que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<DetalleVenta> GetByIdProducto(int idProducto);
    }
}
