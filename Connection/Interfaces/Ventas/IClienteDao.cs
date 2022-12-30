using Connection.Base;
using Models.Ventas;
using System.Collections.Generic;

namespace Connection.Interfaces.Ventas
{
    /// <summary>
    /// Indica que una clase implementará los métodos de acceso a datos para el objeto Cliente.
    /// </summary>
    public interface IClienteDao : IDao<Cliente>
    {
        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un Cliente que coincida con el ID especificado.
        /// </summary>
        /// <param name="id">Identificador único del Cliente.</param>
        /// <returns>Objeto de tipo Cliente que resulte de la búsqueda; en caso de no encontrar, retorna una nueva instancia.</returns>
        Cliente GetById(int id);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de Clientes que coincidan con el valor a filtrar.
        /// </summary>
        /// <param name="value">Valor a filtrar la búsqueda. Puede ser por Nombres, Apellidos, Teléfono, Dirección, etc.</param>
        /// <returns>Colección de objetos de tipo Cliente que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Cliente> Read(string value);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de Clientes que coincidan con el ID de Municipio especificado.
        /// </summary>
        /// <param name="idMunicipio">Identificador único del Municipio asociado.</param>
        /// <returns>Colección de objetos de tipo Cliente que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Cliente> GetByIdMunicipio(int idMunicipio);
    }
}
