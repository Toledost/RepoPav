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
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.dgvInmuebles = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnElegir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInmuebles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(35, 38);
            this.lblCalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(63, 24);
            this.lblCalle.TabIndex = 0;
            this.lblCalle.Text = "Calle:";
            // 
            // lblM2
            // 
            this.lblM2.AutoSize = true;
            this.lblM2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM2.Location = new System.Drawing.Point(35, 85);
            this.lblM2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblM2.Name = "lblM2";
            this.lblM2.Size = new System.Drawing.Size(183, 24);
            this.lblM2.TabIndex = 1;
            this.lblM2.Text = "Metros cuadrados:";
            // 
            // lblMtsMin
            // 
            this.lblMtsMin.AutoSize = true;
            this.lblMtsMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMtsMin.Location = new System.Drawing.Point(35, 126);
            this.lblMtsMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMtsMin.Name = "lblMtsMin";
            this.lblMtsMin.Size = new System.Drawing.Size(84, 24);
            this.lblMtsMin.TabIndex = 2;
            this.lblMtsMin.Text = "Minimo:";
            // 
            // lblMtsMax
            // 
            this.lblMtsMax.AutoSize = true;
            this.lblMtsMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMtsMax.Location = new System.Drawing.Point(283, 128);
            this.lblMtsMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMtsMax.Name = "lblMtsMax";
            this.lblMtsMax.Size = new System.Drawing.Size(89, 24);
            this.lblMtsMax.TabIndex = 3;
            this.lblMtsMax.Text = "Maximo:";
            // 
            // lblBaños
            // 
            this.lblBaños.AutoSize = true;
            this.lblBaños.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaños.Location = new System.Drawing.Point(601, 126);
            this.lblBaños.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaños.Name = "lblBaños";
            this.lblBaños.Size = new System.Drawing.Size(74, 24);
            this.lblBaños.TabIndex = 4;
            this.lblBaños.Text = "Baños:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(106, 40);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(225, 30);
            this.txtCalle.TabIndex = 0;
            // 
            // txtBaños
            // 
            this.txtBaños.Location = new System.Drawing.Point(694, 128);
            this.txtBaños.Margin = new System.Windows.Forms.Padding(4);
            this.txtBaños.Name = "txtBaños";
            this.txtBaños.Size = new System.Drawing.Size(132, 30);
            this.txtBaños.TabIndex = 7;
            // 
            // txtMetrosCuadradosMin
            // 
            this.txtMetrosCuadradosMin.Location = new System.Drawing.Point(127, 128);
            this.txtMetrosCuadradosMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtMetrosCuadradosMin.Name = "txtMetrosCuadradosMin";
            this.txtMetrosCuadradosMin.Size = new System.Drawing.Size(132, 30);
            this.txtMetrosCuadradosMin.TabIndex = 1;
            // 
            // txtMetrosCuadradosMax
            // 
            this.txtMetrosCuadradosMax.Location = new System.Drawing.Point(380, 130);
            this.txtMetrosCuadradosMax.Margin = new System.Windows.Forms.Padding(4);
            this.txtMetrosCuadradosMax.Name = "txtMetrosCuadradosMax";
            this.txtMetrosCuadradosMax.Size = new System.Drawing.Size(132, 30);
            this.txtMetrosCuadradosMax.TabIndex = 2;
            // 
            // txtHabitaciones
            // 
            this.txtHabitaciones.Location = new System.Drawing.Point(694, 172);
            this.txtHabitaciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtHabitaciones.Name = "txtHabitaciones";
            this.txtHabitaciones.Size = new System.Drawing.Size(132, 30);
            this.txtHabitaciones.TabIndex = 8;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(617, 216);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(58, 24);
            this.lblTipo.TabIndex = 21;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabitacion.Location = new System.Drawing.Point(538, 170);
            this.lblHabitacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(137, 24);
            this.lblHabitacion.TabIndex = 20;
            this.lblHabitacion.Text = "Habitaciones:";
            // 
            // txtMontoAlqMax
            // 
            this.txtMontoAlqMax.Location = new System.Drawing.Point(380, 218);
            this.txtMontoAlqMax.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoAlqMax.Name = "txtMontoAlqMax";
            this.txtMontoAlqMax.Size = new System.Drawing.Size(132, 30);
            this.txtMontoAlqMax.TabIndex = 4;
            // 
            // txtMontoAlqMin
            // 
            this.txtMontoAlqMin.Location = new System.Drawing.Point(128, 220);
            this.txtMontoAlqMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoAlqMin.Name = "txtMontoAlqMin";
            this.txtMontoAlqMin.Size = new System.Drawing.Size(132, 30);
            this.txtMontoAlqMin.TabIndex = 3;
            // 
            // lblMontoMaxAlq
            // 
            this.lblMontoMaxAlq.AutoSize = true;
            this.lblMontoMaxAlq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoMaxAlq.Location = new System.Drawing.Point(283, 220);
            this.lblMontoMaxAlq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoMaxAlq.Name = "lblMontoMaxAlq";
            this.lblMontoMaxAlq.Size = new System.Drawing.Size(89, 24);
            this.lblMontoMaxAlq.TabIndex = 32;
            this.lblMontoMaxAlq.Text = "Maximo:";
            // 
            // lblMontoMinAlq
            // 
            this.lblMontoMinAlq.AutoSize = true;
            this.lblMontoMinAlq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoMinAlq.Location = new System.Drawing.Point(35, 218);
            this.lblMontoMinAlq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoMinAlq.Name = "lblMontoMinAlq";
            this.lblMontoMinAlq.Size = new System.Drawing.Size(84, 24);
            this.lblMontoMinAlq.TabIndex = 31;
            this.lblMontoMinAlq.Text = "Minimo:";
            // 
            // lblMontoAlq
            // 
            this.lblMontoAlq.AutoSize = true;
            this.lblMontoAlq.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMontoAlq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoAlq.Location = new System.Drawing.Point(35, 183);
            this.lblMontoAlq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoAlq.Name = "lblMontoAlq";
            this.lblMontoAlq.Size = new System.Drawing.Size(152, 24);
            this.lblMontoAlq.TabIndex = 30;
            this.lblMontoAlq.Text = "Monto Alquiler:";
            // 
            // txtMontoVtaMax
            // 
            this.txtMontoVtaMax.Location = new System.Drawing.Point(886, 73);
            this.txtMontoVtaMax.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoVtaMax.Name = "txtMontoVtaMax";
            this.txtMontoVtaMax.Size = new System.Drawing.Size(132, 30);
            this.txtMontoVtaMax.TabIndex = 6;
            // 
            // txtMontoVtaMin
            // 
            this.txtMontoVtaMin.Location = new System.Drawing.Point(634, 75);
            this.txtMontoVtaMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoVtaMin.Name = "txtMontoVtaMin";
            this.txtMontoVtaMin.Size = new System.Drawing.Size(132, 30);
            this.txtMontoVtaMin.TabIndex = 5;
            // 
            // lblMontoMaxVta
            // 
            this.lblMontoMaxVta.AutoSize = true;
            this.lblMontoMaxVta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoMaxVta.Location = new System.Drawing.Point(789, 73);
            this.lblMontoMaxVta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoMaxVta.Name = "lblMontoMaxVta";
            this.lblMontoMaxVta.Size = new System.Drawing.Size(89, 24);
            this.lblMontoMaxVta.TabIndex = 37;
            this.lblMontoMaxVta.Text = "Maximo:";
            // 
            // lblMontoMinVta
            // 
            this.lblMontoMinVta.AutoSize = true;
            this.lblMontoMinVta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoMinVta.Location = new System.Drawing.Point(538, 73);
            this.lblMontoMinVta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoMinVta.Name = "lblMontoMinVta";
            this.lblMontoMinVta.Size = new System.Drawing.Size(84, 24);
            this.lblMontoMinVta.TabIndex = 36;
            this.lblMontoMinVta.Text = "Minimo:";
            // 
            // lblMontoVta
            // 
            this.lblMontoVta.AutoSize = true;
            this.lblMontoVta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMontoVta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoVta.Location = new System.Drawing.Point(541, 38);
            this.lblMontoVta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoVta.Name = "lblMontoVta";
            this.lblMontoVta.Size = new System.Drawing.Size(134, 24);
            this.lblMontoVta.TabIndex = 35;
            this.lblMontoVta.Text = "Monto Venta:";
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(694, 216);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(132, 33);
            this.cboTipo.TabIndex = 38;
            // 
            // dgvInmuebles
            // 
            this.dgvInmuebles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInmuebles.Location = new System.Drawing.Point(17, 317);
            this.dgvInmuebles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInmuebles.MultiSelect = false;
            this.dgvInmuebles.Name = "dgvInmuebles";
            this.dgvInmuebles.RowHeadersWidth = 62;
            this.dgvInmuebles.RowTemplate.Height = 28;
            this.dgvInmuebles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInmuebles.Size = new System.Drawing.Size(1325, 364);
            this.dgvInmuebles.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.btnLimpiarFiltros);
            this.groupBox1.Controls.Add(this.cboTipo);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.txtMontoVtaMax);
            this.groupBox1.Controls.Add(this.txtMontoVtaMin);
            this.groupBox1.Controls.Add(this.lblMontoMaxVta);
            this.groupBox1.Controls.Add(this.lblMontoMinVta);
            this.groupBox1.Controls.Add(this.lblMontoVta);
            this.groupBox1.Controls.Add(this.txtMontoAlqMax);
            this.groupBox1.Controls.Add(this.txtMontoAlqMin);
            this.groupBox1.Controls.Add(this.lblMontoMaxAlq);
            this.groupBox1.Controls.Add(this.lblMontoMinAlq);
            this.groupBox1.Controls.Add(this.lblMontoAlq);
            this.groupBox1.Controls.Add(this.txtMetrosCuadradosMax);
            this.groupBox1.Controls.Add(this.txtHabitaciones);
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Controls.Add(this.lblHabitacion);
            this.groupBox1.Controls.Add(this.txtMetrosCuadradosMin);
            this.groupBox1.Controls.Add(this.txtBaños);
            this.groupBox1.Controls.Add(this.txtCalle);
            this.groupBox1.Controls.Add(this.lblBaños);
            this.groupBox1.Controls.Add(this.lblMtsMax);
            this.groupBox1.Controls.Add(this.lblMtsMin);
            this.groupBox1.Controls.Add(this.lblM2);
            this.groupBox1.Controls.Add(this.lblCalle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1325, 278);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Inmueble";
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Image = global::TESTWF2020.Properties.Resources.icons8_borrar_48;
            this.btnLimpiarFiltros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(1056, 109);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(234, 59);
            this.btnLimpiarFiltros.TabIndex = 40;
            this.btnLimpiarFiltros.Text = "Limpiar Filtros";
            this.btnLimpiarFiltros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = global::TESTWF2020.Properties.Resources.icons8_fácil_de_encontrar_40;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(1056, 194);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(234, 55);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnElegir
            // 
            this.btnElegir.Image = global::TESTWF2020.Properties.Resources.icons8_natural_user_interface_2_48;
            this.btnElegir.Location = new System.Drawing.Point(846, 693);
            this.btnElegir.Margin = new System.Windows.Forms.Padding(4);
            this.btnElegir.Name = "btnElegir";
            this.btnElegir.Size = new System.Drawing.Size(100, 56);
            this.btnElegir.TabIndex = 41;
            this.btnElegir.UseVisualStyleBackColor = true;
            this.btnElegir.Click += new System.EventHandler(this.btnElegir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::TESTWF2020.Properties.Resources.icons8_cerrar_ventana_48;
            this.btnSalir.Location = new System.Drawing.Point(1242, 687);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 62);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::TESTWF2020.Properties.Resources.icons8_eliminar_48;
            this.btnEliminar.Location = new System.Drawing.Point(289, 693);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 56);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Image = global::TESTWF2020.Properties.Resources.icons8_ver_archivo_40;
            this.btnDetalle.Location = new System.Drawing.Point(154, 693);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(103, 56);
            this.btnDetalle.TabIndex = 13;
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::TESTWF2020.Properties.Resources.icons8_añadir_48;
            this.btnNuevo.Location = new System.Drawing.Point(17, 693);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(108, 56);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmInmuebles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 756);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnElegir);
            this.Controls.Add(this.dgvInmuebles);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnNuevo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInmuebles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inmuebles";
            this.Load += new System.EventHandler(this.frmInmuebles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInmuebles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
    }
}