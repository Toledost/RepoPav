namespace TESTWF2020.GUILayer.ABM
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
            this.usuarioCreador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoTransaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idInmueble = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medioConocimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viaConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioActualizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblFechaCreada = new System.Windows.Forms.Label();
            this.lblUsrCreador = new System.Windows.Forms.Label();
            this.lblTipoTrans = new System.Windows.Forms.Label();
            this.lblDireccionnuemble = new System.Windows.Forms.Label();
            this.lblDNICliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.lblIDMedioConocomiento = new System.Windows.Forms.Label();
            this.lblIDEstadoConsulta = new System.Windows.Forms.Label();
            this.lblIDviaConsulta = new System.Windows.Forms.Label();
            this.lblUsuarioActualizacion = new System.Windows.Forms.Label();
            this.lblFechaCierre = new System.Windows.Forms.Label();
            this.txtIDConsulta = new System.Windows.Forms.TextBox();
            this.txtUsuarioCreador = new System.Windows.Forms.TextBox();
            this.txtDireccionInmueble = new System.Windows.Forms.TextBox();
            this.txtDNICliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtUsuarioActualizacion = new System.Windows.Forms.TextBox();
            this.cboIDTipoTrans = new System.Windows.Forms.ComboBox();
            this.cboIDMedioConocimiento = new System.Windows.Forms.ComboBox();
            this.cboViaConsulta = new System.Windows.Forms.ComboBox();
            this.cboEstadoConsulta = new System.Windows.Forms.ComboBox();
            this.dtpFechaCreada = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaCierre = new System.Windows.Forms.DateTimePicker();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioCreador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoTransaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inmueble = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medioConocimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viaConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioActualizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
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
            this.usuarioCreador,
            this.tipoTransaccion,
            this.inmueble,
            this.dniCliente,
            this.nombreCliente,
            this.apellidoCliente,
            this.medioConocimiento,
            this.viaConsulta,
            this.estadoConsulta,
            this.usuarioActualizacion});
            this.dgvConsultas.Location = new System.Drawing.Point(16, 506);
            this.dgvConsultas.MultiSelect = false;
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.ReadOnly = true;
            this.dgvConsultas.RowHeadersWidth = 62;
            this.dgvConsultas.RowTemplate.Height = 28;
            this.dgvConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultas.Size = new System.Drawing.Size(1912, 278);
            this.dgvConsultas.TabIndex = 44;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 150;
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
            // usuarioCreador
            // 
            this.usuarioCreador.HeaderText = "Usuario Creador";
            this.usuarioCreador.MinimumWidth = 8;
            this.usuarioCreador.Name = "usuarioCreador";
            this.usuarioCreador.ReadOnly = true;
            this.usuarioCreador.Width = 150;
            // 
            // tipoTransaccion
            // 
            this.tipoTransaccion.HeaderText = "Tipo transaccion";
            this.tipoTransaccion.MinimumWidth = 8;
            this.tipoTransaccion.Name = "tipoTransaccion";
            this.tipoTransaccion.ReadOnly = true;
            this.tipoTransaccion.Width = 150;
            // 
            // idInmueble
            // 
            this.idInmueble.HeaderText = "ID inmueble";
            this.idInmueble.MinimumWidth = 8;
            this.idInmueble.Name = "idInmueble";
            this.idInmueble.ReadOnly = true;
            this.idInmueble.Width = 150;
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
            this.estadoConsulta.Name = "estadoConsulta";
            this.estadoConsulta.ReadOnly = true;
            // 
            // usuarioActualizacion
            // 
            this.usuarioActualizacion.HeaderText = "Usuario Actualizacion";
            this.usuarioActualizacion.MinimumWidth = 8;
            this.usuarioActualizacion.Name = "usuarioActualizacion";
            this.usuarioActualizacion.ReadOnly = true;
            this.usuarioActualizacion.Width = 150;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1815, 820);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 35);
            this.btnSalir.TabIndex = 43;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(441, 795);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 35);
            this.btnEliminar.TabIndex = 42;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(320, 795);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(112, 35);
            this.btnDetalle.TabIndex = 41;
            this.btnDetalle.Text = "Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(198, 795);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(112, 35);
            this.btnNuevo.TabIndex = 40;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(1592, 394);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(128, 88);
            this.btnLimpiarFiltros.TabIndex = 46;
            this.btnLimpiarFiltros.Text = "Limpiar Filtros";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(1743, 394);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(128, 88);
            this.btnConsultar.TabIndex = 45;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(226, 23);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(30, 20);
            this.lblID.TabIndex = 47;
            this.lblID.Text = "ID:";
            // 
            // lblFechaCreada
            // 
            this.lblFechaCreada.AutoSize = true;
            this.lblFechaCreada.Location = new System.Drawing.Point(226, 71);
            this.lblFechaCreada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaCreada.Name = "lblFechaCreada";
            this.lblFechaCreada.Size = new System.Drawing.Size(111, 20);
            this.lblFechaCreada.TabIndex = 48;
            this.lblFechaCreada.Text = "Fecha creada:";
            // 
            // lblUsrCreador
            // 
            this.lblUsrCreador.AutoSize = true;
            this.lblUsrCreador.Location = new System.Drawing.Point(226, 188);
            this.lblUsrCreador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsrCreador.Name = "lblUsrCreador";
            this.lblUsrCreador.Size = new System.Drawing.Size(126, 20);
            this.lblUsrCreador.TabIndex = 49;
            this.lblUsrCreador.Text = "Usuario creador:";
            // 
            // lblTipoTrans
            // 
            this.lblTipoTrans.AutoSize = true;
            this.lblTipoTrans.Location = new System.Drawing.Point(226, 240);
            this.lblTipoTrans.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoTrans.Name = "lblTipoTrans";
            this.lblTipoTrans.Size = new System.Drawing.Size(133, 20);
            this.lblTipoTrans.TabIndex = 50;
            this.lblTipoTrans.Text = "Tipo Transaccion:";
            // 
            // lblDireccionnuemble
            // 
            this.lblDireccionnuemble.AutoSize = true;
            this.lblDireccionnuemble.Location = new System.Drawing.Point(226, 292);
            this.lblDireccionnuemble.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccionnuemble.Name = "lblDireccionnuemble";
            this.lblDireccionnuemble.Size = new System.Drawing.Size(149, 20);
            this.lblDireccionnuemble.TabIndex = 51;
            this.lblDireccionnuemble.Text = "Direccion Inmueble:";
            // 
            // lblDNICliente
            // 
            this.lblDNICliente.AutoSize = true;
            this.lblDNICliente.Location = new System.Drawing.Point(226, 360);
            this.lblDNICliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNICliente.Name = "lblDNICliente";
            this.lblDNICliente.Size = new System.Drawing.Size(94, 20);
            this.lblDNICliente.TabIndex = 52;
            this.lblDNICliente.Text = "DNI Cliente:";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(226, 411);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(118, 20);
            this.lblNombreCliente.TabIndex = 53;
            this.lblNombreCliente.Text = "Nombre Cliente";
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.Location = new System.Drawing.Point(226, 462);
            this.lblApellidoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(122, 20);
            this.lblApellidoCliente.TabIndex = 54;
            this.lblApellidoCliente.Text = "Apellido Cliente:";
            // 
            // lblIDMedioConocomiento
            // 
            this.lblIDMedioConocomiento.AutoSize = true;
            this.lblIDMedioConocomiento.Location = new System.Drawing.Point(1236, 105);
            this.lblIDMedioConocomiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDMedioConocomiento.Name = "lblIDMedioConocomiento";
            this.lblIDMedioConocomiento.Size = new System.Drawing.Size(176, 20);
            this.lblIDMedioConocomiento.TabIndex = 55;
            this.lblIDMedioConocomiento.Text = "Medio de conocimiento:";
            // 
            // lblIDEstadoConsulta
            // 
            this.lblIDEstadoConsulta.AutoSize = true;
            this.lblIDEstadoConsulta.Location = new System.Drawing.Point(1236, 182);
            this.lblIDEstadoConsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDEstadoConsulta.Name = "lblIDEstadoConsulta";
            this.lblIDEstadoConsulta.Size = new System.Drawing.Size(146, 20);
            this.lblIDEstadoConsulta.TabIndex = 56;
            this.lblIDEstadoConsulta.Text = "Estado de consulta";
            // 
            // lblIDviaConsulta
            // 
            this.lblIDviaConsulta.AutoSize = true;
            this.lblIDviaConsulta.Location = new System.Drawing.Point(1236, 145);
            this.lblIDviaConsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDviaConsulta.Name = "lblIDviaConsulta";
            this.lblIDviaConsulta.Size = new System.Drawing.Size(122, 20);
            this.lblIDviaConsulta.TabIndex = 57;
            this.lblIDviaConsulta.Text = "Via de consulta:";
            // 
            // lblUsuarioActualizacion
            // 
            this.lblUsuarioActualizacion.AutoSize = true;
            this.lblUsuarioActualizacion.Location = new System.Drawing.Point(1236, 274);
            this.lblUsuarioActualizacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarioActualizacion.Name = "lblUsuarioActualizacion";
            this.lblUsuarioActualizacion.Size = new System.Drawing.Size(164, 20);
            this.lblUsuarioActualizacion.TabIndex = 58;
            this.lblUsuarioActualizacion.Text = "Usuario actualizacion:";
            // 
            // lblFechaCierre
            // 
            this.lblFechaCierre.AutoSize = true;
            this.lblFechaCierre.Location = new System.Drawing.Point(228, 122);
            this.lblFechaCierre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaCierre.Name = "lblFechaCierre";
            this.lblFechaCierre.Size = new System.Drawing.Size(123, 20);
            this.lblFechaCierre.TabIndex = 59;
            this.lblFechaCierre.Text = "Fecha de cierre:";
            // 
            // txtIDConsulta
            // 
            this.txtIDConsulta.Location = new System.Drawing.Point(396, 18);
            this.txtIDConsulta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIDConsulta.Name = "txtIDConsulta";
            this.txtIDConsulta.Size = new System.Drawing.Size(187, 26);
            this.txtIDConsulta.TabIndex = 60;
            // 
            // txtUsuarioCreador
            // 
            this.txtUsuarioCreador.Location = new System.Drawing.Point(404, 177);
            this.txtUsuarioCreador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsuarioCreador.Name = "txtUsuarioCreador";
            this.txtUsuarioCreador.Size = new System.Drawing.Size(180, 26);
            this.txtUsuarioCreador.TabIndex = 62;
            // 
            // txtDireccionInmueble
            // 
            this.txtDireccionInmueble.Location = new System.Drawing.Point(404, 292);
            this.txtDireccionInmueble.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDireccionInmueble.Name = "txtDireccionInmueble";
            this.txtDireccionInmueble.Size = new System.Drawing.Size(180, 26);
            this.txtDireccionInmueble.TabIndex = 64;
            // 
            // txtDNICliente
            // 
            this.txtDNICliente.Location = new System.Drawing.Point(404, 360);
            this.txtDNICliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDNICliente.Name = "txtDNICliente";
            this.txtDNICliente.Size = new System.Drawing.Size(180, 26);
            this.txtDNICliente.TabIndex = 65;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(404, 406);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(180, 26);
            this.txtNombreCliente.TabIndex = 66;
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(404, 462);
            this.txtApellidoCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(180, 26);
            this.txtApellidoCliente.TabIndex = 68;
            // 
            // txtUsuarioActualizacion
            // 
            this.txtUsuarioActualizacion.Location = new System.Drawing.Point(1449, 275);
            this.txtUsuarioActualizacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsuarioActualizacion.Name = "txtUsuarioActualizacion";
            this.txtUsuarioActualizacion.Size = new System.Drawing.Size(180, 26);
            this.txtUsuarioActualizacion.TabIndex = 72;
            // 
            // cboIDTipoTrans
            // 
            this.cboIDTipoTrans.FormattingEnabled = true;
            this.cboIDTipoTrans.Location = new System.Drawing.Point(404, 228);
            this.cboIDTipoTrans.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboIDTipoTrans.Name = "cboIDTipoTrans";
            this.cboIDTipoTrans.Size = new System.Drawing.Size(180, 28);
            this.cboIDTipoTrans.TabIndex = 73;
            // 
            // cboIDMedioConocimiento
            // 
            this.cboIDMedioConocimiento.FormattingEnabled = true;
            this.cboIDMedioConocimiento.Location = new System.Drawing.Point(1449, 92);
            this.cboIDMedioConocimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboIDMedioConocimiento.Name = "cboIDMedioConocimiento";
            this.cboIDMedioConocimiento.Size = new System.Drawing.Size(180, 28);
            this.cboIDMedioConocimiento.TabIndex = 74;
            // 
            // cboViaConsulta
            // 
            this.cboViaConsulta.FormattingEnabled = true;
            this.cboViaConsulta.Location = new System.Drawing.Point(1449, 140);
            this.cboViaConsulta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboViaConsulta.Name = "cboViaConsulta";
            this.cboViaConsulta.Size = new System.Drawing.Size(180, 28);
            this.cboViaConsulta.TabIndex = 75;
            // 
            // cboEstadoConsulta
            // 
            this.cboEstadoConsulta.FormattingEnabled = true;
            this.cboEstadoConsulta.Location = new System.Drawing.Point(1449, 182);
            this.cboEstadoConsulta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboEstadoConsulta.Name = "cboEstadoConsulta";
            this.cboEstadoConsulta.Size = new System.Drawing.Size(180, 28);
            this.cboEstadoConsulta.TabIndex = 76;
            // 
            // dtpFechaCreada
            // 
            this.dtpFechaCreada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCreada.Location = new System.Drawing.Point(396, 77);
            this.dtpFechaCreada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaCreada.Name = "dtpFechaCreada";
            this.dtpFechaCreada.Size = new System.Drawing.Size(187, 26);
            this.dtpFechaCreada.TabIndex = 77;
            // 
            // dtpFechaCierre
            // 
            this.dtpFechaCierre.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCierre.Location = new System.Drawing.Point(396, 122);
            this.dtpFechaCierre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaCierre.Name = "dtpFechaCierre";
            this.dtpFechaCierre.Size = new System.Drawing.Size(180, 26);
            this.dtpFechaCierre.TabIndex = 78;
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
            // usuarioCreador
            // 
            this.usuarioCreador.HeaderText = "Usuario Creador";
            this.usuarioCreador.MinimumWidth = 8;
            this.usuarioCreador.Name = "usuarioCreador";
            this.usuarioCreador.ReadOnly = true;
            this.usuarioCreador.Width = 150;
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
            this.inmueble.HeaderText = "Inmueble";
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
            // usuarioActualizacion
            // 
            this.usuarioActualizacion.HeaderText = "Usuario Actualizacion";
            this.usuarioActualizacion.MinimumWidth = 8;
            this.usuarioActualizacion.Name = "usuarioActualizacion";
            this.usuarioActualizacion.ReadOnly = true;
            this.usuarioActualizacion.Width = 150;
            // 
            // frmABMCConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 895);
            this.Controls.Add(this.dtpFechaCierre);
            this.Controls.Add(this.dtpFechaCreada);
            this.Controls.Add(this.cboEstadoConsulta);
            this.Controls.Add(this.cboViaConsulta);
            this.Controls.Add(this.cboIDMedioConocimiento);
            this.Controls.Add(this.cboIDTipoTrans);
            this.Controls.Add(this.txtUsuarioActualizacion);
            this.Controls.Add(this.txtApellidoCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtDNICliente);
            this.Controls.Add(this.txtDireccionInmueble);
            this.Controls.Add(this.txtUsuarioCreador);
            this.Controls.Add(this.txtIDConsulta);
            this.Controls.Add(this.lblFechaCierre);
            this.Controls.Add(this.lblUsuarioActualizacion);
            this.Controls.Add(this.lblIDviaConsulta);
            this.Controls.Add(this.lblIDEstadoConsulta);
            this.Controls.Add(this.lblIDMedioConocomiento);
            this.Controls.Add(this.lblApellidoCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.lblDNICliente);
            this.Controls.Add(this.lblDireccionnuemble);
            this.Controls.Add(this.lblTipoTrans);
            this.Controls.Add(this.lblUsrCreador);
            this.Controls.Add(this.lblFechaCreada);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnLimpiarFiltros);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvConsultas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnNuevo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmABMCConsultas";
            this.Text = "frmABMCConsultas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmABMCConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblUsrCreador;
        private System.Windows.Forms.Label lblTipoTrans;
        private System.Windows.Forms.Label lblDireccionnuemble;
        private System.Windows.Forms.Label lblDNICliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.Label lblIDMedioConocomiento;
        private System.Windows.Forms.Label lblIDEstadoConsulta;
        private System.Windows.Forms.Label lblIDviaConsulta;
        private System.Windows.Forms.Label lblUsuarioActualizacion;
        private System.Windows.Forms.Label lblFechaCierre;
        private System.Windows.Forms.TextBox txtIDConsulta;
        private System.Windows.Forms.TextBox txtUsuarioCreador;
        private System.Windows.Forms.TextBox txtDireccionInmueble;
        private System.Windows.Forms.TextBox txtDNICliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.TextBox txtUsuarioActualizacion;
        private System.Windows.Forms.ComboBox cboIDTipoTrans;
        private System.Windows.Forms.ComboBox cboIDMedioConocimiento;
        private System.Windows.Forms.ComboBox cboViaConsulta;
        private System.Windows.Forms.ComboBox cboEstadoConsulta;
        private System.Windows.Forms.DateTimePicker dtpFechaCreada;
        private System.Windows.Forms.DateTimePicker dtpFechaCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreada;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioCreador;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoTransaccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn inmueble;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn medioConocimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn viaConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioActualizacion;
    }
}