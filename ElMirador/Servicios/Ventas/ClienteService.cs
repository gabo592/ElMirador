using Connection.Interfaces.Ventas;
using ElMirador.Servicios.Base;
using ElMirador.Servicios.Ubicacion;
using ElMirador.ViewModels.Ventas;
using Models.Ventas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElMirador.Servicios.Ventas
{
    /// <summary>
    /// Clase encarga de proveer los servicios para los Clientes.
    /// </summary>
    internal class ClienteService : ServicioBase
    {
        /// <summary>
        /// DAO para el objeto Cliente
        /// </summary>
        private readonly IClienteDao clienteDao;

        /// <summary>
        /// Proveedor de servicios para las ubicaciones.
        /// </summary>
        private readonly UbicacionService ubicacionService;

        public ClienteService()
        {
            clienteDao = DaoFactory.Get<IClienteDao>(Handler);
            ubicacionService = new UbicacionService();
        }

        public override void Dispose()
        {
            Handler.Clear();
            ubicacionService.Dispose();
        }

        /// <summary>
        /// Crea un nuevo Cliente en la base de datos a partir de una colección de pares clave-valor que corresponden a las propiedades del objeto.
        /// </summary>
        /// <param name="properties">Propiedades del objeto Cliente.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando la colección de pares clave-valor no se proporciona.</exception>
        public void Create(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "Las propiedades del objeto no pueden ser nulas.");

            Cliente cliente = clienteDao.Create(new Cliente
            {
                PrimerNombre = properties["PrimerNombre"].ToString(),
                SegundoNombre = properties["SegundoNombre"].ToString(),
                PrimerApellido = properties["PrimerApellido"].ToString(),
                SegundoApellido = properties["SegundoApellido"].ToString(),
                Telefono = properties["Telefono"].ToString(),
                Direccion = properties["Direccion"].ToString(),
                IdMunicipio = (int)properties["IdMunicipio"]
            });

            if (cliente.Id.Equals(default)) Handler.Add("MODELO_DEFAULT");
        }

        /// <inheritdoc cref="IClienteDao.GetById(int)"/>
        public Cliente GetById(int id) => clienteDao.GetById(id);

        public IEnumerable<ClienteView> GetClientes(string value)
        {
            IEnumerable<Cliente> clientes = clienteDao.Read(value);

            return clientes.Select(cliente =>
            {
                var municipio = ubicacionService.GetMunicipio(cliente.IdMunicipio);
                var departamento = ubicacionService.GetDepartamento(municipio.IdDepartamento);

                return new ClienteView
                {
                    Id = cliente.Id,
                    Nombres = $"{cliente.PrimerNombre} {cliente.SegundoNombre}",
                    Apellidos = $"{cliente.PrimerApellido} {cliente.SegundoApellido}",
                    Telefono = cliente.Telefono,
                    Direccion = cliente.Direccion,
                    Municipio = municipio.Nombre,
                    Departamento = departamento.Nombre
                };
            });
        }

        /// <summary>
        /// Actualiza un Cliente en la base de datos a partir de una colección de pares clave-valor que corresponden a las propiedades del objeto.
        /// </summary>
        /// <param name="properties">Propiedades del objeto Cliente.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando la colección de pares clave-valor no se proporciona.</exception>
        public void Update(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "Las propiedades del objeto no pueden ser nulas.");

            Cliente cliente = clienteDao.Update(new Cliente
            {
                Id = (int)properties["Id"],
                PrimerNombre = properties["PrimerNombre"].ToString(),
                SegundoNombre = properties["SegundoNombre"].ToString(),
                PrimerApellido = properties["PrimerApellido"].ToString(),
                SegundoApellido = properties["SegundoApellido"].ToString(),
                Telefono = properties["Telefono"].ToString(),
                Direccion = properties["Direccion"].ToString(),
                Estado = (bool)properties["Estado"],
                IdMunicipio = (int)properties["IdMunicipio"]
            });

            if (cliente.Id.Equals(default)) Handler.Add("MODELO_DEFAULT");
        }

        /// <summary>
        /// Elimina un Cliente de la base de datos dado su ID.
        /// </summary>
        /// <param name="id">Identificador único del Cliente.</param>
        public void Delete(int id)
        {
            Cliente cliente = clienteDao.Delete(GetById(id));

            if (cliente.Id.Equals(default)) Handler.Add("MODELO_DEFAULT");
        }

        public override string GetErrorMessage()
        {
            StringBuilder builder = new StringBuilder();

            if (Handler != null && Handler.HasError())
            {
                builder.AppendLine(Handler.GetErrorMessage());
            }

            if (ubicacionService != null && ubicacionService.HasError())
            {
                builder.AppendLine(ubicacionService.GetErrorMessage());
            }

            return builder.ToString();
        }

        public override bool HasError() => Handler.HasError() || ubicacionService.HasError();
    }
}
