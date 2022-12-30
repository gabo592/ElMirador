using Connection.Base;
using Models.CapitalHumano;
using System.Collections.Generic;

namespace Connection.Interfaces.CapitalHumano
{
    /// <summary>
    /// Indica que una clase implementará los métodos para el acceso a datos del objeto Empleado.
    /// </summary>
    public interface IEmpleadoDao : IDao<Empleado>
    {
        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar un empleado que coincida
        /// con el ID especificado.
        /// </summary>
        /// <param name="id">Identificador único del empleado.</param>
        /// <returns>Objeto de tipo Empleado que resulte de la búsqueda; en caso de no encontrarlo, crea un nuevo objeto.</returns>
        Empleado GetById(int id);

        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar una colección de registros de tipo Empleado
        /// que cumplan con el valor a filtrar.
        /// </summary>
        /// <param name="value">Valor a filtrar la búsqueda. Puede ser por nombres, apellidos, dirección, etc.</param>
        /// <returns>Colección de objetos de tipo Empleado que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Empleado> Read(string value);

        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar una colección de registros de tipo Empleado
        /// que contengan el ID del Municipio a filtrar.
        /// </summary>
        /// <param name="idMunicipio">Identificador único del Municipio.</param>
        /// <returns>Colección de objetos de tipo Empleado que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Empleado> GetByIdMunicipio(int idMunicipio);
    }
}
