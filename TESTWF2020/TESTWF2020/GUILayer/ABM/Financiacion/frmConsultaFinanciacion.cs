﻿using System;
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

namespace TESTWF2020.GUILayer.FORMFinanciacion
{
    public partial class frmConsultaFinanciacion : Form
    {
        private FinanciacionService financiacionService;
        private bool esParaElegir;
        
        public Financiacion FinanciacionElegida { get; set; }

        public frmConsultaFinanciacion()
        {
            InitializeComponent();
            financiacionService = new FinanciacionService();
        }

        public frmConsultaFinanciacion(bool esParaElegir)
        {
            InitializeComponent();
            financiacionService = new FinanciacionService();
            this.esParaElegir = esParaElegir;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            IList<Financiacion> listaFinanciacion = new List<Financiacion>();
            if (string.IsNullOrWhiteSpace(txtAumentoMaximo.Text) && string.IsNullOrWhiteSpace(txtCantidadCuotas.Text))
            {
                listaFinanciacion = financiacionService.GetAll();

            }
            else
            {
                var dicc = CrearDiccionario();
                listaFinanciacion = financiacionService.GetByFilters(dicc);
            }

            this.dgvFinanciacion.Rows.Clear();
            CargarGrilla(listaFinanciacion);
        }

        private Dictionary<string, object> CrearDiccionario()
        {
            Dictionary<string, object> dicc = new Dictionary<string, object>();

            if (!string.IsNullOrWhiteSpace(txtAumentoMaximo.Text))
            {
                dicc.Add("aumentoMaximo", txtAumentoMaximo.Text);
            }
            if (!string.IsNullOrWhiteSpace(txtCantidadCuotas.Text))
            {
                dicc.Add("cantidadCuotas", txtCantidadCuotas.Text);
            }

            return dicc;
        }

        private void CargarGrilla(IList<Financiacion> listaFinanciacion)
        {
            foreach (Financiacion financiacion in listaFinanciacion)
            {
                this.dgvFinanciacion.Rows.Add(
                    financiacion.IdFinanciacion, 
                    financiacion.Nombre, 
                    financiacion.PorcentajeAumento,
                    financiacion.CantidadCuotas);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmDetalleFinanciacion frmDetalleFinanciacion = new frmDetalleFinanciacion();
            frmDetalleFinanciacion.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int resultado = 0;

            int idFinanciacionElegida = (int)dgvFinanciacion.CurrentRow.Cells["IdFinanciacion"].Value;

            if (idFinanciacionElegida > -1)
            {
                resultado = financiacionService.Delete(idFinanciacionElegida);
            }

            if (resultado > 0)
            {
                MessageBox.Show("Borrado!");
                btnConsultar_Click(sender, e);
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {

            if(dgvFinanciacion.SelectedRows.Count == 1)
            {
                int idFinanciacionElegida = (int)dgvFinanciacion.CurrentRow.Cells["Id"].Value;

                frmDetalleFinanciacion frmDetalleFinanciacion = new frmDetalleFinanciacion(idFinanciacionElegida);
                this.Hide();
                frmDetalleFinanciacion.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("No seleccionó ninguna Financiación");
            }

        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            foreach(TextBox textbox in Controls.OfType<TextBox>())
            {
                textbox.Clear();
            }
        }

        private void btnElegir_Click(object sender, EventArgs e)
        {
            if (dgvFinanciacion.SelectedRows.Count == 1)
            {
                var idFinanciacionElegida = (int)dgvFinanciacion.CurrentRow.Cells["Id"].Value;
                this.FinanciacionElegida = financiacionService.GetById(idFinanciacionElegida);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se selecciono ninguna financiacion");
                btnConsultar_Click(sender, e);
            }
        }

        private void frmConsultaFinanciacion_Load(object sender, EventArgs e)
        {
            if (!esParaElegir)
            {
                this.btnElegir.Visible = false; 
            }
        }
    }
}
