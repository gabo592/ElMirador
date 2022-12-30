using Connection.Base;
using Models.Inventario;
using System.Collections.Generic;

namespace Connection.Interfaces.Inventario
{
    /// <summary>
    /// Indica que una clase implementará los métodos de acceso a datos para el objeto Producto.
    /// </summary>
    public interface IProductoDao : IDao<Producto>
    {
        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un Producto que coincida con el ID especificado.
        /// </summary>
        /// <param name="id">Identificador único del Producto.</param>
        /// <returns>Objeto de tipo Producto que resulte de la búsqueda; en caso de no encontrar, retorna una nueva instancia.</returns>
        Producto GetById(int id);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de objetos de tipo Producto que coincidan con la
        /// descripción especificada.
        /// </summary>
        /// <param name="descripcion">Descripción del Producto.</param>
        /// <returns>Colección de objetos de tipo Producto que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Producto> Read(string descripcion);
    }
}
