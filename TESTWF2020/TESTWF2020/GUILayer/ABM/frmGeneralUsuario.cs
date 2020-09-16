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
    public partial class frmGeneralUsuario : Form
    {
        private UsuarioService usuarioService;
        public frmGeneralUsuario()
        {
            InitializeComponent();
            usuarioService = new UsuarioService();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) &&
                cboPerfil.SelectedIndex ==-1)
            {
                usuarioService.GetAll();
            }
        }

        private void frmGeneralUsuario_Load(object sender, EventArgs e)
        {
            CargarComboBox();
        }

        private void CargarComboBox()
        {
            //cboPerfil.DataSource = usuarioService.GetAll();
            //cboPerfil.ValueMember = "usuario";
            //cboPerfil.DisplayMember = "usuario";
            //cboPerfil.SelectedIndex = -1;
        }
    }
}
