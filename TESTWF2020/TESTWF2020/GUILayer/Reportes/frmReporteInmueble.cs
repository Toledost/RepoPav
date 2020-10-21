using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTWF2020.GUILayer.Reportes
{
    public partial class frmReporteInmueble : Form
    {
        public frmReporteInmueble()
        {
            InitializeComponent();
        }

        private void frmReporteInmueble_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
