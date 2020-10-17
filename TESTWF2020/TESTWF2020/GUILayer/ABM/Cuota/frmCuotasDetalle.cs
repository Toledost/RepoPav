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
    public partial class frmCuotasDetalle : Form
    {
        private int idVentaSeleccionada;
        private CuotaService cuotaService;

        public frmCuotasDetalle()
        {
            InitializeComponent();
            this.cuotaService = new CuotaService();
        }

        public frmCuotasDetalle(int idVentaSeleccionada)
        {
            InitializeComponent();
            this.cuotaService = new CuotaService();
            this.idVentaSeleccionada = idVentaSeleccionada;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCuotasDetalle_Load(object sender, EventArgs e)
        {
            IList<Cuota> cuotas = cuotaService.GetByVenta(idVentaSeleccionada);
            foreach (var cuota in cuotas)
            {
                dgvCuotas.Rows.Add(cuota.NumeroCuota, cuota.FechaPago, cuota.FechaVencimiento, cuota.Pagado);
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (dgvCuotas.SelectedRows.Count > 0)
            {
                IList<int> numeroCuotas = new List<int>();
                foreach (DataGridViewRow row in dgvCuotas.SelectedRows)
                {
                    numeroCuotas.Add((int)row.Cells["nroCuota"].Value);
                }

                cuotaService.RegistrarPagoCuota(idVentaSeleccionada, numeroCuotas);

                MessageBox.Show("Cuotas Pagadas!");
                this.Close();
            }
        }
    }
}
