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
    public partial class frmABMCEmpleado : Form
    {
        #region Atributos y Constructores

        private bool esNuevo;
        private int legajo;
        private EmpleadoService empleadoService;
        
        public frmABMCEmpleado()
        {
            InitializeComponent();
            empleadoService = new EmpleadoService();
        }

        public frmABMCEmpleado(bool esNuevo)
        {
            InitializeComponent();
            this.esNuevo = esNuevo;
            empleadoService = new EmpleadoService();
        }

        public frmABMCEmpleado(bool esNuevo, int legajo)
        {
            InitializeComponent();
            this.esNuevo = esNuevo;
            empleadoService = new EmpleadoService();
            this.legajo = legajo;
        }

        #endregion

        private void frmABMCEmpleado_Load(object sender, EventArgs e)
        {
            if (esNuevo)
            {
                this.btnEditar.Enabled = false;
            }
            else
            {
                this.btnGrabar.Enabled = false;
                this.btnElegirUsuario.Enabled = false;
                HabilitarCampos(false);
                Empleado empleadoSeleccionado = empleadoService.GetByLegajo(legajo);
                CargarTextBox(empleadoSeleccionado);
            }
        }

        private void CargarTextBox(Empleado empleadoSeleccionado)
        {
            this.txtLegajo.Text = empleadoSeleccionado.Legajo.ToString();
            this.txtNombre.Text = empleadoSeleccionado.Nombre.ToString();
            this.txtApellido.Text = empleadoSeleccionado.Apellido.ToString();
            this.txtUsuario.Text = empleadoSeleccionado.Usuario.Nombre.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (Controls.OfType<TextBox>().Any(x => x.Visible && string.IsNullOrWhiteSpace(x.Text)))
            {
                MessageBox.Show("Falta completar algún campo.");
                return;
            }

            Empleado empleado = new Empleado
            {
                Legajo = Convert.ToInt32(this.txtLegajo.Text),
                Nombre = this.txtNombre.Text,
                Apellido = this.txtApellido.Text,
                Usuario = new Usuario
                {
                    Nombre = this.txtUsuario.Text
                }
            };

            if (esNuevo)
            {
                try
                {
                    empleadoService.Create(empleado);
                    MessageBox.Show("Empleado Creado.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El usuario ingresado es incorrecto. Error del tipo: " + ex.GetType().ToString());
                }
            }
            else
            {
                try
                {
                    empleadoService.Update(empleado, legajo);
                    MessageBox.Show("Empleado editado con éxito.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El usuario ingresado es incorrecto. Error del tipo: " + ex.GetType().ToString());
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos(true);
            this.btnGrabar.Enabled = true;
            this.btnElegirUsuario.Enabled = true;
        }

        private void HabilitarCampos(bool x)
        {
            this.txtLegajo.Enabled = x;
            this.txtNombre.Enabled = x;
            this.txtApellido.Enabled = x;
            this.txtUsuario.Enabled = x;
        }

        private void btnElegirUsuario_Click(object sender, EventArgs e)
        {
            frmGeneralUsuario frm = new frmGeneralUsuario(true);
            frm.ShowDialog();
            this.txtUsuario.Text = frm.NombreUsuarioSeleccionado;
        }
    }
}
