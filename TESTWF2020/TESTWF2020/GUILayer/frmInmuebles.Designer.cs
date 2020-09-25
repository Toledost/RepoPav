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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
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
            this.dgvInmuebles = new System.Windows.Forms.DataGridView();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.btnElegir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInmuebles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(61, 43);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(33, 13);
            this.lblCalle.TabIndex = 0;
            this.lblCalle.Text = "Calle:";
            // 
            // lblM2
            // 
            this.lblM2.AutoSize = true;
            this.lblM2.Location = new System.Drawing.Point(60, 70);
            this.lblM2.Name = "lblM2";
            this.lblM2.Size = new System.Drawing.Size(95, 13);
            this.lblM2.TabIndex = 1;
            this.lblM2.Text = "Metros cuadrados:";
            // 
            // lblMtsMin
            // 
            this.lblMtsMin.AutoSize = true;
            this.lblMtsMin.Location = new System.Drawing.Point(60, 100);
            this.lblMtsMin.Name = "lblMtsMin";
            this.lblMtsMin.Size = new System.Drawing.Size(43, 13);
            this.lblMtsMin.TabIndex = 2;
            this.lblMtsMin.Text = "Minimo:";
            // 
            // lblMtsMax
            // 
            this.lblMtsMax.AutoSize = true;
            this.lblMtsMax.Location = new System.Drawing.Point(215, 100);
            this.lblMtsMax.Name = "lblMtsMax";
            this.lblMtsMax.Size = new System.Drawing.Size(46, 13);
            this.lblMtsMax.TabIndex = 3;
            this.lblMtsMax.Text = "Maximo:";
            // 
            // lblBaños
            // 
            this.lblBaños.AutoSize = true;
            this.lblBaños.Location = new System.Drawing.Point(408, 47);
            this.lblBaños.Name = "lblBaños";
            this.lblBaños.Size = new System.Drawing.Size(40, 13);
            this.lblBaños.TabIndex = 4;
            this.lblBaños.Text = "Baños:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(110, 43);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(100, 20);
            this.txtCalle.TabIndex = 0;
            // 
            // txtBaños
            // 
            this.txtBaños.Location = new System.Drawing.Point(499, 40);
            this.txtBaños.Name = "txtBaños";
            this.txtBaños.Size = new System.Drawing.Size(100, 20);
            this.txtBaños.TabIndex = 7;
            // 
            // txtMetrosCuadradosMin
            // 
            this.txtMetrosCuadradosMin.Location = new System.Drawing.Point(109, 97);
            this.txtMetrosCuadradosMin.Name = "txtMetrosCuadradosMin";
            this.txtMetrosCuadradosMin.Size = new System.Drawing.Size(100, 20);
            this.txtMetrosCuadradosMin.TabIndex = 1;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(49, 435);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(130, 435);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnDetalle.TabIndex = 13;
            this.btnDetalle.Text = "Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(211, 435);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(539, 435);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtMetrosCuadradosMax
            // 
            this.txtMetrosCuadradosMax.Location = new System.Drawing.Point(267, 97);
            this.txtMetrosCuadradosMax.Name = "txtMetrosCuadradosMax";
            this.txtMetrosCuadradosMax.Size = new System.Drawing.Size(100, 20);
            this.txtMetrosCuadradosMax.TabIndex = 2;
            // 
            // txtHabitaciones
            // 
            this.txtHabitaciones.Location = new System.Drawing.Point(499, 83);
            this.txtHabitaciones.Name = "txtHabitaciones";
            this.txtHabitaciones.Size = new System.Drawing.Size(100, 20);
            this.txtHabitaciones.TabIndex = 8;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(408, 120);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 21;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Location = new System.Drawing.Point(408, 83);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(72, 13);
            this.lblHabitacion.TabIndex = 20;
            this.lblHabitacion.Text = "Habitaciones:";
            // 
            // txtMontoAlqMax
            // 
            this.txtMontoAlqMax.Location = new System.Drawing.Point(267, 157);
            this.txtMontoAlqMax.Name = "txtMontoAlqMax";
            this.txtMontoAlqMax.Size = new System.Drawing.Size(100, 20);
            this.txtMontoAlqMax.TabIndex = 4;
            // 
            // txtMontoAlqMin
            // 
            this.txtMontoAlqMin.Location = new System.Drawing.Point(109, 157);
            this.txtMontoAlqMin.Name = "txtMontoAlqMin";
            this.txtMontoAlqMin.Size = new System.Drawing.Size(100, 20);
            this.txtMontoAlqMin.TabIndex = 3;
            // 
            // lblMontoMaxAlq
            // 
            this.lblMontoMaxAlq.AutoSize = true;
            this.lblMontoMaxAlq.Location = new System.Drawing.Point(215, 161);
            this.lblMontoMaxAlq.Name = "lblMontoMaxAlq";
            this.lblMontoMaxAlq.Size = new System.Drawing.Size(46, 13);
            this.lblMontoMaxAlq.TabIndex = 32;
            this.lblMontoMaxAlq.Text = "Maximo:";
            // 
            // lblMontoMinAlq
            // 
            this.lblMontoMinAlq.AutoSize = true;
            this.lblMontoMinAlq.Location = new System.Drawing.Point(60, 157);
            this.lblMontoMinAlq.Name = "lblMontoMinAlq";
            this.lblMontoMinAlq.Size = new System.Drawing.Size(43, 13);
            this.lblMontoMinAlq.TabIndex = 31;
            this.lblMontoMinAlq.Text = "Minimo:";
            // 
            // lblMontoAlq
            // 
            this.lblMontoAlq.AutoSize = true;
            this.lblMontoAlq.Location = new System.Drawing.Point(60, 128);
            this.lblMontoAlq.Name = "lblMontoAlq";
            this.lblMontoAlq.Size = new System.Drawing.Size(77, 13);
            this.lblMontoAlq.TabIndex = 30;
            this.lblMontoAlq.Text = "Monto Alquiler:";
            // 
            // txtMontoVtaMax
            // 
            this.txtMontoVtaMax.Location = new System.Drawing.Point(267, 207);
            this.txtMontoVtaMax.Name = "txtMontoVtaMax";
            this.txtMontoVtaMax.Size = new System.Drawing.Size(100, 20);
            this.txtMontoVtaMax.TabIndex = 6;
            // 
            // txtMontoVtaMin
            // 
            this.txtMontoVtaMin.Location = new System.Drawing.Point(109, 207);
            this.txtMontoVtaMin.Name = "txtMontoVtaMin";
            this.txtMontoVtaMin.Size = new System.Drawing.Size(100, 20);
            this.txtMontoVtaMin.TabIndex = 5;
            // 
            // lblMontoMaxVta
            // 
            this.lblMontoMaxVta.AutoSize = true;
            this.lblMontoMaxVta.Location = new System.Drawing.Point(215, 211);
            this.lblMontoMaxVta.Name = "lblMontoMaxVta";
            this.lblMontoMaxVta.Size = new System.Drawing.Size(46, 13);
            this.lblMontoMaxVta.TabIndex = 37;
            this.lblMontoMaxVta.Text = "Maximo:";
            // 
            // lblMontoMinVta
            // 
            this.lblMontoMinVta.AutoSize = true;
            this.lblMontoMinVta.Location = new System.Drawing.Point(60, 207);
            this.lblMontoMinVta.Name = "lblMontoMinVta";
            this.lblMontoMinVta.Size = new System.Drawing.Size(43, 13);
            this.lblMontoMinVta.TabIndex = 36;
            this.lblMontoMinVta.Text = "Minimo:";
            // 
            // lblMontoVta
            // 
            this.lblMontoVta.AutoSize = true;
            this.lblMontoVta.Location = new System.Drawing.Point(60, 183);
            this.lblMontoVta.Name = "lblMontoVta";
            this.lblMontoVta.Size = new System.Drawing.Size(71, 13);
            this.lblMontoVta.TabIndex = 35;
            this.lblMontoVta.Text = "Monto Venta:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(512, 167);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(85, 57);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(499, 120);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(100, 21);
            this.cboTipo.TabIndex = 38;
            // 
            // dgvInmuebles
            // 
            this.dgvInmuebles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInmuebles.Location = new System.Drawing.Point(48, 247);
            this.dgvInmuebles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInmuebles.MultiSelect = false;
            this.dgvInmuebles.Name = "dgvInmuebles";
            this.dgvInmuebles.RowHeadersWidth = 62;
            this.dgvInmuebles.RowTemplate.Height = 28;
            this.dgvInmuebles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInmuebles.Size = new System.Drawing.Size(565, 181);
            this.dgvInmuebles.TabIndex = 39;
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(411, 167);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(85, 57);
            this.btnLimpiarFiltros.TabIndex = 40;
            this.btnLimpiarFiltros.Text = "Limpiar Filtros";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // btnElegir
            // 
            this.btnElegir.Location = new System.Drawing.Point(373, 435);
            this.btnElegir.Name = "btnElegir";
            this.btnElegir.Size = new System.Drawing.Size(75, 23);
            this.btnElegir.TabIndex = 41;
            this.btnElegir.Text = "Elegir";
            this.btnElegir.UseVisualStyleBackColor = true;
            this.btnElegir.Click += new System.EventHandler(this.btnElegir_Click);
            // 
            // frmInmuebles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 481);
            this.Controls.Add(this.btnElegir);
            this.Controls.Add(this.btnLimpiarFiltros);
            this.Controls.Add(this.dgvInmuebles);
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
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtMetrosCuadradosMin);
            this.Controls.Add(this.txtBaños);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.lblBaños);
            this.Controls.Add(this.lblMtsMax);
            this.Controls.Add(this.lblMtsMin);
            this.Controls.Add(this.lblM2);
            this.Controls.Add(this.lblCalle);
            this.Name = "frmInmuebles";
            this.Text = "frmInmuebles";
            this.Load += new System.EventHandler(this.frmInmuebles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInmuebles)).EndInit();
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
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Button btnEliminar;
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
        private System.Windows.Forms.DataGridView dgvInmuebles;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Button btnElegir;
    }
}