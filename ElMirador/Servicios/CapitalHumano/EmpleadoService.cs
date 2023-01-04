using Connection.Interfaces.CapitalHumano;
using ElMirador.Servicios.Base;
using ElMirador.Servicios.Ubicacion;
using ElMirador.ViewModels.CapitalHumano;
using Models.CapitalHumano;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ElMirador.Servicios.CapitalHumano
{
    /// <summary>
    /// Provee los servicios para los Empleados
    /// </summary>
    internal class EmpleadoService : ServicioBase
    {
        /// <summary>
        /// DAO para los Empleados
        /// </summary>
        private readonly IEmpleadoDao empleadoDao;

        /// <summary>
        /// Servicio de ubicaciones.
        /// </summary>
        private readonly UbicacionService ubicacionService;

        public EmpleadoService()
        {
            empleadoDao = DaoFactory.Get<IEmpleadoDao>(Handler);
            ubicacionService = new UbicacionService();
        }

        /// <summary>
        /// Crea un nuevo Empleado en la base de datos dada una colección de pares clave-valor que son las propiedades del objeto.
        /// </summary>
        /// <param name="properties">Propiedades del empleado a crear</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando la colección de pares clave-valor no se proporciona.</exception>
        public void Create(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "Las propiedades del modelo no pueden estar vacías.");

            Empleado empleado = empleadoDao.Create(new Empleado
            {
                PrimerNombre = properties["PrimerNombre"].ToString(),
                SegundoNombre = properties["SegundoNombre"].ToString(),
                PrimerApellido = properties["PrimerApellido"].ToString(),
                SegundoApellido = properties["SegundoApellido"].ToString(),
                Cedula = properties["Cedula"].ToString(),
                Foto = (Image)properties["Foto"],
                Telefono = properties["Telefono"].ToString(),
                Direccion = properties["Direccion"].ToString(),
                IdMunicipio = (int)properties["IdMunicipio"]
            });

            if (empleado.Id.Equals(default)) Handler.Add("MODELO_DEFAULT");
        }

        /// <inheritdoc cref="IEmpleadoDao.GetById(int)"/>
        public Empleado GetById(int id) => empleadoDao.GetById(id);

        /// <summary>
        /// Busca todos los Empleados en la base de datos que coincidan con el valor a filtrar.
        /// </summary>
        /// <param name="value">Valor a filtrar la búsqueda. Puede ser por: nombres, apellidos, cédula, teléfono, dirección, etc.</param>
        /// <returns>Colección de Empleados que resulten de la búsqueda desde una vista personalizada.</returns>
        public IEnumerable<EmpleadoView> GetEmpleados(string value)
        {
            IEnumerable<Empleado> empleados = empleadoDao.Read(value);

            return empleados.Select(empleado =>
            {
                var municipio = ubicacionService.GetMunicipio(empleado.IdMunicipio);
                var departamento = ubicacionService.GetDepartamento(municipio.IdDepartamento);

                return new EmpleadoView
                {
                    Id = empleado.Id,
                    Nombres = $"{empleado.PrimerNombre} {empleado.SegundoNombre}",
                    Apellidos = $"{empleado.PrimerApellido} {empleado.SegundoApellido}",
                    Cedula = empleado.Cedula,
                    Telefono = empleado.Telefono,
                    Direccion = empleado.Direccion,
                    Municipio = municipio.Nombre,
                    Departamento = departamento.Nombre
                };
            });
        }

        /// <summary>
        /// Actualiza un Empleado en la base de datos dada una colección de pares clave-valor que son las propiedades del objeto.
        /// </summary>
        /// <param name="properties">Propiedades del empleado a actualizar</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando la colección de pares clave-valor no se proporciona.</exception>
        public void Update(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "Las propiedades del modelo no pueden estar vacías.");

            Empleado empleado = empleadoDao.Update(new Empleado
            {
                Id = (int)properties["Id"],
                PrimerNombre = properties["PrimerNombre"].ToString(),
                SegundoNombre = properties["SegundoNombre"].ToString(),
                PrimerApellido = properties["PrimerApellido"].ToString(),
                SegundoApellido = properties["SegundoApellido"].ToString(),
                Cedula = properties["Cedula"].ToString(),
                Foto = (Image)properties["Foto"],
                Telefono = properties["Telefono"].ToString(),
                Direccion = properties["Direccion"].ToString(),
                Estado = (bool)properties["Estado"],
                IdMunicipio = (int)properties["IdMunicipio"]
            });

            if (empleado.Id.Equals(default)) Handler.Add("MODELO_DEFAULT");
        }

        /// <summary>
        /// Elimina un Empleado en la base de datos dado su ID.
        /// </summary>
        /// <param name="id">Identificador único del Empleado a eliminar.</param>
        public void Delete(int id)
        {
            Empleado empleado = empleadoDao.Delete(GetById(id));

            if (empleado.Id.Equals(default)) Handler.Add("MODELO_DEFAULT");
        }

        public override void Dispose()
        {
            Handler.Clear();
            ubicacionService.Dispose();
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
