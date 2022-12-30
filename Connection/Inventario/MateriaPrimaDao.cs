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
    /// Clase encargada de implementar el DAO para el objeto Materia Prima.
    /// </summary>
    internal class MateriaPrimaDao : BaseDao<MateriaPrima>, IMateriaPrimaDao
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        public MateriaPrimaDao(ErrorHandler handler, string connectionString) : base(handler, connectionString)
        {
            Handler = handler;
        }

        public override MateriaPrima Create(MateriaPrima model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.CREATE)) return new MateriaPrima();

            return Read(StoredProcedures.MateriaPrimaCreate, new Dictionary<string, object>
            {
                {"Descripcion", model.Descripcion },
                {"UnidadMedida", model.UnidadMedida },
                {"Cantidad", model.Cantidad },
                {"Precio", model.Precio },
                {"Foto", model.Foto }
            }).FirstOrDefault() ?? new MateriaPrima();
        }

        public override MateriaPrima Delete(MateriaPrima model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.DELETE)) return new MateriaPrima();

            return Read(StoredProcedures.MateriaPrimaDelete, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault() ?? new MateriaPrima();
        }

        public MateriaPrima GetById(int id)
        {
            if (id.Equals(default))
            {
                Handler.Add("ID_DEFAULT");
                return new MateriaPrima();
            }

            return Read(StoredProcedures.MateriaPrimaRead, new Dictionary<string, object>
            {
                {"Id", id },
                {"Estado", 1 }
            }).FirstOrDefault() ?? new MateriaPrima();
        }

        public override IEnumerable<MateriaPrima> Read()
        {
            return Read(string.Empty);
        }

        public IEnumerable<MateriaPrima> Read(string value)
        {
            return Read(StoredProcedures.MateriaPrimaRead, new Dictionary<string, object>
            {
                {"Descripcion", value },
                {"UnidadMedida", value },
                {"Estado", 1 }
            });
        }

        public override MateriaPrima Update(MateriaPrima model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.UPDATE)) return new MateriaPrima();

            return Read(StoredProcedures.MateriaPrimaUpdate, new Dictionary<string, object>
            {
                {"Id", model.Id },
                {"Descripcion", model.Descripcion },
                {"UnidadMedida", model.UnidadMedida },
                {"Cantidad", model.Cantidad },
                {"Precio", model.Precio },
                {"Foto", model.Foto }
            }).FirstOrDefault() ?? new MateriaPrima();
        }
    }
}
