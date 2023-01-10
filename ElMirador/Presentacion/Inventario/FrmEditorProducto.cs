using ElMirador.Interfaces;
using ElMirador.Properties;
using ElMirador.Servicios.Inventario;
using ElMirador.ViewModels.Inventario;
using Models.Inventario;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ElMirador.Presentacion.Inventario
{
    public partial class FrmEditorProducto : Form, ISujeto
    {
        #region Private Fields

        /// <summary>
        /// Producto a editar.
        /// </summary>
        private Producto producto;

        /// <summary>
        /// Proveedor de servicios para los Productos.
        /// </summary>
        private readonly ProductoService service;

        /// <summary>
        /// Proveedor de servicios para los Detalles de Producto.
        /// </summary>
        private readonly DetalleProductoService detalleProductoService;

        /// <summary>
        /// Proveedor de servicios para las materias primas.
        /// </summary>
        private readonly MateriaPrimaService materiaPrimaService;

        /// <summary>
        /// Lista de Observadores que estarán pendientes a los cambios notificados por esta clase.
        /// </summary>
        private readonly List<IObservador> observadores;

        /// <summary>
        /// Lista de Detalles de Producto a eliminar.
        /// </summary>
        private readonly List<MateriaPrimaView> ToDelete;

        /// <summary>
        /// Lista de Detalles de Producto a manejar por esta clase.
        /// </summary>
        private List<MateriaPrimaView> Detalles;

        #endregion

        public FrmEditorProducto(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
            service = new ProductoService();
            detalleProductoService = new DetalleProductoService();
            materiaPrimaService = new MateriaPrimaService();
            observadores = new List<IObservador>();
            ToDelete = new List<MateriaPrimaView>();
            Detalles = new List<MateriaPrimaView>();
            Init();
        }

        private void Init()
        {
            DgvMateriasPrimas.DataSource = materiaPrimaService.GetMateriasPrimas(string.Empty).ToArray();

            if (producto is null) return;

            TxtDescripcion.Text = producto.Descripcion;
            NumPrecio.Value = producto.Precio;
            NumCantidad.Value = Convert.ToDecimal(producto.Cantidad);
            PbFoto.Image = producto.Foto;

            Detalles = detalleProductoService.GetMateriasPrimas(producto.Id).ToList();

            DgvDetallesProducto.DataSource = Detalles.ToArray();
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
            RbSiMateriaPrima.Checked = true;
            TxtBuscarMateriaPrima.Text = string.Empty;
            DgvMateriasPrimas.DataSource = materiaPrimaService.GetMateriasPrimas(string.Empty).ToArray();
            DgvDetallesProducto.DataSource = null;
        }

        private void EnableMateriaPrimaControls(bool enable)
        {
            TxtBuscarMateriaPrima.Enabled = enable;
            DgvMateriasPrimas.Enabled = enable;
            BtnAgregarMateriaPrima.Enabled = enable;
            DgvDetallesProducto.Enabled = enable;
            BtnEliminarDetalleProducto.Enabled = enable;
        }

        private TModel GetSelected<TModel>(DataGridView dataGridView)
        {
            if (dataGridView.SelectedRows.Count == 0) return default;

            TModel[] models = (TModel[])dataGridView.DataSource;

            return models[dataGridView.SelectedRows[0].Index];
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
                    producto = service.Create(properties);

                    if (service.HasError())
                    {
                        MessageBox.Show(this, service.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (RbSiMateriaPrima.Checked)
                    {
                        Detalles.ForEach(value => detalleProductoService.Create(new Dictionary<string, object>
                        {
                            {"IdProducto", producto.Id },
                            {"IdMateriaPrima", value.Id },
                            {"Cantidad", value.Cantidad }
                        }));
                    }
                }
                else
                {
                    properties.Add("Id", producto.Id);
                    properties.Add("Estado", producto.Estado);

                    service.Update(properties);

                    ToDelete.ForEach(value => detalleProductoService.Delete(producto.Id, value.Id));

                    if (RbSiMateriaPrima.Checked)
                    {
                        Detalles.ForEach(value => detalleProductoService.Update(new Dictionary<string, object>
                        {
                            {"IdProducto", producto.Id },
                            {"IdMateriaPrima", value.Id },
                            {"Cantidad", value.Cantidad }
                        }));
                    }
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

        private void TxtBuscarMateriaPrima_TextChange(object sender, EventArgs e)
        {
            DgvMateriasPrimas.DataSource = materiaPrimaService.GetMateriasPrimas(TxtBuscarMateriaPrima.Text).ToArray();
        }

        private void BtnAgregarMateriaPrima_Click(object sender, EventArgs e)
        {
            MateriaPrimaView selected = GetSelected<MateriaPrimaView>(DgvMateriasPrimas);

            Detalles.RemoveAll(value => value.Id == selected.Id);

            Detalles.Add(selected);

            DgvDetallesProducto.DataSource = Detalles.ToArray();

            MessageBox.Show(this, "¡Se ha añadido al detalle del producto!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnEliminarDetalleProducto_Click(object sender, EventArgs e)
        {
            MateriaPrimaView selected = GetSelected<MateriaPrimaView>(DgvDetallesProducto);

            if (selected.Equals(default))
            {
                MessageBox.Show(this, "Para eliminar un detalle de producto, primero debe seleccionarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"¿Desea eliminar el Detalle de Producto con ID: {selected.Id}?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No) return;

            ToDelete.Add(selected);
            Detalles.Remove(selected);
            DgvDetallesProducto.DataSource = Detalles.ToArray();
        }

        private void RbSiMateriaPrima_CheckedChanged(object sender, EventArgs e)
        {
            EnableMateriaPrimaControls(RbSiMateriaPrima.Checked);
        }
    }
}
