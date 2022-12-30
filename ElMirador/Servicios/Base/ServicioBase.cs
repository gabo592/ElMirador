using Common.Util;

namespace ElMirador.Servicios.Base
{
    /// <summary>
    /// Clase encargada de proveer los métodos y propiedades básicas para proporcionar un servicio.
    /// </summary>
    internal abstract class ServicioBase : IServicioBase
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        protected readonly ErrorHandler Handler;

        public ServicioBase()
        {
            Handler = new ErrorHandler();
        }

        public abstract void Dispose();

        public abstract string GetErrorMessage();

        public abstract bool HasError();
    }
}
