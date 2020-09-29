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
        public frmABMCVenta()
        {
            InitializeComponent();
            ventaService = new VentaService();
        }

        private void btnSeleccionarInmueble_Click(object sender, EventArgs e)
        {
            frmInmuebles frmInmuebles = new frmInmuebles(true);
            frmInmuebles.ShowDialog();
            this.txtDireccionInmueble .Text = frmInmuebles.idInmuebleSeleccionado.ToString();
        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            frmConsultarClientes frmConsultarClientes = new frmConsultarClientes(true);
            frmConsultarClientes.ShowDialog();
            this.txtDniCliente .Text = frmConsultarClientes.dniClienteSeleccionado.ToString();
        }

        private void btnSeleccionarFinanciacion_Click(object sender, EventArgs e)
        {
            frmConsultaFinanciacion frmConsultaFinanciacion = new frmConsultaFinanciacion();
            frmConsultaFinanciacion.ShowDialog();
            this.txtFinanciacion.Text = frmConsultaFinanciacion.financiacionElegida.ToString();
            //this.txtMontoCuota.Text = 
            //this.txtMontoTotal.Text = 
            //this.txtFinanciacion.Text = frmConsultaFinanciacion.financiacionElegida.Nombre.ToString();
            //this.txtCantCuota.Text = frmConsultaFinanciacion.financiacionElegida.CantidadCuotas.ToString();

            //Financiacion financiacion = new Financiacion();
            //this.txtCantCuota.Text = financiacion.CantidadCuotas.ToString();

            // TODO: agregar busqueda del objeto ...
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFinanciacion.Text) || 
                string.IsNullOrWhiteSpace(txtDniCliente.Text) || 
                txtDniCliente.Text == "0" ||
                string.IsNullOrWhiteSpace(txtDireccionInmueble.Text) ||
                txtDireccionInmueble.Text == "0" ||
                string.IsNullOrWhiteSpace(txtCantCuota.Text) ||
                string.IsNullOrWhiteSpace(txtMontoCuota.Text) ||
                string.IsNullOrWhiteSpace(txtMontoTotal.Text))
            {
                MessageBox.Show("Falta completar algun campo");
                return;
            }
            Venta venta = new Venta
            {
                Cliente = new Cliente
                {
                    Dni = Convert.ToInt32(txtDniCliente.Text)
                },
                EsFinanciada = false, // TODO: cambiar al valor que tenga 
                FechaEntrega = Convert.ToDateTime(dtpFechaEntrega.Value),
                FechaVenta = Convert.ToDateTime(dtpFechaVenta.Value),
                //Financiacion = 
                Inmueble = new Inmueble
                {
                    Id = Convert.ToInt32(txtDireccionInmueble.Text) //TODO: falta que sea la direccion del inmuble
                },
                MontoCuota = Convert.ToInt32(txtMontoCuota.Text),
                MontoTotal = Convert.ToInt32(txtMontoTotal.Text)
            };

            ventaService.Grabar(venta);
            MessageBox.Show("Se registro la venta");

        }
    }
}
