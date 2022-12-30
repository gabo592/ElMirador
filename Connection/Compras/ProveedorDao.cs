using Common.Util;
using Connection.Base;
using Connection.Constantes;
using Connection.Interfaces.Compras;
using Models.Compras;
using System.Collections.Generic;
using System.Linq;

namespace Connection.Compras
{
    /// <summary>
    /// Clase encargada de implementar el DAO para el objeto Proveedor.
    /// </summary>
    internal class ProveedorDao : BaseDao<Proveedor>, IProveedorDao
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        public ProveedorDao(ErrorHandler handler, string connectionString) : base(handler, connectionString)
        {
            Handler = handler;
        }

        public override Proveedor Create(Proveedor model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.CREATE)) return new Proveedor();

            return Read(StoredProcedures.ProveedorCreate, new Dictionary<string, object>
            {
                {"Nombre", model.Nombre },
                {"Telefono", model.Telefono },
                {"Direccion", model.Direccion }
            }).FirstOrDefault() ?? new Proveedor();
        }

        public override Proveedor Delete(Proveedor model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.DELETE)) return new Proveedor();

            return Read(StoredProcedures.ProveedorDelete, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault() ?? new Proveedor();
        }

        public Proveedor GetById(int id)
        {
            if (id.Equals(default))
            {
                Handler.Add("ID_DEFAULT");
                return new Proveedor();
            }

            return Read(StoredProcedures.ProveedorRead, new Dictionary<string, object>
            {
                {"Id", id },
                {"Estado", 1 }
            }).FirstOrDefault() ?? new Proveedor();
        }

        public override IEnumerable<Proveedor> Read()
        {
            return Read(string.Empty);
        }

        public IEnumerable<Proveedor> Read(string value)
        {
            return Read(StoredProcedures.ProveedorRead, new Dictionary<string, object>
            {
                {"Nombre", value },
                {"Telefono", value },
                {"Direccion", value },
                {"Estado", 1 }
            });
        }

        public override Proveedor Update(Proveedor model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.UPDATE)) return new Proveedor();

            return Read(StoredProcedures.ProveedorUpdate, new Dictionary<string, object>
            {
                {"Id", model.Id },
                {"Nombre", model.Nombre },
                {"Telefono", model.Telefono },
                {"Direccion", model.Direccion }
            }).FirstOrDefault() ?? new Proveedor();
        }
    }
}
