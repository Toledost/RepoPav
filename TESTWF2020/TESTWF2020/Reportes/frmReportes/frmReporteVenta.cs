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
    public partial class frmReporteVenta : Form
    {
        private ReporteService reporteService;
        private InmuebleService inmuebleService;
        private ClienteService clienteService;
        public frmReporteVenta()
        {
            InitializeComponent();
            reporteService = new ReporteService();
            inmuebleService = new InmuebleService();
            clienteService = new ClienteService();
            dtpFechaDesde.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today;
        }

        private void frmReporteVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDInmobiliariaCasaFelizDataSet.tablaVenta' Puede moverla o quitarla según sea necesario.
            //this.tablaVentaTableAdapter.Fill(this.bDInmobiliariaCasaFelizDataSet.tablaVenta);

            //this.rptvVenta.RefreshReport();
            CargarCombos();
        }

        private void CargarCombos()
        {
            this.cboInmueble.DataSource = inmuebleService.GetByFilters(new Dictionary<string, object>());
            this.cboInmueble.ValueMember = "Id";
            this.cboInmueble.DisplayMember = "DireccionCompleta";
            this.cboInmueble.SelectedIndex = -1;

            this.cboCliente.DataSource = clienteService.GetAll();
            this.cboCliente.ValueMember = "Dni";
            this.cboCliente.DisplayMember = "NombreCompleto";
            this.cboCliente.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var fecha = DateTime.Compare(dtpFechaDesde.Value.Date, dtpFechaHasta.Value.Date);
            if (fecha!=0)
            {
                if (dtpFechaDesde.Value > dtpFechaHasta.Value)
                {
                    MessageBox.Show("Fechas erroneas!!!");
                    return;
                }
            }

            var diccParametros = CrearDiccionario();
            DataTable tabla = reporteService.GetByFiltersRptVenta(diccParametros);


            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No existen resultados con esas condiciones", "Buscar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.btnLimpiarFiltros_Click(sender, e);

                this.rptvVenta.Clear();
            }
            else
            {
                this.tablaVentaBindingSource.DataSource = tabla;
                this.rptvVenta.RefreshReport();
                btnGrafico.Enabled = true;
            }
        }

        private Dictionary<string,object> CrearDiccionario()
        {
            var dict = new Dictionary<string, object>();

            dict = Validador.CargarDiccionarioComboBox(dict, cboCliente, cboInmueble);

            if (dtpFechaDesde.Value.Date != dtpFechaHasta.Value.Date)
            {
                dict.Add("fechaVentaDesde", dtpFechaDesde.Value.ToString("yyyyMMdd"));
                dict.Add("fechaVentaHasta", dtpFechaHasta.Value.ToString("yyyyMMdd"));
            }

            return dict;
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            var dict = CrearDiccionario();
            frmEstadisticaVenta frmEstadisticaVenta = new frmEstadisticaVenta(dict);
            frmEstadisticaVenta.ShowDialog();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today;
            cboCliente.SelectedIndex = -1;
            cboInmueble.SelectedIndex = -1;
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGrafico.Enabled = false;
        }

        private void cboInmueble_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGrafico.Enabled = false;
        }

        private void dtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            btnGrafico.Enabled = false;
        }

        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            btnGrafico.Enabled = false;
        }
    }
}
