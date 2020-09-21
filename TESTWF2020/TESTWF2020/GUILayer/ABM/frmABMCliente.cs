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
    public partial class frmABMCliente : Form
    {
        private int dniClienteSeleccionado;
        private ClienteService clienteService;

        public frmABMCliente()
        {
            InitializeComponent();
            this.clienteService = new ClienteService();
        }

        public frmABMCliente(int dniClienteSeleccionado)
        {
            InitializeComponent();
            this.dniClienteSeleccionado = dniClienteSeleccionado;
            this.clienteService = new ClienteService();
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmABMCliente_Load(object sender, EventArgs e)
        {


            if (dniClienteSeleccionado != 0)
            {

                this.btnGrabar.Enabled = false;
                Cliente clienteSeleccionado = clienteService.GetByDni(dniClienteSeleccionado);
                CargarTextBox(clienteSeleccionado);
                DeshabilitarCampos();

            }
                       
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.btnGrabar.Enabled = true;
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            foreach (var textBox in Controls.OfType<TextBox>())
            {
                textBox.ReadOnly = false;
            }            
        }

        private void DeshabilitarCampos()
        {
            foreach (var textBox in Controls.OfType<TextBox>())
            {
                textBox.ReadOnly = true;
            }
        }

        private void CargarTextBox(Cliente clienteSeleccionado)
        {
            this.txtDni.Text = clienteSeleccionado.Dni.ToString();
            this.txtNombre.Text = clienteSeleccionado.Nombre.ToString();
            this.txtApellido.Text = clienteSeleccionado.Apellido.ToString();
            this.txtMail.Text = clienteSeleccionado.Mail.ToString();
            this.txtTelefono.Text = clienteSeleccionado.Telefono.ToString();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (Controls.OfType<TextBox>().Any(x => x.Visible && string.IsNullOrWhiteSpace(x.Text))
                || Controls.OfType<ComboBox>().Any(x => x.SelectedIndex < 0))
            {
                MessageBox.Show("Falta completar algún campo");
                return;
            }

            Cliente cliente = new Cliente()
            {
                Dni = Convert.ToInt32(this.txtDni.Text),
                Nombre = this.txtNombre.Text,
                Apellido = this.txtApellido.Text,
                Mail = this.txtMail.Text,
                Telefono = Convert.ToInt32(this.txtTelefono.Text)
            };


            if (dniClienteSeleccionado == 0)
            {
                clienteService.Create(cliente);
                MessageBox.Show("Cliente creado", "Crear cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                clienteService.Update(cliente);
                MessageBox.Show("Cliente actualizado", "Actualizar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }
    }
}
