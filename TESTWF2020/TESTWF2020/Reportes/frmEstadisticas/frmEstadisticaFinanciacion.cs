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
    public partial class frmEstadisticaFinanciacion : Form
    {
        private ReporteService reporteService;

        public frmEstadisticaFinanciacion()
        {
            InitializeComponent();
            reporteService = new ReporteService();
        }

        private void frmEstadisticaFinanciacion_Load(object sender, EventArgs e)
        {

            this.rptvEstadisticaFinanciacion.RefreshReport();
        }

        private void rptvEstadisticaFinanciacion_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = reporteService.GetVentasPorFinanciacion();

            ReportDataSource ds = new ReportDataSource("DataSetEstadisticaFinanciacion", tabla);

            rptvEstadisticaFinanciacion.LocalReport.DataSources.Clear();
            rptvEstadisticaFinanciacion.LocalReport.DataSources.Add(ds);
            rptvEstadisticaFinanciacion.LocalReport.Refresh();
        }
    }
}
