namespace ElMirador.ViewModels.Inventario
{
    /// <summary>
    /// Objeto simple de tipo Producto desde una vista personalizada.
    /// </summary>
    internal class ProductoView
    {
        /// <summary>
        /// Identificador único del Producto.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Descripción del Producto.
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Precio en catálogo del Producto.
        /// </summary>
        public decimal Precio { get; set; }

        /// <summary>
        /// Cantidad en stock del Producto.
        /// </summary>
        public double Cantidad { get; set; }
    }
}
