using Models.Interfaces;
using System.Drawing;

namespace Models.CapitalHumano
{
    /// <summary>
    /// Objeto simple de tipo Empleado.
    /// </summary>
    public class Empleado : IIdentity, IPerson, IActivable
    {
        public int Id { get; set; }

        public string PrimerNombre { get; set; }

        public string SegundoNombre { get; set; }

        public string PrimerApellido { get; set; }

        public string SegundoApellido { get; set; }

        /// <summary>
        /// Obtiene o establece el número de cédula del empleado.
        /// </summary>
        public string Cedula { get; set; }

        /// <summary>
        /// Obtiene o establece la foto del empleado.
        /// </summary>
        public Image Foto { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public bool Estado { get; set; }

        public int IdMunicipio { get; set; }
    }
}
