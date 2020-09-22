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
    public partial class frmABMCMedioDeConocimiento : Form
    {

        private MedioDeConocimientoService medioDeConocimientoService;
        public frmABMCMedioDeConocimiento()
        {
            InitializeComponent();
            medioDeConocimientoService = new MedioDeConocimientoService();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var medios = medioDeConocimientoService.GetAll();

            foreach (var medio in medios)
            {
                this.dgvMedioConocimiento.Rows.Add(medio.Id, medio.Nombre, medio.Descripcion);
            }           
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (dgvMedioConocimiento.SelectedRows.Count == 1)
            {
                var idMedioSeleccionado = (int)this.dgvMedioConocimiento.CurrentRow.Cells["ID"].Value;
                frmDetalleMedioDeConocimiento frmABMCInmueble = new frmDetalleMedioDeConocimiento (idMedioSeleccionado);
                frmABMCInmueble.ShowDialog();
            }
            else
            {
                MessageBox.Show("No seleccionó ningún Medio");
            }
        }
    }
}
