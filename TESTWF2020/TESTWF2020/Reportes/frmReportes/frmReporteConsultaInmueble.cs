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
using TESTWF2020.Reportes.frmEstadisticas;
using TESTWF2020.Utilities;

namespace TESTWF2020.Reportes.frmReportes
{
    public partial class frmReporteConsultaInmueble : Form
    {
        private ReporteService reporteService;
        private EstadoConsultaService estadoConsultaService;
        private InmuebleService inmuebleService;
        private ClienteService clienteService;

        public frmReporteConsultaInmueble()
        {
            InitializeComponent();
            reporteService = new ReporteService();
            estadoConsultaService = new EstadoConsultaService();
            inmuebleService = new InmuebleService();
            clienteService = new ClienteService();
        }

        private void frmReporteConsultaInmueble_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1ConsultaInmueble.ConsultaInmueble' Puede moverla o quitarla según sea necesario.
            //this.consultaInmuebleTableAdapter.Fill(this.dataSet1ConsultaInmueble.ConsultaInmueble);

            //this.rptvConsultaInmueble.RefreshReport();

            CargarCombos();
        }

        private void CargarCombos()
        {
            this.cboEstadoConsulta.DataSource = estadoConsultaService.GetAll();
            this.cboEstadoConsulta.ValueMember = "Id";
            this.cboEstadoConsulta.DisplayMember = "Nombre";
            this.cboEstadoConsulta.SelectedIndex = -1;

            this.cboInmueble.DataSource = inmuebleService.GetByFilters(new Dictionary<string, object>());
            this.cboInmueble.ValueMember = "Id";
            this.cboInmueble.DisplayMember = "DireccionCompleta";
            this.cboInmueble.SelectedIndex = -1;

            this.cboCliente.DataSource = clienteService.GetAll();
            this.cboCliente.ValueMember = "Dni";
            this.cboCliente.DisplayMember = "NombreCompleto";
            this.cboCliente.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {           
            var fecha = DateTime.Compare(dtpFechaDesde.Value.Date, dtpFechaHasta.Value.Date);
            if (fecha != 0)
            {
                if (dtpFechaDesde.Value > dtpFechaHasta.Value)
                {
                    MessageBox.Show("Fechas erroneas!!!");
                    return;
                }
            }

            var diccParametros = CrearDiccionario();
            DataTable tabla = reporteService.GetByFiltersRptConsultaInmueble(diccParametros);


            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No existen resultados con esas condiciones", "Buscar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.btnLimpiarFiltros_Click(sender,e);

                this.rptvConsultaInmueble.Clear();
            }
            else
            {
                this.consultaInmuebleBindingSource.DataSource = tabla;
                this.rptvConsultaInmueble.RefreshReport();
                this.btnGrafico.Enabled = true;
            }
        }

        private Dictionary<string, object> CrearDiccionario()
        {            
            var dicc = new Dictionary<string, object>();

            Validador.CargarDiccionarioComboBox(dicc, cboEstadoConsulta, cboInmueble, cboCliente);

            if (dtpFechaDesde.Value.Date != dtpFechaHasta.Value.Date)
            {
                dicc.Add("fechaConsultaDesde", dtpFechaDesde.Value.ToString("yyyyMMdd"));
                dicc.Add("fechaConsultaHasta", dtpFechaHasta.Value.ToString("yyyyMMdd"));
            }

            return dicc;
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today;
            cboEstadoConsulta.SelectedIndex = -1;
            cboCliente.SelectedIndex = -1;
            cboInmueble.SelectedIndex = -1;
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            var diccParametros = CrearDiccionario();
            frmEstadisticaConsultaInmueble frmEstadisticaConsultaInmueble = new frmEstadisticaConsultaInmueble(diccParametros);
            frmEstadisticaConsultaInmueble.ShowDialog();
            this.Show();
        }

        private void cboInmueble_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnGrafico.Enabled = false;
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnGrafico.Enabled = false;
        }

        private void cboEstadoConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnGrafico.Enabled = false;
        }

        private void dtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            this.btnGrafico.Enabled = false;
        }

        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            this.btnGrafico.Enabled = false;
        }
    }
}
