using Common.Util;
using Connection.Base;
using Connection.Constantes;
using Connection.Interfaces.Inventario;
using Models.Inventario;
using System.Collections.Generic;
using System.Linq;

namespace Connection.Inventario
{
    /// <summary>
    /// Clase encargada de implementar el DAO para el objeto Producto.
    /// </summary>
    internal class ProductoDao : BaseDao<Producto>, IProductoDao
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        public ProductoDao(ErrorHandler handler, string connectionString) : base(handler, connectionString)
        {
            Handler = handler;
        }

        public override Producto Create(Producto model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.CREATE)) return new Producto();

            return Read(StoredProcedures.ProductoCreate, new Dictionary<string, object>
            {
                {"Descripcion", model.Descripcion },
                {"Precio", model.Precio },
                {"Cantidad", model.Cantidad },
                {"Foto", model.Foto }
            }).FirstOrDefault() ?? new Producto();
        }

        public override Producto Delete(Producto model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.DELETE)) return new Producto();

            return Read(StoredProcedures.ProductoDelete, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault() ?? new Producto();
        }

        public Producto GetById(int id)
        {
            if (id.Equals(default))
            {
                Handler.Add("ID_DEFAULT");
                return new Producto();
            }

            return Read(StoredProcedures.ProductoRead, new Dictionary<string, object>
            {
                {"Id", id },
                {"Estado", 1 }
            }).FirstOrDefault() ?? new Producto();
        }

        public override IEnumerable<Producto> Read()
        {
            return Read(string.Empty);
        }

        public IEnumerable<Producto> Read(string descripcion)
        {
            return Read(StoredProcedures.ProductoRead, new Dictionary<string, object>
            {
                {"Descripcion", descripcion },
                {"Estado", 1 }
            });
        }

        public override Producto Update(Producto model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.UPDATE)) return new Producto();

            return Read(StoredProcedures.ProductoUpdate, new Dictionary<string, object>
            {
                {"Id", model.Id },
                {"Descripcion", model.Descripcion },
                {"Precio", model.Precio },
                {"Cantidad", model.Cantidad },
                {"Foto", model.Foto }
            }).FirstOrDefault() ?? new Producto();
        }
    }
}
