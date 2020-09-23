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
using TESTWF2020.GUILayer.ABM;

namespace TESTWF2020.GUILayer
{
    public partial class frmConsultarClientes : Form
    {
        ClienteService clienteService = new ClienteService();
        
        public frmConsultarClientes()
        {
            InitializeComponent();
            clienteService = new ClienteService();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            IList<Cliente> listaClientes = new List<Cliente>();
            

            if (string.IsNullOrWhiteSpace(txtDni.Text) && 
                string.IsNullOrWhiteSpace(txtNombre.Text) && 
                string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                listaClientes = clienteService.GetAll();                
            }

            else
            {
                var dicc = CrearDiccionario();
                listaClientes = clienteService.GetByFilters(dicc);
            }

            CargarGrilla(listaClientes);
        }

        private Dictionary<string, object> CrearDiccionario()
        {
            Dictionary<string, object> dicc = new Dictionary<string, object>();

            if (!string.IsNullOrWhiteSpace(txtDni.Text))
            {
                dicc.Add("dni", txtDni.Text);
            }

            if (!string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                dicc.Add("nombre", txtNombre.Text);
            }

            if (!string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                dicc.Add("apellido", txtApellido.Text);
            }

            return dicc;

        } 

       
        private void CargarGrilla(IList<Cliente> listaClientes)
        {
            this.dgvCliente.Rows.Clear();
            foreach (var cliente in listaClientes)
            {
                this.dgvCliente.Rows.Add(cliente.Dni, cliente.Nombre, cliente.Apellido, cliente.Mail, cliente.Telefono);
            }
            
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {

            if (dgvCliente.SelectedRows.Count == 1)
            {
                var dniClienteSeleccionado = (int)this.dgvCliente.CurrentRow.Cells["DNI"].Value;
                frmABMCliente frmDetalleCliente = new frmABMCliente(dniClienteSeleccionado);
                this.Hide();
                frmDetalleCliente.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("No seleccionó ningún Cliente");
            }
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmABMCliente frmDetalleCliente = new frmABMCliente();
            this.Hide();
            frmDetalleCliente.ShowDialog();
            this.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count == 1)
            {
                var clienteSeleccionado = (int)this.dgvCliente.CurrentRow.Cells["DNI"].Value;
                clienteService.Delete(clienteSeleccionado);
                MessageBox.Show("Cliente eliminado", "Eliminar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnBuscar_Click(sender, e);
                
            }
            else
            {
                MessageBox.Show("No seleccionó ningún Cliente");
            }
        }
    }
}
