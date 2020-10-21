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

namespace TESTWF2020.GUILayer.ABM
{
    public partial class frmVentaGeneral : Form
    {
        private VentaService ventaService;
        public frmVentaGeneral()
        {
            InitializeComponent();
            this.ventaService = new VentaService();
        }

        private void btnElegirCliente_Click(object sender, EventArgs e)
        {
            frmConsultarClientes frmConsultarClientes = new frmConsultarClientes(true);
            frmConsultarClientes.ShowDialog();
            this.txtDNICliente.Text = frmConsultarClientes.dniClienteSeleccionado.ToString();
        }

        private void btnCuotas_Click(object sender, EventArgs e)
        {
            var idVentaSeleccionada = (int)this.dgvVenta.CurrentRow.Cells["idVenta"].Value;
            frmCuotasDetalle frmCuotasDetalle = new frmCuotasDetalle(idVentaSeleccionada);
            frmCuotasDetalle.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvVenta.Rows.Clear();

            IList<Venta> ventas = string.IsNullOrWhiteSpace(this.txtDNICliente.Text) ? ventaService.GetAll() : ventaService.GetByDni(txtDNICliente.Text);

            foreach (var venta in ventas)
            {
                dgvVenta.Rows.Add(venta.IdVenta, venta.MontoCuota, (venta.Inmueble.Calle + " " + venta.Inmueble.CalleNumero), venta.Cliente.Dni, (venta.Cliente.Nombre + " " + venta.Cliente.Apellido), venta.EsFinanciada ? "Sí" : "No", (venta.EmpleadoVendedor.Nombre + " " + venta.EmpleadoVendedor.Apellido), venta.UsuarioVendedor.Nombre, venta.FechaVenta, venta.FechaEntrega);
            }
        }

        private void btnBorrarComprador_Click(object sender, EventArgs e)
        {
            this.txtDNICliente.Clear();
        }

        private void dgvVenta_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVenta.CurrentRow.Cells["esFinanciada"].Value.ToString() == "Sí")
                btnCuotas.Enabled = true;
            else
                btnCuotas.Enabled = false;
        }
    }
}
