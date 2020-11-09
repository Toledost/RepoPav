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
using TESTWF2020.Reportes.frmEstadisticas;
using TESTWF2020.Utilities;

namespace TESTWF2020.Reportes.frmReportes
{
    public partial class frmReporteEmpleado : Form
    {
        private ReporteService reporteService;
        private EmpleadoService empleadoService;
        private UsuarioService usuarioService;
        public frmReporteEmpleado()
        {
            InitializeComponent();
            reporteService = new ReporteService();
            empleadoService = new EmpleadoService();
            usuarioService = new UsuarioService();
        }

        private void frmReporteEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDInmobiliariaCasaFelizDataSetEmpleado.tablaEmpleado' Puede moverla o quitarla según sea necesario.
            //this.tablaEmpleadoTableAdapter.Fill(this.bDInmobiliariaCasaFelizDataSetEmpleado.tablaEmpleado);
            //this.rptvEmpleados.RefreshReport();
            CargarCombos();
        }

        private void CargarCombos()
        {
            this.cboNombreEmpleado.DataSource = empleadoService.GetByFilters(new Dictionary<string, object>());
            this.cboNombreEmpleado.ValueMember = "Legajo";
            this.cboNombreEmpleado.DisplayMember = "NombreCompleto";
            this.cboNombreEmpleado.SelectedIndex = -1;

            this.cboUsuario.DataSource = usuarioService.GetByFilters(new Dictionary<string, object>(),false);
            this.cboUsuario.ValueMember = "Nombre";
            this.cboUsuario.DisplayMember = "Nombre";
            this.cboUsuario.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var fecha = DateTime.Compare(dtpFechaDesde.Value.Date, dtpFechaHasta.Value.Date);
            if (fecha != 0)
            {
                if (dtpFechaDesde.Value > dtpFechaHasta.Value)
                {
                    MessageBox.Show("Fechas erroneas!!!");
                    return;
                }
            }

            var diccParametros = CrearDiccionario();
            DataTable tabla = reporteService.GetByFiltersRptEmpleado(diccParametros);


            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No existen resultados con esas condiciones", "Buscar Reporte", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.btnLimpiarFiltros_Click(sender, e);

                this.rptvEmpleados.Clear();
            }
            else
            {
                this.tablaEmpleadoBindingSource.DataSource = tabla;
                this.rptvEmpleados.RefreshReport();
                this.btnGrafico.Enabled = true;

            }
        }

        private Dictionary<string,object> CrearDiccionario()
        {
            var dict = new Dictionary<string, object>();

            dict = Validador.CargarDiccionarioComboBox(dict, cboNombreEmpleado, cboUsuario);

            if (dtpFechaDesde.Value.Date != dtpFechaHasta.Value.Date)
            {
                dict.Add("fechaDesde", dtpFechaDesde.Value.ToString("yyyyMMdd"));
                dict.Add("fechaHasta", dtpFechaHasta.Value.ToString("yyyyMMdd"));
            }

            return dict;
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            var dict = CrearDiccionario();
            frmEstadisiticaEmpleado frmEstadisiticaEmpleado = new frmEstadisiticaEmpleado(dict);
            frmEstadisiticaEmpleado.ShowDialog();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today;
            cboNombreEmpleado.SelectedIndex = -1;
            cboUsuario.SelectedIndex = -1;
        }

        private void dtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            btnGrafico.Enabled = false;
        }

        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            btnGrafico.Enabled = false;
        }

        private void cboNombreEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGrafico.Enabled = false;
        }

        private void cboUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGrafico.Enabled = false;
        }
    }
}
