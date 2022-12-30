using Connection.Base;
using Models.Inventario;
using System.Collections.Generic;

namespace Connection.Interfaces.Inventario
{
    /// <summary>
    /// Indica que una clase implementará los métodos de acceso a datos para el objeto Detalle de Producto.
    /// </summary>
    public interface IDetalleProductoDao : IDao<DetalleProducto>
    {
        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un Detalle de Producto que coincida con el ID de Producto y
        /// Materia Prima especificados.
        /// </summary>
        /// <param name="idProducto">Identificador único del Producto asociado al Detalle.</param>
        /// <param name="idMateriaPrima">Identificador único de la Materia Prima asociado al Detalle.</param>
        /// <returns>Objeto de tipo Detalle de Producto que resulte de la búsqueda; en caso de no encontrar, retorna una nueva instancia.</returns>
        DetalleProducto Read(int idProducto, int idMateriaPrima);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de Detalles de Producto que coincidan con el ID
        /// de Producto especificado.
        /// </summary>
        /// <param name="idProducto">Identificador único del Producto asociado al Detalle.</param>
        /// <returns>Colección de objetos de tipo Detalle de Producto que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<DetalleProducto> GetByIdProducto(int idProducto);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de Detalles de Producto que coincidan con el ID
        /// de Materia Prima especificado.
        /// </summary>
        /// <param name="idMateriaPrima">Identificador único de la Materia Prima asociado al Detalle.</param>
        /// <returns>Colección de objetos de tipo Detalle de Producto que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<DetalleProducto> GetByIdMateriaPrima(int idMateriaPrima);
    }
}
