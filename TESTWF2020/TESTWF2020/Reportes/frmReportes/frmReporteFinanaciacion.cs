using Microsoft.Reporting.WinForms;
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
    public partial class frmReporteFinanaciacion : Form
    {
        private ReporteService reporteService;

        public frmReporteFinanaciacion()
        {
            InitializeComponent();
            reporteService = new ReporteService();
        }

        private void frmReporteFinanaciacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDInmobiliariaCasaFelizDataSetFinanciacion.DataTableFinanciacion' Puede moverla o quitarla según sea necesario.
            this.dataTableFinanciacionTableAdapter.Fill(this.bDInmobiliariaCasaFelizDataSetFinanciacion.DataTableFinanciacion);

            this.rptvFinanaciacion.RefreshReport();
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
            DataTable tabla = reporteService.GetByFiltersRptFinanciacion(diccParametros);


            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No existe financiacion con esas condiciones");
                dtpFechaDesde.Value = DateTime.Today;
                dtpFechaHasta.Value = DateTime.Today;
                txtFinanciacion.Text = default;
            }
            else
            {
                this.dataTableFinanciacionBindingSource.DataSource = tabla;
                this.rptvFinanaciacion.RefreshReport();
            }
        }

        private Dictionary<string, object> CrearDiccionario()
        {
            var dict = new Dictionary<string, object>();

            if (!string.IsNullOrWhiteSpace(this.txtFinanciacion.Text))
            {
                dict.Add("nombreFinanciacion", txtFinanciacion.Text);
            }

            if (dtpFechaDesde.Value.Date != dtpFechaHasta.Value.Date)
            {
                dict.Add("fechaVentaDesde", dtpFechaDesde.Value.ToString("yyyyMMdd"));
                dict.Add("fechaVentaHasta", dtpFechaHasta.Value.ToString("yyyyMMdd"));
            }

            return dict;
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            frmEstadisticaFinanciacion frmEstadisticaFinanciacion = new frmEstadisticaFinanciacion();
            frmEstadisticaFinanciacion.ShowDialog();
        }
    }
}
