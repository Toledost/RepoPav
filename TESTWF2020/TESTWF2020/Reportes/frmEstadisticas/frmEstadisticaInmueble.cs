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

namespace TESTWF2020.Reportes.frmEstadisticas
{
    public partial class frmEstadisticaInmueble : Form
    {
        private ReporteService reporteService;
        private Dictionary<string, object> dict;

        public frmEstadisticaInmueble()
        {
            InitializeComponent();
            reporteService = new ReporteService();
        }

        public frmEstadisticaInmueble(Dictionary<string, object> dict)
        {
            InitializeComponent();
            reporteService = new ReporteService();
            this.dict = dict;
        }

        private void frmEstadisticaInmueble_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = reporteService.GetDiasPorEstado(dict);

            ReportDataSource ds = new ReportDataSource("DataSetInmueble", tabla);

            reportViewer1 .LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }
    }
}
