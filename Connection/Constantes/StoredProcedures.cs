namespace Connection.Constantes
{
    /// <summary>
    /// Clase encargada de contener los procedimientos almacenados que ejecutará el programa. Esta clase no puede heredarse.
    /// </summary>
    internal sealed class StoredProcedures
    {
        #region CapitalHumano

        public const string EmpleadoCreate = "EMPLEADO_CREATE";
        public const string EmpleadoRead = "EMPLEADO_READ";
        public const string EmpleadoUpdate = "EMPLEADO_UPDATE";
        public const string EmpleadoDelete = "EMPLEADO_DELETE";

        #endregion

        #region Compras

        public const string CompraCreate = "COMPRA_CREATE";
        public const string CompraRead = "COMPRA_READ";
        public const string CompraUpdate = "COMPRA_UPDATE";
        public const string CompraDelete = "COMPRA_DELETE";

        public const string DetalleCompraCreate = "DETALLE_COMPRA_CREATE";
        public const string DetalleCompraRead = "DETALLE_COMPRA_READ";
        public const string DetalleCompraUpdate = "DETALLE_COMPRA_UPDATE";
        public const string DetalleCompraDelete = "DETALLE_COMPRA_DELETE";

        public const string ProveedorCreate = "PROVEEDOR_CREATE";
        public const string ProveedorRead = "PROVEEDOR_READ";
        public const string ProveedorUpdate = "PROVEEDOR_UPDATE";
        public const string ProveedorDelete = "PROVEEDOR_DELETE";

        #endregion

        #region Inventario

        public const string DetalleProductoCreate = "DETALLE_PRODUCTO_CREATE";
        public const string DetalleProductoRead = "DETALLE_PRODUCTO_READ";
        public const string DetalleProductoUpdate = "DETALLE_PRODUCTO_UPDATE";
        public const string DetalleProductoDelete = "DETALLE_PRODUCTO_DELETE";

        public const string MateriaPrimaCreate = "MATERIA_PRIMA_CREATE";
        public const string MateriaPrimaRead = "MATERIA_PRIMA_READ";
        public const string MateriaPrimaUpdate = "MATERIA_PRIMA_UPDATE";
        public const string MateriaPrimaDelete = "MATERIA_PRIMA_DELETE";

        public const string ProductoCreate = "PRODUCTO_CREATE";
        public const string ProductoRead = "PRODUCTO_READ";
        public const string ProductoUpdate = "PRODUCTO_UPDATE";
        public const string ProductoDelete = "PRODUCTO_DELETE";

        #endregion

        #region Seguridad

        public const string UsuarioCreate = "USUARIO_CREATE";
        public const string UsuarioRead = "USUARIO_READ";
        public const string UsuarioUpdate = "USUARIO_UPDATE";
        public const string UsuarioDelete = "USUARIO_DELETE";
        public const string UsuarioLogin = "USUARIO_LOGIN";

        #endregion

        #region Ubicacion

        public const string DepartamentoRead = "DEPARTAMENTO_READ";
        public const string MunicipioRead = "MUNICIPIO_READ";

        #endregion

        #region Ventas

        public const string ClienteCreate = "CLIENTE_CREATE";
        public const string ClienteRead = "CLIENTE_READ";
        public const string ClienteUpdate = "CLIENTE_UPDATE";
        public const string ClienteDelete = "CLIENTE_DELETE";

        public const string DetalleVentaCreate = "DETALLE_VENTA_CREATE";
        public const string DetalleVentaRead = "DETALLE_VENTA_READ";
        public const string DetalleVentaUpdate = "DETALLE_VENTA_UPDATE";
        public const string DetalleVentaDelete = "DETALLE_VENTA_DELETE";

        public const string VentaCreate = "VENTA_CREATE";
        public const string VentaRead = "VENTA_READ";
        public const string VentaUpdate = "VENTA_UPDATE";
        public const string VentaDelete = "VENTA_DELETE";

        #endregion
    }
}
