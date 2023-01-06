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
    public partial class FrmEditorProducto : Form, ISujeto
    {
        #region Private Fields

        /// <summary>
        /// Producto a editar.
        /// </summary>
        private readonly Producto producto;

        /// <summary>
        /// Proveedor de servicios para los Productos.
        /// </summary>
        private readonly ProductoService service;

        /// <summary>
        /// Lista de Observadores que estarán pendientes a los cambios notificados por esta clase.
        /// </summary>
        private readonly List<IObservador> observadores;

        #endregion

        public FrmEditorProducto(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
            service = new ProductoService();
            observadores = new List<IObservador>();
            Init();
        }

        private void Init()
        {
            if (producto is null) return;

            TxtDescripcion.Text = producto.Descripcion;
            NumPrecio.Value = producto.Precio;
            NumCantidad.Value = Convert.ToDecimal(producto.Cantidad);
            PbFoto.Image = producto.Foto;
        }

        /// <summary>
        /// Abre un cuadro de diálogo que le permite al usuario seleccionar la imagen que ocupará el Producto como su Foto.
        /// </summary>
        /// <returns>Imagen seleccionada por el usuario; en caso de no existir, retorna la imagen por defecto.</returns>
        private Image SelectPhoto()
        {
            Image image = producto?.Foto;

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

                return image is null ? Resources.burger : image;
            }
        }

        private void Limpiar()
        {
            TxtDescripcion.Text = string.Empty;
            NumPrecio.Value = NumPrecio.Minimum;
            NumCantidad.Value = NumCantidad.Minimum;
            PbFoto.Image = Resources.burger;
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
                {"Precio", NumPrecio.Value },
                {"Cantidad", NumCantidad.Value },
                {"Foto", PbFoto.Image }
            };

            try
            {
                if (producto is null)
                {
                    service.Create(properties);
                }
                else
                {
                    properties.Add("Id", producto.Id);
                    properties.Add("Estado", producto.Estado);
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
                throw;
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
