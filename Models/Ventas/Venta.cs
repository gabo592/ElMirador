using Models.Interfaces;
using System;

namespace Models.Ventas
{
    /// <summary>
    /// Objeto simple de tipo Venta.
    /// </summary>
    public class Venta : IIdentity, ITransaction, IActivable
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public bool Estado { get; set; }

        public int IdEmpleado { get; set; }

        /// <summary>
        /// Obtiene o establece el identificador único del cliente asociado a la transacción.
        /// </summary>
        public int IdCliente { get; set; }
    }
}
