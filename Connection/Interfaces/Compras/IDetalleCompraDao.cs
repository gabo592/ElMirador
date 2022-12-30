using Connection.Base;
using Models.Compras;
using System.Collections.Generic;

namespace Connection.Interfaces.Compras
{
    /// <summary>
    /// Indica que una clase implementará los métodos de acceso a datos para el objeto Detalle de Compra.
    /// </summary>
    public interface IDetalleCompraDao : IDao<DetalleCompra>
    {
        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar un Detalle de Compra que coincida con el ID de Compra y
        /// Materia Prima especificados.
        /// </summary>
        /// <param name="idCompra">Identificador único de la Compra asociada al Detalle.</param>
        /// <param name="idMateriaPrima">Identificador único de la Materia Prima asociada al Detalle.</param>
        /// <returns>Objeto de tipo Detalle de Compra que resulte de la búsqueda; en caso de no encontrar, crea una nueva instancia.</returns>
        DetalleCompra Read(int idCompra, int idMateriaPrima);

        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar una colección de Detalles de Compra que coincidan con el ID de Compra
        /// especificado.
        /// </summary>
        /// <param name="idCompra">Identificador único de la Compra asociada al Detalle.</param>
        /// <returns>Colección de objetos de tipo Detalle de Compra que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<DetalleCompra> GetByIdCompra(int idCompra);

        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar una colección de Detalles de Compra que coincidan con el ID de Materia
        /// Prima especificado.
        /// </summary>
        /// <param name="idMateriaPrima">Identificador único de la Materia Prima asociada al Detalle.</param>
        /// <returns>Colección de objetos de tipo Detalle de Compra que resulten de la búsqueda; en caso de no encontrar, retornan una colección vacía.</returns>
        IEnumerable<DetalleCompra> GetByIdMateriaPrima(int idMateriaPrima);
    }
}
