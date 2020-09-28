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
    public partial class frmGeneralUsuario : Form
    {
        private UsuarioService usuarioService;
        private PerfilService perfilService;
        private bool esParaElegir = false;

        public string NombreUsuarioSeleccionado { get; set; }

        public frmGeneralUsuario()
        {
            InitializeComponent();
            usuarioService = new UsuarioService();
            perfilService = new PerfilService();
        }

        public frmGeneralUsuario(bool elegir)
        {
            InitializeComponent();
            usuarioService = new UsuarioService();
            perfilService = new PerfilService();
            this.esParaElegir = elegir;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            IList<Usuario> listaUsuarios = new List<Usuario>();

            //if (string.IsNullOrWhiteSpace(txtNombre.Text) &&
            //    cboPerfilGeneral.SelectedIndex ==-1)
            //{
            //    //listaUsuarios =  usuarioService.GetAll();
            //}
            //else
            //{
            //    var dicc = CrearDiccionario();
            //    listaUsuarios = usuarioService.GetByFilters(dicc,chkLibre.Checked);
            //}

            var dicc = CrearDiccionario();
            listaUsuarios = usuarioService.GetByFilters(dicc, chkLibre.Checked);
            CargarGrilla(listaUsuarios);
        }

        private Dictionary<string,object> CrearDiccionario()
        {
            var dicc = new Dictionary<string, object>();
            if (!string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                dicc.Add("nombre", txtNombre.Text);
            }
            if (!(cboPerfilGeneral.SelectedIndex ==-1))
            {
                dicc.Add("idPerfil",cboPerfilGeneral.SelectedValue);
            }
            return dicc;
            

        }

        private void CargarTextBox(Usuario usuario)
        {
            this.txtNombre.Text = usuario.Nombre.ToString();
            this.cboPerfilGeneral.SelectedValue = usuario.Perfil.IdPerfil.ToString();
        }

        private void frmGeneralUsuario_Load(object sender, EventArgs e)
        {
            CargarComboBox();
            if (esParaElegir)
            {
                btnEliminar.Visible = false;
                btnSeleccionar.Focus();
            }
            else
            {
                btnSeleccionar.Visible = false;
                btnBuscar.Focus();
            }
        }

        private void CargarComboBox()
        {
            cboPerfilGeneral.DataSource = perfilService.GetAll();
            cboPerfilGeneral.ValueMember = "idPerfil";
            cboPerfilGeneral.DisplayMember = "nombre";
            cboPerfilGeneral.SelectedIndex = -1;
        }

        private void CargarGrilla(IList<Usuario> lista)
        {
            this.dgvGeneralUsuario.Rows.Clear();
            foreach (var usuario in lista)
            {   
                this.dgvGeneralUsuario.Rows.Add(usuario.Nombre, usuario.Perfil);
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (dgvGeneralUsuario.SelectedRows.Count == 1)
            {
                var nombreUsuarioSeleccionado = this.dgvGeneralUsuario.CurrentRow.Cells["Nombre"].Value.ToString();
                frmABMCUsuario frmABMCUsuario = new frmABMCUsuario(false, nombreUsuarioSeleccionado);
                frmABMCUsuario.ShowDialog();
                btnBuscar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("No seleccionó ningún Usuario");
            }
            //btnBuscar_Click(sender, e);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmABMCUsuario frmABMCUsuario = new frmABMCUsuario(true);
            frmABMCUsuario.ShowDialog();
            btnBuscar_Click(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvGeneralUsuario.SelectedRows.Count == 1)
            {
                var nombreUsuarioSeleccionado = this.dgvGeneralUsuario.CurrentRow.Cells["Nombre"].Value.ToString();
                Delete(nombreUsuarioSeleccionado);
            }
            else
            {
                MessageBox.Show("No seleccionó ningún Usuario");
            }
            btnBuscar_Click(sender, e);
        }

        private void Delete(string nombreUsuarioSeleccionado)
        {
            usuarioService.Delete(nombreUsuarioSeleccionado);
            MessageBox.Show("Usuario eliminado correctamente");
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvGeneralUsuario.SelectedRows.Count == 1)
            {
                NombreUsuarioSeleccionado = this.dgvGeneralUsuario.CurrentRow.Cells["Nombre"].Value.ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error. Debe seleccionar un Usuario.");
            }
        }
    }
}
