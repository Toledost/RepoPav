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
    public partial class frmDetalleNuevoViaConsulta : Form
    {
        private bool esNuevo;
        private int idViaConsulta;
        private ViaDeConsultaService viaDeConsultaService;

        public frmDetalleNuevoViaConsulta()
        {
            InitializeComponent();
            viaDeConsultaService = new ViaDeConsultaService();
    }
        public frmDetalleNuevoViaConsulta(bool esNuevo)
        {
            InitializeComponent();
            this.esNuevo = esNuevo;
            viaDeConsultaService = new ViaDeConsultaService();
        }
        public frmDetalleNuevoViaConsulta(bool esNuevo, int idViaConsulta)
        {
            InitializeComponent();
            this.esNuevo = esNuevo;
            this.idViaConsulta = idViaConsulta;
            viaDeConsultaService = new ViaDeConsultaService();
        }

        private void frmDetalleNuevoViaConsulta_Load(object sender, EventArgs e)
        {
            if (esNuevo)
            {
                this.btnEditar.Enabled = false;
                this.txtIdViaDeConsulta.Enabled = false;
                
            }
            else
            {
                this.btnGrabar.Enabled = false;
                ViaDeConsulta viaDeConsulta = viaDeConsultaService.GetById(idViaConsulta);
                CargarTextBox(viaDeConsulta);
                DeshabilitarCampos();
            }
            
        }

        private void DeshabilitarCampos()
        {
            foreach (var textBox in Controls.OfType<TextBox>())
            {
                textBox.ReadOnly = true;
            }
        }

        private void CargarTextBox(ViaDeConsulta viaDeConsulta)
        {
            this.txtNombre.Text = viaDeConsulta.Nombre.ToString();
            this.txtIdViaDeConsulta.Text = viaDeConsulta.Id.ToString();
            this.txtDescripcion.Text = viaDeConsulta.Descripcion.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.btnGrabar.Enabled = true;
            this.txtIdViaDeConsulta.Enabled = false;
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            foreach (var textBox in Controls.OfType<TextBox>())
            {
                if (textBox.Name == "txtIdViaConsulta" &&
                    textBox.Name == "txtNombre" &&
                    textBox.Name == "txtDescripcion")
                {
                    continue;
                }
                textBox.ReadOnly = false;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //if (Controls.OfType<TextBox>().Any(x => x.Visible && string.IsNullOrWhiteSpace(x.Text))
            //    || Controls.OfType<ComboBox>().Any(x => x.SelectedIndex < 0))
            if(string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Falta completar algún campo");
                return;
            }

            ViaDeConsulta viaDeConsulta = new ViaDeConsulta
            {
                //Id = Convert.ToInt32(this.txtIdViaDeConsulta.Text),
                Nombre = this.txtNombre.Text,
                Descripcion = this.txtDescripcion.Text
            };

            if (esNuevo)
            {
                
                viaDeConsultaService.Create(viaDeConsulta);
                MessageBox.Show("Creado");
                this.Close();
                
            }
            else
            {
                viaDeConsultaService.UpDate(viaDeConsulta);
                MessageBox.Show("Editado");
                this.Close();
                
            }
        }
    }
}
