using ElMirador.Interfaces;
using ElMirador.Properties;
using ElMirador.Servicios.Inventario;
using Models.Inventario;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ElMirador.Presentacion.Inventario
{
    public partial class FrmEditorMateriaPrima : Form, ISujeto
    {
        #region Private Fields

        /// <summary>
        /// Materia Prima a editar.
        /// </summary>
        private readonly MateriaPrima materiaPrima;

        /// <summary>
        /// Lista de observadores que estarán pendientes a los cambios notificados por esta clase.
        /// </summary>
        private readonly List<IObservador> observadores;

        /// <summary>
        /// Proveedor de servicios para las Materias Primas.
        /// </summary>
        private readonly MateriaPrimaService service;

        #endregion

        public FrmEditorMateriaPrima(MateriaPrima materiaPrima)
        {
            InitializeComponent();
            this.materiaPrima = materiaPrima;
            observadores = new List<IObservador>();
            service = new MateriaPrimaService();
            Init();
        }

        private void Init()
        {
            if (materiaPrima is null) return;

            TxtDescripcion.Text = materiaPrima.Descripcion;
            TxtUnidadMedida.Text = materiaPrima.UnidadMedida;
            NumCantidad.Value = Convert.ToDecimal(materiaPrima.Cantidad);
            NumPrecio.Value = materiaPrima.Precio;
            PbFoto.Image = materiaPrima.Foto;
        }

        /// <summary>
        /// Abre un cuadro de diálogo que le permite al usuario seleccionar la imagen que ocupará la Materia Prima como su Foto.
        /// </summary>
        /// <returns>Imagen seleccionada por el usuario; en caso de no existir, retorna la imagen por defecto.</returns>
        private Image SelectPhoto()
        {
            Image image = materiaPrima?.Foto;

            using (OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "JPG (*.jpg)|*.jpg|JPEG (*.jpeg)|*.jpeg|PNG (*.png)|*.png|Bitmap (*.bmp)|*.bmp|GIF (*.gif)|*.gif",
                FilterIndex = 0,
                RestoreDirectory = true
            })
            {
                DialogResult result = openFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Stream stream = openFileDialog.OpenFile();
                    image = Image.FromStream(stream);
                }

                return image is null ? Resources.material : image;
            }
        }

        private void Limpiar()
        {
            TxtDescripcion.Text = string.Empty;
            TxtUnidadMedida.Text = string.Empty;
            NumCantidad.Value = NumCantidad.Minimum;
            NumPrecio.Value = NumPrecio.Minimum;
            PbFoto.Image = Resources.material;
        }

        private void PbFoto_Click(object sender, EventArgs e)
        {
            PbFoto.Image = SelectPhoto();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            IDictionary<string, object> properties = new Dictionary<string, object>
            {
                {"Descripcion", TxtDescripcion.Text },
                {"UnidadMedida", TxtUnidadMedida.Text },
                {"Cantidad", NumCantidad.Value },
                {"Precio", NumPrecio.Value },
                {"Foto", PbFoto.Image }
            };

            try
            {
                if (materiaPrima is null)
                {
                    service.Create(properties);
                }
                else
                {
                    properties.Add("Id", materiaPrima.Id);
                    properties.Add("Estado", materiaPrima.Estado);
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
