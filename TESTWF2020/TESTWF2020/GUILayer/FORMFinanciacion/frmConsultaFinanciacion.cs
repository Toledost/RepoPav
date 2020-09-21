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

namespace TESTWF2020.GUILayer.FORMFinanciacion
{
    public partial class frmConsultaFinanciacion : Form
    {
        private FinanciacionService financiacionService;
        public frmConsultaFinanciacion()
        {
            InitializeComponent();
            financiacionService = new FinanciacionService();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            IList<Financiacion> listaFinanciacion = financiacionService.GetAll();

            CargarGrilla(listaFinanciacion);
        }

        private void CargarGrilla(IList<Financiacion> listaFinanciacion)
        {
            foreach (Financiacion financiacion in listaFinanciacion)
            {
                this.dgvFinanciacion.Rows.Add(
                    financiacion.IdFinanciacion, 
                    financiacion.Nombre, 
                    financiacion.PorcentajeAumento,
                    financiacion.CantidadCuotas);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmDetalleFinanciacion frmDetalleFinanciacion = new frmDetalleFinanciacion();
            frmDetalleFinanciacion.ShowDialog();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int resultado = 0;

            int idFinanciacionElegida = (int)dgvFinanciacion.CurrentRow.Cells["IdFinanciacion"].Value;

            if (idFinanciacionElegida > -1)
            {
                resultado = financiacionService.Delete(idFinanciacionElegida);
            }

            if (resultado > 0)
            {
                MessageBox.Show("Borrado!");
                btnConsultar_Click(sender, e);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int idFinanciacionElegida = (int)dgvFinanciacion.CurrentRow.Cells["IdFinanciacion"].Value;

                if (idFinanciacionElegida > -1)
                {
                    frmDetalleFinanciacion frmDetalleFinanciacion = new frmDetalleFinanciacion(idFinanciacionElegida);
                    frmDetalleFinanciacion.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
