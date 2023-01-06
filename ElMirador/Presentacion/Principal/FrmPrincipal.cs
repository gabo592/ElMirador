using ElMirador.Presentacion.CapitalHumano;
using ElMirador.Presentacion.Compras;
using ElMirador.Presentacion.Inventario;
using ElMirador.Presentacion.Ventas;
using System;
using System.Windows.Forms;

namespace ElMirador.Presentacion.Principal
{
    public partial class FrmPrincipal : Form
    {
        private Form ChildForm;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "¿Desea cerrar la aplicación? Los cambios no guardados podrían perderse.", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            e.Cancel = result == DialogResult.No;
        }

        private void PbMenu_Click(object sender, EventArgs e)
        {
            if (!PnlSideBar.Visible)
            {
                SideBarTransition.Show(PnlSideBar);
            }

            PnlSideBar.Visible = !PnlSideBar.Visible;
        }

        /// <summary>
        /// Agrega un formulario al panel principal.
        /// </summary>
        /// <param name="form">Formulario a agregar.</param>
        private void AddForm(Form form)
        {
            ChildForm?.Close();

            ChildForm = form;

            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;

            PnlPrincipal.Controls.Add(ChildForm);
            PnlPrincipal.Tag = ChildForm;

            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            AddForm(new FrmBuscadorEmpleado());
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            AddForm(new FrmBuscadorClientes());
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            AddForm(new FrmBuscadorProveedores());
        }

        private void BtnMateriasPrimas_Click(object sender, EventArgs e)
        {
            AddForm(new FrmBuscadorMateriasPrimas());
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            AddForm(new FrmBuscadorProductos());
        }
    }
}
