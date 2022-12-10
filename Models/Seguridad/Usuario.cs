using Models.Interfaces;

namespace Models.Seguridad
{
    /// <summary>
    /// Objeto simple de tipo usuario.
    /// </summary>
    public class Usuario : IIdentity, INameable, ISecurity, IActivable
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Clave { get; set; }

        /// <summary>
        /// Obtiene o establece el rol del usuario dentro del sistema.
        /// </summary>
        public string Rol { get; set; }

        public bool Estado { get; set; }

        /// <summary>
        /// Obtiene o establece el identificador único del empleado asociado al usuario.
        /// </summary>
        public int IdEmpleado { get; set; }
    }
}
