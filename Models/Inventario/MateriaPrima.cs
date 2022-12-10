using Models.Interfaces;
using System.Drawing;

namespace Models.Inventario
{
    /// <summary>
    /// Objeto simple de tipo materia prima.
    /// </summary>
    public class MateriaPrima : IIdentity, IProduct, IActivable
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        /// <summary>
        /// Obtiene o establece la unidad de medida para la materia prima.
        /// </summary>
        public string UnidadMedida { get; set; }

        public double Cantidad { get; set; }

        public decimal Precio { get; set; }

        public Image Foto { get; set; }

        public bool Estado { get; set; }
    }
}
