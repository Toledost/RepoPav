﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TESTWF2020.Entities;
using TESTWF2020.BusinessLayer;

namespace TESTWF2020.GUILayer.ABM
{
    public partial class frmABMCConsultas : Form
    {
        private Consulta consulta;
        private ConsultaService consultaService;
        private EstadoConsultaService estadoConsultaService;
        private ViaDeConsultaService viaDeConsultaService;
        private MedioDeConocimientoService medioDeConocimientoService;
        private TipoTransaccionService tipoTransaccionService;

        public frmABMCConsultas()
        {
            InitializeComponent();
            this.consulta = new Consulta();
            this.consultaService = new ConsultaService();
            this.estadoConsultaService = new EstadoConsultaService();
            this.viaDeConsultaService = new ViaDeConsultaService();
            this.medioDeConocimientoService = new MedioDeConocimientoService();
            this.tipoTransaccionService = new TipoTransaccionService();
            

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmABMCConsultas_Load(object sender, EventArgs e)
        {
            CargarCombos();

        }

        private void CargarCombos()
        {
            this.cboEstadoConsulta.DataSource = estadoConsultaService.GetAll();
            this.cboEstadoConsulta.ValueMember = "Id";
            this.cboEstadoConsulta.DisplayMember = "Nombre";
            this.cboEstadoConsulta.SelectedIndex = -1;

            //this.cboViaConsulta.DataSource = viaDeConsultaService.GetAll();
            this.cboViaConsulta.ValueMember = "Id";
            this.cboViaConsulta.DisplayMember = "Nombre";
            this.cboViaConsulta.SelectedIndex = -1;

            this.cboIDMedioConocimiento.DataSource = medioDeConocimientoService.GetAll();
            this.cboIDMedioConocimiento.ValueMember = "Id";
            this.cboIDMedioConocimiento.DisplayMember = "Nombre";
            this.cboIDMedioConocimiento.SelectedIndex = -1;

            this.cboIDTipoTrans.DataSource = tipoTransaccionService.GetAll();
            this.cboIDTipoTrans.ValueMember = "Id";
            this.cboIDTipoTrans.DisplayMember = "Nombre";
            this.cboIDTipoTrans.SelectedIndex = -1;



        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.dgvConsultas.Rows.Clear();
            var consultas = consultaService.GetAll();

            foreach (var consulta in consultas)
            {
                this.dgvConsultas.Rows.Add(consulta.Id, consulta.FechaCreada, consulta.FechaCierre, 
                    consulta.UsuarioCreado, consulta.TipoTransaccion.Id, consulta.Inmueble.Id, 
                    consulta.MedioConocimiento.Id, consulta.ViaDeConsulta.Id,
                    consulta.EstadoConsulta.Id);
                    //consulta.DniCliente, consulta.NombreCliente, consulta.ApellidoCliente,
            }
        }
    }
}
