using Models.Interfaces;

namespace Models.Ventas
{
    /// <summary>
    /// Objeto simple de tipo detalle de venta.
    /// </summary>
    public class DetalleVenta : ITransactionDetail
    {
        /// <summary>
        /// Obtiene o establece el identificador único de la venta asociado a la transacción.
        /// </summary>
        public int IdVenta { get; set; }

        /// <summary>
        /// Obtiene o establece el identificador único del producto asociado a la transacción.
        /// </summary>
        public int IdProducto { get; set; }


        /// <summary>
        /// Obtiene o establece el precio de venta.
        /// </summary>
        public decimal Precio { get; set; }

        public double Cantidad { get; set; }

        public double Descuento { get; set; }
    }
}
