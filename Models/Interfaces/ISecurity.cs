namespace Models.Interfaces
{
    /// <summary>
    /// Indica que una clase posee una propiedad que se utilizará como seguridad.
    /// </summary>
    public interface ISecurity
    {
        /// <summary>
        /// Clave o contraseña del registro.
        /// </summary>
        string Clave { get; set; }
    }
}
