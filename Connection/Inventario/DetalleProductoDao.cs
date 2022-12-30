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
    /// Clase encargada de implementar el DAO para el objeto Detalle de Producto.
    /// </summary>
    internal class DetalleProductoDao : BaseDao<DetalleProducto>, IDetalleProductoDao
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        public DetalleProductoDao(ErrorHandler handler, string connectionString) : base(handler, connectionString)
        {
            Handler = handler;
        }

        public override DetalleProducto Create(DetalleProducto model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.CREATE)) return new DetalleProducto();

            return Read(StoredProcedures.DetalleProductoCreate, new Dictionary<string, object>
            {
                {"IdProducto", model.IdProducto },
                {"IdMateriaPrima", model.IdMateriaPrima },
                {"Cantidad", model.Cantidad }
            }).FirstOrDefault() ?? new DetalleProducto();
        }

        public override DetalleProducto Delete(DetalleProducto model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.DELETE)) return new DetalleProducto();

            return Read(StoredProcedures.DetalleProductoDelete, new Dictionary<string, object>
            {
                {"IdProducto", model.IdProducto },
                {"IdMateriaPrima", model.IdMateriaPrima }
            }).FirstOrDefault() ?? new DetalleProducto();
        }

        public IEnumerable<DetalleProducto> GetByIdMateriaPrima(int idMateriaPrima)
        {
            if (idMateriaPrima.Equals(default))
            {
                Handler.Add("ID_MATERIA_PRIMA_DEFAULT");
                return Enumerable.Empty<DetalleProducto>();
            }

            return Read(StoredProcedures.DetalleProductoRead, new Dictionary<string, object>
            {
                {"IdMateriaPrima", idMateriaPrima }
            });
        }

        public IEnumerable<DetalleProducto> GetByIdProducto(int idProducto)
        {
            if (idProducto.Equals(default))
            {
                Handler.Add("ID_PRODUCTO_DEFAULT");
                return Enumerable.Empty<DetalleProducto>();
            }

            return Read(StoredProcedures.DetalleProductoRead, new Dictionary<string, object>
            {
                {"IdProducto", idProducto }
            });
        }

        public override IEnumerable<DetalleProducto> Read()
        {
            return Read(StoredProcedures.DetalleProductoRead);
        }

        public DetalleProducto Read(int idProducto, int idMateriaPrima)
        {
            if (idProducto.Equals(default))
            {
                Handler.Add("ID_PRODUCTO_DEFAULT");
                return new DetalleProducto();
            }

            if (idMateriaPrima.Equals(default))
            {
                Handler.Add("ID_MATERIA_PRIMA_DEFAULT");
                return new DetalleProducto();
            }

            return Read(StoredProcedures.DetalleProductoRead, new Dictionary<string, object>
            {
                {"IdProducto", idProducto },
                {"IdMateriaPrima", idMateriaPrima }
            }).FirstOrDefault() ?? new DetalleProducto();
        }

        public override DetalleProducto Update(DetalleProducto model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.UPDATE)) return new DetalleProducto();

            return Read(StoredProcedures.DetalleProductoUpdate, new Dictionary<string, object>
            {
                {"IdProducto", model.IdProducto },
                {"IdMateriaPrima", model.IdMateriaPrima },
                {"Cantidad", model.Cantidad }
            }).FirstOrDefault() ?? new DetalleProducto();
        }
    }
}
