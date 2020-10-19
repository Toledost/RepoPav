using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TESTWF2020.Entities;
using TESTWF2020.GUILayer;
using TESTWF2020.GUILayer.ABM;
using TESTWF2020.GUILayer.FORMFinanciacion;
using TESTWF2020.Reportes.frmReportes;

namespace TESTWF2020
{
    public partial class frmPrincipal : Form
    {
        //Comentario del frmPricipal
        private frmLogin login;
        private readonly string tituloOriginal = "Inmobiliaria Casa Feliz";
        private Usuario usuarioLogueado;
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
            usuarioLogueado = login.UsuarioLogueado;
            this.Show();
            this.Text = string.Concat(tituloOriginal, " - Usuario: ", usuarioLogueado.Nombre);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            login.UsuarioLogueado = null;
            frmPrincipal_Load(sender, e);
        }

        private void inmueblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInmuebles frmInmuebles = new frmInmuebles();
            this.Hide();
            frmInmuebles.ShowDialog();
            this.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarClientes frmConsultarClientes = new frmConsultarClientes();
            this.Hide();
            frmConsultarClientes.ShowDialog();
            this.Show();
        }

        private void planesFinanciacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaFinanciacion frmConsultaFinanciacion = new frmConsultaFinanciacion();
            this.Hide();
            frmConsultaFinanciacion.ShowDialog();
            this.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleados frmEmpleados = new frmEmpleados();
            this.Hide();
            frmEmpleados.ShowDialog();
            this.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGeneralUsuario frmGeneralUsuario = new frmGeneralUsuario();
            this.Hide();
            frmGeneralUsuario.ShowDialog();
            this.Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMCConsultas frmConsultas = new frmABMCConsultas(usuarioLogueado);
            this.Hide();
            frmConsultas.ShowDialog();
            this.Show();
        }

        private void mediosDeConocimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMCMedioDeConocimiento frmMedios = new frmABMCMedioDeConocimiento();
            this.Hide();
            frmMedios.ShowDialog();
            this.Show();
        }

        private void viaDeConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMCViaDeConsulta frmABMCViaDeConsulta = new frmABMCViaDeConsulta();
            this.Hide();
            frmABMCViaDeConsulta.ShowDialog();
            this.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMCVenta frmABMCVenta = new frmABMCVenta(usuarioLogueado);
            this.Hide();
            frmABMCVenta.ShowDialog();
            this.Show();
        }

        private void reporteDeInmuebleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteInmueble frmReporteInmueble = new frmReporteInmueble();
            frmReporteInmueble.ShowDialog();
            this.Show();
        }

        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteVenta frmReporteVenta = new frmReporteVenta();
            frmReporteVenta.ShowDialog();
            this.Show();
        }
        
        private void cuotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteCuota frmReporteCuota = new frmReporteCuota();
            frmReporteCuota.ShowDialog();
        }

        private void ventaGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentaGeneral frmVentaGeneral = new frmVentaGeneral();
            frmVentaGeneral.ShowDialog();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReporteEmpleado frmReporteEmpleado = new frmReporteEmpleado();
            frmReporteEmpleado.ShowDialog();
        }
    }
}
