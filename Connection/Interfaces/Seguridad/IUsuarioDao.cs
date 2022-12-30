using Connection.Base;
using Models.Seguridad;
using System.Collections.Generic;

namespace Connection.Interfaces.Seguridad
{
    /// <summary>
    /// Indica que una clase implementará los métodos de acceso a datos para el objeto Usuario.
    /// </summary>
    public interface IUsuarioDao : IDao<Usuario>
    {
        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un Usuario que coincida con el ID especificado.
        /// </summary>
        /// <param name="id">Identificador único del Usuario.</param>
        /// <returns>Objeto de tipo Usuario que resulte de la búsqueda; en caso de no encontrar, retorna una nueva instancia.</returns>
        Usuario GetById(int id);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de Usuarios que coincidan con el valor a filtrar.
        /// </summary>
        /// <param name="value">Valor a filtrar la búsqueda. Este puede ser por nombre o rol.</param>
        /// <returns>Colección de objetos de tipo Usuario que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Usuario> Read(string value);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un Usuario que coincida con el ID del Empleado especificado.
        /// </summary>
        /// <param name="idEmpleado">Identificador único del Empleado asociado al Usuario.</param>
        /// <returns>Objeto de tipo Usuario que resulte de la búsqueda; en caso de no encontrar, retorna una nueva instancia.</returns>
        Usuario GetByIdEmpleado(int idEmpleado);

        /// <summary>
        /// Verifica las credenciales de inicio de sesión de un usuario dado su nombre y clave o contraseña de acceso.
        /// </summary>
        /// <param name="nombre">Nombre de usuario.</param>
        /// <param name="clave">Clave o contraseña de acceso.</param>
        /// <returns>Objeto de tipo Usuario cuyo login fue satisfactorio; en caso de algún problema, retorna una nueva instancia.</returns>
        Usuario Login(string nombre, string clave);
    }
}
