using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTWF2020.Reportes.frmReportes
{
    public partial class frmReportesPrincipal : Form
    {
        public frmReportesPrincipal()
        {
            InitializeComponent();
        }

        private void btnRptConsultaInmueble_Click(object sender, EventArgs e)
        {
            frmReporteConsultaInmueble frmReporteConsultaInmueble = new frmReporteConsultaInmueble();
            frmReporteConsultaInmueble.ShowDialog();
        }

        private void btnRptConsultaMedioConoc_Click(object sender, EventArgs e)
        {
            frmReporteConsultaMedioConocimiento frmReporteConsultaMedioConocimiento = new frmReporteConsultaMedioConocimiento();
            frmReporteConsultaMedioConocimiento.ShowDialog();
        }

        private void btnRptCuotas_Click(object sender, EventArgs e)
        {
            frmReporteCuota frmReporteCuota = new frmReporteCuota();
            frmReporteCuota.ShowDialog();
        }

        private void btnRptEmpleados_Click(object sender, EventArgs e)
        {
            frmReporteEmpleado frmReporteEmpleado = new frmReporteEmpleado();
            frmReporteEmpleado.ShowDialog();
        }

        private void btnRptFinanciacion_Click(object sender, EventArgs e)
        {
            frmReporteFinanciacion frmReporteFinanciacion = new frmReporteFinanciacion();
            frmReporteFinanciacion.ShowDialog();
        }

        private void btnRptVendedor_Click(object sender, EventArgs e)
        {
            frmReporteVendedor frmReporteVendedor = new frmReporteVendedor();
            frmReporteVendedor.ShowDialog();
        }

        private void btnRptVenta_Click(object sender, EventArgs e)
        {
            frmReporteVenta frmReporteVenta = new frmReporteVenta();
            frmReporteVenta.ShowDialog();
        }

        private void btnRptInmuebles_Click(object sender, EventArgs e)
        {
            frmReporteInmueble frmReporteInmueble = new frmReporteInmueble();
            frmReporteInmueble.ShowDialog();
        }
    }
}
