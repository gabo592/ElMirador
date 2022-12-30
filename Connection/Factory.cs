using Common.Util;
using Connection.CapitalHumano;
using Connection.Compras;
using Connection.Interfaces.CapitalHumano;
using Connection.Interfaces.Compras;
using Connection.Interfaces.Inventario;
using Connection.Interfaces.Seguridad;
using Connection.Interfaces.Ubicacion;
using Connection.Interfaces.Ventas;
using Connection.Inventario;
using Connection.Seguridad;
using Connection.Ubicacion;
using Connection.Ventas;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Connection
{
    /// <summary>
    /// Clase encargada de fabricar el DAO solicitado. Esta clase no puede heredarse.
    /// </summary>
    public sealed class Factory
    {
        private static readonly IDictionary<Type, Type> Daos = new Dictionary<Type, Type>
        {
            //CapitalHumano
            {typeof(IEmpleadoDao), typeof(EmpleadoDao) },

            //Compras
            {typeof(ICompraDao), typeof(CompraDao) },
            {typeof(IDetalleCompraDao), typeof(DetalleCompraDao) },
            {typeof(IProveedorDao), typeof(ProveedorDao) },

            //Inventario
            {typeof(IDetalleProductoDao), typeof(DetalleProductoDao) },
            {typeof(IMateriaPrimaDao), typeof(MateriaPrimaDao) },
            {typeof(IProductoDao), typeof(ProductoDao) },

            //Seguridad
            {typeof(IUsuarioDao), typeof(UsuarioDao) },

            //Ubicacion
            {typeof(IDepartamentoDao), typeof(DepartamentoDao) },
            {typeof(IMunicipioDao), typeof(MunicipioDao) },

            //Ventas
            {typeof(IClienteDao), typeof(ClienteDao) },
            {typeof(IDetalleVentaDao), typeof(DetalleVentaDao) },
            {typeof(IVentaDao), typeof(VentaDao) }
        };

        /// <summary>
        /// Realiza la invocación de un DAO en base al mapping ya configurado.
        /// </summary>
        /// <typeparam name="TDao">Tipo de DAO a invocar.</typeparam>
        /// /// <param name="handler">Administrador de errores.</param>
        /// <param name="connectionString">Cadena de conexión a la base de datos.</param>
        /// <returns>El tipo de DAO a invocar.</returns>
        /// <exception cref="ArgumentException">Se dispara cuando el DAO no se encuentra mapeado.</exception>
        /// <exception cref="ArgumentNullException">Se dispara cuando no se logra obtener un constructor que cumpla con los requisitos del DAO.</exception>
        public static TDao Invoke<TDao>(ErrorHandler handler, string connectionString)
        {
            if (!Daos.TryGetValue(typeof(TDao), out Type type)) throw new ArgumentException("El DAO a invocar no se encuentra mappeado.");

            ConstructorInfo constructor = type.GetConstructor(new Type[] { typeof(ErrorHandler), typeof(string) });

            if (constructor is null) throw new ArgumentNullException("El DAO a invocar no tiene configurado un constructor que contenga una instancia del administrador de errores y la cadena de conexión a la base de datos.");

            return (TDao)constructor.Invoke(new object[] { handler, connectionString });
        }
    }
}
