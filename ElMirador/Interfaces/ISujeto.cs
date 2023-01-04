namespace ElMirador.Interfaces
{
    /// <summary>
    /// Indica que una clase notificará los cambios que las clases Observador deberán actualizar en sí mismas.
    /// </summary>
    public interface ISujeto
    {
        /// <summary>
        /// Agrega una clase que implemente la interfaz IObservador a la colección de Observadores.
        /// </summary>
        /// <param name="observador">Observador a agregar.</param>
        void AgregarObservador(IObservador observador);

        /// <summary>
        /// Notifica a todas las clases Observadores que estén pendientes de ésta clase a actualizar su estado.
        /// </summary>
        void Notificar();
    }
}
