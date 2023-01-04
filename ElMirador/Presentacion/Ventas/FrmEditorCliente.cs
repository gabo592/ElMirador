using ElMirador.Interfaces;
using ElMirador.Servicios.Ubicacion;
using ElMirador.Servicios.Ventas;
using Models.Interfaces;
using Models.Ubicacion;
using Models.Ventas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ElMirador.Presentacion.Ventas
{
    public partial class FrmEditorCliente : Form, ISujeto
    {
        #region Private Fields

        /// <summary>
        /// Cliente a editar.
        /// </summary>
        private readonly Cliente cliente;

        /// <summary>
        /// Lista de observadores que están pendientes de los cambios de esta clase.
        /// </summary>
        private readonly List<IObservador> observadores;

        /// <summary>
        /// Servicio de ubicaciones.
        /// </summary>
        private readonly UbicacionService ubicacionService;

        /// <summary>
        /// Proveedor de servicios para los clientes.
        /// </summary>
        private readonly ClienteService service;

        #endregion

        public FrmEditorCliente(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            observadores = new List<IObservador>();
            ubicacionService = new UbicacionService();
            service = new ClienteService();
            LoadLocation();
            Init();
        }

        private void Init()
        {
            if (cliente is null) return;

            TxtPrimerNombre.Text = cliente.PrimerNombre;
            TxtSegundoNombre.Text = cliente.SegundoNombre;
            TxtPrimerApellido.Text = cliente.PrimerApellido;
            TxtSegundoApellido.Text = cliente.SegundoApellido;
            TxtTelefono.Text = cliente.Telefono;
            TxtDireccion.Text = cliente.Direccion;

            Municipio municipio = ubicacionService.GetMunicipio(cliente.IdMunicipio);
            Departamento departamento = ubicacionService.GetDepartamento(municipio.IdDepartamento);

            Departamento[] departamentos = (Departamento[])CmbDepartamentos.DataSource;
            CmbDepartamentos.SelectedItem = departamentos.FirstOrDefault(x => x.Id == departamento.Id);
            Municipio[] municipios = (Municipio[])CmbMunicipios.DataSource;
            CmbMunicipios.SelectedItem = municipios.FirstOrDefault(x => x.Id == municipio.Id);
        }

        private void LoadLocation()
        {
            CmbDepartamentos.DataSource = ubicacionService.GetDepartamentos(string.Empty).ToArray();
            CmbDepartamentos.DisplayMember = nameof(INameable.Nombre);

            Departamento departamento = (Departamento)CmbDepartamentos.SelectedItem;

            CmbMunicipios.DataSource = ubicacionService.GetMunicipios(departamento.Id).ToArray();
            CmbMunicipios.DisplayMember = nameof(INameable.Nombre);
        }

        private void Limpiar()
        {
            TxtPrimerNombre.Text = string.Empty;
            TxtSegundoNombre.Text = string.Empty;
            TxtPrimerApellido.Text = string.Empty;
            TxtSegundoApellido.Text = string.Empty;
            TxtTelefono.Text = string.Empty;
            TxtDireccion.Text = string.Empty;

            LoadLocation();
        }

        private void CmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Departamento departamento = (Departamento)CmbDepartamentos.SelectedItem;

            CmbMunicipios.DataSource = ubicacionService.GetMunicipios(departamento.Id).ToArray();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Municipio municipio = (Municipio)CmbMunicipios.SelectedItem;

            IDictionary<string, object> properties = new Dictionary<string, object>
            {
                {"PrimerNombre", TxtPrimerNombre.Text },
                {"SegundoNombre", TxtSegundoNombre.Text },
                {"PrimerApellido", TxtPrimerApellido.Text },
                {"SegundoApellido", TxtSegundoApellido.Text },
                {"Telefono", TxtTelefono.Text },
                {"Direccion", TxtDireccion.Text },
                {"IdMunicipio", municipio.Id }
            };

            try
            {
                if (cliente is null)
                {
                    service.Create(properties);
                }
                else
                {
                    properties.Add("Id", cliente.Id);
                    properties.Add("Estado", cliente.Estado);
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
