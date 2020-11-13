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
    public partial class frmEstadisticaVenta : Form
    {
        private ReporteService reporteService;
        private Dictionary<string, object> dict;

        public frmEstadisticaVenta()
        {
            InitializeComponent();
            reporteService = new ReporteService();
        }

        public frmEstadisticaVenta(Dictionary<string, object> dict)
        {
            InitializeComponent();
            reporteService = new ReporteService();
            this.dict = dict;
        }

        private void frmEstadisticaVenta_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = reporteService.GetVentasPorMes(dict);

            ReportDataSource ds = new ReportDataSource("DataSetVenta", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }
    }
}
