using ElMirador.Interfaces;
using ElMirador.Servicios.Compras;
using Models.Compras;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ElMirador.Presentacion.Compras
{
    public partial class FrmEditorProveedor : Form, ISujeto
    {
        /// <summary>
        /// Proveedor a editar.
        /// </summary>
        private readonly Proveedor proveedor;

        /// <summary>
        /// Servicios para los proveedores.
        /// </summary>
        private readonly ProveedorService service;

        /// <summary>
        /// Lista de Observadores que estarán pendientes a los cambios de esta clase.
        /// </summary>
        private readonly List<IObservador> observadores;

        public FrmEditorProveedor(Proveedor proveedor)
        {
            InitializeComponent();
            this.proveedor = proveedor;
            service = new ProveedorService();
            observadores = new List<IObservador>();
            Init();
        }

        private void Init()
        {
            if (proveedor is null) return;

            TxtNombre.Text = proveedor.Nombre;
            TxtTelefono.Text = proveedor.Telefono;
            TxtDireccion.Text = proveedor.Direccion;
        }

        private void Limpiar()
        {
            TxtNombre.Text = string.Empty;
            TxtTelefono.Text = string.Empty;
            TxtDireccion.Text = string.Empty;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            IDictionary<string, object> properties = new Dictionary<string, object>
            {
                {"Nombre", TxtNombre.Text },
                {"Telefono", TxtTelefono.Text },
                {"Direccion", TxtDireccion.Text }
            };

            try
            {
                if (proveedor is null)
                {
                    service.Create(properties);
                }
                else
                {
                    properties.Add("Id", proveedor.Id);
                    properties.Add("Estado", proveedor.Estado);
                    service.Update(properties);
                }

                if (service.HasError())
                {
                    MessageBox.Show(this, service.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Notificar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void AgregarObservador(IObservador observador) => observadores.Add(observador);

        public void Notificar() => observadores.ForEach(observador => observador.Actualizar());
    }
}
