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

namespace TESTWF2020.Reportes.frmReportes
{
    public partial class frmReporteVenta : Form
    {
        private ReporteService reporteService;
        public frmReporteVenta()
        {
            InitializeComponent();
            reporteService = new ReporteService();
        }

        private void frmReporteVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDInmobiliariaCasaFelizDataSet.tablaVenta' Puede moverla o quitarla según sea necesario.
            this.tablaVentaTableAdapter.Fill(this.bDInmobiliariaCasaFelizDataSet.tablaVenta);

            this.rptvVenta.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string idInmueble,clienteNombre,clienteApellido = "";
            if (dtpFechaDesde.Value != dtpFechaHasta.Value)
            {
                if (dtpFechaDesde.Value > dtpFechaHasta.Value)
                {
                    MessageBox.Show("Fechas erroneas!!!");
                    return;
                }
            }
            if (!string.IsNullOrEmpty(txtNombreInmueble.Text))
            {
                idInmueble = txtNombreInmueble.Text;
            }
            if (!string.IsNullOrEmpty(txtNombreComprador.Text))
            {
                clienteNombre = txtNombreComprador.Text;
            }
            if (!string.IsNullOrEmpty(txtApellidoComprador.Text))
            {
                clienteApellido = txtApellidoComprador.Text;
            }

            var diccParametros = CrearDiccionario();
            DataTable tabla = reporteService.GetByFiltersRptVenta(diccParametros);


            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No existe inmueble con esas condiciones");
                dtpFechaDesde.Value = DateTime.Today;
                dtpFechaHasta.Value = DateTime.Today;
                txtNombreInmueble.Text = default;
            }
            else
            {
                this.tablaVentaBindingSource.DataSource = tabla;
                this.rptvVenta.RefreshReport();
            }
        }

        private Dictionary<string,object> CrearDiccionario()
        {
            var dict = new Dictionary<string, object>();

            if (!string.IsNullOrWhiteSpace(this.txtNombreInmueble.Text))
            {
                dict.Add("nombreInmueble", txtNombreInmueble.Text);
            }
            if (!string.IsNullOrWhiteSpace(this.txtNombreComprador.Text))
            {
                dict.Add("nombreComprador", txtNombreComprador.Text);
            }
            if (!string.IsNullOrWhiteSpace(this.txtApellidoComprador.Text))
            {
                dict.Add("apellidoComprador", txtApellidoComprador.Text);
            }

            if (!(dtpFechaDesde.Value == dtpFechaHasta.Value))
            {
                dict.Add("fechaVentaDesde", dtpFechaDesde.Value.ToString("yyyyMMdd"));
                dict.Add("fechaVentaHasta", dtpFechaHasta.Value.ToString("yyyyMMdd"));
            }

            return dict;
        }
    }
}
