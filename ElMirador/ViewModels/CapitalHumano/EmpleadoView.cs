namespace ElMirador.ViewModels.CapitalHumano
{
    /// <summary>
    /// Objeto simple de tipo Empleado desde una vista personalizada.
    /// </summary>
    internal class EmpleadoView
    {
        /// <summary>
        /// Identificador único del Empleado.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombres del Empleado.
        /// </summary>
        public string Nombres { get; set; }

        /// <summary>
        /// Apellidos del Empleado.
        /// </summary>
        public string Apellidos { get; set; }

        /// <summary>
        /// Número de cédula del Empleado.
        /// </summary>
        public string Cedula { get; set; }

        /// <summary>
        /// Número de teléfono del Empleado.
        /// </summary>
        public string Telefono { get; set; }

        /// <summary>
        /// Dirección del Empleado.
        /// </summary>
        public string Direccion { get; set; }

        /// <summary>
        /// Nombre del municipio al que pertenece el Empleado.
        /// </summary>
        public string Municipio { get; set; }

        /// <summary>
        /// Nombre del departamento al que pertenece el municipio.
        /// </summary>
        public string Departamento { get; set; }
    }
}
