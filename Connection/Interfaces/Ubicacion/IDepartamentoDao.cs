using Connection.Base;
using Models.Ubicacion;
using System.Collections.Generic;

namespace Connection.Interfaces.Ubicacion
{
    /// <summary>
    /// Indica que una clase implementará los métodos de acceso a datos para el objeto Departamento.
    /// </summary>
    public interface IDepartamentoDao : IDao<Departamento>
    {
        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un Departamento que coincida con el ID especificado.
        /// </summary>
        /// <param name="id">Identificador único del Departamento.</param>
        /// <returns>Objeto de tipo Departamento que resulte de la búsqueda; en caso de no encontrar, retorna una nueva instancia.</returns>
        Departamento GetById(int id);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de Departamentos que coincidan con el Nombre especificado.
        /// </summary>
        /// <param name="nombre">Nombre del Departamento.</param>
        /// <returns>Colección de objetos de tipo Departamento que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Departamento> Read(string nombre);
    }
}
