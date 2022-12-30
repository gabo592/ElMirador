using Common.Util;
using Connection;
using ElMirador.Properties;

namespace ElMirador.Servicios
{
    /// <summary>
    /// Clase encargada de fabricar los DAO solicitados.
    /// </summary>
    internal static class DaoFactory
    {
        private static readonly string connectionString;

        static DaoFactory()
        {
            connectionString = Settings.Default.connectionString;
        }

        /// <inheritdoc cref="Factory.Invoke{TDao}(ErrorHandler, string)"/>
        public static TDao Get<TDao>(ErrorHandler handler) => Factory.Invoke<TDao>(handler, connectionString);
    }
}
