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
using TESTWF2020.Utilities;

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
            if (Validador.ValidarSalir())
            {
                this.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNombre.ReadOnly = false;
            txtPorcAumento.ReadOnly = false;
            txtCantCuotas.ReadOnly = false;
            btnGrabar.Enabled = true;
            btnEditar.Enabled = false;
        }

        private void frmDetalleFinanciacion_Load(object sender, EventArgs e)
        {
            if (idFinanciacionElegida > 0)
            {
                Financiacion financiacion = financiacionService.GetById(idFinanciacionElegida);
                CargarTextBox(financiacion);

                this.btnGrabar.Enabled = false;
            }
        }

        private void CargarTextBox(Financiacion financiacion)
        {
            txtNombre.ReadOnly = true;
            txtNombre.Text = financiacion.Nombre;

            txtPorcAumento.ReadOnly = true;
            txtPorcAumento.Text = financiacion.PorcentajeAumento.ToString();

            txtCantCuotas.ReadOnly = true;
            txtCantCuotas.Text = financiacion.CantidadCuotas.ToString();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (Validador.ValidarTextBox(txtNombre,txtPorcAumento, txtCantCuotas))
            {
                Financiacion newFinanciacion = new Financiacion
                {
                    Nombre = txtNombre.Text,
                    PorcentajeAumento = Convert.ToInt32(txtPorcAumento.Text),
                    CantidadCuotas = Convert.ToInt32(txtCantCuotas.Text)
                };

                if (idFinanciacionElegida == 0)
                {
                    var resultado = financiacionService.Create(newFinanciacion);
                    MessageBox.Show("Creado");
                }
                else
                {
                    newFinanciacion.IdFinanciacion = idFinanciacionElegida;
                    var res = financiacionService.Update(newFinanciacion);
                    MessageBox.Show("Editado");
                }
                this.Close();
            }

        }
    }
}
