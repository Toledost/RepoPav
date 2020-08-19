using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TESTWF2020.Clases;
using TESTWF2020.BusinessLayer;

namespace TESTWF2020
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            usuarioService = new UsuarioService();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!TextoCompletado(txtUsuario.Text,"Usuario"))
                return;  
            
            if (!TextoCompletado(txtClave.Text, "Clave"))
                return;

            
            var user = usuarioService.ValidarUsuario(txtUsuario.Text, txtClave.Text);

            if (user != null)
            {
                UsuarioLogueado = user.Nombre;
                MessageBox.Show(UsuarioLogueado);
                this.Close();
            }
            else
                MessageBox.Show("Usuario y/o clave incorrectos");
            return;
        }

        private UsuarioService usuarioService;
        public string UsuarioLogueado { get; set; }

        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region MetodosVerificadores
        private bool TextoCompletado(string campo,string nombreCampo)
        {
            if (string.IsNullOrEmpty(campo))
            {
                MessageBox.Show("Falta colocar " + nombreCampo);
                return false;
            }
            return true;
        }

        #endregion

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
