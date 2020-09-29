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
using TESTWF2020.GUILayer.FORMFinanciacion;

namespace TESTWF2020.GUILayer.ABM
{
    public partial class frmABMCVenta : Form
    {
        private VentaService ventaService;
        private Inmueble inmuebleSeleccionado;

        public frmABMCVenta()
        {
            InitializeComponent();
            ventaService = new VentaService();
        }

        private void btnSeleccionarInmueble_Click(object sender, EventArgs e)
        {
            frmInmuebles frmInmuebles = new frmInmuebles(true);
            frmInmuebles.ShowDialog();

            inmuebleSeleccionado = frmInmuebles.InmuebleSeleccionado;
            this.txtDireccionInmueble.Text = inmuebleSeleccionado.Calle + " " + inmuebleSeleccionado.CalleNumero.ToString();
            this.txtMontoTotal.Text = inmuebleSeleccionado.MontoVenta.ToString();
        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            frmConsultarClientes frmConsultarClientes = new frmConsultarClientes(true);
            frmConsultarClientes.ShowDialog();
            this.txtDniCliente .Text = frmConsultarClientes.dniClienteSeleccionado.ToString();
        }

        private void btnSeleccionarFinanciacion_Click(object sender, EventArgs e)
        {
            frmConsultaFinanciacion frmConsultaFinanciacion = new frmConsultaFinanciacion(true);
            frmConsultaFinanciacion.ShowDialog();
            
            this.txtFinanciacion.Text = frmConsultaFinanciacion.financiacionElegida.ToString();
            this.txtCantCuota.Text = frmConsultaFinanciacion.cantCuotasSeleccionada.ToString();
            //this.txtMontoCuota.Text = CalcularMontoCuota(montoTotal, frmConsultaFinanciacion.cantCuotasSeleccionada).ToString();
            //TODO: revisar que se actualice cuando se elige primero la financ
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtFinanciacion.Text) ||
            //    string.IsNullOrWhiteSpace(txtDniCliente.Text) ||
            //    txtDniCliente.Text == "0" ||
            //    string.IsNullOrWhiteSpace(txtDireccionInmueble.Text) ||
            //    txtDireccionInmueble.Text == "0" ||
            //    string.IsNullOrWhiteSpace(txtCantCuota.Text) ||
            //    string.IsNullOrWhiteSpace(txtMontoCuota.Text) ||
            //    string.IsNullOrWhiteSpace(txtMontoTotal.Text))
            //{
            //    MessageBox.Show("Falta completar algun campo");
            //    return;
            //}

            Venta venta = new Venta
            {
                Cliente = new Cliente
                {
                    Dni = Convert.ToInt32(txtDniCliente.Text)
                },
                EsFinanciada = false, // TODO: cambiar al valor que tenga 
                FechaEntrega = Convert.ToDateTime(dtpFechaEntrega.Value),
                FechaVenta = Convert.ToDateTime(dtpFechaVenta.Value),
                Inmueble = new Inmueble
                {
                    Id = inmuebleSeleccionado.Id,
                },
                //MontoCuota = Convert.ToInt32(txtMontoCuota.Text),
                MontoTotal = Convert.ToInt32(txtMontoTotal.Text)
            };

            ventaService.Grabar(venta);

            MessageBox.Show("Se registro la venta");
        }
        
        private void frmABMCVenta_Load(object sender, EventArgs e)
        {
            this.btnSeleccionarFinanciacion.Enabled = false;
        }

        private void chkFinanciada_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkFinanciada.Checked)
            {
                this.btnSeleccionarFinanciacion.Enabled = true;
            }
            else
            {
                this.btnSeleccionarFinanciacion.Enabled = false;
                this.txtCantCuota.Clear();
                this.txtFinanciacion.Clear();
                this.txtMontoCuota.Clear();
            }
        }

        private float CalcularMontoCuota(int monto, int cantCuotas)
        {
            return monto / cantCuotas;
        }
    }
}
