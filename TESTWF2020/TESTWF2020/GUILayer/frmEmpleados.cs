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
    public partial class frmEmpleados : Form
    {
        private EmpleadoService empleadoService;

        public frmEmpleados()
        {
            InitializeComponent();
            this.empleadoService = new EmpleadoService();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            var dicParametros = CrearDiccionario();
            var empleados = empleadoService.GetByFilters(dicParametros);
            dgvEmpleados.DataSource = empleados;
        }

        private Dictionary<string, object> CrearDiccionario()
        {
            var dic = new Dictionary<string, object>();

            if (!string.IsNullOrWhiteSpace(this.txtNombre.Text))
            {
                dic.Add("nombre", txtNombre.Text);
            }

            if (!string.IsNullOrWhiteSpace(this.txtApellido.Text))
            {
                dic.Add("apellido", txtApellido.Text);
            }

            if (!string.IsNullOrWhiteSpace(this.txtUsuario.Text))
            {
                dic.Add("usuario", txtUsuario.Text);
            }

            return dic;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            this.txtNombre.Clear();
            this.txtApellido.Clear();
            this.txtUsuario.Clear();

            CargarGrilla();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 1)
            {
                var legajoSeleccionado = (int)this.dgvEmpleados.CurrentRow.Cells["legajo"].Value;
                empleadoService.Delete(legajoSeleccionado);
                btnConsultar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("No seleccionó ningún Emplado.");
            }
        }
    }
}
