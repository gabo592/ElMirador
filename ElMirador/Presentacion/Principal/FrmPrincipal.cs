using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElMirador.Presentacion.Principal
{
    public partial class FrmPrincipal : Form
    {
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
    }
}
