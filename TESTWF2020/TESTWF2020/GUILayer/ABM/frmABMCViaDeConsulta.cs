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
    public partial class frmABMCViaDeConsulta : Form
    {
        ViaDeConsultaService viaDeConsultaService;
        private bool esNuevo;

        public frmABMCViaDeConsulta()
        {
            InitializeComponent();
            viaDeConsultaService = new ViaDeConsultaService();
            this.esNuevo = esNuevo;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.dgvViaDeConsultas.Rows.Clear();
            var viasDeConsultas = viaDeConsultaService.GetAll();
            CargarGrilla(viasDeConsultas);
        }

        private void CargarGrilla(IList<ViaDeConsulta> viasDeConsultas)
        {
            foreach (var viaDeConsulta in viasDeConsultas)
            {
                this.dgvViaDeConsultas.Rows.Add(viaDeConsulta.Id,viaDeConsulta.Nombre,viaDeConsulta.Descripcion);
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (dgvViaDeConsultas.SelectedRows.Count == 1)
            {
                var viaConsultaSeleccionada = (int)this.dgvViaDeConsultas.CurrentRow.Cells["Id"].Value;
                frmDetalleNuevoViaConsulta frmDetalleNuevoViaConsulta = new frmDetalleNuevoViaConsulta(false, viaConsultaSeleccionada);
                frmDetalleNuevoViaConsulta.ShowDialog();
            }
            else
            {
                MessageBox.Show("No seleccionó ninguna via de consulta");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmDetalleNuevoViaConsulta frmDetalleNuevoViaConsulta = new frmDetalleNuevoViaConsulta(true);
            frmDetalleNuevoViaConsulta.ShowDialog();
        }
    }
}
