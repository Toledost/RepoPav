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
    public partial class frmDetalleMedioDeConocimiento : Form
    {
        private int idMedioSeleccionado;
        private MedioDeConocimientoService medioDeConocimientoService;

        public frmDetalleMedioDeConocimiento()
        {
            InitializeComponent();
            this.medioDeConocimientoService = new MedioDeConocimientoService();
        }

        public frmDetalleMedioDeConocimiento(int idMedioSeleccionado)
        {
            InitializeComponent();
            this.idMedioSeleccionado = idMedioSeleccionado;
            this.medioDeConocimientoService = new MedioDeConocimientoService();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Seguro que desea salir sin grabar cambios?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmDetalleMedioDeConocimiento_Load(object sender, EventArgs e)
        {
            if (idMedioSeleccionado != 0)
            {
                this.btnGrabar.Enabled = false;
                MedioDeConocimiento medioSeleccionado = medioDeConocimientoService.GetById(idMedioSeleccionado);
                CargarTextBox(medioSeleccionado);
                DeshabilitarCampos();
            }
            else
            {
                this.btnEditar.Enabled = false;
                //this.txtID.Enabled = false;
            }
        }

        private void DeshabilitarCampos()
        {
            foreach (var textBox in Controls.OfType<TextBox>())
            {
                textBox.ReadOnly = true;
            }
        }

        private void CargarTextBox(MedioDeConocimiento medioSeleccionado)
        {
            //this.txtID.Text = medioSeleccionado.Id.ToString();
            this.txtNombre.Text = medioSeleccionado.Nombre.ToString();
            this.txtDescripcion.Text = medioSeleccionado.Descripcion.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.btnGrabar.Enabled = true;
            this.btnEditar.Enabled = false;
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            foreach (var textBox in Controls.OfType<TextBox>())
            {
                textBox.ReadOnly = false;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (Controls.OfType<TextBox>().Any(x => x.Visible && string.IsNullOrWhiteSpace(x.Text)))

            {
                MessageBox.Show("Falta completar algún campo");
                return;
            }

            MedioDeConocimiento medio = new MedioDeConocimiento()
            {
                Id = (int)idMedioSeleccionado,
                Nombre = this.txtNombre.Text,
                Descripcion = this.txtDescripcion.Text
            };


            if (idMedioSeleccionado == 0)
            {
                medioDeConocimientoService.Create(medio);
                MessageBox.Show("Medio creado", "Crear Medio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                medioDeConocimientoService.Update(medio);
                MessageBox.Show("Medio actualizado", "Actualizar Medio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }
    }
}
