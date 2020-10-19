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

namespace TESTWF2020.Reportes.frmReportes
{
    public partial class frmReporteInmueble : Form
    {
        private ReporteService reporteService;
        
        
        public frmReporteInmueble()
        {
            InitializeComponent();
            reporteService = new ReporteService();
           
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inmuebleEstado.RelacionInmuebleEstado' Puede moverla o quitarla según sea necesario.
            this.relacionInmuebleEstadoTableAdapter.Fill(this.inmuebleEstado.RelacionInmuebleEstado);

            this.reportViewer1.RefreshReport();
        }

        private void frmReportes_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inmuebleEstado1.RelacionInmuebleEstado' Puede moverla o quitarla según sea necesario.
            this.relacionInmuebleEstadoTableAdapter1.Fill(this.inmuebleEstado1.RelacionInmuebleEstado);

            this.rptvInmueble.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string inmueble = "";
            var fecha = DateTime.Compare(dtpFechaDesde.Value.Date, dtpFechaHasta.Value.Date);
            if (fecha != 0)
            {
                if (dtpFechaDesde.Value > dtpFechaHasta.Value)
                {
                    MessageBox.Show("Fechas erroneas!!!");
                    return;
                }
            }

            if (!string.IsNullOrEmpty(txtIdInmueble.Text))
            {
                inmueble = txtIdInmueble.Text;
            }

            var diccParametros = CrearDiccionario();
            DataTable tabla = reporteService.GetByFiltersRptInmueble(diccParametros);
            
            
            if (tabla.Rows.Count==0)
            {
                MessageBox.Show("No existe inmueble con esas condiciones");
                dtpFechaDesde.Value = DateTime.Today;
                dtpFechaHasta.Value = DateTime.Today;
                txtIdInmueble.Text = default;
            }
            else
            {
                this.bindingSource2.DataSource = tabla;
                this.rptvInmueble.RefreshReport();
            }
            
        }

        private Dictionary<string, object> CrearDiccionario()
        {
            var dict = new Dictionary<string, object>();

            if (!string.IsNullOrWhiteSpace(this.txtIdInmueble.Text))
            {
                dict.Add("idInmueble", txtIdInmueble.Text);
            }

            if (dtpFechaDesde.Value.Date != dtpFechaHasta.Value.Date)
            {
                dict.Add("fechaDesde", dtpFechaDesde.Value.ToString("yyyyMMdd"));
                dict.Add("fechaHasta", dtpFechaHasta.Value.ToString("yyyyMMdd"));
            }

            return dict;
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            frmEstadisticaInmueble frmEstadisticaInmueble = new frmEstadisticaInmueble();
            frmEstadisticaInmueble.ShowDialog();
        }
    }
}
