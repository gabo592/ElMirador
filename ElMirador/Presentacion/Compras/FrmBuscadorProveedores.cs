using ElMirador.Interfaces;
using ElMirador.Presentacion.Base;
using ElMirador.Servicios.Compras;
using ElMirador.ViewModels.Compras;
using System;
using System.Windows.Forms;

namespace ElMirador.Presentacion.Compras
{
    public partial class FrmBuscadorProveedores : FrmBuscador, IObservador
    {
        /// <summary>
        /// Servicios para los Proveedores.
        /// </summary>
        private readonly ProveedorService service;

        public FrmBuscadorProveedores() : base("Proveedores")
        {
            InitializeComponent();
            service = new ProveedorService();
            Actualizar();
        }

        protected override void OnBtnCrear_Click(object sender, EventArgs args)
        {
            FrmEditorProveedor editorProveedor = new FrmEditorProveedor(null);
            editorProveedor.AgregarObservador(this);
            editorProveedor.ShowDialog();
        }

        protected override void OnBtnModificar_Click(object sender, EventArgs args)
        {
            ProveedorView selected = GetSelected<ProveedorView>();

            if (selected.Equals(default))
            {
                MessageBox.Show(this, "Para modificar un Proveedor, antes debe seleccionarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var proveedor = service.GetById(selected.Id);

            if (proveedor.Id.Equals(default))
            {
                MessageBox.Show(this, "El Proveedor no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmEditorProveedor editorProveedor = new FrmEditorProveedor(proveedor);
            editorProveedor.AgregarObservador(this);
            editorProveedor.ShowDialog();
        }

        protected override void OnBtnEliminar_Click(object sender, EventArgs args)
        {
            ProveedorView selected = GetSelected<ProveedorView>();

            if (selected.Equals(default))
            {
                MessageBox.Show(this, "Para eliminar un Proveedor, antes debe seleccionarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var proveedor = service.GetById(selected.Id);

            if (proveedor.Id.Equals(default))
            {
                MessageBox.Show(this, "El Proveedor no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"¿Desea eliminar el Proveedor con ID: {proveedor.Id}?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No) return;

            try
            {
                service.Delete(proveedor.Id);

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
            LoadDataGrid(service.GetProveedores(text));
        }

        public void Actualizar()
        {
            LoadDataGrid(service.GetProveedores(string.Empty));
        }
    }
}
