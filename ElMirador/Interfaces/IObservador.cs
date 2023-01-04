namespace ElMirador.Interfaces
{
    /// <summary>
    /// Indica que una clase estará pendiente de los cambios que notifique otra clase Sujeto y actualizará esos cambios.
    /// </summary>
    public interface IObservador
    {
        /// <summary>
        /// Actualiza los cambios notificados por la clase Sujeto.
        /// </summary>
        void Actualizar();
    }
}
