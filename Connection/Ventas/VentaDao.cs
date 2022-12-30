using Common.Util;
using Connection.Base;
using Connection.Constantes;
using Connection.Interfaces.Ventas;
using Models.Ventas;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Connection.Ventas
{
    /// <summary>
    /// Clase encargada de implementar el DAO para el objeto Venta.
    /// </summary>
    internal class VentaDao : BaseDao<Venta>, IVentaDao
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        public VentaDao(ErrorHandler handler, string connectionString) : base(handler, connectionString)
        {
            Handler = handler;
        }

        public override Venta Create(Venta model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.CREATE)) return new Venta();

            return Read(StoredProcedures.VentaCreate, new Dictionary<string, object>
            {
                {"IdEmpleado", model.IdEmpleado },
                {"IdCliente", model.IdCliente }
            }).FirstOrDefault() ?? new Venta();
        }

        public override Venta Delete(Venta model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.DELETE)) return new Venta();

            return Read(StoredProcedures.VentaDelete, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault() ?? new Venta();
        }

        public Venta GetById(int id)
        {
            if (id.Equals(default))
            {
                Handler.Add("ID_DEFAULT");
                return new Venta();
            }

            return Read(StoredProcedures.VentaRead, new Dictionary<string, object>
            {
                {"Id", id },
                {"Estado", 1 }
            }).FirstOrDefault() ?? new Venta();
        }

        public IEnumerable<Venta> GetByIdCliente(int idCliente)
        {
            if (idCliente.Equals(default))
            {
                Handler.Add("ID_CLIENTE_DEFAULT");
                return Enumerable.Empty<Venta>();
            }

            return Read(StoredProcedures.VentaRead, new Dictionary<string, object>
            {
                {"IdCliente", idCliente },
                {"Estado", 1 }
            });
        }

        public IEnumerable<Venta> GetByIdEmpleado(int idEmpleado)
        {
            if (idEmpleado.Equals(default))
            {
                Handler.Add("ID_EMPLEADO_DEFAULT");
                return Enumerable.Empty<Venta>();
            }

            return Read(StoredProcedures.VentaRead, new Dictionary<string, object>
            {
                {"IdEmpleado", idEmpleado },
                {"Estado", 1 }
            });
        }

        public override IEnumerable<Venta> Read()
        {
            return Read(StoredProcedures.VentaRead, new Dictionary<string, object>
            {
                {"Estado", 1 }
            });
        }

        public IEnumerable<Venta> Read(DateTime fecha)
        {
            return Read(StoredProcedures.VentaRead, new Dictionary<string, object>
            {
                {"Fecha", fecha },
                {"Estado", 1 }
            });
        }

        public override Venta Update(Venta model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.UPDATE)) return new Venta();

            return Read(StoredProcedures.VentaUpdate, new Dictionary<string, object>
            {
                {"Id", model.Id },
                {"Fecha", model.Fecha },
                {"IdEmpleado", model.IdEmpleado },
                {"IdCliente", model.IdCliente }
            }).FirstOrDefault() ?? new Venta();
        }
    }
}
