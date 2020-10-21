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
    public partial class frmReporteConsultaMedioConocimiento : Form
    {
        private ReporteService reporteService;
        public frmReporteConsultaMedioConocimiento()
        {
            InitializeComponent();
            this.reporteService = new ReporteService();
        }

        private void frmReporteConsultaMedioConocimiento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1ConsultaInmueble.ConsultaMedioConocimiento' Puede moverla o quitarla según sea necesario.
            this.consultaMedioConocimientoTableAdapter.Fill(this.dataSet1ConsultaInmueble.ConsultaMedioConocimiento);

            this.rptvMedioConocimiento.RefreshReport();
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
                MessageBox.Show("No existe medio de conocimiento con esas condiciones");
                dtpFechaDesde.Value = DateTime.Today;
                dtpFechaHasta.Value = DateTime.Today;
                txtMedioConocimiento.Text = default;
            }
            else
            {
                this.consultaMedioConocimientoBindingSource.DataSource = tabla;
                this.rptvMedioConocimiento.RefreshReport();
            }

        }

        private Dictionary<string, object> CrearDiccionario()
        {
            var dict = new Dictionary<string, object>();

            if (!string.IsNullOrWhiteSpace(this.txtMedioConocimiento.Text))
            {
                dict.Add("nombreMedioConocimiento", txtMedioConocimiento.Text);
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
            frmEstadisticaMedioConocimiento frmEstadisticaMedioConocimiento = new frmEstadisticaMedioConocimiento();
            frmEstadisticaMedioConocimiento.ShowDialog();
        }
    }
}
