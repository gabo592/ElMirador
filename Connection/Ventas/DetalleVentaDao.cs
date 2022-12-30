using Common.Util;
using Connection.Base;
using Connection.Constantes;
using Connection.Interfaces.Ventas;
using Models.Ventas;
using System.Collections.Generic;
using System.Linq;

namespace Connection.Ventas
{
    /// <summary>
    /// Clase encargada de implementar el DAO para el objeto Detalle de Venta.
    /// </summary>
    internal class DetalleVentaDao : BaseDao<DetalleVenta>, IDetalleVentaDao
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        public DetalleVentaDao(ErrorHandler handler, string connectionString) : base(handler, connectionString)
        {
            Handler = handler;
        }

        public override DetalleVenta Create(DetalleVenta model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.CREATE)) return new DetalleVenta();

            return Read(StoredProcedures.DetalleVentaCreate, new Dictionary<string, object>
            {
                {"IdVenta", model.IdVenta },
                {"IdProducto", model.IdProducto },
                {"Precio", model.Precio },
                {"Cantidad", model.Cantidad },
                {"Descuento", model.Descuento }
            }).FirstOrDefault() ?? new DetalleVenta();
        }

        public override DetalleVenta Delete(DetalleVenta model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.DELETE)) return new DetalleVenta();

            return Read(StoredProcedures.DetalleVentaDelete, new Dictionary<string, object>
            {
                {"IdVenta", model.IdVenta },
                {"IdProducto", model.IdProducto }
            }).FirstOrDefault() ?? new DetalleVenta();
        }

        public IEnumerable<DetalleVenta> GetByIdProducto(int idProducto)
        {
            if (idProducto.Equals(default))
            {
                Handler.Add("ID_PRODUCTO_DEFAULT");
                return Enumerable.Empty<DetalleVenta>();
            }

            return Read(StoredProcedures.DetalleVentaRead, new Dictionary<string, object>
            {
                {"IdProducto", idProducto }
            });
        }

        public IEnumerable<DetalleVenta> GetByIdVenta(int idVenta)
        {
            if (idVenta.Equals(default))
            {
                Handler.Add("ID_VENTA_DEFAULT");
                return Enumerable.Empty<DetalleVenta>();
            }

            return Read(StoredProcedures.DetalleVentaRead, new Dictionary<string, object>
            {
                {"IdVenta", idVenta }
            });
        }

        public override IEnumerable<DetalleVenta> Read()
        {
            return Read(StoredProcedures.DetalleVentaRead);
        }

        public DetalleVenta Read(int idVenta, int idProducto)
        {
            if (idVenta.Equals(default))
            {
                Handler.Add("ID_VENTA_DEFAULT");
                return new DetalleVenta();
            }

            if (idProducto.Equals(default))
            {
                Handler.Add("ID_PRODUCTO_DEFAULT");
                return new DetalleVenta();
            }

            return Read(StoredProcedures.DetalleVentaRead, new Dictionary<string, object>
            {
                {"IdVenta", idVenta },
                {"IdProducto", idProducto }
            }).FirstOrDefault() ?? new DetalleVenta();
        }

        public override DetalleVenta Update(DetalleVenta model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.UPDATE)) return new DetalleVenta();

            return Read(StoredProcedures.DetalleVentaUpdate, new Dictionary<string, object>
            {
                {"IdVenta", model.IdVenta },
                {"IdProducto", model.IdProducto },
                {"Precio", model.Precio },
                {"Cantidad", model.Cantidad },
                {"Descuento", model.Descuento }
            }).FirstOrDefault() ?? new DetalleVenta();
        }
    }
}
