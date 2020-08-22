using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TESTWF2020.Entities;

namespace TESTWF2020
{
    public partial class frmPrincipal : Form
    {
        private frmLogin login;
        private readonly string tituloOriginal = "Inmobiliaria Casa Feliz";
        public frmPrincipal()
        {
            InitializeComponent();
            login = new frmLogin();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.Hide();
            login.ShowDialog();
            if (login.UsuarioLogueado == null)
            {
                this.Close();
                return;
            }
            this.Show();
            this.Text = string.Concat(tituloOriginal, " - Usuario: ", login.UsuarioLogueado.Nombre);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            login.UsuarioLogueado = null;
            frmPrincipal_Load(sender, e);
        }
    }
}
