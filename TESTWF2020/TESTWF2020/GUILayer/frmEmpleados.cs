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
    public partial class frmEmpleados : Form
    {
        #region Atributos y Constructores

        private EmpleadoService empleadoService;
        public frmEmpleados()
        {
            InitializeComponent();
            this.empleadoService = new EmpleadoService();
        }

        #endregion

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmABMCEmpleado frmABMCEmpleado = new frmABMCEmpleado(true);
            frmABMCEmpleado.ShowDialog();
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
        
        private void CargarGrilla()
        {
            var dicParametros = CrearDiccionario();
            var empleados = empleadoService.GetByFilters(dicParametros);
            dgvEmpleados.DataSource = empleados;
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 1)
            {
                var legajoSeleccionado = (int)this.dgvEmpleados.CurrentRow.Cells["legajo"].Value;
                frmABMCEmpleado frmABMCEmpleado = new frmABMCEmpleado(false, legajoSeleccionado);
                frmABMCEmpleado.ShowDialog();
            }
            else
            {
                MessageBox.Show("No seleccionó ningún Emplado.");
            }
        }
    }
}
