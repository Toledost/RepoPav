﻿using Microsoft.Reporting.WinForms;
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

namespace TESTWF2020.Reportes.frmEstadisticas
{
    public partial class frmEstadisticaConsultaInmueble : Form
    {

        private ReporteService reporteService;
        private Dictionary<string, object> diccParametros;

        public frmEstadisticaConsultaInmueble()
        {
            InitializeComponent();
            reporteService = new ReporteService();
        }

        public frmEstadisticaConsultaInmueble(Dictionary<string, object> diccParametros)
        {
            InitializeComponent();
            reporteService = new ReporteService();
            this.diccParametros = diccParametros;
        }

        private void frmEstadisticaConsultaInmueble_Load(object sender, EventArgs e)
        {

            this.rptvEstadisticaConsultaInmueble.RefreshReport();
        }

        private void rptvEstadisticaConsultaInmueble_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = reporteService.GetConsultaInmuebleEstadistica(diccParametros);

            ReportDataSource ds = new ReportDataSource("DataSet1ConsultaxInmuebleEstadistica", tabla);

            rptvEstadisticaConsultaInmueble.LocalReport.DataSources.Clear();
            rptvEstadisticaConsultaInmueble.LocalReport.DataSources.Add(ds);
            rptvEstadisticaConsultaInmueble.LocalReport.Refresh();
        }
    }
}
