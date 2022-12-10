namespace Models.Interfaces
{
    /// <summary>
    /// Indica que una clase tendrá una propiedad ID con la cuál será identificada.
    /// </summary>
    public interface IIdentity
    {
        /// <summary>
        /// Identificador único de la clase.
        /// </summary>
        int Id { get; set; }
    }
}
