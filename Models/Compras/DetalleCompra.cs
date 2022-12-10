using Models.Interfaces;

namespace Models.Compras
{
    /// <summary>
    /// Objeto simple de tipo Detalle de Compra
    /// </summary>
    public class DetalleCompra : ITransactionDetail
    {
        /// <summary>
        /// Obtiene o establce el identificador único de la compra asociado a la transacción.
        /// </summary>
        public int IdCompra { get; set; }

        /// <summary>
        /// Obtiene o establece el identificador único de la materia prima asociado a la transacción.
        /// </summary>
        public int IdMateriaPrima { get; set; }

        public double Cantidad { get; set; }

        /// <summary>
        /// Obtiene o establece el costo de la transacción.
        /// </summary>
        public decimal Costo { get; set; }

        public double Descuento { get; set; }
    }
}
