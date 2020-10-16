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
using TESTWF2020.Utilities;

namespace TESTWF2020.GUILayer.ABM
{
    public partial class frmABMCUsuario : Form
    {
        private PerfilService perfilService;
        private UsuarioService usuarioService;
        private string nombreUsuarioSeleccionado;
        private bool esNuevo;

        public frmABMCUsuario()
        {
            InitializeComponent();
            perfilService = new PerfilService();
            usuarioService = new UsuarioService();
        }

        public frmABMCUsuario(bool esNuevo, string nombreUsuarioSeleccionado)
        {
            InitializeComponent();
            this.nombreUsuarioSeleccionado = nombreUsuarioSeleccionado;
            this.esNuevo = esNuevo;
            perfilService = new PerfilService();
            usuarioService = new UsuarioService();
        }

        public frmABMCUsuario(bool esNuevo)
        {
            InitializeComponent();
            this.esNuevo = esNuevo;
            perfilService = new PerfilService();
            usuarioService = new UsuarioService();
        }


        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (Validador.ValidarTextBox(txtNombre,txtContraseña) && 
                Validador.ValidarComboBox(cboPerfil))

            {
                Usuario user = new Usuario
                {
                    Contraseña = txtContraseña.Text,
                    Nombre = txtNombre.Text,
                    Perfil = new Perfil
                    {
                        IdPerfil = Convert.ToInt32(this.cboPerfil.SelectedValue)
                    }
                };

                if (esNuevo)
                {

                    var usuario = usuarioService.GetUsuario(user.Nombre, true);
                    if (usuario == null)
                    {
                        usuarioService.Insert(user);
                        MessageBox.Show("Usuario creado", "Crear usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("Este usuario fue eliminado anteriormente ¿Desea restablecerlo?",
                            "Recuperar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (dr == DialogResult.Yes)
                        {
                            usuarioService.Recuperar(txtNombre.Text);
                            MessageBox.Show("Cliente restablecido", "Recuperar cliente", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }
                    this.Close();

                    //usuarioService.Insert(user);
                    //MessageBox.Show("Se creo correctamente el usuario");
                }
                else
                {
                    usuarioService.Update(user, nombreUsuarioSeleccionado);
                    //usuarioService.UpDate(user, true);
                    MessageBox.Show("Se edito correctamente");
                    this.Close();
                }
            }           
        }

        private void frmABMCUsuario_Load(object sender, EventArgs e)
        {
            
            CargarComboBox();
            if (esNuevo)
            {
                CargarComboBox();
                btnEditar.Enabled = false;
            }
            else
            {
                this.btnGrabar.Enabled = false;
                Usuario usuarioSelec = usuarioService.GetUsuario(nombreUsuarioSeleccionado);
                CargarComboBoxSeleccionado(usuarioSelec);
                CargarTextBox(usuarioSelec);
                txtContraseña.ReadOnly = true;
                txtNombre.ReadOnly = true;
                cboPerfil.Enabled = false;
            }

        }

        private void CargarComboBoxSeleccionado(Usuario usuarioSelec)
        {
            cboPerfil.SelectedValue = usuarioSelec.Perfil.IdPerfil;
        }

        private void CargarTextBox(Usuario usuarioSelec)
        {
            this.txtNombre.Text = usuarioSelec.Nombre;
            this.txtContraseña.Text = usuarioSelec.Contraseña;
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
            if (Validador.ValidarSalir())
            {
                this.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.btnGrabar.Enabled = true;
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            foreach (var textBox in Controls.OfType<TextBox>())
            {
                if (textBox.Name == "txtNombre" && textBox.Name == "txtContraseña")
                {
                    continue;
                }
                textBox.ReadOnly = false;
            }
            foreach (var comboBox in Controls.OfType<ComboBox>())
            {
                comboBox.Enabled = true;
            }
        }
    }
}
