using Connection.Base;
using Models.Ubicacion;
using System.Collections.Generic;

namespace Connection.Interfaces.Ubicacion
{
    /// <summary>
    /// Indica que una clase implementará los métodos de acceso a datos para el objeto Municipio.
    /// </summary>
    public interface IMunicipioDao : IDao<Municipio>
    {
        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un Municipio que coincida con el ID especificado.
        /// </summary>
        /// <param name="id">Identificador único del Municipio.</param>
        /// <returns>Objeto de tipo Municipio que resulte de la búsqueda; en caso de no encontrar, retorna una nueva instancia.</returns>
        Municipio GetById(int id);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de Municipios que coincidan con el Nombre especificado.
        /// </summary>
        /// <param name="nombre">Nombre del Municipio.</param>
        /// <returns>Colección de objetos de tipo Municipio que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Municipio> Read(string nombre);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de Municipios que coincidan con el ID del Departamento
        /// especificado.
        /// </summary>
        /// <param name="idDepartamento">Identificador único del Departamento asociado.</param>
        /// <returns>Colección de objetos de tipo Municipio que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Municipio> GetByIdDepartamento(int idDepartamento);
    }
}
