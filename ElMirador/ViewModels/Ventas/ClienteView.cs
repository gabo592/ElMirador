namespace ElMirador.ViewModels.Ventas
{
    /// <summary>
    /// Objeto simple de tipo Cliente desde una vista personalizada.
    /// </summary>
    internal class ClienteView
    {
        /// <summary>
        /// Identificador único del Cliente.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombres del Cliente.
        /// </summary>
        public string Nombres { get; set; }

        /// <summary>
        /// Apellidos del Cliente.
        /// </summary>
        public string Apellidos { get; set; }

        /// <summary>
        /// Número de teléfono del Cliente.
        /// </summary>
        public string Telefono { get; set; }

        /// <summary>
        /// Dirección del Cliente.
        /// </summary>
        public string Direccion { get; set; }

        /// <summary>
        /// Nombre del Municipio al que pertenece el Cliente.
        /// </summary>
        public string Municipio { get; set; }

        /// <summary>
        /// Nombre del Departamento al que pertenece el Municipio.
        /// </summary>
        public string Departamento { get; set; }
    }
}
