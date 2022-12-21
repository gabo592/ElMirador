using System.Collections.Generic;

namespace Connection.Base
{
    /// <summary>
    /// Indica que una clase implementa los métodos necesarios para el acceso a datos de un objeto.
    /// </summary>
    public interface IDao<TModel> where TModel : new()
    {
        /// <summary>
        /// Crea un nuevo registro dentro de la base de datos dado un modelo especificado.
        /// </summary>
        /// <param name="model">Modelo a crear.</param>
        /// <returns>Modelo ya creado en la base de datos.</returns>
        TModel Create(TModel model);

        /// <summary>
        /// Obtiene todos los registros de la base de datos dado un modelo especificado.
        /// </summary>
        /// <returns>Colección genérica de modelos del tipo especificado.</returns>
        IEnumerable<TModel> Read();

        /// <summary>
        /// Actualiza un registro dentro de la base de datos dado un modelo especificado.
        /// </summary>
        /// <param name="model">Modelo a actualizar.</param>
        /// <returns>Modelo ya actualizado en la base de datos.</returns>
        TModel Update(TModel model);

        /// <summary>
        /// Elimina un registro de la base de datos dado un modelo especificado.
        /// </summary>
        /// <param name="model">Modelo a eliminar.</param>
        /// <returns>Modelo ya eliminado en la base de datos.</returns>
        TModel Delete(TModel model);
    }
}
