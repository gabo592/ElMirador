using Common.Util;
using System.Collections.Generic;

namespace Connection.Base
{
    /// <summary>
    /// Clase encargada de proveer los métodos necesarios para el acceso a datos de un objeto. Así como
    /// lectura de procedimientos almacenados.
    /// </summary>
    /// <typeparam name="TModel">Tipo de modelo a obtener.</typeparam>
    internal abstract class BaseDao<TModel> : IDao<TModel> where TModel : new()
    {
        /// <summary>
        /// Instancia de la conexión a la base de datos.
        /// </summary>
        private readonly Database database;

        public BaseDao(ErrorHandler handler, string connectionString)
        {
            database = new Database(handler, connectionString);
        }

        public abstract TModel Create(TModel model);

        public abstract TModel Delete(TModel model);

        public abstract IEnumerable<TModel> Read();

        public abstract TModel Update(TModel model);

        /// <inheritdoc cref="Database.Read{TModel}(string, IDictionary{string, object})"/>
        public IEnumerable<TModel> Read(string procedure, IDictionary<string, object> parameters = null) => database.Read<TModel>(procedure, parameters);
    }
}
