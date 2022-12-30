using Common.Util;
using Connection.Base;
using Connection.Constantes;
using Connection.Interfaces.CapitalHumano;
using Models.CapitalHumano;
using System.Collections.Generic;
using System.Linq;

namespace Connection.CapitalHumano
{
    /// <summary>
    /// Clase encargada de implementar el DAO para el objeto Empleado.
    /// </summary>
    internal class EmpleadoDao : BaseDao<Empleado>, IEmpleadoDao
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        public EmpleadoDao(ErrorHandler handler, string connectionString) : base(handler, connectionString)
        {
            Handler = handler;
        }

        public override Empleado Create(Empleado model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.CREATE)) return new Empleado();

            return Read(StoredProcedures.EmpleadoCreate, new Dictionary<string, object>
            {
                {"PrimerNombre", model.PrimerNombre },
                {"SegundoNombre", model.SegundoNombre },
                {"PrimerApellido", model.PrimerApellido },
                {"SegundoApellido", model.SegundoApellido },
                {"Cedula", model.Cedula },
                {"Foto", model.Foto },
                {"Telefono", model.Telefono },
                {"Dirección", model.Direccion },
                {"IdMunicipio", model.IdMunicipio }
            }).FirstOrDefault() ?? new Empleado();
        }

        public override Empleado Delete(Empleado model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.DELETE)) return new Empleado();

            return Read(StoredProcedures.EmpleadoDelete, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault() ?? new Empleado();
        }

        public Empleado GetById(int id)
        {
            if (id.Equals(default))
            {
                Handler.Add("ID_DEFAULT");
                return new Empleado();
            }

            return Read(StoredProcedures.EmpleadoRead, new Dictionary<string, object>
            {
                {"Id", id },
                {"Estado", 1 }
            }).FirstOrDefault() ?? new Empleado();
        }

        public IEnumerable<Empleado> GetByIdMunicipio(int idMunicipio)
        {
            if (idMunicipio.Equals(default))
            {
                Handler.Add("ID_MUNICIPIO_DEFAULT");
                return Enumerable.Empty<Empleado>();
            }

            return Read(StoredProcedures.EmpleadoRead, new Dictionary<string, object>
            {
                {"Estado", 1 },
                {"IdMunicipio", idMunicipio }
            });
        }

        public override IEnumerable<Empleado> Read()
        {
            return Read(string.Empty);
        }

        public IEnumerable<Empleado> Read(string value)
        {
            return Read(StoredProcedures.EmpleadoRead, new Dictionary<string, object>
            {
                {"PrimerNombre", value },
                {"SegundoNombre", value },
                {"PrimerApellido", value },
                {"SegundoApellido", value },
                {"Cedula", value },
                {"Telefono", value },
                {"Direccion", value },
                {"Estado", 1 }
            });
        }

        public override Empleado Update(Empleado model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.UPDATE)) return new Empleado();

            return Read(StoredProcedures.EmpleadoUpdate, new Dictionary<string, object>
            {
                {"Id", model.Id },
                {"PrimerNombre", model.PrimerNombre },
                {"SegundoNombre", model.SegundoNombre },
                {"PrimerApellido", model.PrimerApellido },
                {"SegundoApellido", model.SegundoApellido },
                {"Cedula", model.Cedula },
                {"Foto", model.Foto },
                {"Telefono", model.Telefono },
                {"Dirección", model.Direccion },
                {"IdMunicipio", model.IdMunicipio }
            }).FirstOrDefault() ?? new Empleado();
        }
    }
}
