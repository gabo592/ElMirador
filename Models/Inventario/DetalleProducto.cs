namespace Models.Inventario
{
    /// <summary>
    /// Objeto simple de tipo Detalle de Producto.
    /// </summary>
    public class DetalleProducto
    {
        /// <summary>
        /// Obtiene o establece el identificador único del producto asociado al detalle.
        /// </summary>
        public int IdProducto { get; set; }

        /// <summary>
        /// Obtiene o establece el identificador único de la materia prima asociado al detalle.
        /// </summary>
        public int IdMateriaPrima { get; set; }

        /// <summary>
        /// Obtiene o establece la cantidad de materia prima utilizada en el detalle.
        /// </summary>
        public double Cantidad { get; set; }
    }
}
