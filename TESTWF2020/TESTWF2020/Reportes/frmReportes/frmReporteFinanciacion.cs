using Microsoft.Reporting.WinForms;
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
    public partial class frmReporteFinanciacion : Form
    {
        private ReporteService reporteService;
        private FinanciacionService financiacionService;

        public frmReporteFinanciacion()
        {
            InitializeComponent();
            reporteService = new ReporteService();
            financiacionService = new FinanciacionService();
            dtpFechaDesde.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today;
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
            DataTable tabla = reporteService.GetByFiltersRptFinanciacion(diccParametros);


            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No existen resultados con esas condiciones", "Buscar Reporte", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.btnLimpiarFiltros_Click(sender, e);
                this.rptvFinanciacion.Clear();
            }
            else
            {
                this.dataTableFinanciacionBindingSource.DataSource = tabla;
                this.rptvFinanciacion.RefreshReport();
                btnGrafico.Enabled = true;

            }
        }

        private Dictionary<string, object> CrearDiccionario()
        {
            var dict = new Dictionary<string, object>();

            dict = Validador.CargarDiccionarioComboBox(dict, cboNombreFinanciacion);

            if (dtpFechaDesde.Value.Date != dtpFechaHasta.Value.Date)
            {
                dict.Add("fechaVentaDesde", dtpFechaDesde.Value.ToString("yyyyMMdd"));
                dict.Add("fechaVentaHasta", dtpFechaHasta.Value.ToString("yyyyMMdd"));
            }

            return dict;
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            var dict = CrearDiccionario();
            frmEstadisticaFinanciacion frmEstadisticaFinanciacion = new frmEstadisticaFinanciacion(dict);
            frmEstadisticaFinanciacion.ShowDialog();
        }

        private void frmReporteFinanciacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDInmobiliariaCasaFelizDataSetFinanciacion.DataTableFinanciacion' Puede moverla o quitarla según sea necesario.
            //this.dataTableFinanciacionTableAdapter.Fill(this.bDInmobiliariaCasaFelizDataSetFinanciacion.DataTableFinanciacion);

            //this.rptvFinanciacion.RefreshReport();
            CargarCombos();
        }

        private void CargarCombos()
        {
            this.cboNombreFinanciacion.DataSource = financiacionService.GetByFilters(new Dictionary<string, object>());
            this.cboNombreFinanciacion.ValueMember = "IdFinanciacion";
            this.cboNombreFinanciacion.DisplayMember = "Nombre";
            this.cboNombreFinanciacion.SelectedIndex = -1;
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today;
            cboNombreFinanciacion.SelectedIndex = -1;
        }

        private void dtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            btnGrafico.Enabled = false;
        }

        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            btnGrafico.Enabled = false;
        }

        private void cboNombreFinanciacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGrafico.Enabled = false;
        }
    }
}
