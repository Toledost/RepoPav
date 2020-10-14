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
    public partial class frmReporteVenta : Form
    {
        public frmReporteVenta()
        {
            InitializeComponent();
        }

        private void frmReporteVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDInmobiliariaCasaFelizDataSet.tablaVenta' Puede moverla o quitarla según sea necesario.
            this.tablaVentaTableAdapter.Fill(this.bDInmobiliariaCasaFelizDataSet.tablaVenta);

            this.rptvVenta.RefreshReport();
        }
    }
}
