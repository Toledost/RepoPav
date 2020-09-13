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
using TESTWF2020.Entities;

namespace TESTWF2020.GUILayer.ABM
{
    public partial class frmABMCInmueble : Form
    {
        private bool esNuevo;
        private int idInmueble;
        private InmuebleService inmuebleService;

        public frmABMCInmueble()
        {
            InitializeComponent();
            this.inmuebleService = new InmuebleService();
        }

        public frmABMCInmueble(bool esNuevo)
        {
            InitializeComponent();
            this.esNuevo = esNuevo;
            this.inmuebleService = new InmuebleService();
        }

        public frmABMCInmueble(bool esNuevo, int idInmueble)
        {
            InitializeComponent();
            this.esNuevo = esNuevo;
            this.idInmueble = idInmueble;
            this.inmuebleService = new InmuebleService();
        }

        private void frmABMCInmueble_Load(object sender, EventArgs e)
        {
            if (esNuevo)
            {
                this.btnEditar.Enabled = false;
                this.dataGridView1.Visible = false;
            }
            else
            {
                Inmueble inmuebleSeleccionado = inmuebleService.GetById(idInmueble);
                this.txtID.Text = inmuebleSeleccionado.Id.ToString();
            }

        }
    }
}
