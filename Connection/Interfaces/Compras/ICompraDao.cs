using Connection.Base;
using Models.Compras;
using System;
using System.Collections.Generic;

namespace Connection.Interfaces.Compras
{
    /// <summary>
    /// Indica que una clase implementará los métodos para el acceso a datos con el objeto Compra.
    /// </summary>
    public interface ICompraDao : IDao<Compra>
    {
        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar la Compra que coincida con el ID especificado.
        /// </summary>
        /// <param name="id">Identificador único de la Compra.</param>
        /// <returns>Objeto de tipo Compra que resulte de la búsqueda; en caso de no encontrarlo, crea una nueva instancia.</returns>
        Compra GetById(int id);

        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar una colección de Compras que coincidan con la fecha
        /// especificada.
        /// </summary>
        /// <param name="fecha">Fecha de Compra.</param>
        /// <returns>Colección de objetos de tipo Compra que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Compra> Read(DateTime fecha);

        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar una colección de Compras que coincidan con el ID del
        /// Empleado a filtrar.
        /// </summary>
        /// <param name="idEmpleado">Identificador único del Empleado asociado a la Compra.</param>
        /// <returns>Colección de objetos de tipo Compra que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Compra> GetByIdEmpleado(int idEmpleado);

        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar una colección de Compras que coincidan con el ID del
        /// Proveedor a filtrar.
        /// </summary>
        /// <param name="idProveedor">Identificador único del Proveedor asociado a la Compra.</param>
        /// <returns>Colección de objetos de tipo Compra que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Compra> GetByIdProveedor(int idProveedor);
    }
}
