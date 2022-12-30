using Models.Seguridad;

namespace ElMirador.Servicios.Base
{
    /// <summary>
    /// Clase encargada de administrar la sesión de usuario dentro del sistema.
    /// </summary>
    internal static class Sesion
    {
        /// <summary>
        /// Usuario que interactua con el sistema.
        /// </summary>
        public static Usuario Usuario { get; private set; }

        /// <summary>
        /// Indica si existe un usuario con la sesión activa.
        /// </summary>
        public static bool IsActive => Usuario != null;

        /// <summary>
        /// Establece un inicio de sesión para un usuario. Si existe una sesión activa, ésta se cerrará para permitir que la nueva sesión se inicie.
        /// </summary>
        /// <param name="usuario">Usuario a iniciar sesión.</param>
        public static void Set(Usuario usuario)
        {
            if (usuario is null || usuario.Id.Equals(default))
            {
                Close();
                return;
            }

            if (IsActive) Close();

            Usuario = usuario;
        }

        /// <summary>
        /// Cierra la sesión actual.
        /// </summary>
        private static void Close() => Usuario = null;
    }
}
