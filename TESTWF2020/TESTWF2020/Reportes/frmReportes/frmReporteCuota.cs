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

namespace TESTWF2020.Reportes.frmReportes
{
    public partial class frmReporteCuota : Form
    {
        private ReporteService reporteService;
        public frmReporteCuota()
        {
            InitializeComponent();
            reporteService = new ReporteService();
        }

        private void frmReporteCuota_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDInmobiliariaCasaFelizDataSetCuota.TablaCuota' Puede moverla o quitarla según sea necesario.
            this.tablaCuotaTableAdapter.Fill(this.bDInmobiliariaCasaFelizDataSetCuota.TablaCuota);

            this.rptvCuotas.RefreshReport();
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
            DataTable tabla = reporteService.GetByFiltersRptCuota(diccParametros);

            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No existe inmueble con esas condiciones");
                dtpFechaDesde.Value = DateTime.Today;
                dtpFechaHasta.Value = DateTime.Today;
                txtNombreCliente.Text = default;
            }
            else
            {
                this.bDInmobiliariaCasaFelizDataSetCuotaBindingSource.DataSource = tabla;
                this.rptvCuotas.RefreshReport();
            }
        }

        private Dictionary<string,object> CrearDiccionario()
        {
            var dict = new Dictionary<string, object>();

            if (!string.IsNullOrWhiteSpace(this.txtNombreCliente.Text))
            {
                dict.Add("nombreCliente", txtNombreCliente.Text);
            }
            if (!string.IsNullOrWhiteSpace(this.txtApellidoCliente.Text))
            {
                dict.Add("apellidoCliente", txtApellidoCliente.Text);
            }
            if (!string.IsNullOrWhiteSpace(this.txtCalleInmueble.Text))
            {
                dict.Add("calleInmueble", txtCalleInmueble.Text);
            }

            if (dtpFechaDesde.Value.Date != dtpFechaHasta.Value.Date)
            {
                dict.Add("fechaDesde", dtpFechaDesde.Value.ToString("yyyyMMdd"));
                dict.Add("fechaHasta", dtpFechaHasta.Value.ToString("yyyyMMdd"));
            }

            return dict;
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            frmCuotaEstadistica frmCuotaEstadistica = new frmCuotaEstadistica();
            frmCuotaEstadistica.ShowDialog();
        }
    }
}
