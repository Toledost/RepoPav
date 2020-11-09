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
    public partial class frmCuotaEstadistica : Form
    {
        private ReporteService reporteService;
        private Dictionary<string, object> diccParametros;

        public frmCuotaEstadistica()
        {
            InitializeComponent();
            this.reporteService = new ReporteService();
        }

        public frmCuotaEstadistica(Dictionary<string, object> diccParametros)
        {
            InitializeComponent();
            this.reporteService = new ReporteService();
            this.diccParametros = diccParametros;
        }

        private void frmCuotaEstadistica_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = reporteService.GetCuotasByDireccion(diccParametros);

            ReportDataSource ds = new ReportDataSource("EstadisticoCuotaDataSet", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }
    }
}
