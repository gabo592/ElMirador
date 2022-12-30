using Connection.Interfaces.Seguridad;
using ElMirador.Servicios.Base;
using Models.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElMirador.Servicios.Seguridad
{
    /// <summary>
    /// Clase encargada de proveer los servicios para el objeto Usuario.
    /// </summary>
    internal class UsuarioService : ServicioBase
    {
        private readonly IUsuarioDao usuarioDao;

        public UsuarioService()
        {
            usuarioDao = DaoFactory.Get<IUsuarioDao>(Handler);
        }

        /// <summary>
        /// Inicia la sesión a un usuario dado su nombre y clave de acceso.
        /// </summary>
        /// <param name="nombre">Nombre de usuario.</param>
        /// <param name="clave">Clave o contraseña del usuario.</param>
        public void Login(string nombre, string clave)
        {
            Usuario usuario = usuarioDao.Login(nombre, clave);

            if (usuario.Id.Equals(default))
            {
                Handler.Add("MODELO_DEFAULT");
                return;
            }

            Sesion.Set(usuario);
        }

        public override void Dispose()
        {
            Handler.Clear();
        }

        public override string GetErrorMessage() => Handler.GetErrorMessage();

        public override bool HasError() => Handler.HasError();
    }
}
