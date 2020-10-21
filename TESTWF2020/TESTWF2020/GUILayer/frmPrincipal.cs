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
        private Timer timer;

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
            timer = new Timer();
            timer.Tick += new EventHandler(eventoTimer);
            timer.Enabled = true;
            usuarioLogueado = login.UsuarioLogueado;
            this.Show();
            this.lblUsuarioLogeado.Text = "Usuario: " + usuarioLogueado.Nombre;
            this.lblLegajo.Text = "Perfil: " + usuarioLogueado.Perfil;
            this.Text = string.Concat(tituloOriginal, " - Usuario: ", usuarioLogueado.Nombre);
        }

        private void eventoTimer(object ob, EventArgs args)
        {
            DateTime hoy = DateTime.Now;
            lblHora.Text = hoy.ToString("yyyy-MM-dd HH:mm tt");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            login.UsuarioLogueado = null;
            frmPrincipal_Load(sender, e);
        }

        private void mostrarFormEnPanel(Form form)
        {
            if (midPanel.Controls.Count > 0) midPanel.Controls.RemoveAt(0);
            form.TopLevel = false;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.midPanel.Controls.Add(form);
            this.midPanel.Tag = form;
            form.Show();
        }

        private void inmueblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInmuebles frmInmuebles = new frmInmuebles();
            mostrarFormEnPanel(frmInmuebles);
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarClientes frmConsultarClientes = new frmConsultarClientes();
            mostrarFormEnPanel(frmConsultarClientes);
        }

        private void planesFinanciacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaFinanciacion frmConsultaFinanciacion = new frmConsultaFinanciacion();
            mostrarFormEnPanel(frmConsultaFinanciacion);
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleados frmEmpleados = new frmEmpleados();
            mostrarFormEnPanel(frmEmpleados);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGeneralUsuario frmGeneralUsuario = new frmGeneralUsuario();
            mostrarFormEnPanel(frmGeneralUsuario);
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMCConsultas frmConsultas = new frmABMCConsultas(usuarioLogueado);
            mostrarFormEnPanel(frmConsultas);
        }

        private void mediosDeConocimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMCMedioDeConocimiento frmMedios = new frmABMCMedioDeConocimiento();
            mostrarFormEnPanel(frmMedios);
        }

        private void viaDeConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMCViaDeConsulta frmABMCViaDeConsulta = new frmABMCViaDeConsulta();
            mostrarFormEnPanel(frmABMCViaDeConsulta);
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMCVenta frmABMCVenta = new frmABMCVenta(usuarioLogueado);
            mostrarFormEnPanel(frmABMCVenta);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            frmABMCConsultas frmConsultas = new frmABMCConsultas(usuarioLogueado);
            mostrarFormEnPanel(frmConsultas);
        }

        private void btnInmuebles_Click(object sender, EventArgs e)
        {
            frmInmuebles frmInmuebles = new frmInmuebles();
            mostrarFormEnPanel(frmInmuebles);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmABMCVenta frmABMCVenta = new frmABMCVenta(usuarioLogueado);
            mostrarFormEnPanel(frmABMCVenta);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmConsultarClientes frmConsultarClientes = new frmConsultarClientes();
            mostrarFormEnPanel(frmConsultarClientes);
        }

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            frmConsultaFinanciacion frmConsultaFinanciacion = new frmConsultaFinanciacion();
            mostrarFormEnPanel(frmConsultaFinanciacion);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmEmpleados frmEmpleados = new frmEmpleados();
            mostrarFormEnPanel(frmEmpleados);
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
        
        private void reporteInmuebleXConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteConsultaInmueble frmReporteConsultaInmueble = new frmReporteConsultaInmueble();
            frmReporteConsultaInmueble.ShowDialog();
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

        private void ventaFinanciadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteFinanaciacion frmReporteFinanaciacion = new frmReporteFinanaciacion();
            frmReporteFinanaciacion.ShowDialog();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteVendedor frmReporteVendedor = new frmReporteVendedor();
            frmReporteVendedor.ShowDialog();
        }

        private void consultaMedioConocimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteConsultaMedioConocimiento frmReporteConsultaMedioConocimiento = new frmReporteConsultaMedioConocimiento();
            frmReporteConsultaMedioConocimiento.ShowDialog();
        }
    }
}
