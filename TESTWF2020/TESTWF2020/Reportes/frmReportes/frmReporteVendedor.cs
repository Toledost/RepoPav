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

namespace TESTWF2020.Reportes.frmReportes
{
    public partial class frmReporteVendedor : Form
    {
        private ReporteService reporteService;
        private object txtN;
        private object txtNText;

        public frmReporteVendedor()
        {
            InitializeComponent();
            reporteService = new ReporteService();
        }

        private void frmReporteVendedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDInmobiliariaCasaFelizDataSetVendedor.DataTableVendedor' Puede moverla o quitarla según sea necesario.
            this.dataTableVendedorTableAdapter.Fill(this.bDInmobiliariaCasaFelizDataSetVendedor.DataTableVendedor);

            this.rptvVendedor.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var fecha = DateTime.Compare(dtpFechaDesde.Value.Date, dtpFechaHasta.Value.Date);
            if (fecha != 0)
            {
                if (dtpFechaDesde.Value > dtpFechaHasta.Value)
                {
                    MessageBox.Show("Fechas erroneas!!!");
                    return;
                }
            }

            var diccParametros = CrearDiccionario();
            DataTable tabla = reporteService.GetByFiltersRptVendedor(diccParametros);


            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No existe Vendedor con esas condiciones");
                dtpFechaDesde.Value = DateTime.Today;
                dtpFechaHasta.Value = DateTime.Today;
                txtNombreVendedor.Text = default;
            }
            else
            {
                this.dataTableVendedorBindingSource.DataSource = tabla;
                this.rptvVendedor.RefreshReport();
            }
        }
        private Dictionary<string, object> CrearDiccionario()
        {
            var dict = new Dictionary<string, object>();

            if (!string.IsNullOrWhiteSpace(this.txtNombreVendedor.Text))
            {
                dict.Add("nombreVendedor", txtNombreVendedor.Text);
            }
            if (!string.IsNullOrWhiteSpace(this.txtCalleInmueble.Text))
            {
                dict.Add("calleInmueble", txtCalleInmueble.Text);
            }
            if (!string.IsNullOrWhiteSpace(this.txtNroCalle.Text))
            {
                dict.Add("nroCalleInmueble", txtNroCalle.Text);
            }

            if (dtpFechaDesde.Value.Date != dtpFechaHasta.Value.Date)
            {
                dict.Add("fechaDesde", dtpFechaDesde.Value.ToString("yyyyMMdd"));
                dict.Add("fechaHasta", dtpFechaHasta.Value.ToString("yyyyMMdd"));
            }

            return dict;
        }
    }
}