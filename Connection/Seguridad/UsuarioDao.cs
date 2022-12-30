using Common.Util;
using Connection.Base;
using Connection.Constantes;
using Connection.Interfaces.Seguridad;
using Models.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Connection.Seguridad
{
    /// <summary>
    /// Clase encargada de implementar el DAO para el objeto Usuario.
    /// </summary>
    internal class UsuarioDao : BaseDao<Usuario>, IUsuarioDao
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        public UsuarioDao(ErrorHandler handler, string connectionString) : base(handler, connectionString)
        {
            Handler = handler;
        }

        public override Usuario Create(Usuario model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.CREATE)) return new Usuario();

            return Read(StoredProcedures.UsuarioCreate, new Dictionary<string, object>
            {
                {"Nombre", model.Nombre },
                {"Clave", model.Clave },
                {"Rol", model.Rol },
                {"IdEmpleado", model.IdEmpleado }
            }).FirstOrDefault() ?? new Usuario();
        }

        public override Usuario Delete(Usuario model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.DELETE)) return new Usuario();

            return Read(StoredProcedures.UsuarioDelete, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault() ?? new Usuario();
        }

        public Usuario GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario GetByIdEmpleado(int idEmpleado)
        {
            throw new NotImplementedException();
        }

        public Usuario Login(string nombre, string clave)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                Handler.Add("NOMBRE_VACIO");
                return new Usuario();
            }

            if (nombre.Length > 50)
            {
                Handler.Add("LONGITUD_NOMBRE_EXCEDIDA");
                return new Usuario();
            }

            if (string.IsNullOrWhiteSpace(clave))
            {
                Handler.Add("CLAVE_VACIO");
                return new Usuario();
            }

            if (clave.Length < 6)
            {
                Handler.Add("LONGITUD_CLAVE_MINIMA");
                return new Usuario();
            }

            return Read(StoredProcedures.UsuarioLogin, new Dictionary<string, object>
            {
                {"Nombre", nombre },
                {"Clave", clave }
            }).FirstOrDefault() ?? new Usuario();
        }

        public override IEnumerable<Usuario> Read()
        {
            return Read(string.Empty);
        }

        public IEnumerable<Usuario> Read(string value)
        {
            return Read(StoredProcedures.UsuarioRead, new Dictionary<string, object>
            {
                {"Nombre", value },
                {"Rol", value },
                {"Estado", 1 }
            });
        }

        public override Usuario Update(Usuario model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.UPDATE)) return new Usuario();

            return Read(StoredProcedures.UsuarioUpdate, new Dictionary<string, object>
            {
                {"Id", model.Id },
                {"Nombre", model.Nombre },
                {"Clave", model.Clave },
                {"Rol", model.Rol },
                {"IdEmpleado", model.IdEmpleado }
            }).FirstOrDefault() ?? new Usuario();
        }
    }
}
