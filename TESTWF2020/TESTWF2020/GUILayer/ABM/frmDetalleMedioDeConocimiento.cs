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
    public partial class frmDetalleMedioDeConocimiento : Form
    {
        private int idMedioSeleccionado;

        public frmDetalleMedioDeConocimiento()
        {
            InitializeComponent();
        }

        public frmDetalleMedioDeConocimiento(int idMedioSeleccionado)
        {
            InitializeComponent();
            this.idMedioSeleccionado = idMedioSeleccionado;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDetalleMedioDeConocimiento_Load(object sender, EventArgs e)
        {
            if (idMedioSeleccionado == 0)
            {
                this.btnEditar.Enabled = false;
            }
        }
    }
}
