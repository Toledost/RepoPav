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
using TESTWF2020.GUILayer.ABM;

namespace TESTWF2020.GUILayer
{
    public partial class frmInmuebles : Form
    {
        #region private y constructor

        /// <summary>
        /// private que nos permite acceder a la capa de servicio
        /// </summary>
        private InmuebleService inmuebleService;
        private TipoInmuebleService tipoInmuebleService;
        private bool esParaElegir;
        public Inmueble InmuebleSeleccionado { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public frmInmuebles()
        {
            InitializeComponent();
            inmuebleService = new InmuebleService();
            tipoInmuebleService = new TipoInmuebleService();

        }
        public frmInmuebles(bool esParaElegir)
        {
            InitializeComponent();
            inmuebleService = new InmuebleService();
            tipoInmuebleService = new TipoInmuebleService();
            this.esParaElegir = esParaElegir;
        }

        #endregion

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            var dictParametros = CrearDiccionario();
            var inmuebles = inmuebleService.GetByFilters(dictParametros);
            
            this.dgvInmuebles.DataSource = inmuebles;
            this.dgvInmuebles.Columns["CalleNumero"].HeaderText = "Numero";
        }

        private Dictionary<string, object> CrearDiccionario()
        {
            var dict = new Dictionary<string, object>();

            if (!string.IsNullOrWhiteSpace(this.txtCalle.Text))
            {
                dict.Add("calle", txtCalle.Text);
            }
            if (!string.IsNullOrWhiteSpace(this.txtMetrosCuadradosMin.Text))
            {
                dict.Add("mtsMin", txtMetrosCuadradosMin.Text);
            }
            if (!string.IsNullOrWhiteSpace(this.txtMetrosCuadradosMax.Text))
            {
                dict.Add("mtsMax", txtMetrosCuadradosMax.Text);
            }
            if (!string.IsNullOrWhiteSpace(this.txtBaños.Text))
            {
                dict.Add("baños", txtBaños.Text);
            }
            if (!string.IsNullOrWhiteSpace(this.txtHabitaciones.Text))
            {
                dict.Add("habitaciones", txtHabitaciones.Text);
            }
            if (!string.IsNullOrWhiteSpace(this.txtMontoVtaMin.Text))
            {
                dict.Add("montoVtaMin", txtMontoVtaMin.Text);
            }
            if (!string.IsNullOrWhiteSpace(this.txtMontoVtaMax.Text))
            {
                dict.Add("montoVtaMax", txtMontoVtaMax.Text);
            }
            if (!(cboTipo.SelectedIndex == -1))
            {
                dict.Add("tipoInmueble", cboTipo.SelectedValue);
            }

            return dict;
        }

        private void frmInmuebles_Load(object sender, EventArgs e)
        {
            CargarComboTipo();
            if (!esParaElegir)
            {
                btnElegir.Visible = false;
            }
        }

        private void CargarComboTipo()
        {
            this.cboTipo.DataSource = tipoInmuebleService.GetAll();
            this.cboTipo.ValueMember = "id";
            this.cboTipo.DisplayMember = "nombre";
            this.cboTipo.SelectedIndex = -1;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmABMCInmueble frmABMCInmueble = new frmABMCInmueble(true);
            frmABMCInmueble.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (dgvInmuebles.SelectedRows.Count == 1)
            {
                var idInmuebleSeleccionado = (int)this.dgvInmuebles.CurrentRow.Cells["Id"].Value;
                frmABMCInmueble frmABMCInmueble = new frmABMCInmueble(false, idInmuebleSeleccionado);
                frmABMCInmueble.ShowDialog();
                btnConsultar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("No seleccionó ningún Inmueble");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInmuebles.SelectedRows.Count == 1)
            {
                var idInmuebleSeleccionado = (int)this.dgvInmuebles.CurrentRow.Cells["Id"].Value;
                inmuebleService.Delete(idInmuebleSeleccionado);
                btnConsultar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("No seleccionó ningún Inmueble");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            foreach (var textBox in Controls.OfType<TextBox>())
            {
                textBox.Clear();
            }
            cboTipo.SelectedIndex = -1;
        }

        private void btnElegir_Click(object sender, EventArgs e)
        {
            if (dgvInmuebles.SelectedRows.Count == 1)
            {
                InmuebleSeleccionado = inmuebleService.GetById((int)dgvInmuebles.CurrentRow.Cells["Id"].Value);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se selecciono ningun inmueble");
                btnConsultar_Click(sender, e);
            }
        }
    }
}
