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
    /// Clase encargada de implementar el DAO para el objeto Cliente.
    /// </summary>
    internal class ClienteDao : BaseDao<Cliente>, IClienteDao
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        public ClienteDao(ErrorHandler handler, string connectionString) : base(handler, connectionString)
        {
            Handler = handler;
        }

        public override Cliente Create(Cliente model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.CREATE)) return new Cliente();

            return Read(StoredProcedures.ClienteCreate, new Dictionary<string, object>
            {
                {"PrimerNombre", model.PrimerNombre },
                {"SegundoNombre", model.SegundoNombre },
                {"PrimerApellido", model.PrimerApellido },
                {"SegundoApellido", model.SegundoApellido },
                {"Telefono", model.Telefono },
                {"Direccion", model.Direccion },
                {"IdMunicipio", model.IdMunicipio }
            }).FirstOrDefault() ?? new Cliente();
        }

        public override Cliente Delete(Cliente model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.DELETE)) return new Cliente();

            return Read(StoredProcedures.ClienteDelete, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault() ?? new Cliente();
        }

        public Cliente GetById(int id)
        {
            if (id.Equals(default))
            {
                Handler.Add("ID_DEFAULT");
                return new Cliente();
            }

            return Read(StoredProcedures.ClienteRead, new Dictionary<string, object>
            {
                {"Id", id },
                {"Estado", 1 }
            }).FirstOrDefault() ?? new Cliente();
        }

        public IEnumerable<Cliente> GetByIdMunicipio(int idMunicipio)
        {
            if (idMunicipio.Equals(default))
            {
                Handler.Add("ID_MUNICIPIO_DEFAULT");
                return Enumerable.Empty<Cliente>();
            }

            return Read(StoredProcedures.ClienteRead, new Dictionary<string, object>
            {
                {"IdMunicipio", idMunicipio },
                {"Estado", 1 }
            });
        }

        public override IEnumerable<Cliente> Read()
        {
            return Read(string.Empty);
        }

        public IEnumerable<Cliente> Read(string value)
        {
            return Read(StoredProcedures.ClienteRead, new Dictionary<string, object>
            {
                {"PrimerNombre", value },
                {"SegundoNombre", value },
                {"PrimerApellido", value },
                {"SegundoApellido", value },
                {"Telefono", value },
                {"Dirección", value },
                {"Estado", 1 }
            });
        }

        public override Cliente Update(Cliente model)
        {
            if (Validations.HasError(model, Handler, Validations.Operaciones.UPDATE)) return new Cliente();

            return Read(StoredProcedures.ClienteUpdate, new Dictionary<string, object>
            {
                {"Id", model.Id},
                {"PrimerNombre", model.PrimerNombre },
                {"SegundoNombre", model.SegundoNombre },
                {"PrimerApellido", model.PrimerApellido },
                {"SegundoApellido", model.SegundoApellido },
                {"Telefono", model.Telefono },
                {"Direccion", model.Direccion },
                {"IdMunicipio", model.IdMunicipio }
            }).FirstOrDefault() ?? new Cliente();
        }
    }
}
