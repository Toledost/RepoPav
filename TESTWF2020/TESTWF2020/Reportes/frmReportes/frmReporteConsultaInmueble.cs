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
        private MedioDeConocimientoService medioDeConocimientoService;


        public frmReporteConsultaInmueble()
        {
            InitializeComponent();
            reporteService = new ReporteService();
            estadoConsultaService = new EstadoConsultaService();
            medioDeConocimientoService = new MedioDeConocimientoService();
        }

        private void frmReporteConsultaInmueble_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1ConsultaInmueble.ConsultaInmueble' Puede moverla o quitarla según sea necesario.
            this.consultaInmuebleTableAdapter.Fill(this.dataSet1ConsultaInmueble.ConsultaInmueble);

            this.rptvConsultaInmueble.RefreshReport();

            CargarCombos();
        }

        private void CargarCombos()
        {
            this.cboEstadoConsulta.DataSource = estadoConsultaService.GetAll();
            this.cboEstadoConsulta.ValueMember = "Id";
            this.cboEstadoConsulta.DisplayMember = "Nombre";
            this.cboEstadoConsulta.SelectedIndex = -1;

            this.cboMedioConocimento.DataSource = medioDeConocimientoService.GetAll();
            this.cboMedioConocimento.ValueMember = "Id";
            this.cboMedioConocimento.DisplayMember = "Nombre";
            this.cboMedioConocimento.SelectedIndex = -1;
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
                
            }
            else
            {
                this.consultaInmuebleBindingSource.DataSource = tabla;
                this.rptvConsultaInmueble.RefreshReport();
            }
        }

        private Dictionary<string, object> CrearDiccionario()
        {            
            var dicc = new Dictionary<string, object>();

            Validador.CargarDiccionarioTextBox(dicc, txtCalle,txtNombreCliente,txtApellidoCliente);
            Validador.CargarDiccionarioComboBox(dicc, cboEstadoConsulta, cboMedioConocimento);

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
            txtCalle.Text = default;
            txtNombreCliente.Text = default;
            txtApellidoCliente.Text = default;
            cboEstadoConsulta.SelectedIndex = -1;
            cboMedioConocimento.SelectedIndex = -1;
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            frmEstadisticaConsultaInmueble frmEstadisticaConsultaInmueble = new frmEstadisticaConsultaInmueble();
            frmEstadisticaConsultaInmueble.ShowDialog();
            this.Show();

        }
    }
}
