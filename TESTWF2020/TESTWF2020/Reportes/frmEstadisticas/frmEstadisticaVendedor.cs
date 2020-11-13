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
    public partial class frmEstadisticaVendedor : Form
    {
        private ReporteService reporteService;
        private Dictionary<string, object> dict;

        public frmEstadisticaVendedor()
        {
            InitializeComponent();
            reporteService = new ReporteService();
        }

        public frmEstadisticaVendedor(Dictionary<string, object> dict)
        {
            InitializeComponent();
            reporteService = new ReporteService();
            this.dict = dict;
        }

        private void frmEstadisticaVendedor_Load(object sender, EventArgs e)
        {
            this.rptvEstadisticaVendedor.RefreshReport();
        }

        private void rptvEstadisticaVendedor_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = reporteService.GetVentasPorVendedor(dict);

            ReportDataSource ds = new ReportDataSource("DataSetEstadisticaVendedor", tabla);

            rptvEstadisticaVendedor.LocalReport.DataSources.Clear();
            rptvEstadisticaVendedor.LocalReport.DataSources.Add(ds);
            rptvEstadisticaVendedor.LocalReport.Refresh();
        }
    }
}
