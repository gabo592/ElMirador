using Models.Interfaces;
using System.Drawing;

namespace Models.Inventario
{
    /// <summary>
    /// Objeto simple de tipo producto.
    /// </summary>
    public class Producto : IIdentity, IProduct, IActivable
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public double Cantidad { get; set; }

        public decimal Precio { get; set; }

        public Image Foto { get; set; }

        public bool Estado { get; set; }
    }
}
