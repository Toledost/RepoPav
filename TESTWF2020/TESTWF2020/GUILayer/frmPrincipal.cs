using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTWF2020
{
    public partial class frmPrincipal : Form
    {
        private string titulo = "Inmobiliaria Casa Feliz";

        public frmPrincipal()
        {
            InitializeComponent();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
            if (login.UsuarioLogueado != null)
            {
                this.btnLogin.Dispose();
                this.Text += login.UsuarioLogueado;
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.btnLogin.Dispose();
            frmLogin login = new frmLogin();
            login.ShowDialog();
            //if (login.UsuarioLogueado != null)
        }
    }
}
