using System;

namespace ElMirador.Servicios.Base
{
    /// <summary>
    /// Indica que una clase implementará los métodos base para proporcionar un servicio.
    /// </summary>
    internal interface IServicioBase : IDisposable
    {
        /// <summary>
        /// Verifica si el administrador de errores contiene errores almacenados.
        /// </summary>
        /// <returns>Verdadero si el administrador contiene errores; de lo contrario, Falso.</returns>
        bool HasError();

        /// <summary>
        /// Obtiene los mensajes de error contenidos por el administrador de errores.
        /// </summary>
        /// <returns>Mensajes de errores almacenados.</returns>
        string GetErrorMessage();
    }
}
