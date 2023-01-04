using ElMirador.Interfaces;
using ElMirador.Presentacion.Base;
using ElMirador.Servicios.CapitalHumano;
using ElMirador.ViewModels.CapitalHumano;
using System;
using System.Windows.Forms;

namespace ElMirador.Presentacion.CapitalHumano
{
    public partial class FrmBuscadorEmpleado : FrmBuscador, IObservador
    {
        /// <summary>
        /// Proveedor de servicios para los Empleados.
        /// </summary>
        private readonly EmpleadoService service;

        public FrmBuscadorEmpleado() : base("Empleados")
        {
            InitializeComponent();
            service = new EmpleadoService();
            Actualizar();
        }

        public void Actualizar()
        {
            LoadDataGrid(service.GetEmpleados(string.Empty));
        }

        protected override void OnBtnCrear_Click(object sender, EventArgs args)
        {
            FrmEditarEmpleado editarEmpleado = new FrmEditarEmpleado(null);
            editarEmpleado.AgregarObservador(this);
            editarEmpleado.ShowDialog();
        }

        protected override void OnBtnEliminar_Click(object sender, EventArgs args)
        {
            EmpleadoView selected = GetSelected<EmpleadoView>();

            if (selected.Equals(default))
            {
                MessageBox.Show(this, "Para eliminar un empleado, primero debe seleccionarlo.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var empleado = service.GetById(selected.Id);

            if (empleado.Id.Equals(default))
            {
                MessageBox.Show(this, "El empleado a eliminar no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"¿Desea eliminar el empleado con ID: {empleado.Id}?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No) return;

            try
            {
                service.Delete(empleado.Id);

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
            EmpleadoView selected = GetSelected<EmpleadoView>();

            if (selected.Equals(default))
            {
                MessageBox.Show(this, "Para actualizar un empleado, primero debe seleccionarlo.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var empleado = service.GetById(selected.Id);

            if (empleado.Id.Equals(default))
            {
                MessageBox.Show(this, "El empleado a actualizar no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmEditarEmpleado editarEmpleado = new FrmEditarEmpleado(empleado);
            editarEmpleado.AgregarObservador(this);
            editarEmpleado.ShowDialog();
        }

        protected override void OnTxtBuscar_TextChanged(string text)
        {
            LoadDataGrid(service.GetEmpleados(text));
        }
    }
}
