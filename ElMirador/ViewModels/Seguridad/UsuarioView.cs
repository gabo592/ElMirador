namespace ElMirador.ViewModels.Seguridad
{
    /// <summary>
    /// Objeto simple de tipo Usuario desde una vista personalizada.
    /// </summary>
    internal class UsuarioView
    {
        /// <summary>
        /// Identificador único del Usuario.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre de usuario.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Rol del usuario.
        /// </summary>
        public string Rol { get; set;}

        /// <summary>
        /// Nombre del Empleado asociado al Usuario.
        /// </summary>
        public string Empleado { get; set; }
    }
}
