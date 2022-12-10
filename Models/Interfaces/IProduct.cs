using System.Drawing;

namespace Models.Interfaces
{
    /// <summary>
    /// Indica que una clase posee propiedades de un producto para su almacenamiento.
    /// </summary>
    public interface IProduct
    {
        /// <summary>
        /// Obtiene o establece la descripción del producto.
        /// </summary>
        string Descripcion { get; set; }

        /// <summary>
        /// Obtiene o establece la cantidad en stock del producto.
        /// </summary>
        double Cantidad { get; set; }

        /// <summary>
        /// Obtiene o establece el precio en catálogo del producto.
        /// </summary>
        decimal Precio { get; set; }

        /// <summary>
        /// Obtiene o establece la foto del producto.
        /// </summary>
        Image Foto { get; set; }
    }
}
