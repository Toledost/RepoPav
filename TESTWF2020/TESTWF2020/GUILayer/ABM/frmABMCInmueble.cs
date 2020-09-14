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

        public frmABMCInmueble()
        {
            InitializeComponent();
            this.inmuebleService = new InmuebleService();
            this.historialService = new HistorialEstadoService();
        }

        public frmABMCInmueble(bool esNuevo)
        {
            InitializeComponent();
            this.esNuevo = esNuevo;
            this.inmuebleService = new InmuebleService();
            this.historialService = new HistorialEstadoService();
        }

        public frmABMCInmueble(bool esNuevo, int idInmueble)
        {
            InitializeComponent();
            this.esNuevo = esNuevo;
            this.idInmueble = idInmueble;
            this.inmuebleService = new InmuebleService();
            this.historialService = new HistorialEstadoService();
        }

        private void frmABMCInmueble_Load(object sender, EventArgs e)
        {
            if (esNuevo)
            {
                this.btnEditar.Enabled = false;
                this.dataGridView1.Visible = false;
            }
            else
            {
                Inmueble inmuebleSeleccionado = inmuebleService.GetById(idInmueble);
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
                
                IList<HistorialEstado> listaHistorialInmueble = historialService.GetHistorialEstadoByInmuebleID(idInmueble);

                var estadoActual = listaHistorialInmueble.Where(x => x.FechaFin == DateTime.MinValue).FirstOrDefault();

                this.cboEstado.Text = estadoActual.Estado.Nombre;

            }

        }
    }
}
