using Connection.Interfaces.Compras;
using ElMirador.Servicios.Base;
using ElMirador.ViewModels.Compras;
using Models.Compras;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ElMirador.Servicios.Compras
{
    /// <summary>
    /// Clase encargada de suministrar los servicios para los Proveedores.
    /// </summary>
    internal class ProveedorService : ServicioBase
    {
        /// <summary>
        /// DAO para los Proveedores.
        /// </summary>
        private readonly IProveedorDao proveedorDao;

        public ProveedorService()
        {
            proveedorDao = DaoFactory.Get<IProveedorDao>(Handler);
        }

        /// <summary>
        /// Crea un nuevo Proveedor en la base de datos dada una colección de pares clave-valor que corresponden a las propiedades del objeto.
        /// </summary>
        /// <param name="properties">Propiedades del Proveedor</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando la colección de pares clave-valor no es proporcionada.</exception>
        public void Create(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "Las propiedades del objeto no pueden ser nulas.");

            Proveedor proveedor = proveedorDao.Create(new Proveedor
            {
                Nombre = properties["Nombre"].ToString(),
                Telefono = properties["Telefono"].ToString(),
                Direccion = properties["Direccion"].ToString()
            });

            if (proveedor.Id.Equals(default)) Handler.Add("MODELO_DEFAULT");
        }

        /// <inheritdoc cref="IProveedorDao.GetById(int)"/>
        public Proveedor GetById(int id) => proveedorDao.GetById(id);

        public IEnumerable<ProveedorView> GetProveedores(string value)
        {
            IEnumerable<Proveedor> proveedores = proveedorDao.Read(value);

            return proveedores.Select(proveedor =>
            {
                return new ProveedorView
                {
                    Id = proveedor.Id,
                    Nombre = proveedor.Nombre,
                    Telefono = proveedor.Telefono,
                    Direccion = proveedor.Direccion
                };
            });
        }

        /// <summary>
        /// Actualiza un Proveedor en la base de datos dada una colección de pares clave-valor que corresponden a las propiedades del objeto.
        /// </summary>
        /// <param name="properties">Propiedades del Proveedor</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando la colección de pares clave-valor no es proporcionada.</exception>
        public void Update(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "Las propiedades del objeto no pueden ser nulas.");

            Proveedor proveedor = proveedorDao.Update(new Proveedor
            {
                Id = (int)properties["Id"],
                Nombre = properties["Nombre"].ToString(),
                Telefono = properties["Telefono"].ToString(),
                Direccion = properties["Direccion"].ToString(),
                Estado = (bool)properties["Estado"]
            });

            if (proveedor.Id.Equals(default)) Handler.Add("MODELO_DEFAULT");
        }

        /// <summary>
        /// Elimina un Proveedor de la base de datos dado su ID.
        /// </summary>
        /// <param name="id">Identificador único del Proveedor.</param>
        public void Delete(int id)
        {
            Proveedor proveedor = proveedorDao.Delete(GetById(id));

            if (proveedor.Id.Equals(default)) Handler.Add("MODELO_DEFAULT");
        }

        public override void Dispose() => Handler.Clear();

        public override string GetErrorMessage() => Handler.GetErrorMessage();

        public override bool HasError() => Handler.HasError();
    }
}
