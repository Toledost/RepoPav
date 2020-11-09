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
    public partial class frmReporteConsultaMedioConocimiento : Form
    {
        private ReporteService reporteService;
        private MedioDeConocimientoService medioDeConocimientoService;
        public frmReporteConsultaMedioConocimiento()
        {
            InitializeComponent();
            this.reporteService = new ReporteService();
            medioDeConocimientoService = new MedioDeConocimientoService();
        }

        private void frmReporteConsultaMedioConocimiento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1ConsultaInmueble.ConsultaMedioConocimiento' Puede moverla o quitarla según sea necesario.
            //this.consultaMedioConocimientoTableAdapter.Fill(this.dataSet1ConsultaInmueble.ConsultaMedioConocimiento);

            //this.rptvMedioConocimiento.RefreshReport();
            CargarCombos();
        }

        private void CargarCombos()
        {
            this.cboMedioDeConocimiento.DataSource = medioDeConocimientoService.GetAll();
            this.cboMedioDeConocimiento.ValueMember = "Id";
            this.cboMedioDeConocimiento.DisplayMember = "Nombre";
            this.cboMedioDeConocimiento.SelectedIndex = -1;
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
            DataTable tabla = reporteService.GetByFiltersRptConsultaMedioConocimiento(diccParametros);


            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No existen resultados con esas condiciones", "Buscar Reporte", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaDesde.Value = DateTime.Today;
                dtpFechaHasta.Value = DateTime.Today;
                cboMedioDeConocimiento.SelectedIndex = -1;
            }
            else
            {
                this.consultaMedioConocimientoBindingSource.DataSource = tabla;
                this.rptvMedioConocimiento.RefreshReport();
                this.btnGrafico.Enabled = true;
            }

        }

        private Dictionary<string, object> CrearDiccionario()
        {
            var dict = new Dictionary<string, object>();

            dict = Validador.CargarDiccionarioComboBox(dict, cboMedioDeConocimiento);

            if (dtpFechaDesde.Value.Date != dtpFechaHasta.Value.Date)
            {
                dict.Add("fechaDesde", dtpFechaDesde.Value.ToString("yyyyMMdd"));
                dict.Add("fechaHasta", dtpFechaHasta.Value.ToString("yyyyMMdd"));
            }

            return dict;
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            var diccionario = CrearDiccionario();
            frmEstadisticaMedioConocimiento frmEstadisticaMedioConocimiento = new frmEstadisticaMedioConocimiento(diccionario);
            frmEstadisticaMedioConocimiento.ShowDialog();
        }

        private void cboMedioDeConocimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnGrafico.Enabled = false;
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today;
            cboMedioDeConocimiento.SelectedIndex = -1;
        }

        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            this.btnGrafico.Enabled = false;
        }

        private void dtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            this.btnGrafico.Enabled = false;
        }
    }
}
