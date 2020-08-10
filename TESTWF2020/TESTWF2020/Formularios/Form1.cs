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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
            if (login.UsuarioLogueado != null)
            {
                //MessageBox.Show(login.UsuarioLogueado.NUsuario);
                this.btnLogin.Dispose();
                this.Text += login.UsuarioLogueado.NUsuario;
            }
        }


    }
}
