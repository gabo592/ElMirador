using System;
using System.Collections.Generic;
using System.Resources;
using System.Text;

namespace Common.Util
{
    /// <summary>
    /// Clase encargada de administrar los errores dentro del sistema.
    /// </summary>
    public class ErrorHandler : List<string>
    {
        /// <summary>
        /// Agrega el mensaje de error contenido en la excepción, siempre y cuando ésta no sea nula.
        /// </summary>
        /// <param name="exception">Excepción a agregar.</param>
        public void Add(Exception exception)
        {
            if (exception is null) return;

            if (exception.InnerException != null)
            {
                Add(exception.InnerException.Message);
                return;
            }

            Add(exception.Message);
        }

        /// <summary>
        /// Verifica si el administrador de errores contiene errores almacenados.
        /// </summary>
        /// <returns>Verdadero en caso de que existan errores; de lo contrario, Falso.</returns>
        public bool HasError() => Count > 0;

        /// <summary>
        /// Obtiene los mensajes de error que el administrador ha almacenado.
        /// </summary>
        /// <returns>Cadena de texto con todos los mensajes de errores acumulados.</returns>
        public string GetErrorMessage()
        {
            StringBuilder stringBuilder = new StringBuilder();

            ResourceManager resourceManager = new ResourceManager(typeof(Resources.Messages));

            foreach (string name in this)
            {
                string value = resourceManager.GetString(name);
                stringBuilder.AppendLine(value);
            }

            return stringBuilder.ToString();
        }
    }
}
