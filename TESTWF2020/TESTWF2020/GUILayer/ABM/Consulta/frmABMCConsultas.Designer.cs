﻿namespace TESTWF2020.GUILayer.ABM
{
    partial class frmABMCConsultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioUltimaModificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoTransaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inmueble = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medioConocimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viaConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblFechaCreada = new System.Windows.Forms.Label();
            this.lblUserModificador = new System.Windows.Forms.Label();
            this.lblTipoTrans = new System.Windows.Forms.Label();
            this.lblDireccionnuemble = new System.Windows.Forms.Label();
            this.lblDNICliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.lblIDMedioConocomiento = new System.Windows.Forms.Label();
            this.lblIDEstadoConsulta = new System.Windows.Forms.Label();
            this.lblIDviaConsulta = new System.Windows.Forms.Label();
            this.lblFechaCierre = new System.Windows.Forms.Label();
            this.txtIDConsulta = new System.Windows.Forms.TextBox();
            this.txtUsuarioModificador = new System.Windows.Forms.TextBox();
            this.txtDireccionInmueble = new System.Windows.Forms.TextBox();
            this.txtDNICliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.cboIDTipoTrans = new System.Windows.Forms.ComboBox();
            this.cboIDMedioConocimiento = new System.Windows.Forms.ComboBox();
            this.cboViaConsulta = new System.Windows.Forms.ComboBox();
            this.cboEstadoConsulta = new System.Windows.Forms.ComboBox();
            this.dtpFechaCreada = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaCierre = new System.Windows.Forms.DateTimePicker();
            this.btnElegir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.AllowUserToAddRows = false;
            this.dgvConsultas.AllowUserToDeleteRows = false;
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fechaCreada,
            this.fechaCierre,
            this.usuarioUltimaModificacion,
            this.tipoTransaccion,
            this.inmueble,
            this.dniCliente,
            this.nombreCliente,
            this.apellidoCliente,
            this.medioConocimiento,
            this.viaConsulta,
            this.estadoConsulta});
            this.dgvConsultas.Location = new System.Drawing.Point(12, 208);
            this.dgvConsultas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvConsultas.MultiSelect = false;
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.ReadOnly = true;
            this.dgvConsultas.RowHeadersWidth = 62;
            this.dgvConsultas.RowTemplate.Height = 28;
            this.dgvConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultas.Size = new System.Drawing.Size(1337, 460);
            this.dgvConsultas.TabIndex = 44;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // fechaCreada
            // 
            this.fechaCreada.HeaderText = "Fecha Creada";
            this.fechaCreada.MinimumWidth = 8;
            this.fechaCreada.Name = "fechaCreada";
            this.fechaCreada.ReadOnly = true;
            this.fechaCreada.Width = 150;
            // 
            // fechaCierre
            // 
            this.fechaCierre.HeaderText = "Fecha Cierre";
            this.fechaCierre.MinimumWidth = 8;
            this.fechaCierre.Name = "fechaCierre";
            this.fechaCierre.ReadOnly = true;
            this.fechaCierre.Width = 150;
            // 
            // usuarioUltimaModificacion
            // 
            this.usuarioUltimaModificacion.HeaderText = "Usuario Ultima Modificacion";
            this.usuarioUltimaModificacion.MinimumWidth = 8;
            this.usuarioUltimaModificacion.Name = "usuarioUltimaModificacion";
            this.usuarioUltimaModificacion.ReadOnly = true;
            this.usuarioUltimaModificacion.Width = 150;
            // 
            // tipoTransaccion
            // 
            this.tipoTransaccion.HeaderText = "Tipo transaccion";
            this.tipoTransaccion.MinimumWidth = 8;
            this.tipoTransaccion.Name = "tipoTransaccion";
            this.tipoTransaccion.ReadOnly = true;
            this.tipoTransaccion.Width = 150;
            // 
            // inmueble
            // 
            this.inmueble.HeaderText = "inmueble";
            this.inmueble.MinimumWidth = 8;
            this.inmueble.Name = "inmueble";
            this.inmueble.ReadOnly = true;
            this.inmueble.Width = 150;
            // 
            // dniCliente
            // 
            this.dniCliente.HeaderText = "DNI Cliente";
            this.dniCliente.MinimumWidth = 8;
            this.dniCliente.Name = "dniCliente";
            this.dniCliente.ReadOnly = true;
            this.dniCliente.Width = 150;
            // 
            // nombreCliente
            // 
            this.nombreCliente.HeaderText = "Nombre Cliente";
            this.nombreCliente.MinimumWidth = 8;
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.ReadOnly = true;
            this.nombreCliente.Width = 150;
            // 
            // apellidoCliente
            // 
            this.apellidoCliente.HeaderText = "Apellido Cliente";
            this.apellidoCliente.MinimumWidth = 8;
            this.apellidoCliente.Name = "apellidoCliente";
            this.apellidoCliente.ReadOnly = true;
            this.apellidoCliente.Width = 150;
            // 
            // medioConocimiento
            // 
            this.medioConocimiento.HeaderText = "Medio Conocimieneto";
            this.medioConocimiento.MinimumWidth = 8;
            this.medioConocimiento.Name = "medioConocimiento";
            this.medioConocimiento.ReadOnly = true;
            this.medioConocimiento.Width = 150;
            // 
            // viaConsulta
            // 
            this.viaConsulta.HeaderText = "Via de Consulta";
            this.viaConsulta.MinimumWidth = 8;
            this.viaConsulta.Name = "viaConsulta";
            this.viaConsulta.ReadOnly = true;
            this.viaConsulta.Width = 150;
            // 
            // estadoConsulta
            // 
            this.estadoConsulta.HeaderText = "Estado de Consulta";
            this.estadoConsulta.MinimumWidth = 8;
            this.estadoConsulta.Name = "estadoConsulta";
            this.estadoConsulta.ReadOnly = true;
            this.estadoConsulta.Width = 150;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::TESTWF2020.Properties.Resources.icons8_cerrar_ventana_48;
            this.btnSalir.Location = new System.Drawing.Point(1244, 681);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 62);
            this.btnSalir.TabIndex = 43;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::TESTWF2020.Properties.Resources.icons8_eliminar_48;
            this.btnEliminar.Location = new System.Drawing.Point(252, 681);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 62);
            this.btnEliminar.TabIndex = 42;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Image = global::TESTWF2020.Properties.Resources.icons8_ver_archivo_40;
            this.btnDetalle.Location = new System.Drawing.Point(131, 681);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(100, 62);
            this.btnDetalle.TabIndex = 41;
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::TESTWF2020.Properties.Resources.icons8_añadir_48;
            this.btnNuevo.Location = new System.Drawing.Point(12, 681);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 62);
            this.btnNuevo.TabIndex = 40;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Image = global::TESTWF2020.Properties.Resources.icons8_borrar_48;
            this.btnLimpiarFiltros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(1171, 18);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(166, 61);
            this.btnLimpiarFiltros.TabIndex = 46;
            this.btnLimpiarFiltros.Text = "Limpiar \r\nFiltros";
            this.btnLimpiarFiltros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = global::TESTWF2020.Properties.Resources.icons8_fácil_de_encontrar_40;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(1170, 93);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(167, 59);
            this.btnConsultar.TabIndex = 45;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(148, 21);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 24);
            this.lblID.TabIndex = 47;
            this.lblID.Text = "ID:";
            // 
            // lblFechaCreada
            // 
            this.lblFechaCreada.AutoSize = true;
            this.lblFechaCreada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCreada.Location = new System.Drawing.Point(35, 54);
            this.lblFechaCreada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaCreada.Name = "lblFechaCreada";
            this.lblFechaCreada.Size = new System.Drawing.Size(145, 24);
            this.lblFechaCreada.TabIndex = 48;
            this.lblFechaCreada.Text = "Fecha creada:";
            // 
            // lblUserModificador
            // 
            this.lblUserModificador.AutoSize = true;
            this.lblUserModificador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserModificador.Location = new System.Drawing.Point(35, 119);
            this.lblUserModificador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserModificador.Name = "lblUserModificador";
            this.lblUserModificador.Size = new System.Drawing.Size(148, 48);
            this.lblUserModificador.TabIndex = 49;
            this.lblUserModificador.Text = "Usuario ultima \r\nmodificacion:";
            // 
            // lblTipoTrans
            // 
            this.lblTipoTrans.AutoSize = true;
            this.lblTipoTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoTrans.Location = new System.Drawing.Point(390, 18);
            this.lblTipoTrans.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoTrans.Name = "lblTipoTrans";
            this.lblTipoTrans.Size = new System.Drawing.Size(179, 24);
            this.lblTipoTrans.TabIndex = 50;
            this.lblTipoTrans.Text = "Tipo Transaccion:";
            // 
            // lblDireccionnuemble
            // 
            this.lblDireccionnuemble.AutoSize = true;
            this.lblDireccionnuemble.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionnuemble.Location = new System.Drawing.Point(371, 54);
            this.lblDireccionnuemble.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccionnuemble.Name = "lblDireccionnuemble";
            this.lblDireccionnuemble.Size = new System.Drawing.Size(198, 24);
            this.lblDireccionnuemble.TabIndex = 51;
            this.lblDireccionnuemble.Text = "Direccion Inmueble:";
            // 
            // lblDNICliente
            // 
            this.lblDNICliente.AutoSize = true;
            this.lblDNICliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNICliente.Location = new System.Drawing.Point(448, 89);
            this.lblDNICliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNICliente.Name = "lblDNICliente";
            this.lblDNICliente.Size = new System.Drawing.Size(121, 24);
            this.lblDNICliente.TabIndex = 52;
            this.lblDNICliente.Text = "DNI Cliente:";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(407, 125);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(162, 24);
            this.lblNombreCliente.TabIndex = 53;
            this.lblNombreCliente.Text = "Nombre Cliente:";
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoCliente.Location = new System.Drawing.Point(825, 18);
            this.lblApellidoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(164, 24);
            this.lblApellidoCliente.TabIndex = 54;
            this.lblApellidoCliente.Text = "Apellido Cliente:";
            // 
            // lblIDMedioConocomiento
            // 
            this.lblIDMedioConocomiento.AutoSize = true;
            this.lblIDMedioConocomiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDMedioConocomiento.Location = new System.Drawing.Point(753, 51);
            this.lblIDMedioConocomiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDMedioConocomiento.Name = "lblIDMedioConocomiento";
            this.lblIDMedioConocomiento.Size = new System.Drawing.Size(236, 24);
            this.lblIDMedioConocomiento.TabIndex = 55;
            this.lblIDMedioConocomiento.Text = "Medio de conocimiento:";
            // 
            // lblIDEstadoConsulta
            // 
            this.lblIDEstadoConsulta.AutoSize = true;
            this.lblIDEstadoConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDEstadoConsulta.Location = new System.Drawing.Point(795, 122);
            this.lblIDEstadoConsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDEstadoConsulta.Name = "lblIDEstadoConsulta";
            this.lblIDEstadoConsulta.Size = new System.Drawing.Size(194, 24);
            this.lblIDEstadoConsulta.TabIndex = 56;
            this.lblIDEstadoConsulta.Text = "Estado de consulta:";
            // 
            // lblIDviaConsulta
            // 
            this.lblIDviaConsulta.AutoSize = true;
            this.lblIDviaConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDviaConsulta.Location = new System.Drawing.Point(829, 84);
            this.lblIDviaConsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDviaConsulta.Name = "lblIDviaConsulta";
            this.lblIDviaConsulta.Size = new System.Drawing.Size(160, 24);
            this.lblIDviaConsulta.TabIndex = 57;
            this.lblIDviaConsulta.Text = "Via de consulta:";
            // 
            // lblFechaCierre
            // 
            this.lblFechaCierre.AutoSize = true;
            this.lblFechaCierre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCierre.Location = new System.Drawing.Point(15, 91);
            this.lblFechaCierre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaCierre.Name = "lblFechaCierre";
            this.lblFechaCierre.Size = new System.Drawing.Size(165, 24);
            this.lblFechaCierre.TabIndex = 59;
            this.lblFechaCierre.Text = "Fecha de cierre:";
            // 
            // txtIDConsulta
            // 
            this.txtIDConsulta.Location = new System.Drawing.Point(192, 18);
            this.txtIDConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDConsulta.Name = "txtIDConsulta";
            this.txtIDConsulta.Size = new System.Drawing.Size(160, 28);
            this.txtIDConsulta.TabIndex = 60;
            // 
            // txtUsuarioModificador
            // 
            this.txtUsuarioModificador.Location = new System.Drawing.Point(191, 130);
            this.txtUsuarioModificador.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuarioModificador.Name = "txtUsuarioModificador";
            this.txtUsuarioModificador.Size = new System.Drawing.Size(160, 28);
            this.txtUsuarioModificador.TabIndex = 62;
            // 
            // txtDireccionInmueble
            // 
            this.txtDireccionInmueble.Location = new System.Drawing.Point(577, 55);
            this.txtDireccionInmueble.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionInmueble.Name = "txtDireccionInmueble";
            this.txtDireccionInmueble.Size = new System.Drawing.Size(160, 28);
            this.txtDireccionInmueble.TabIndex = 64;
            // 
            // txtDNICliente
            // 
            this.txtDNICliente.Location = new System.Drawing.Point(577, 91);
            this.txtDNICliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNICliente.Name = "txtDNICliente";
            this.txtDNICliente.Size = new System.Drawing.Size(160, 28);
            this.txtDNICliente.TabIndex = 65;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(577, 127);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(160, 28);
            this.txtNombreCliente.TabIndex = 66;
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(997, 15);
            this.txtApellidoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(160, 28);
            this.txtApellidoCliente.TabIndex = 68;
            // 
            // cboIDTipoTrans
            // 
            this.cboIDTipoTrans.FormattingEnabled = true;
            this.cboIDTipoTrans.Location = new System.Drawing.Point(578, 18);
            this.cboIDTipoTrans.Margin = new System.Windows.Forms.Padding(4);
            this.cboIDTipoTrans.Name = "cboIDTipoTrans";
            this.cboIDTipoTrans.Size = new System.Drawing.Size(160, 30);
            this.cboIDTipoTrans.TabIndex = 73;
            // 
            // cboIDMedioConocimiento
            // 
            this.cboIDMedioConocimiento.FormattingEnabled = true;
            this.cboIDMedioConocimiento.Location = new System.Drawing.Point(997, 51);
            this.cboIDMedioConocimiento.Margin = new System.Windows.Forms.Padding(4);
            this.cboIDMedioConocimiento.Name = "cboIDMedioConocimiento";
            this.cboIDMedioConocimiento.Size = new System.Drawing.Size(160, 30);
            this.cboIDMedioConocimiento.TabIndex = 74;
            // 
            // cboViaConsulta
            // 
            this.cboViaConsulta.FormattingEnabled = true;
            this.cboViaConsulta.Location = new System.Drawing.Point(997, 86);
            this.cboViaConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.cboViaConsulta.Name = "cboViaConsulta";
            this.cboViaConsulta.Size = new System.Drawing.Size(160, 30);
            this.cboViaConsulta.TabIndex = 75;
            // 
            // cboEstadoConsulta
            // 
            this.cboEstadoConsulta.FormattingEnabled = true;
            this.cboEstadoConsulta.Location = new System.Drawing.Point(997, 122);
            this.cboEstadoConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.cboEstadoConsulta.Name = "cboEstadoConsulta";
            this.cboEstadoConsulta.Size = new System.Drawing.Size(160, 30);
            this.cboEstadoConsulta.TabIndex = 76;
            // 
            // dtpFechaCreada
            // 
            this.dtpFechaCreada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCreada.Location = new System.Drawing.Point(192, 55);
            this.dtpFechaCreada.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaCreada.Name = "dtpFechaCreada";
            this.dtpFechaCreada.Size = new System.Drawing.Size(160, 28);
            this.dtpFechaCreada.TabIndex = 77;
            // 
            // dtpFechaCierre
            // 
            this.dtpFechaCierre.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCierre.Location = new System.Drawing.Point(192, 91);
            this.dtpFechaCierre.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaCierre.Name = "dtpFechaCierre";
            this.dtpFechaCierre.Size = new System.Drawing.Size(160, 28);
            this.dtpFechaCierre.TabIndex = 78;
            // 
            // btnElegir
            // 
            this.btnElegir.Image = global::TESTWF2020.Properties.Resources.icons8_natural_user_interface_2_48;
            this.btnElegir.Location = new System.Drawing.Point(735, 681);
            this.btnElegir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnElegir.Name = "btnElegir";
            this.btnElegir.Size = new System.Drawing.Size(100, 67);
            this.btnElegir.TabIndex = 79;
            this.btnElegir.UseVisualStyleBackColor = true;
            this.btnElegir.Click += new System.EventHandler(this.btnElegir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.dtpFechaCierre);
            this.groupBox1.Controls.Add(this.dtpFechaCreada);
            this.groupBox1.Controls.Add(this.cboEstadoConsulta);
            this.groupBox1.Controls.Add(this.cboViaConsulta);
            this.groupBox1.Controls.Add(this.cboIDMedioConocimiento);
            this.groupBox1.Controls.Add(this.cboIDTipoTrans);
            this.groupBox1.Controls.Add(this.txtApellidoCliente);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.txtDNICliente);
            this.groupBox1.Controls.Add(this.txtDireccionInmueble);
            this.groupBox1.Controls.Add(this.txtUsuarioModificador);
            this.groupBox1.Controls.Add(this.txtIDConsulta);
            this.groupBox1.Controls.Add(this.lblFechaCierre);
            this.groupBox1.Controls.Add(this.lblIDviaConsulta);
            this.groupBox1.Controls.Add(this.lblIDEstadoConsulta);
            this.groupBox1.Controls.Add(this.lblIDMedioConocomiento);
            this.groupBox1.Controls.Add(this.lblApellidoCliente);
            this.groupBox1.Controls.Add(this.lblNombreCliente);
            this.groupBox1.Controls.Add(this.lblDNICliente);
            this.groupBox1.Controls.Add(this.lblDireccionnuemble);
            this.groupBox1.Controls.Add(this.lblTipoTrans);
            this.groupBox1.Controls.Add(this.lblUserModificador);
            this.groupBox1.Controls.Add(this.lblFechaCreada);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.btnLimpiarFiltros);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1349, 178);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Consulta";
            // 
            // frmABMCConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 756);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnElegir);
            this.Controls.Add(this.dgvConsultas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnNuevo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmABMCConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.frmABMCConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblFechaCreada;
        private System.Windows.Forms.Label lblUserModificador;
        private System.Windows.Forms.Label lblTipoTrans;
        private System.Windows.Forms.Label lblDireccionnuemble;
        private System.Windows.Forms.Label lblDNICliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.Label lblIDMedioConocomiento;
        private System.Windows.Forms.Label lblIDEstadoConsulta;
        private System.Windows.Forms.Label lblIDviaConsulta;
        private System.Windows.Forms.Label lblFechaCierre;
        private System.Windows.Forms.TextBox txtIDConsulta;
        private System.Windows.Forms.TextBox txtUsuarioModificador;
        private System.Windows.Forms.TextBox txtDireccionInmueble;
        private System.Windows.Forms.TextBox txtDNICliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.ComboBox cboIDTipoTrans;
        private System.Windows.Forms.ComboBox cboIDMedioConocimiento;
        private System.Windows.Forms.ComboBox cboViaConsulta;
        private System.Windows.Forms.ComboBox cboEstadoConsulta;
        private System.Windows.Forms.DateTimePicker dtpFechaCreada;
        private System.Windows.Forms.DateTimePicker dtpFechaCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreada;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioUltimaModificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoTransaccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn inmueble;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn medioConocimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn viaConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoConsulta;
        private System.Windows.Forms.Button btnElegir;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}