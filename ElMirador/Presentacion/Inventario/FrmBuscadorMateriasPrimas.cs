using ElMirador.Interfaces;
using ElMirador.Presentacion.Base;
using ElMirador.Servicios.Inventario;
using ElMirador.ViewModels.Inventario;
using System;
using System.Windows.Forms;

namespace ElMirador.Presentacion.Inventario
{
    public partial class FrmBuscadorMateriasPrimas : FrmBuscador, IObservador
    {
        /// <summary>
        /// Proveedor de servicios para las Materias Primas.
        /// </summary>
        private readonly MateriaPrimaService service;

        public FrmBuscadorMateriasPrimas() : base("Materias Primas")
        {
            InitializeComponent();
            service = new MateriaPrimaService();
            Actualizar();
        }

        protected override void OnBtnCrear_Click(object sender, EventArgs args)
        {
            FrmEditorMateriaPrima editorMateriaPrima = new FrmEditorMateriaPrima(null);
            editorMateriaPrima.AgregarObservador(this);
            editorMateriaPrima.ShowDialog();
        }

        protected override void OnBtnModificar_Click(object sender, EventArgs args)
        {
            MateriaPrimaView selected = GetSelected<MateriaPrimaView>();

            if (selected.Equals(default))
            {
                MessageBox.Show(this, "Para eliminar una Materia Prima, primero debe seleccionarla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var materiaPrima = service.GetById(selected.Id);

            if (materiaPrima.Id.Equals(default))
            {
                MessageBox.Show(this, "No existe esa Materia Prima.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmEditorMateriaPrima editorMateriaPrima = new FrmEditorMateriaPrima(materiaPrima);
            editorMateriaPrima.AgregarObservador(this);
            editorMateriaPrima.ShowDialog();
        }

        protected override void OnBtnEliminar_Click(object sender, EventArgs args)
        {
            MateriaPrimaView selected = GetSelected<MateriaPrimaView>();

            if (selected.Equals(default))
            {
                MessageBox.Show(this, "Para eliminar una Materia Prima, primero debe seleccionarla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var materiaPrima = service.GetById(selected.Id);

            if (materiaPrima.Id.Equals(default))
            {
                MessageBox.Show(this, "No existe esa Materia Prima.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"¿Desea eliminar la materia prima con ID: {materiaPrima.Id}?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No) return;

            try
            {
                service.Delete(materiaPrima.Id);

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
            LoadDataGrid(service.GetMateriasPrimas(text));
        }

        public void Actualizar()
        {
            LoadDataGrid(service.GetMateriasPrimas(string.Empty));
        }
    }
}
