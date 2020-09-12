namespace TESTWF2020.GUILayer
{
    partial class frmInmuebles
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
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblM2 = new System.Windows.Forms.Label();
            this.lblMtsMin = new System.Windows.Forms.Label();
            this.lblMtsMax = new System.Windows.Forms.Label();
            this.lblBaños = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtBaños = new System.Windows.Forms.TextBox();
            this.txtMetrosCuadradosMin = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoInmueble = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalleNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantHab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantBaños = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoAlq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoVta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtMetrosCuadradosMax = new System.Windows.Forms.TextBox();
            this.txtHabitaciones = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.txtMontoAlqMax = new System.Windows.Forms.TextBox();
            this.txtMontoAlqMin = new System.Windows.Forms.TextBox();
            this.lblMontoMaxAlq = new System.Windows.Forms.Label();
            this.lblMontoMinAlq = new System.Windows.Forms.Label();
            this.lblMontoAlq = new System.Windows.Forms.Label();
            this.txtMontoVtaMax = new System.Windows.Forms.TextBox();
            this.txtMontoVtaMin = new System.Windows.Forms.TextBox();
            this.lblMontoMaxVta = new System.Windows.Forms.Label();
            this.lblMontoMinVta = new System.Windows.Forms.Label();
            this.lblMontoVta = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(92, 66);
            this.lblCalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(48, 20);
            this.lblCalle.TabIndex = 0;
            this.lblCalle.Text = "Calle:";
            // 
            // lblM2
            // 
            this.lblM2.AutoSize = true;
            this.lblM2.Location = new System.Drawing.Point(92, 128);
            this.lblM2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblM2.Name = "lblM2";
            this.lblM2.Size = new System.Drawing.Size(141, 20);
            this.lblM2.TabIndex = 1;
            this.lblM2.Text = "Metros cuadrados:";
            // 
            // lblMtsMin
            // 
            this.lblMtsMin.AutoSize = true;
            this.lblMtsMin.Location = new System.Drawing.Point(92, 185);
            this.lblMtsMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMtsMin.Name = "lblMtsMin";
            this.lblMtsMin.Size = new System.Drawing.Size(63, 20);
            this.lblMtsMin.TabIndex = 2;
            this.lblMtsMin.Text = "Minimo:";
            // 
            // lblMtsMax
            // 
            this.lblMtsMax.AutoSize = true;
            this.lblMtsMax.Location = new System.Drawing.Point(324, 185);
            this.lblMtsMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMtsMax.Name = "lblMtsMax";
            this.lblMtsMax.Size = new System.Drawing.Size(67, 20);
            this.lblMtsMax.TabIndex = 3;
            this.lblMtsMax.Text = "Maximo:";
            // 
            // lblBaños
            // 
            this.lblBaños.AutoSize = true;
            this.lblBaños.Location = new System.Drawing.Point(612, 72);
            this.lblBaños.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaños.Name = "lblBaños";
            this.lblBaños.Size = new System.Drawing.Size(59, 20);
            this.lblBaños.TabIndex = 4;
            this.lblBaños.Text = "Baños:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(165, 66);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(148, 26);
            this.txtCalle.TabIndex = 0;
            // 
            // txtBaños
            // 
            this.txtBaños.Location = new System.Drawing.Point(748, 62);
            this.txtBaños.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBaños.Name = "txtBaños";
            this.txtBaños.Size = new System.Drawing.Size(148, 26);
            this.txtBaños.TabIndex = 7;
            // 
            // txtMetrosCuadradosMin
            // 
            this.txtMetrosCuadradosMin.Location = new System.Drawing.Point(165, 180);
            this.txtMetrosCuadradosMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMetrosCuadradosMin.Name = "txtMetrosCuadradosMin";
            this.txtMetrosCuadradosMin.Size = new System.Drawing.Size(148, 26);
            this.txtMetrosCuadradosMin.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.idTipoInmueble,
            this.Calle,
            this.CalleNro,
            this.m2,
            this.cantHab,
            this.cantBaños,
            this.descripcion,
            this.montoAlq,
            this.montoVta});
            this.dataGridView1.Location = new System.Drawing.Point(60, 483);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(902, 151);
            this.dataGridView1.TabIndex = 11;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 150;
            // 
            // idTipoInmueble
            // 
            this.idTipoInmueble.HeaderText = "Tipo";
            this.idTipoInmueble.MinimumWidth = 8;
            this.idTipoInmueble.Name = "idTipoInmueble";
            this.idTipoInmueble.ReadOnly = true;
            this.idTipoInmueble.Width = 150;
            // 
            // Calle
            // 
            this.Calle.HeaderText = "Calle";
            this.Calle.MinimumWidth = 8;
            this.Calle.Name = "Calle";
            this.Calle.ReadOnly = true;
            this.Calle.Width = 150;
            // 
            // CalleNro
            // 
            this.CalleNro.HeaderText = "Nro";
            this.CalleNro.MinimumWidth = 8;
            this.CalleNro.Name = "CalleNro";
            this.CalleNro.ReadOnly = true;
            this.CalleNro.Width = 150;
            // 
            // m2
            // 
            this.m2.HeaderText = "M2";
            this.m2.MinimumWidth = 8;
            this.m2.Name = "m2";
            this.m2.ReadOnly = true;
            this.m2.Width = 150;
            // 
            // cantHab
            // 
            this.cantHab.HeaderText = "Habitaciones";
            this.cantHab.MinimumWidth = 8;
            this.cantHab.Name = "cantHab";
            this.cantHab.ReadOnly = true;
            this.cantHab.Width = 150;
            // 
            // cantBaños
            // 
            this.cantBaños.HeaderText = "Baños";
            this.cantBaños.MinimumWidth = 8;
            this.cantBaños.Name = "cantBaños";
            this.cantBaños.ReadOnly = true;
            this.cantBaños.Width = 150;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.MinimumWidth = 8;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 150;
            // 
            // montoAlq
            // 
            this.montoAlq.HeaderText = "Monto Alquiler ";
            this.montoAlq.MinimumWidth = 8;
            this.montoAlq.Name = "montoAlq";
            this.montoAlq.ReadOnly = true;
            this.montoAlq.Width = 150;
            // 
            // montoVta
            // 
            this.montoVta.HeaderText = "Monto Venta";
            this.montoVta.MinimumWidth = 8;
            this.montoVta.Name = "montoVta";
            this.montoVta.ReadOnly = true;
            this.montoVta.Width = 150;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(74, 669);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(112, 35);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(195, 669);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(112, 35);
            this.btnDetalle.TabIndex = 13;
            this.btnDetalle.Text = "Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(316, 669);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 35);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(638, 345);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 87);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar Filtros";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(868, 669);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 35);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtMetrosCuadradosMax
            // 
            this.txtMetrosCuadradosMax.Location = new System.Drawing.Point(402, 180);
            this.txtMetrosCuadradosMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMetrosCuadradosMax.Name = "txtMetrosCuadradosMax";
            this.txtMetrosCuadradosMax.Size = new System.Drawing.Size(148, 26);
            this.txtMetrosCuadradosMax.TabIndex = 2;
            // 
            // txtHabitaciones
            // 
            this.txtHabitaciones.Location = new System.Drawing.Point(748, 128);
            this.txtHabitaciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHabitaciones.Name = "txtHabitaciones";
            this.txtHabitaciones.Size = new System.Drawing.Size(148, 26);
            this.txtHabitaciones.TabIndex = 8;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(612, 185);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 20);
            this.lblTipo.TabIndex = 21;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Location = new System.Drawing.Point(612, 128);
            this.lblHabitacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(106, 20);
            this.lblHabitacion.TabIndex = 20;
            this.lblHabitacion.Text = "Habitaciones:";
            // 
            // txtMontoAlqMax
            // 
            this.txtMontoAlqMax.Location = new System.Drawing.Point(402, 300);
            this.txtMontoAlqMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMontoAlqMax.Name = "txtMontoAlqMax";
            this.txtMontoAlqMax.Size = new System.Drawing.Size(148, 26);
            this.txtMontoAlqMax.TabIndex = 4;
            // 
            // txtMontoAlqMin
            // 
            this.txtMontoAlqMin.Location = new System.Drawing.Point(165, 300);
            this.txtMontoAlqMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMontoAlqMin.Name = "txtMontoAlqMin";
            this.txtMontoAlqMin.Size = new System.Drawing.Size(148, 26);
            this.txtMontoAlqMin.TabIndex = 3;
            // 
            // lblMontoMaxAlq
            // 
            this.lblMontoMaxAlq.AutoSize = true;
            this.lblMontoMaxAlq.Location = new System.Drawing.Point(324, 305);
            this.lblMontoMaxAlq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoMaxAlq.Name = "lblMontoMaxAlq";
            this.lblMontoMaxAlq.Size = new System.Drawing.Size(67, 20);
            this.lblMontoMaxAlq.TabIndex = 32;
            this.lblMontoMaxAlq.Text = "Maximo:";
            // 
            // lblMontoMinAlq
            // 
            this.lblMontoMinAlq.AutoSize = true;
            this.lblMontoMinAlq.Location = new System.Drawing.Point(92, 300);
            this.lblMontoMinAlq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoMinAlq.Name = "lblMontoMinAlq";
            this.lblMontoMinAlq.Size = new System.Drawing.Size(63, 20);
            this.lblMontoMinAlq.TabIndex = 31;
            this.lblMontoMinAlq.Text = "Minimo:";
            // 
            // lblMontoAlq
            // 
            this.lblMontoAlq.AutoSize = true;
            this.lblMontoAlq.Location = new System.Drawing.Point(92, 245);
            this.lblMontoAlq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoAlq.Name = "lblMontoAlq";
            this.lblMontoAlq.Size = new System.Drawing.Size(114, 20);
            this.lblMontoAlq.TabIndex = 30;
            this.lblMontoAlq.Text = "Monto Alquiler:";
            // 
            // txtMontoVtaMax
            // 
            this.txtMontoVtaMax.Location = new System.Drawing.Point(402, 412);
            this.txtMontoVtaMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMontoVtaMax.Name = "txtMontoVtaMax";
            this.txtMontoVtaMax.Size = new System.Drawing.Size(148, 26);
            this.txtMontoVtaMax.TabIndex = 6;
            // 
            // txtMontoVtaMin
            // 
            this.txtMontoVtaMin.Location = new System.Drawing.Point(165, 412);
            this.txtMontoVtaMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMontoVtaMin.Name = "txtMontoVtaMin";
            this.txtMontoVtaMin.Size = new System.Drawing.Size(148, 26);
            this.txtMontoVtaMin.TabIndex = 5;
            // 
            // lblMontoMaxVta
            // 
            this.lblMontoMaxVta.AutoSize = true;
            this.lblMontoMaxVta.Location = new System.Drawing.Point(324, 417);
            this.lblMontoMaxVta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoMaxVta.Name = "lblMontoMaxVta";
            this.lblMontoMaxVta.Size = new System.Drawing.Size(67, 20);
            this.lblMontoMaxVta.TabIndex = 37;
            this.lblMontoMaxVta.Text = "Maximo:";
            // 
            // lblMontoMinVta
            // 
            this.lblMontoMinVta.AutoSize = true;
            this.lblMontoMinVta.Location = new System.Drawing.Point(92, 412);
            this.lblMontoMinVta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoMinVta.Name = "lblMontoMinVta";
            this.lblMontoMinVta.Size = new System.Drawing.Size(63, 20);
            this.lblMontoMinVta.TabIndex = 36;
            this.lblMontoMinVta.Text = "Minimo:";
            // 
            // lblMontoVta
            // 
            this.lblMontoVta.AutoSize = true;
            this.lblMontoVta.Location = new System.Drawing.Point(92, 357);
            this.lblMontoVta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoVta.Name = "lblMontoVta";
            this.lblMontoVta.Size = new System.Drawing.Size(105, 20);
            this.lblMontoVta.TabIndex = 35;
            this.lblMontoVta.Text = "Monto Venta:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(771, 345);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(128, 88);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(748, 185);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(121, 28);
            this.cboTipo.TabIndex = 38;
            // 
            // frmInmuebles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 740);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtMontoVtaMax);
            this.Controls.Add(this.txtMontoVtaMin);
            this.Controls.Add(this.lblMontoMaxVta);
            this.Controls.Add(this.lblMontoMinVta);
            this.Controls.Add(this.lblMontoVta);
            this.Controls.Add(this.txtMontoAlqMax);
            this.Controls.Add(this.txtMontoAlqMin);
            this.Controls.Add(this.lblMontoMaxAlq);
            this.Controls.Add(this.lblMontoMinAlq);
            this.Controls.Add(this.lblMontoAlq);
            this.Controls.Add(this.txtMetrosCuadradosMax);
            this.Controls.Add(this.txtHabitaciones);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblHabitacion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMetrosCuadradosMin);
            this.Controls.Add(this.txtBaños);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.lblBaños);
            this.Controls.Add(this.lblMtsMax);
            this.Controls.Add(this.lblMtsMin);
            this.Controls.Add(this.lblM2);
            this.Controls.Add(this.lblCalle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmInmuebles";
            this.Text = "frmInmuebles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblM2;
        private System.Windows.Forms.Label lblMtsMin;
        private System.Windows.Forms.Label lblMtsMax;
        private System.Windows.Forms.Label lblBaños;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtBaños;
        private System.Windows.Forms.TextBox txtMetrosCuadradosMin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoInmueble;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalleNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn m2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantHab;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantBaños;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoAlq;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoVta;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtMetrosCuadradosMax;
        private System.Windows.Forms.TextBox txtHabitaciones;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.TextBox txtMontoAlqMax;
        private System.Windows.Forms.TextBox txtMontoAlqMin;
        private System.Windows.Forms.Label lblMontoMaxAlq;
        private System.Windows.Forms.Label lblMontoMinAlq;
        private System.Windows.Forms.Label lblMontoAlq;
        private System.Windows.Forms.TextBox txtMontoVtaMax;
        private System.Windows.Forms.TextBox txtMontoVtaMin;
        private System.Windows.Forms.Label lblMontoMaxVta;
        private System.Windows.Forms.Label lblMontoMinVta;
        private System.Windows.Forms.Label lblMontoVta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cboTipo;
    }
}