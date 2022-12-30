namespace ElMirador.ViewModels.Ubicacion
{
    /// <summary>
    /// Objeto simple de tipo Municipio desde una vista personalizada.
    /// </summary>
    internal class MunicipioView
    {
        /// <summary>
        /// Identificador único del Municipio.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre del Municipio.
        /// </summary>
        public string Municipio { get; set; }

        /// <summary>
        /// Nombre del Departamento.
        /// </summary>
        public string Departamento { get; set; }
    }
}
