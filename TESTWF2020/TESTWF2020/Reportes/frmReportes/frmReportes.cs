﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTWF2020.Reportes.frmReportes
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inmuebleEstado.RelacionInmuebleEstado' Puede moverla o quitarla según sea necesario.
            this.relacionInmuebleEstadoTableAdapter.Fill(this.inmuebleEstado.RelacionInmuebleEstado);

            this.reportViewer1.RefreshReport();
        }
    }
}
