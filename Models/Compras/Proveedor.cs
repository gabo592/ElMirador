using Models.Interfaces;

namespace Models.Compras
{
    /// <summary>
    /// Objeto simple de tipo Proveedor.
    /// </summary>
    public class Proveedor : IIdentity, INameable, IActivable
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        /// <summary>
        /// Obtiene o establece el número de teléfono del proveedor.
        /// </summary>
        public string Telefono { get; set; }

        /// <summary>
        /// Obtiene o establece la dirección del proveedor.
        /// </summary>
        public string Direccion { get; set; }

        public bool Estado { get; set; }
    }
}
