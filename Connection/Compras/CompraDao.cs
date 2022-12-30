using Common.Util;
using Connection.Base;
using Connection.Constantes;
using Connection.Interfaces.Compras;
using Models.Compras;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Connection.Compras
{
    /// <summary>
    /// Clase encargada de implementar el DAO para el objeto Compra.
    /// </summary>
    internal class CompraDao : BaseDao<Compra>, ICompraDao
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        public CompraDao(ErrorHandler handler, string connectionString) : base(handler, connectionString)
        {
            Handler = handler;
        }

        public override Compra Create(Compra model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.CREATE)) return new Compra();

            return Read(StoredProcedures.CompraCreate, new Dictionary<string, object>
            {
                {"Fecha", model.Fecha },
                {"IdEmpleado", model.IdEmpleado },
                {"IdProveedor", model.IdProveedor }
            }).FirstOrDefault() ?? new Compra();
        }

        public override Compra Delete(Compra model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.DELETE)) return new Compra();

            return Read(StoredProcedures.CompraDelete, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault() ?? new Compra();
        }

        public Compra GetById(int id)
        {
            if (id.Equals(default))
            {
                Handler.Add("ID_DEFAULT");
                return new Compra();
            }

            return Read(StoredProcedures.CompraRead, new Dictionary<string, object>
            {
                {"Id", id },
                {"Estado", 1 }
            }).FirstOrDefault() ?? new Compra();
        }

        public IEnumerable<Compra> GetByIdEmpleado(int idEmpleado)
        {
            if (idEmpleado.Equals(default))
            {
                Handler.Add("ID_EMPLEADO_DEFAULT");
                return Enumerable.Empty<Compra>();
            }

            return Read(StoredProcedures.CompraRead, new Dictionary<string, object>
            {
                {"IdEmpleado", idEmpleado },
                {"Estado", 1 }
            });
        }

        public IEnumerable<Compra> GetByIdProveedor(int idProveedor)
        {
            if (idProveedor.Equals(default))
            {
                Handler.Add("ID_PROVEEDOR_DEFAULT");
                return Enumerable.Empty<Compra>();
            }

            return Read(StoredProcedures.CompraRead, new Dictionary<string, object>
            {
                {"IdProveedor", idProveedor },
                {"Estado", 1 }
            });
        }

        public override IEnumerable<Compra> Read()
        {
            return Read(StoredProcedures.CompraRead, new Dictionary<string, object>
            {
                {"Estado", 1 }
            });
        }

        public IEnumerable<Compra> Read(DateTime fecha)
        {
            return Read(StoredProcedures.CompraRead, new Dictionary<string, object>
            {
                {"Fecha", fecha },
                {"Estado", 1 }
            });
        }

        public override Compra Update(Compra model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.UPDATE)) return new Compra();

            return Read(StoredProcedures.CompraUpdate, new Dictionary<string, object>
            {
                {"Id", model.Id },
                {"Fecha", model.Fecha },
                {"IdEmpleado", model.IdEmpleado },
                {"IdProveedor", model.IdProveedor }
            }).FirstOrDefault() ?? new Compra();
        }
    }
}
