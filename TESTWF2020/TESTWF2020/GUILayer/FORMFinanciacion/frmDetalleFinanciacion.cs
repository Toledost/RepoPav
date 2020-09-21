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
    public partial class frmDetalleFinanciacion : Form
    {
        private FinanciacionService financiacionService;
        private int idFinanciacionElegida;

        public frmDetalleFinanciacion()
        {
            InitializeComponent();
            financiacionService = new FinanciacionService();
        }

        public frmDetalleFinanciacion(int idFinanciacionElegida)
        {
            InitializeComponent();
            this.idFinanciacionElegida = idFinanciacionElegida;
            financiacionService = new FinanciacionService();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtPorcAumento.Enabled = true;
            txtCantCuotas.Enabled = true;
            btnGrabar.Enabled = true;
        }

        private void frmDetalleFinanciacion_Load(object sender, EventArgs e)
        {
            MessageBox.Show(idFinanciacionElegida.ToString());
            if (idFinanciacionElegida > 0)
            {
                Financiacion financiacion = financiacionService.GetById(idFinanciacionElegida);
                txtNombre.Text = financiacion.Nombre;
                txtPorcAumento.Text = financiacion.PorcentajeAumento.ToString();
                txtCantCuotas.Text = financiacion.CantidadCuotas.ToString();

            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (Controls.OfType<TextBox>().Any(x => string.IsNullOrWhiteSpace(x.Text)))
            {
                MessageBox.Show("Falta completar campos");
            }

            Financiacion newFinanciacion = new Financiacion
            {
                Nombre = txtNombre.Text,
                PorcentajeAumento = Convert.ToInt32(txtPorcAumento.Text),
                CantidadCuotas = Convert.ToInt32(txtCantCuotas.Text)
            };

            var resultado = financiacionService.Create(newFinanciacion);

            if (resultado == 1)
            {
                MessageBox.Show("Creado");
            }
        }
    }
}
