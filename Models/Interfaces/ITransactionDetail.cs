namespace Models.Interfaces
{
    /// <summary>
    /// Indica que una clase es el detalle de un movimiento transaccional.
    /// </summary>
    public interface ITransactionDetail
    {
        /// <summary>
        /// Obtiene o establece la cantidad de elementos involucrados en la transacción.
        /// </summary>
        double Cantidad { get; set; }

        /// <summary>
        /// Obtiene o establece el descuento aplicado en la transacción.
        /// </summary>
        double Descuento { get; set; }
    }
}
