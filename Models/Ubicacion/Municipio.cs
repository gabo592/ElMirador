using Models.Interfaces;

namespace Models.Ubicacion
{
    /// <summary>
    /// Objeto simple de tipo municipio.
    /// </summary>
    public class Municipio : IIdentity, INameable
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        /// <summary>
        /// Obtiene o establece el identificador único del departamento asociado al municipio.
        /// </summary>
        public int IdDepartamento { get; set; }
    }
}
