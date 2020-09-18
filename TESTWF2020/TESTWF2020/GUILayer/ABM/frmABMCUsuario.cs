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
    public partial class frmABMCUsuario : Form
    {
        private PerfilService perfilService;
        private UsuarioService usuarioService;
        public frmABMCUsuario()
        {
            InitializeComponent();
            perfilService = new PerfilService();
            usuarioService = new UsuarioService();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.txtNombre.Text) 
                && !string.IsNullOrWhiteSpace(this.txtContraseña.Text)
                && this.cboPerfil.SelectedIndex !=-1)
            {
                Usuario user = new Usuario
                {
                    Contraseña = txtContraseña.Text,
                    Nombre = txtNombre.Text,
                    Perfil = new Perfil
                    {
                        IdPerfil = (int)cboPerfil.SelectedValue
                    }
                };
                usuarioService.Insert(user);
                MessageBox.Show("Se creo correctamente el usuario");
            }

            
        }

        private void frmABMCUsuario_Load(object sender, EventArgs e)
        {
            CargarComboBox();
        }

        private void CargarComboBox()
        {
            cboPerfil.DataSource = perfilService.GetAll();
            cboPerfil.ValueMember = "idPerfil";
            cboPerfil.DisplayMember = "nombre";
            cboPerfil.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmGeneralUsuario frmGeneralUsuario = new frmGeneralUsuario();
            this.Hide();
            frmGeneralUsuario.ShowDialog();
            this.Show();
        }

    }
}
