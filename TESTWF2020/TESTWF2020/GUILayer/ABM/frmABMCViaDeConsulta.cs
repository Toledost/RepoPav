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
    public partial class frmABMCViaDeConsulta : Form
    {
        ViaDeConsultaService viaDeConsultaService;
        public frmABMCViaDeConsulta()
        {
            InitializeComponent();
            viaDeConsultaService = new ViaDeConsultaService();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var viasDeConsultas = viaDeConsultaService.GetAll();
            CargarGrilla(viasDeConsultas);
        }

        private void CargarGrilla(IList<ViaDeConsulta> viasDeConsultas)
        {
            foreach (var viaDeConsulta in viasDeConsultas)
            {
                this.dgvViaDeConsultas.Rows.Add(viaDeConsulta.Id,viaDeConsulta.Nombre,viaDeConsulta.Descripcion);
            }
        }
    }
}
