using ElMirador.Interfaces;
using ElMirador.Properties;
using ElMirador.Servicios.CapitalHumano;
using ElMirador.Servicios.Ubicacion;
using Models.CapitalHumano;
using Models.Interfaces;
using Models.Ubicacion;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ElMirador.Presentacion.CapitalHumano
{
    public partial class FrmEditarEmpleado : Form, ISujeto
    {
        #region Private Fields

        /// <summary>
        /// Empleado a editar por este formulario.
        /// </summary>
        private readonly Empleado empleado;

        /// <summary>
        /// Servicio de ubicaciones.
        /// </summary>
        private readonly UbicacionService ubicacionService;

        /// <summary>
        /// Proveedor de servicios para los empleados.
        /// </summary>
        private readonly EmpleadoService service;

        /// <summary>
        /// Lista de Observadores a los que debe notificar los cambios esta clase.
        /// </summary>
        private readonly List<IObservador> observadores;

        #endregion

        public FrmEditarEmpleado(Empleado empleado)
        {
            InitializeComponent();
            this.empleado = empleado;
            observadores = new List<IObservador>();
            ubicacionService = new UbicacionService();
            service = new EmpleadoService();
            LoadComboBox();
            Init();
        }

        private void Init()
        {
            if (empleado is null) return;

            TxtPrimerNombre.Text = empleado.PrimerNombre;
            TxtSegundoNombre.Text = empleado.SegundoNombre;
            TxtPrimerApellido.Text = empleado.PrimerApellido;
            TxtSegundoApellido.Text = empleado.SegundoApellido;
            TxtCedula.Text = empleado.Cedula;
            PbFotoEmpleado.Image = empleado.Foto is null ? Resources.user : empleado.Foto;
            TxtTelefono.Text = empleado.Telefono;
            TxtDireccion.Text = empleado.Direccion;

            Municipio municipio = ubicacionService.GetMunicipio(empleado.IdMunicipio);

            if (municipio is null) return;

            Departamento departamento = ubicacionService.GetDepartamento(municipio.IdDepartamento);

            if (departamento is null) return;

            Departamento[] departamentos = (Departamento[])CmbDepartamentos.DataSource;
            CmbDepartamentos.SelectedItem = departamentos.FirstOrDefault(value => value.Id == departamento.Id);

            Municipio[] municipios = (Municipio[])CmbMunicipios.DataSource;
            CmbMunicipios.SelectedItem = municipios.FirstOrDefault(value => value.Id == municipio.Id);
        }

        private void LoadComboBox()
        {
            CmbDepartamentos.DataSource = ubicacionService.GetDepartamentos(string.Empty).ToArray();
            CmbDepartamentos.DisplayMember = nameof(INameable.Nombre);

            Departamento departamento = (Departamento)CmbDepartamentos.SelectedItem;

            CmbMunicipios.DataSource = ubicacionService.GetMunicipios(departamento.Id).ToArray();
            CmbMunicipios.DisplayMember = nameof(INameable.Nombre);

            LoadMunicipios();
        }

        private void LoadMunicipios()
        {
            Departamento departamento = (Departamento)CmbDepartamentos.SelectedItem;
            CmbMunicipios.DataSource = ubicacionService.GetMunicipios(departamento.Id).ToArray();
        }

        private void Limpiar()
        {
            TxtPrimerNombre.Text = string.Empty;
            TxtSegundoNombre.Text = string.Empty;
            TxtPrimerApellido.Text = string.Empty;
            TxtSegundoApellido.Text = string.Empty;
            TxtCedula.Text = string.Empty;
            PbFotoEmpleado.Image = Resources.user;
            TxtTelefono.Text = string.Empty;
            TxtDireccion.Text = string.Empty;
        }

        /// <summary>
        /// Abre un cuadro de diálogo que le permite al usuario seleccionar la imagen que ocupará el empleado como su Foto.
        /// </summary>
        /// <returns>Imagen seleccionada por el usuario; en caso de no existir, retorna la imagen por defecto.</returns>
        private Image SelectPhoto()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "JPG (*.jpg)|*.jpg|JPEG (*.jpeg)|*.jpeg|PNG (*.png)|*.png|Bitmap (*.bmp)|*.bmp|GIF (*.gif)|*.gif",
                FilterIndex = 0,
                RestoreDirectory = true
            })
            {
                DialogResult result = openFileDialog.ShowDialog();

                Image image = empleado?.Foto;

                if (result == DialogResult.OK)
                {
                    Stream stream = openFileDialog.OpenFile();
                    image = Image.FromStream(stream);
                }

                return image is null ? Resources.user : image;
            }
        }

        private void CmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMunicipios();
        }

        private void PbFotoEmpleado_Click(object sender, EventArgs e)
        {
            PbFotoEmpleado.Image = SelectPhoto();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Municipio municipio = CmbMunicipios.SelectedItem as Municipio;

            IDictionary<string, object> properties = new Dictionary<string, object>
            {
                {"PrimerNombre", TxtPrimerNombre.Text },
                {"SegundoNombre", TxtSegundoNombre.Text },
                {"PrimerApellido", TxtPrimerApellido.Text },
                {"SegundoApellido", TxtSegundoApellido.Text },
                {"Cedula", TxtCedula.Text },
                {"Foto", PbFotoEmpleado.Image },
                {"Telefono", TxtTelefono.Text },
                {"Direccion", TxtDireccion.Text },
                {"IdMunicipio", municipio.Id }
            };

            try
            {
                if (empleado is null)
                {
                    service.Create(properties);
                }
                else
                {
                    properties.Add("Id", empleado.Id);
                    properties.Add("Estado", empleado.Estado);
                    service.Update(properties);
                }

                if (service.HasError())
                {
                    MessageBox.Show(this, service.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Notificar();
            }
            catch(Exception ex)
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

        public void Notificar() => observadores.ForEach(observador => observador.Actualizar());

        public void AgregarObservador(IObservador observador) => observadores.Add(observador);
    }
}
