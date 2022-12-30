using Connection.Base;
using Models.Inventario;
using System.Collections.Generic;

namespace Connection.Interfaces.Inventario
{
    /// <summary>
    /// Indica que una clase implementará los métodos de acceso a datos para el objeto Materia Prima.
    /// </summary>
    public interface IMateriaPrimaDao : IDao<MateriaPrima>
    {
        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una Materia Prima que coincida con el ID especificado.
        /// </summary>
        /// <param name="id">Identificador único de la Materia Prima.</param>
        /// <returns>Objeto de tipo Materia Prima que resulte de la búsqueda; en caso de no encontrar, retorna una nueva instancia.</returns>
        MateriaPrima GetById(int id);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de Materias Primas que coincidan con el valor a filtrar.
        /// </summary>
        /// <param name="value">Valor a filtrar la búsqueda. Este puede ser la Descripcion o Unidad de Medida.</param>
        /// <returns>Colección de objetos de tipo Materia Prima que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<MateriaPrima> Read(string value);
    }
}
