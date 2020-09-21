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
            

            if (string.IsNullOrWhiteSpace(txtDni.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                listaClientes = clienteService.GetAll();
                
            }

            else
            {
                                
            }

            CargarGrilla(listaClientes);
        }

        private void CargarGrilla(IList<Cliente> listaClientes)
        {
            foreach (var cliente in listaClientes)
            {
                this.dgvCliente.Rows.Add(cliente.Dni, cliente.Nombre, cliente.Apellido, cliente.Mail, cliente.Telefono);
            }
            
        }
    }
}
