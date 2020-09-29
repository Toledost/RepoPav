using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TESTWF2020.BusinessLayer;
using TESTWF2020.Entities;

namespace TESTWF2020.GUILayer.ABM
{
    public partial class frmDetalleConsulta : Form
    {
        private int idConsultaSeleccionada;
        private Usuario usuarioLogueado;
        private ConsultaService consultaService;
        private EstadoConsultaService estadoConsultaService;
        private ViaDeConsultaService viaDeConsultaService;
        private MedioDeConocimientoService medioDeConocimientoService;
        private TipoTransaccionService tipoTransaccionService;

        public frmDetalleConsulta()
        {
            InitializeComponent();
            this.consultaService = new ConsultaService();
            this.estadoConsultaService = new EstadoConsultaService();
            this.viaDeConsultaService = new ViaDeConsultaService();
            this.medioDeConocimientoService = new MedioDeConocimientoService();
            this.tipoTransaccionService = new TipoTransaccionService();
        }

        public frmDetalleConsulta(Usuario usuarioLogueado)
        {
            InitializeComponent();
            this.usuarioLogueado = usuarioLogueado;
            this.consultaService = new ConsultaService();
            this.estadoConsultaService = new EstadoConsultaService();
            this.viaDeConsultaService = new ViaDeConsultaService();
            this.medioDeConocimientoService = new MedioDeConocimientoService();
            this.tipoTransaccionService = new TipoTransaccionService();
        }

        public frmDetalleConsulta(int idConsultaSeleccionada, Usuario usuarioLogueado)
        {
            InitializeComponent();
            this.idConsultaSeleccionada = idConsultaSeleccionada;
            this.usuarioLogueado = usuarioLogueado;
            this.consultaService = new ConsultaService();
            this.estadoConsultaService = new EstadoConsultaService();
            this.viaDeConsultaService = new ViaDeConsultaService();
            this.medioDeConocimientoService = new MedioDeConocimientoService();
            this.tipoTransaccionService = new TipoTransaccionService();
        }


        private void btnElegir_Click(object sender, EventArgs e)
        {
            frmInmuebles frmInmuebles = new frmInmuebles(true);
            //this.Hide();
            frmInmuebles.ShowDialog();
            this.txtIDInmueble.Text = frmInmuebles.InmuebleSeleccionado.Id.ToString();
            // TODO: falta hacer busqueda del objeto para que devuelva el nombre del inmueble 
        }

        private void btnElegirCliente_Click(object sender, EventArgs e)
        {
            frmConsultarClientes frmConsultarClientes = new frmConsultarClientes(true);
            //this.Hide();
            frmConsultarClientes.ShowDialog();
            this.txtDNICliente.Text = frmConsultarClientes.dniClienteSeleccionado.ToString();
        }
        private void frmDetalleConsulta_Load(object sender, EventArgs e)
        {
            CargarCombos();

            if (idConsultaSeleccionada > 0)
            {
                CargarDatos();
                ConfigurarControles(false);
            }
            else
            {
                ConfigurarControles(true);
            }
            
        }

        private void CargarCombos()
        {
            this.cboEstadoConsulta.DataSource = estadoConsultaService.GetAll();
            this.cboEstadoConsulta.ValueMember = "Id";
            this.cboEstadoConsulta.DisplayMember = "Nombre";
            this.cboEstadoConsulta.SelectedIndex = -1;

            this.cboViaConsulta.DataSource = viaDeConsultaService.GetAll();
            this.cboViaConsulta.ValueMember = "Id";
            this.cboViaConsulta.DisplayMember = "Nombre";
            this.cboViaConsulta.SelectedIndex = -1;

            this.cboIDMedioConocimiento.DataSource = medioDeConocimientoService.GetAll();
            this.cboIDMedioConocimiento.ValueMember = "Id";
            this.cboIDMedioConocimiento.DisplayMember = "Nombre";
            this.cboIDMedioConocimiento.SelectedIndex = -1;

            this.cboIDTipoTrans.DataSource = tipoTransaccionService.GetAll();
            this.cboIDTipoTrans.ValueMember = "Id";
            this.cboIDTipoTrans.DisplayMember = "Nombre";
            this.cboIDTipoTrans.SelectedIndex = -1;
        }

        private void CargarDatos()
        {
            Consulta consulta = consultaService.GetById(idConsultaSeleccionada);
            if (consulta != null)
            {
                this.txtIDConsulta.Text = consulta.Id.ToString();
                this.txtIDInmueble.Text = consulta.Inmueble.Id.ToString();
                this.txtDNICliente.Text = consulta.Cliente.Dni.ToString();
                this.cboEstadoConsulta.SelectedValue = consulta.EstadoConsulta.Id;
                this.cboIDMedioConocimiento.SelectedValue = consulta.MedioConocimiento.Id;
                this.cboIDTipoTrans.SelectedValue = consulta.TipoTransaccion.Id;
                this.cboViaConsulta.SelectedValue = consulta.ViaDeConsulta.Id;
            }
            
        }

        private void ConfigurarControles(bool habilitados)
        {
            this.cboEstadoConsulta.Enabled = habilitados;
            this.cboIDMedioConocimiento.Enabled = habilitados;
            this.cboIDTipoTrans.Enabled = habilitados;
            this.cboViaConsulta.Enabled = habilitados;
            this.btnEditar.Enabled = !habilitados;
            this.btnGrabar.Enabled = habilitados;
            this.btnElegir.Enabled = habilitados;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ConfigurarControles(true);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Validar();

            Consulta consulta = new Consulta
            {
                Inmueble = new Inmueble
                {
                    Id = Convert.ToInt32(txtIDInmueble.Text)
                },
                Cliente = new Cliente
                {
                    Dni = Convert.ToInt32(txtDNICliente.Text)
                },
                EstadoConsulta = new EstadoConsulta
                {
                    Id = Convert.ToInt32(cboEstadoConsulta.SelectedValue)
                },
                MedioConocimiento = new MedioDeConocimiento
                {
                    Id = Convert.ToInt32(cboIDMedioConocimiento.SelectedValue)
                },
                TipoTransaccion = new TipoTransaccion
                {
                    Id = Convert.ToInt32(cboIDTipoTrans.SelectedValue)
                },
                UsuarioUltimaModificacion = usuarioLogueado,
                ViaDeConsulta = new ViaDeConsulta
                {
                    Id = Convert.ToInt32(cboViaConsulta.SelectedValue)
                }
            };

            consulta.FechaCierre = cboEstadoConsulta.Text != "Abierta" ? DateTime.Now : (DateTime?)null;


            if (idConsultaSeleccionada > 0)
            {
                consulta.Id = Convert.ToInt32(txtIDConsulta.Text);
                consultaService.Update(consulta);
                this.Close();
            }
            else
            {
                consultaService.Create(consulta);
                this.Close();
            }
        }

        private void Validar()
        {
            if (string.IsNullOrEmpty(txtIDInmueble.Text) || txtIDInmueble.Text == "0")
            {
                MessageBox.Show("Falta elegir un inmueble");
                return;
            }
            if (string.IsNullOrEmpty(txtDNICliente.Text) || txtDNICliente.Text == "0")
            {
                MessageBox.Show("Falta elegir un cliente");
                return;
            }
            if (Controls.OfType<ComboBox>().Any(x => x.SelectedIndex == -1))
            {
                //MessageBox.Show("combobox");
                MessageBox.Show("Falta completar algun campo");
                return;
            }
        }
    }
}
