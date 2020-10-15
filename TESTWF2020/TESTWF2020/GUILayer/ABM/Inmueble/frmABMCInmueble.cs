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

        private bool seleccionoNuevo;
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

        public frmABMCInmueble(bool seleccionoNuevo)
        {
            InitializeComponent();
            this.seleccionoNuevo = seleccionoNuevo;
            this.inmuebleService = new InmuebleService();
            this.historialService = new HistorialEstadoService();
            this.estadoInmuebleService = new EstadoInmuebleService();
            this.tipoInmuebleService = new TipoInmuebleService();
        }

        public frmABMCInmueble(bool seleccionoNuevo, int idInmueble)
        {
            InitializeComponent();
            this.seleccionoNuevo = seleccionoNuevo;
            this.idInmueble = idInmueble;
            this.inmuebleService = new InmuebleService();
            this.historialService = new HistorialEstadoService();
            this.estadoInmuebleService = new EstadoInmuebleService();
            this.tipoInmuebleService = new TipoInmuebleService();
        }
        #endregion

        private void frmABMCInmueble_Load(object sender, EventArgs e)
        {
            CargarComboEstado();
            CargarComboTipoInmueble();

            if (seleccionoNuevo)
            {
                this.btnEditar.Enabled = false;
                this.dataGridView1.Visible = false;
                this.lblId.Visible = false;
                this.txtID.Visible = false;
            }
            else
            {
                this.btnGrabar.Enabled = false;
                Inmueble inmuebleSeleccionado = inmuebleService.GetById(idInmueble);
                CargarTextBox(inmuebleSeleccionado);

                IList<HistorialEstado> listaHistorialInmueble = historialService.GetHistorialEstadoByInmuebleID(inmuebleSeleccionado.Id);

                var estadoActual = listaHistorialInmueble.Where(x => x.FechaFin == null).FirstOrDefault();
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

            Inmueble inmueble = CapturarDatosInmueble();
            EstadoInmueble estado = CapturarDatosEstado();

            if (seleccionoNuevo)
            {
                inmuebleService.Create(inmueble, estado);
                MessageBox.Show("Creado");
            }
            else
            {
                // Añadimos el Id del form al inmueble
                inmueble.Id = Convert.ToInt32(this.txtID.Text);

                // Buscamos todo su historial de estado
                IList<HistorialEstado> listaHistorialInmueble = historialService.GetHistorialEstadoByInmuebleID(inmueble.Id);

                // Obtenemos el último estado (sin fechaFin)
                var estadoActual = listaHistorialInmueble.Where(x => x.FechaFin == null).FirstOrDefault();

                // Verificamos si seleccionó un nuevo estado
                var esEstadoNuevo = estadoActual.Estado.Id != estado.Id;

                // Hacemos el update del inmueble y si corresponde el del Historial de Estado
                inmuebleService.Update(inmueble, esEstadoNuevo, estado);

                MessageBox.Show("Editado");
            }
            this.Close();
        }

        private EstadoInmueble CapturarDatosEstado()
        {
            return new EstadoInmueble
            {
                Id = Convert.ToInt32(this.cboEstado.SelectedValue)
            };
        }

        private Inmueble CapturarDatosInmueble()
        {
            return new Inmueble
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
