namespace ElMirador.ViewModels.Inventario
{
    /// <summary>
    /// Objeto simple de tipo Materia Prima desde una vista personalizada.
    /// </summary>
    internal class MateriaPrimaView
    {
        /// <summary>
        /// Identificador único de la Materia Prima.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Descripcion de la Materia Prima.
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Siglas de la unidad de medida de la Materia Prima.
        /// </summary>
        public string Medida { get; set; }

        /// <summary>
        /// Cantidad en stock de la Materia Prima.
        /// </summary>
        public double Cantidad { get; set; }

        /// <summary>
        /// Precio en catálogo de la Materia Prima.
        /// </summary>
        public decimal Precio { get; set; }
    }
}
