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
    public partial class frmEditarUsuarios : Form
    {
        //private Usuario usuarioSeleccionado;
        
        private PerfilService perfilService;
        public frmEditarUsuarios()
        {
            InitializeComponent();
            perfilService = new PerfilService();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarCombo()
        {
            cboPerfil.DataSource = perfilService.GetAll();
            cboPerfil.ValueMember = "idPerfil";
            cboPerfil.DisplayMember = "nombre";
            cboPerfil.SelectedIndex = -1;
        }

        private void frmEditarUsuarios_Load(object sender, EventArgs e)
        {
            CargarCombo();
            //Usuario usuario = UsuarioService.GetNombre((Usuario)usuarioSeleccionado);
            //CargarTextBox(usuario);
            //No se como corregir el error, el camino ya esta todo hecho pero no puedo devolver solo el nombre 
            //
            
        }

        private void CargarTextBox(Usuario usuario)
        {
            this.txtNombre.Text = usuario.Nombre.ToString();
            
        }
    }
}
