namespace Models.Interfaces
{
    /// <summary>
    /// Indica que una clase posee una propiedad Estado el cuál indicará la disponibilidad de la misma.
    /// </summary>
    public interface IActivable
    {
        /// <summary>
        /// Estado del objeto.
        /// </summary>
        bool Estado { get; set; }
    }
}
