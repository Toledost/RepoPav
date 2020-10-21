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
        private Usuario usuarioLogueado;

        public frmABMCVenta(Usuario usuarioLogueado)
        {
            InitializeComponent();
            ventaService = new VentaService();
            this.usuarioLogueado = usuarioLogueado;
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
            if  (string.IsNullOrWhiteSpace(txtDniCliente.Text) ||
                txtDniCliente.Text == "0")
            {
                MessageBox.Show("Falta completar en DNI del cliente");
            }
            if (string.IsNullOrWhiteSpace(txtDireccionInmueble.Text) ||
                txtDireccionInmueble.Text == "0")
            {
                MessageBox.Show("Falta completar la direccion del inmueble");
            }
            if (string.IsNullOrWhiteSpace(txtMontoTotal.Text))
            {
                MessageBox.Show("Falta completar el monto total del inmueble");
            }
                //string.IsNullOrWhiteSpace(txtFinanciacion.Text) ||
                //string.IsNullOrWhiteSpace(txtCantCuota.Text) ||
                //string.IsNullOrWhiteSpace(txtMontoCuota.Text) ||
            

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
                MontoTotal = Convert.ToInt32(txtMontoTotal.Text),
                UsuarioVendedor = usuarioLogueado
            };

            var resultado = ventaService.Grabar(venta);
            if (resultado)
            {
                MessageBox.Show("Se registro la venta con éxito");
                this.Close();

            }
            else
            {
                MessageBox.Show("No se registro la venta");
            }

        }

        private void frmABMCVenta_Load(object sender, EventArgs e)
        {
            habilitarCampos(false);
        }

        private void habilitarCampos(bool valor)
        {
            this.btnSeleccionarFinanciacion.Enabled = valor;
            this.txtFinanciacion.Enabled = valor;
            this.txtCantCuota.Enabled = valor;
            this.txtMontoCuota.Enabled = valor;
        }

        private void btnSeleccionarConsulta_Click(object sender, EventArgs e)
        {
            frmABMCConsultas frmABMCConsultas = new frmABMCConsultas(true,usuarioLogueado);
            frmABMCConsultas.ShowDialog();
            if (frmABMCConsultas.consultaSeleccionada != null)
            {
                this.inmuebleSeleccionado = frmABMCConsultas.consultaSeleccionada.Inmueble;

                this.txtDniCliente.Text = frmABMCConsultas.consultaSeleccionada.Cliente.Dni.ToString();
                this.txtDireccionInmueble.Text = inmuebleSeleccionado.Calle + " " + inmuebleSeleccionado.CalleNumero;
                this.txtMontoTotal.Text = inmuebleSeleccionado.MontoVenta.ToString();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
