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
    public partial class frmReporteEmpleado : Form
    {
        private ReporteService reporteService;  
        public frmReporteEmpleado()
        {
            InitializeComponent();
            reporteService = new ReporteService();
        }

        private void frmReporteEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDInmobiliariaCasaFelizDataSetEmpleado.tablaEmpleado' Puede moverla o quitarla según sea necesario.
            this.tablaEmpleadoTableAdapter.Fill(this.bDInmobiliariaCasaFelizDataSetEmpleado.tablaEmpleado);
            this.rptvEmpleados.RefreshReport();
        }

        private void rptvEmpleados_Load(object sender, EventArgs e)
        {

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
                MessageBox.Show("No existe Empleado con esas condiciones");
                dtpFechaDesde.Value = DateTime.Today;
                dtpFechaHasta.Value = DateTime.Today;
                txtNombreEmpleado.Text = default;
                txtUsuario.Text = default;
            }
            else
            {
                this.tablaEmpleadoBindingSource.DataSource = tabla;
                this.rptvEmpleados.RefreshReport();
            }
        }

        private Dictionary<string,object> CrearDiccionario()
        {
            var dict = new Dictionary<string, object>();

            if (!string.IsNullOrWhiteSpace(this.txtNombreEmpleado.Text))
            {
                dict.Add("nombreEmpleado", txtNombreEmpleado.Text);
            }
            if (!string.IsNullOrWhiteSpace(this.txtApellidoEmpleado.Text))
            {
                dict.Add("apellidoEmpleado", txtApellidoEmpleado.Text);
            }
            if (!string.IsNullOrWhiteSpace(this.txtUsuario.Text))
            {
                dict.Add("usuario", txtUsuario.Text);
            }

            if (dtpFechaDesde.Value.Date != dtpFechaHasta.Value.Date)
            {
                dict.Add("fechaDesde", dtpFechaDesde.Value.ToString("yyyyMMdd"));
                dict.Add("fechaHasta", dtpFechaHasta.Value.ToString("yyyyMMdd"));
            }

            return dict;
        }
    }
}
