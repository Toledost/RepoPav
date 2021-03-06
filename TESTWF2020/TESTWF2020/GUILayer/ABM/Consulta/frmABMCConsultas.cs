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
        private Usuario usuarioLogueado;
        private bool esParaElegir;
        public Consulta consultaSeleccionada { get; private set; }

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

        public frmABMCConsultas(Usuario usuarioLogueado)
        {
            InitializeComponent();
            this.consulta = new Consulta();
            this.consultaService = new ConsultaService();
            this.estadoConsultaService = new EstadoConsultaService();
            this.viaDeConsultaService = new ViaDeConsultaService();
            this.medioDeConocimientoService = new MedioDeConocimientoService();
            this.tipoTransaccionService = new TipoTransaccionService();
            this.usuarioLogueado = usuarioLogueado;
        }

        public frmABMCConsultas(bool esParaElegir, Usuario usuarioLogueado)
        {
            InitializeComponent();
            this.consulta = new Consulta();
            this.consultaService = new ConsultaService();
            this.estadoConsultaService = new EstadoConsultaService();
            this.viaDeConsultaService = new ViaDeConsultaService();
            this.medioDeConocimientoService = new MedioDeConocimientoService();
            this.tipoTransaccionService = new TipoTransaccionService();
            this.esParaElegir = esParaElegir;
            this.usuarioLogueado = usuarioLogueado;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmABMCConsultas_Load(object sender, EventArgs e)
        {
            CargarCombos();
            this.btnElegir.Visible = false;

            if (esParaElegir)
            {
                this.btnElegir.Visible = true;
            }
        }

        private void CargarCombos()
        {
            this.cboEstadoConsulta.DataSource = estadoConsultaService.GetAll();
            this.cboEstadoConsulta.ValueMember = "Id";
            this.cboEstadoConsulta.DisplayMember = "Nombre";
            this.cboEstadoConsulta.SelectedIndex = -1;

            this.cboViaConsulta.DataSource = viaDeConsultaService.GetAll();
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
            //var consultas = consultaService.GetAll();
            var diccParametros = CrearDiccionario();
            var consultas = consultaService.GetByFilters(diccParametros);

            //this.dgvConsultas.DataSource = consultas;

            foreach (var consulta in consultas)
            {
                this.dgvConsultas.Rows.Add(consulta.Id, consulta.FechaCreada, consulta.FechaCierre,
                    consulta.UsuarioUltimaModificacion.Nombre, consulta.TipoTransaccion.Nombre, (string.Join(" ", consulta.Inmueble.Calle, consulta.Inmueble.CalleNumero)),
                    consulta.Cliente.Dni, consulta.Cliente.Nombre, consulta.Cliente.Apellido,
                    consulta.MedioConocimiento.Nombre, consulta.ViaDeConsulta.Nombre,
                    consulta.EstadoConsulta.Nombre);
            }
        }
        

        private Dictionary<string, object> CrearDiccionario()
        {
            var dicc = new Dictionary<string, object>();

            if (!string.IsNullOrWhiteSpace(this.txtIDConsulta.Text))
            {
                dicc.Add("idConsulta", txtIDConsulta.Text);
            }

            if (!string.IsNullOrWhiteSpace(this.txtUsuarioModificador.Text))
            {
                dicc.Add("usuarioUltimaModificacion", txtUsuarioModificador.Text);
            }

            if (!(cboIDTipoTrans.SelectedIndex == -1))
            {
                dicc.Add("tipoTransaccion", cboIDTipoTrans.SelectedValue);
            }

            if (!string.IsNullOrWhiteSpace(this.txtDireccionInmueble.Text))
            {
                dicc.Add("direccionInmueble", txtDireccionInmueble.Text);
            }

            if (!string.IsNullOrWhiteSpace(this.txtDNICliente.Text))
            {
                dicc.Add("dniCliente", txtDNICliente.Text);
            }

            if (!string.IsNullOrWhiteSpace(this.txtNombreCliente.Text))
            {
                dicc.Add("nombreCliente", txtNombreCliente.Text);
            }

            if (!string.IsNullOrWhiteSpace(this.txtApellidoCliente.Text))
            {
                dicc.Add("apellidoCliente", txtApellidoCliente.Text);
            }

            if (!(cboIDMedioConocimiento.SelectedIndex == -1))
            {
                dicc.Add("medioConocimiento", cboIDMedioConocimiento.SelectedValue);
            }

            if (!(cboViaConsulta.SelectedIndex == -1))
            {
                dicc.Add("viaDeConsulta", cboViaConsulta.SelectedValue);
            }

            if (!(cboEstadoConsulta.SelectedIndex == -1))
            {
                dicc.Add("estadoConsulta", cboEstadoConsulta.SelectedValue);
            }

            return dicc;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvConsultas.SelectedRows.Count == 1)
            {
                DialogResult dr = MessageBox.Show($"¿ Esta seguro de desea eliminar la Consulta N°: {this.dgvConsultas.CurrentRow.Cells["Id"].Value} ?", "Eliminar Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                
                if (dr == DialogResult.Yes)
                {
                    var idConsultaSeleccionada = (int)this.dgvConsultas.CurrentRow.Cells["Id"].Value;
                    consultaService.Delete(idConsultaSeleccionada, usuarioLogueado);
                    MessageBox.Show("Consulta eliminado", "Eliminar Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnConsultar_Click(sender, e);
                }
            }

            else
            {
                MessageBox.Show("No seleccionó ninguna Consulta");
            }
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            foreach (var textBox in Controls.OfType<TextBox>())
            {
                textBox.Clear();
            }
            cboIDTipoTrans.SelectedIndex = -1;
            cboIDMedioConocimiento.SelectedIndex = -1;
            cboEstadoConsulta.SelectedIndex = -1;
            cboViaConsulta.SelectedIndex = -1;
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (dgvConsultas.SelectedRows.Count == 1)
            {
                var idConsultaSeleccionada = (int)this.dgvConsultas.CurrentRow.Cells["Id"].Value;
                frmDetalleConsulta frmDetalleConsulta = new frmDetalleConsulta(idConsultaSeleccionada, usuarioLogueado);
                frmDetalleConsulta.ShowDialog();
                btnConsultar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("No seleccionó ninguna Consulta");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmDetalleConsulta frmDetalleConsulta = new frmDetalleConsulta(usuarioLogueado);
            frmDetalleConsulta.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void btnElegir_Click(object sender, EventArgs e)
        {
            if (dgvConsultas.SelectedRows.Count == 1)
            {
                this.consultaSeleccionada = consultaService.GetById((int)this.dgvConsultas.CurrentRow.Cells["Id"].Value);
                this.Close();
            }
        }
    }
}
