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
    /// Clase encargada de implementar el DAO para el objeto Detalle de Compra.
    /// </summary>
    internal class DetalleCompraDao : BaseDao<DetalleCompra>, IDetalleCompraDao
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        public DetalleCompraDao(ErrorHandler handler, string connectionString) : base(handler, connectionString)
        {
            Handler = handler;
        }

        public override DetalleCompra Create(DetalleCompra model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.CREATE)) return new DetalleCompra();

            return Read(StoredProcedures.DetalleCompraCreate, new Dictionary<string, object>
            {
                {"IdCompra", model.IdCompra },
                {"IdMateriaPrima", model.IdMateriaPrima },
                {"Cantidad", model.Cantidad },
                {"Costo", model.Costo },
                {"Descuento", model.Descuento }
            }).FirstOrDefault() ?? new DetalleCompra();
        }

        public override DetalleCompra Delete(DetalleCompra model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.DELETE)) return new DetalleCompra();

            return Read(StoredProcedures.DetalleCompraCreate, new Dictionary<string, object>
            {
                {"IdCompra", model.IdCompra },
                {"IdMateriaPrima", model.IdMateriaPrima }
            }).FirstOrDefault() ?? new DetalleCompra();
        }

        public IEnumerable<DetalleCompra> GetByIdCompra(int idCompra)
        {
            if (idCompra.Equals(default))
            {
                Handler.Add("ID_COMPRA_DEFAULT");
                return Enumerable.Empty<DetalleCompra>();
            }

            return Read(StoredProcedures.DetalleCompraRead, new Dictionary<string, object>
            {
                {"IdCompra", idCompra }
            });
        }

        public IEnumerable<DetalleCompra> GetByIdMateriaPrima(int idMateriaPrima)
        {
            if (idMateriaPrima.Equals(default))
            {
                Handler.Add("ID_MATERIA_PRIMA_DEFAULT");
                return Enumerable.Empty<DetalleCompra>();
            }

            return Read(StoredProcedures.DetalleCompraRead, new Dictionary<string, object>
            {
                {"IdMateriaPrima", idMateriaPrima }
            });
        }

        public override IEnumerable<DetalleCompra> Read()
        {
            return Read(StoredProcedures.DetalleCompraRead);
        }

        public DetalleCompra Read(int idCompra, int idMateriaPrima)
        {
            if (idCompra.Equals(default))
            {
                Handler.Add("ID_COMPRA_DEFAULT");
                return new DetalleCompra();
            }

            if (idMateriaPrima.Equals(default))
            {
                Handler.Add("ID_MATERIA_PRIMA_DEFAULT");
                return new DetalleCompra();
            }

            return Read(StoredProcedures.DetalleCompraRead, new Dictionary<string, object>
            {
                {"IdCompra", idCompra },
                {"IdMateriaPrima", idMateriaPrima }
            }).FirstOrDefault() ?? new DetalleCompra();
        }

        public override DetalleCompra Update(DetalleCompra model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.UPDATE)) return new DetalleCompra();

            return Read(StoredProcedures.DetalleCompraUpdate, new Dictionary<string, object>
            {
                {"IdCompra", model.IdCompra },
                {"IdMateriaPrima", model.IdMateriaPrima },
                {"Cantidad", model.Cantidad },
                {"Costo", model.Costo },
                {"Descuento", model.Descuento }
            }).FirstOrDefault() ?? new DetalleCompra();
        }
    }
}
