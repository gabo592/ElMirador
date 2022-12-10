using System;

namespace Models.Interfaces
{
    /// <summary>
    /// Indica que una clase realizará movimientos transaccionales dentro del sistema.
    /// </summary>
    public interface ITransaction
    {
        /// <summary>
        /// Obtiene o establece la fecha en que se realizó la transacción.
        /// </summary>
        DateTime Fecha { get; set; }

        /// <summary>
        /// Obtiene o establece el identificador único del empleado asociado en la transacción.
        /// </summary>
        int IdEmpleado { get; set; }
    }
}
