using ElMirador.Interfaces;
using ElMirador.Presentacion.Base;
using ElMirador.Servicios.Ventas;
using ElMirador.ViewModels.Ventas;
using System;
using System.Windows.Forms;

namespace ElMirador.Presentacion.Ventas
{
    public partial class FrmBuscadorClientes : FrmBuscador, IObservador
    {
        /// <summary>
        /// Proveedor de servicios para los Clientes.
        /// </summary>
        private readonly ClienteService service;

        public FrmBuscadorClientes() : base("Clientes")
        {
            InitializeComponent();
            service = new ClienteService();
            Actualizar();
        }

        public void Actualizar()
        {
            LoadDataGrid(service.GetClientes(string.Empty));
        }

        protected override void OnBtnCrear_Click(object sender, EventArgs args)
        {
            FrmEditorCliente editorCliente = new FrmEditorCliente(null);
            editorCliente.AgregarObservador(this);
            editorCliente.ShowDialog();
        }

        protected override void OnBtnEliminar_Click(object sender, EventArgs args)
        {
            ClienteView selected = GetSelected<ClienteView>();

            if (selected.Equals(default))
            {
                MessageBox.Show(this, "Para eliminar un cliente, primero debe seleccionarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var cliente = service.GetById(selected.Id);

            if (cliente.Id.Equals(default))
            {
                MessageBox.Show(this, "No existe el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"¿Desea eliminar al cliente con ID: {cliente.Id}?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No) return;

            try
            {
                service.Delete(cliente.Id);

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

        protected override void OnBtnModificar_Click(object sender, EventArgs args)
        {
            ClienteView selected = GetSelected<ClienteView>();

            if (selected.Equals(default))
            {
                MessageBox.Show(this, "Para eliminar un cliente, primero debe seleccionarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var cliente = service.GetById(selected.Id);

            if (cliente.Id.Equals(default))
            {
                MessageBox.Show(this, "No existe el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmEditorCliente editorCliente = new FrmEditorCliente(cliente);
            editorCliente.AgregarObservador(this);
            editorCliente.ShowDialog();
        }

        protected override void OnTxtBuscar_TextChanged(string text)
        {
            LoadDataGrid(service.GetClientes(text));
        }
    }
}
