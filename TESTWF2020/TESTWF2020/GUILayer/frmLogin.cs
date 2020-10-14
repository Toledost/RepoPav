using System;
using System.Windows.Forms;
using TESTWF2020.BusinessLayer;
using TESTWF2020.Entities;

namespace TESTWF2020
{
    public partial class frmLogin : Form
    {
        #region properties and privates

        private UsuarioService usuarioService;
        public Usuario UsuarioLogueado { get; set; }

        #endregion

        public frmLogin()
        {
            InitializeComponent();
            usuarioService = new UsuarioService();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!TextoCompletado(txtUsuario.Text, "Usuario"))
                return;

            if (!TextoCompletado(txtClave.Text, "Clave"))
                return;

            UsuarioLogueado = usuarioService.ValidarUsuario(txtUsuario.Text, txtClave.Text);

            if (UsuarioLogueado != null)
            {
                MessageBox.Show($"Logueado: {UsuarioLogueado.Nombre}");
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario y/o clave incorrectos",
                    "Error de logueo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }                
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region MetodosVerificadores

        /// <summary>
        /// Devuelve true si se completó el campo, false si no se completó y muestra Mbox
        /// </summary>
        /// <param name="campo"></param>
        /// <param name="nombreCampo"></param>
        /// <returns></returns>
        private bool TextoCompletado(string campo, string nombreCampo)
        {
            if (string.IsNullOrEmpty(campo))
            {
                MessageBox.Show("Falta colocar " + nombreCampo,
                    "Error de logueo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        #endregion
    }
}
