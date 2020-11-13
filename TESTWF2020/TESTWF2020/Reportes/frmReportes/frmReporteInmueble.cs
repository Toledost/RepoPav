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
    public partial class frmReporteInmueble : Form
    {
        private ReporteService reporteService;
        private InmuebleService inmuebleService;

        public frmReporteInmueble()
        {
            InitializeComponent();
            reporteService = new ReporteService();
            inmuebleService = new InmuebleService();
            dtpFechaDesde.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today;
        }

        private void frmReportes_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inmuebleEstado1.RelacionInmuebleEstado' Puede moverla o quitarla según sea necesario.
            //this.relacionInmuebleEstadoTableAdapter1.Fill(this.inmuebleEstado1.RelacionInmuebleEstado);

            //this.rptvInmueble.RefreshReport();
            CargarCombos();
        }

        private void CargarCombos()
        {
            this.cboInmueble.DataSource = inmuebleService.GetByFilters(new Dictionary<string, object>());
            this.cboInmueble.ValueMember = "Id";
            this.cboInmueble.DisplayMember = "DireccionCompleta";
            this.cboInmueble.SelectedIndex = -1;
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
            DataTable tabla = reporteService.GetByFiltersRptInmueble(diccParametros);
            
            
            if (tabla.Rows.Count==0)
            {
                MessageBox.Show("No existen resultados con esas condiciones", "Buscar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.btnLimpiarFiltros_Click(sender, e);

                this.rptvInmueble.Clear();
            }
            else
            {
                this.bindingSource2.DataSource = tabla;
                this.rptvInmueble.RefreshReport();
                this.btnGrafico.Enabled = true;
            }
            
        }

        private Dictionary<string, object> CrearDiccionario()
        {
            var dict = new Dictionary<string, object>();

            dict = Validador.CargarDiccionarioComboBox(dict, cboInmueble);

            if (dtpFechaDesde.Value.Date != dtpFechaHasta.Value.Date)
            {
                dict.Add("fechaDesde", dtpFechaDesde.Value.ToString("yyyyMMdd"));
                dict.Add("fechaHasta", dtpFechaHasta.Value.ToString("yyyyMMdd"));
            }

            return dict;
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            var dict = CrearDiccionario();
            frmEstadisticaInmueble frmEstadisticaInmueble = new frmEstadisticaInmueble(dict);
            frmEstadisticaInmueble.ShowDialog();
        }

        private void cboInmueble_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today;
            cboInmueble.SelectedIndex = -1;
        }
    }
}
