using Connection.Interfaces.Ubicacion;
using ElMirador.Servicios.Base;
using Models.Ubicacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElMirador.Servicios.Ubicacion
{
    /// <summary>
    /// Clase encargada de brindar los servicios para los objetos Departamento y Municipio.
    /// </summary>
    internal class UbicacionService : ServicioBase
    {
        private readonly IDepartamentoDao departamentoDao;
        private readonly IMunicipioDao municipioDao;

        public UbicacionService()
        {
            departamentoDao = DaoFactory.Get<IDepartamentoDao>(Handler);
            municipioDao = DaoFactory.Get<IMunicipioDao>(Handler);
        }

        /// <inheritdoc cref="IDepartamentoDao.GetById(int)"/>
        public Departamento GetDepartamentoById(int id) => departamentoDao.GetById(id);

        /// <inheritdoc cref="IMunicipioDao.GetById(int)"/>
        public Municipio GetMunicipioById(int id) => municipioDao.GetById(id);

        public override void Dispose()
        {
            Handler.Clear();
        }

        public override string GetErrorMessage() => Handler.GetErrorMessage();

        public override bool HasError() => Handler.HasError();
    }
}
