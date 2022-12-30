using Connection.Base;
using Models.Ventas;
using System;
using System.Collections.Generic;

namespace Connection.Interfaces.Ventas
{
    /// <summary>
    /// Indica que una clase implementará los métodos de acceso a datos para el objeto Venta.
    /// </summary>
    public interface IVentaDao : IDao<Venta>
    {
        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una Venta que coincida con el ID especificado.
        /// </summary>
        /// <param name="id">Identificador único de la Venta.</param>
        /// <returns>Objeto de tipo Venta que resulte de la búsqueda; en caso de no encontrar, retorna una nueva instancia.</returns>
        Venta GetById(int id);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de Ventas que coincidan con la fecha especificada.
        /// </summary>
        /// <param name="fecha">Fecha de Venta.</param>
        /// <returns>Colección de objetos de tipo Venta que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Venta> Read(DateTime fecha);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de Ventas que coincidan con el ID del Empleado especificado.
        /// </summary>
        /// <param name="idEmpleado">Identificador único del Empleado asociado.</param>
        /// <returns>Colección de objetos de tipo Venta que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Venta> GetByIdEmpleado(int idEmpleado);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de Ventas que coincidan con el ID del Cliente especificado.
        /// </summary>
        /// <param name="idCliente">Identificador único del Cliente asociado.</param>
        /// <returns>Colección de objetos de tipo Venta que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Venta> GetByIdCliente(int idCliente);
    }
}
