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
    public partial class frmEstadisticaMedioConocimiento : Form
    {
        private ReporteService reporteService;
        public frmEstadisticaMedioConocimiento()
        {
            InitializeComponent();
            this.reporteService = new ReporteService();
        }

        private void frmEstadisticaMedioConocimiento_Load(object sender, EventArgs e)
        {

            this.rptvEstadisticaMedioConocimiento.RefreshReport();
        }

        private void rptvEstadisticaMedioConocimiento_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = reporteService.GetCantConsultasByMedioConocimiento();

            ReportDataSource ds = new ReportDataSource("DataSetEstadisticaMedioConocimiento", tabla);

            rptvEstadisticaMedioConocimiento.LocalReport.DataSources.Clear();
            rptvEstadisticaMedioConocimiento.LocalReport.DataSources.Add(ds);
            rptvEstadisticaMedioConocimiento.LocalReport.Refresh();
        }
    }
}
