﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TESTWF2020.Reportes.frmEstadisticas;
using TESTWF2020.GUILayer.ABM;
using TESTWF2020.Reportes.frmReportes;

namespace TESTWF2020
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmEstadisticaConsultaInmueble());
        }
    }
}
