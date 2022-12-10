namespace Models.Interfaces
{
    /// <summary>
    /// Indica que una clase posee una propiedad Nombre.
    /// </summary>
    public interface INameable
    {
        /// <summary>
        /// Nombre del objeto.
        /// </summary>
        string Nombre { get; set; }
    }
}
