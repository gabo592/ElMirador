using Connection.Base;
using Models.Compras;
using System.Collections.Generic;

namespace Connection.Interfaces.Compras
{
    /// <summary>
    /// Indica que una clase implementará los métodos de acceso a datos del objeto Proveedor.
    /// </summary>
    public interface IProveedorDao : IDao<Proveedor>
    {
        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar un Proveedor que coincida con el ID especificado.
        /// </summary>
        /// <param name="id">Identificador único del Proveedor.</param>
        /// <returns>Objeto de tipo Proveedor que resulte de la búsqueda; en caso de no encontrar, retorna una nueva instancia.</returns>
        Proveedor GetById(int id);

        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar una colección de Proveedores que coincidan con el valor a filtrar.
        /// </summary>
        /// <param name="value">Valor a filtrar la búsqueda. Puede ser por nombre, dirección, o teléfono.</param>
        /// <returns>Colección de objetos de tipo Proveedor que resulten de la búsqueda, en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Proveedor> Read(string value);
    }
}
