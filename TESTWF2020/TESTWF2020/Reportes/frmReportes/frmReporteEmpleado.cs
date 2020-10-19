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
    public partial class frmReporteEmpleado : Form
    {
        public frmReporteEmpleado()
        {
            InitializeComponent();
        }

        private void frmReporteEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDInmobiliariaCasaFelizDataSetEmpleado.tablaEmpleado' Puede moverla o quitarla según sea necesario.
            this.tablaEmpleadoTableAdapter.Fill(this.bDInmobiliariaCasaFelizDataSetEmpleado.tablaEmpleado);
            this.rptvEmpleados.RefreshReport();
        }

        private void rptvEmpleados_Load(object sender, EventArgs e)
        {

        }
    }
}
