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
    public partial class frmEstadisiticaEmpleado : Form
    {
        private ReporteService reporteService;
        public frmEstadisiticaEmpleado()
        {
            InitializeComponent();
            reporteService = new ReporteService();
        }

        private void frmEstadisiticaEmpleado_Load(object sender, EventArgs e)
        {

            this.rptvEmpleado.RefreshReport();
        }


        private void rptvEmpleado_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = reporteService.GetEmpleadosPorAñoMes();

            ReportDataSource ds = new ReportDataSource("DataSetEmpleado", tabla);

            rptvEmpleado.LocalReport.DataSources.Clear();
            rptvEmpleado.LocalReport.DataSources.Add(ds);
            rptvEmpleado.LocalReport.Refresh();
        }
    }
}
