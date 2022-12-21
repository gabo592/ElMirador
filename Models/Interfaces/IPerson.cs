namespace Models.Interfaces
{
    /// <summary>
    /// Indica que una clase posee propiedades de una persona natural.
    /// </summary>
    public interface IPerson
    {
        /// <summary>
        /// Obtiene o establece el primer nombre de la persona.
        /// </summary>
        string PrimerNombre { get; set; }

        /// <summary>
        /// Obtiene o establece el segundo nombre de la persona.
        /// </summary>
        string SegundoNombre { get; set; }

        /// <summary>
        /// Obtiene o establece el primer apellido de la persona.
        /// </summary>
        string PrimerApellido { get; set; }

        /// <summary>
        /// Obtiene o establece el segundo apellido de la persona.
        /// </summary>
        string SegundoApellido { get; set; }

        /// <summary>
        /// Obtiene o establece el número de teléfono de la persona.
        /// </summary>
        string Telefono { get; set; }

        /// <summary>
        /// Obtiene o establece la dirección de la persona.
        /// </summary>
        string Direccion { get; set; }

        /// <summary>
        /// Obtiene o establece el ID del municipio al que está relacionado la persona.
        /// </summary>
        int IdMunicipio { get; set; }
    }
}
