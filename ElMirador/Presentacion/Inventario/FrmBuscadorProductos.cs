using ElMirador.Interfaces;
using ElMirador.Presentacion.Base;
using ElMirador.Servicios.Inventario;
using ElMirador.ViewModels.Inventario;
using System;
using System.Windows.Forms;

namespace ElMirador.Presentacion.Inventario
{
    public partial class FrmBuscadorProductos : FrmBuscador, IObservador
    {
        /// <summary>
        /// Proveedor de servicios para los Productos.
        /// </summary>
        private readonly ProductoService service;

        public FrmBuscadorProductos() : base("Productos")
        {
            InitializeComponent();
            service = new ProductoService();
            Actualizar();
        }

        protected override void OnBtnCrear_Click(object sender, EventArgs args)
        {
            FrmEditorProducto editorProducto = new FrmEditorProducto(null);
            editorProducto.AgregarObservador(this);
            editorProducto.ShowDialog();
        }

        protected override void OnBtnModificar_Click(object sender, EventArgs args)
        {
            ProductoView productoView = GetSelected<ProductoView>();

            if (productoView.Equals(default))
            {
                MessageBox.Show(this, "Para actualizar un producto, primero debe seleccionarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var producto = service.GetById(productoView.Id);

            if (producto.Id.Equals(default))
            {
                MessageBox.Show(this, "El producto no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmEditorProducto editorProducto = new FrmEditorProducto(producto);
            editorProducto.AgregarObservador(this);
            editorProducto.ShowDialog();
        }

        protected override void OnBtnEliminar_Click(object sender, EventArgs args)
        {
            ProductoView productoView = GetSelected<ProductoView>();

            if (productoView.Equals(default))
            {
                MessageBox.Show(this, "Para eliminar un producto, primero debe seleccionarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var producto = service.GetById(productoView.Id);

            if (producto.Id.Equals(default))
            {
                MessageBox.Show(this, "El producto no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"¿Desea eliminar el producto con ID: {producto.Id}?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No) return;

            try
            {
                service.Delete(producto.Id);

                if (service.HasError())
                {
                    MessageBox.Show(this, service.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnTxtBuscar_TextChanged(string text)
        {
            LoadDataGrid(service.GetProductos(text));
        }

        public void Actualizar()
        {
            LoadDataGrid(service.GetProductos(string.Empty));
        }
    }
}
