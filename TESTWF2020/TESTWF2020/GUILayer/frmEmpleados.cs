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
            var listaEmpleados = empleadoService.GetEmpleados();
            CargarGrilla(listaEmpleados);
        }

        private void CargarGrilla(IList<Empleado> lista)
        {
            foreach (var empleado in lista)
            {
                this.dgvEmpleados.Rows.Add(empleado.Legajo, empleado.Nombre, empleado.Apellido, empleado.Usuario.Nombre);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
