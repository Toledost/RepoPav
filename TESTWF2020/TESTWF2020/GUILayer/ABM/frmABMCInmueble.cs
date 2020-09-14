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
    
    public partial class frmABMCInmueble : Form
    {
       
        private bool esNuevo;
        private int idInmueble;
        private InmuebleService inmuebleService;
        private HistorialEstadoService historialService;
        private EstadoService estadoService;

        public frmABMCInmueble()
        {
            InitializeComponent();
            this.inmuebleService = new InmuebleService();
            this.historialService = new HistorialEstadoService();
            this.estadoService = new EstadoService();
        }

        public frmABMCInmueble(bool esNuevo)
        {
            InitializeComponent();
            this.esNuevo = esNuevo;
            this.inmuebleService = new InmuebleService();
            this.historialService = new HistorialEstadoService();
            this.estadoService = new EstadoService();
        }

        public frmABMCInmueble(bool esNuevo, int idInmueble)
        {
            InitializeComponent();
            this.esNuevo = esNuevo;
            this.idInmueble = idInmueble;
            this.inmuebleService = new InmuebleService();
            this.historialService = new HistorialEstadoService();
            this.estadoService = new EstadoService();
        }

        private void frmABMCInmueble_Load(object sender, EventArgs e)
        {
            if (esNuevo)
            {
                this.btnEditar.Enabled = false;
                this.dataGridView1.Visible = false;
                CargarComboEstado();

            }
            else
            {
                this.btnGrabar.Enabled = false;
                Inmueble inmuebleSeleccionado = inmuebleService.GetById(idInmueble);
                CargarTextBox(inmuebleSeleccionado);

                IList<HistorialEstado> listaHistorialInmueble = historialService.GetHistorialEstadoByInmuebleID(inmuebleSeleccionado.Id);

                var estadoActual = listaHistorialInmueble.Where(x => x.FechaFin == DateTime.MinValue).FirstOrDefault();
                //listaHistorialInmueble.Where(x => x.FechaFin == DateTime.MinValue).FirstOrDefault().FechaFin=null;
                estadoActual.FechaFin = null;

                this.cboEstado.Text = estadoActual.Estado.Nombre;
                CargarGrilla(listaHistorialInmueble);
            }
        }

        private void CargarComboEstado()
        {
            this.cboEstado.DataSource = estadoService.GetAll();
            this.cboEstado.SelectedIndex = -1;
            //this.cboEstado.ValueMember = ;

        }

        private void CargarGrilla(IList<HistorialEstado> lista)
        {
            foreach (var historial in lista)
            {
                this.dataGridView1.Rows.Add(historial.Estado.Nombre, historial.FechaInicio, historial.FechaFin);
            }
            this.dataGridView1.Sort(this.dataGridView1.Columns["fechaInicio"],ListSortDirection.Descending);
        }

        private void CargarTextBox(Inmueble inmuebleSeleccionado)
        {
            this.txtID.Text = inmuebleSeleccionado.Id.ToString();
            this.txtTipo.Text = inmuebleSeleccionado.TipoInmueble.ToString();
            this.txtCalle.Text = inmuebleSeleccionado.Calle.ToString();
            this.txtNro.Text = inmuebleSeleccionado.CalleNumero.ToString();
            this.txtMetrosCuadrados.Text = inmuebleSeleccionado.MetrosCuadrados.ToString();
            this.txtBaños.Text = inmuebleSeleccionado.Baños.ToString();
            this.txtHabitaciones.Text = inmuebleSeleccionado.Habitaciones.ToString();
            this.txtMontoAlq.Text = inmuebleSeleccionado.MontoAlquiler.ToString();
            this.txtMontoVta.Text = inmuebleSeleccionado.MontoVenta.ToString();
            this.txtDescripcion.Text = inmuebleSeleccionado.Descripcion.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
