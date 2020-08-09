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

namespace TESTWF2020
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!TextoCompletado(txtUsuario.Text,"Usuario"))
                return;
            
            if (!TextoCompletado(txtClave.Text, "Clave"))
                return;
            UsuarioLogueado = UsuarioLogueado.BuscarUsuario(txtUsuario.Text,txtClave.Text);
            if (UsuarioLogueado != null)
            {
                MessageBox.Show("Logueado con exito");
                this.Close();
            }
            MessageBox.Show("Usuario y/o clave incorrectos");
        }

        private Usuario usuarioLogueado = new Usuario();
        
        internal Usuario UsuarioLogueado { get => usuarioLogueado; set => usuarioLogueado = value; }

        
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
    }
}
