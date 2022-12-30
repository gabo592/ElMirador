using ElMirador.Servicios.Seguridad;
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
    public partial class FrmLogin : Form
    {
        private readonly UsuarioService service;

        public FrmLogin()
        {
            InitializeComponent();
            service = new UsuarioService();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text;
            string clave = TxtClave.Text;

            try
            {
                service.Login(nombre, clave);

                if (service.HasError())
                {
                    MessageBox.Show(this, service.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FrmPrincipal frmPrincipal = new FrmPrincipal();
                Hide();
                frmPrincipal.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
