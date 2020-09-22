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
        #region private y constructor

        private bool esNuevo;
        private int idInmueble;
        private InmuebleService inmuebleService;
        private HistorialEstadoService historialService;
        private EstadoInmuebleService estadoInmuebleService;
        private TipoInmuebleService tipoInmuebleService;

        public frmABMCInmueble()
        {
            InitializeComponent();
            this.inmuebleService = new InmuebleService();
            this.historialService = new HistorialEstadoService();
            this.estadoInmuebleService = new EstadoInmuebleService();
            this.tipoInmuebleService = new TipoInmuebleService();
        }

        public frmABMCInmueble(bool esNuevo)
        {
            InitializeComponent();
            this.esNuevo = esNuevo;
            this.inmuebleService = new InmuebleService();
            this.historialService = new HistorialEstadoService();
            this.estadoInmuebleService = new EstadoInmuebleService();
            this.tipoInmuebleService = new TipoInmuebleService();
        }

        public frmABMCInmueble(bool esNuevo, int idInmueble)
        {
            InitializeComponent();
            this.esNuevo = esNuevo;
            this.idInmueble = idInmueble;
            this.inmuebleService = new InmuebleService();
            this.historialService = new HistorialEstadoService();
            this.estadoInmuebleService = new EstadoInmuebleService();
            this.tipoInmuebleService = new TipoInmuebleService();
        }
        #endregion

        private void frmABMCInmueble_Load(object sender, EventArgs e)
        {
            if (esNuevo)
            {
                this.btnEditar.Enabled = false;
                this.dataGridView1.Visible = false;
                this.lblId.Visible = false;
                this.txtID.Visible = false;
                CargarComboEstado();
                CargarComboTipoInmueble();
            }
            else
            {
                CargarComboEstado();
                CargarComboTipoInmueble();

                this.btnGrabar.Enabled = false;
                Inmueble inmuebleSeleccionado = inmuebleService.GetById(idInmueble);
                CargarTextBox(inmuebleSeleccionado);

                IList<HistorialEstado> listaHistorialInmueble = historialService.GetHistorialEstadoByInmuebleID(inmuebleSeleccionado.Id);

                var estadoActual = listaHistorialInmueble.Where(x => x.FechaFin == DateTime.MinValue).FirstOrDefault();

                estadoActual.FechaFin = null;

                this.cboEstado.SelectedValue = estadoActual.Estado.Id;
                this.cboTipoInmueble.SelectedValue = inmuebleSeleccionado.TipoInmueble.Id;
                CargarGrilla(listaHistorialInmueble);

                DeshabilitarCampos();
            }
        }

        private void DeshabilitarCampos()
        {
            foreach (var textBox in Controls.OfType<TextBox>())
            {
                textBox.ReadOnly = true;
            }
            foreach (var comboBox in Controls.OfType<ComboBox>())
            {
                comboBox.Enabled = false;
            }
        }

        private void HabilitarCampos()
        {
            foreach (var textBox in Controls.OfType<TextBox>())
            {
                if (textBox.Name == "txtID")
                {
                    continue;
                }
                textBox.ReadOnly = false;
            }
            foreach (var comboBox in Controls.OfType<ComboBox>())
            {
                comboBox.Enabled = true;
            }
        }

        private void CargarComboTipoInmueble()
        {
            this.cboTipoInmueble.DataSource = tipoInmuebleService.GetAll();
            this.cboTipoInmueble.ValueMember = "Id";
            this.cboTipoInmueble.DisplayMember = "Nombre";
            this.cboTipoInmueble.SelectedIndex = -1;
        }

        private void CargarComboEstado()
        {
            this.cboEstado.DataSource = estadoInmuebleService.GetAll();
            this.cboEstado.ValueMember = "Id";
            this.cboEstado.DisplayMember = "Nombre";
            this.cboEstado.SelectedIndex = -1;

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
            this.txtCalle.Text = inmuebleSeleccionado.Calle.ToString();
            this.txtNro.Text = inmuebleSeleccionado.CalleNumero.ToString();
            this.txtMetrosCuadrados.Text = inmuebleSeleccionado.MetrosCuadrados.ToString();
            this.txtBaños.Text = inmuebleSeleccionado.Baños.ToString();
            this.txtHabitaciones.Text = inmuebleSeleccionado.Habitaciones.ToString();
            this.txtMontoAlq.Text = inmuebleSeleccionado.MontoAlquiler.ToString();
            this.txtMontoVta.Text = inmuebleSeleccionado.MontoVenta.ToString();
            this.txtDescripcion.Text = inmuebleSeleccionado.Descripcion.ToString();
            
            
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (Controls.OfType<TextBox>().Any(x => x.Visible && string.IsNullOrWhiteSpace(x.Text))
                || Controls.OfType<ComboBox>().Any(x => x.SelectedIndex < 0))
            {
                MessageBox.Show("Falta completar algún campo");
                return;
            }

            Inmueble inmueble = new Inmueble
            {
                Calle = this.txtCalle.Text,
                CalleNumero = Convert.ToInt32(this.txtNro.Text),
                Baños = Convert.ToInt32(this.txtBaños.Text),
                Habitaciones = Convert.ToInt32(this.txtHabitaciones.Text),
                Descripcion = this.txtDescripcion.Text,
                MetrosCuadrados = Convert.ToDouble(this.txtMetrosCuadrados.Text),
                MontoAlquiler = Convert.ToInt32(this.txtMontoAlq.Text),
                MontoVenta = Convert.ToInt32(this.txtMontoVta.Text),
                TipoInmueble = new TipoInmueble
                {
                    Id = Convert.ToInt32(this.cboTipoInmueble.SelectedValue)
                }
            };

            if (esNuevo)
            {
                inmuebleService.Create(inmueble);
                var Ids = inmuebleService.GetByFilters(new Dictionary<string, object>()).Select(x => x.Id);
                inmueble.Id = Ids.Max();
                HistorialEstado historialEstado = new HistorialEstado
                {
                    FechaInicio = DateTime.Now,
                    Inmueble = inmueble,
                    Estado = new EstadoInmueble
                    {
                        Id = Convert.ToInt32(this.cboEstado.SelectedValue)
                    }
                };
                historialService.Create(historialEstado);
                MessageBox.Show("Creado");
            }
            else
            {
                inmueble.Id = Convert.ToInt32(this.txtID.Text);
                IList<HistorialEstado> listaHistorialInmueble = historialService.GetHistorialEstadoByInmuebleID(inmueble.Id);

                var estadoActual = listaHistorialInmueble.Where(x => x.FechaFin == DateTime.MinValue).FirstOrDefault();

                if (estadoActual.Estado.Id != Convert.ToInt32(this.cboEstado.SelectedValue))
                {
                    inmuebleService.Update(inmueble, true);
                    HistorialEstado historialEstado = new HistorialEstado
                    {
                        FechaInicio = DateTime.Now,
                        Inmueble = inmueble,
                        Estado = new EstadoInmueble
                        {
                            Id = Convert.ToInt32(this.cboEstado.SelectedValue)
                        }
                    };
                    historialService.Create(historialEstado);
                }
                inmuebleService.Update(inmueble, false);

                MessageBox.Show("Editado");
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.btnGrabar.Enabled = true;
            HabilitarCampos();
        }
    }
}
