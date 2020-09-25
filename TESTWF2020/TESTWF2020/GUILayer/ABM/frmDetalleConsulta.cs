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

namespace TESTWF2020.GUILayer.ABM
{
    public partial class frmDetalleConsulta : Form
    {
        private int idConsultaSeleccionada;
        private ConsultaService consultaService;

        public frmDetalleConsulta()
        {
            InitializeComponent();
            consultaService = new ConsultaService();
        }

        public frmDetalleConsulta(int idConsultaSeleccionada)
        {
            InitializeComponent();
            this.idConsultaSeleccionada = idConsultaSeleccionada;
            consultaService = new ConsultaService();
        }


        private void btnElegir_Click(object sender, EventArgs e)
        {
            frmInmuebles frmInmuebles = new frmInmuebles(true);
            //this.Hide();
            frmInmuebles.ShowDialog();
            this.txtIDInmueble.Text = frmInmuebles.idInmuebleSeleccionado.ToString();
        }

        
    }
}
