namespace TESTWF2020.GUILayer.ABM
{
    partial class frmABMCInmueble
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
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblNro = new System.Windows.Forms.Label();
            this.lblBaños = new System.Windows.Forms.Label();
            this.lblHab = new System.Windows.Forms.Label();
            this.lblMontoVta = new System.Windows.Forms.Label();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.lblMetrosCuadrados = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtNro = new System.Windows.Forms.TextBox();
            this.txtMetrosCuadrados = new System.Windows.Forms.TextBox();
            this.txtBaños = new System.Windows.Forms.TextBox();
            this.txtHabitaciones = new System.Windows.Forms.TextBox();
            this.txtMontoVta = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEstadoActual = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.cboTipoInmueble = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(106, 85);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(46, 18);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(102, 113);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(51, 18);
            this.lblCalle.TabIndex = 1;
            this.lblCalle.Text = "Calle:";
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNro.Location = new System.Drawing.Point(81, 146);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(73, 18);
            this.lblNro.TabIndex = 2;
            this.lblNro.Text = "Numero:";
            // 
            // lblBaños
            // 
            this.lblBaños.AutoSize = true;
            this.lblBaños.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaños.Location = new System.Drawing.Point(474, 85);
            this.lblBaños.Name = "lblBaños";
            this.lblBaños.Size = new System.Drawing.Size(61, 18);
            this.lblBaños.TabIndex = 3;
            this.lblBaños.Text = "Baños:";
            // 
            // lblHab
            // 
            this.lblHab.AutoSize = true;
            this.lblHab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHab.Location = new System.Drawing.Point(427, 113);
            this.lblHab.Name = "lblHab";
            this.lblHab.Size = new System.Drawing.Size(111, 18);
            this.lblHab.TabIndex = 4;
            this.lblHab.Text = "Habitaciones:";
            // 
            // lblMontoVta
            // 
            this.lblMontoVta.AutoSize = true;
            this.lblMontoVta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoVta.Location = new System.Drawing.Point(429, 143);
            this.lblMontoVta.Name = "lblMontoVta";
            this.lblMontoVta.Size = new System.Drawing.Size(108, 18);
            this.lblMontoVta.TabIndex = 6;
            this.lblMontoVta.Text = "Monto Venta:";
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrip.Location = new System.Drawing.Point(804, 50);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(103, 18);
            this.lblDescrip.TabIndex = 7;
            this.lblDescrip.Text = "Descripcion:";
            // 
            // lblMetrosCuadrados
            // 
            this.lblMetrosCuadrados.AutoSize = true;
            this.lblMetrosCuadrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetrosCuadrados.Location = new System.Drawing.Point(12, 180);
            this.lblMetrosCuadrados.Name = "lblMetrosCuadrados";
            this.lblMetrosCuadrados.Size = new System.Drawing.Size(150, 18);
            this.lblMetrosCuadrados.TabIndex = 8;
            this.lblMetrosCuadrados.Text = "Metros cuadrados:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(124, 52);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 18);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "Id:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(155, 47);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(197, 26);
            this.txtID.TabIndex = 10;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(155, 115);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(197, 26);
            this.txtCalle.TabIndex = 12;
            this.txtCalle.Tag = "Calle";
            // 
            // txtNro
            // 
            this.txtNro.Location = new System.Drawing.Point(155, 148);
            this.txtNro.Name = "txtNro";
            this.txtNro.Size = new System.Drawing.Size(196, 26);
            this.txtNro.TabIndex = 13;
            this.txtNro.Tag = "Numero";
            // 
            // txtMetrosCuadrados
            // 
            this.txtMetrosCuadrados.Location = new System.Drawing.Point(155, 181);
            this.txtMetrosCuadrados.Name = "txtMetrosCuadrados";
            this.txtMetrosCuadrados.Size = new System.Drawing.Size(196, 26);
            this.txtMetrosCuadrados.TabIndex = 14;
            this.txtMetrosCuadrados.Tag = "Metros Cuadrados";
            // 
            // txtBaños
            // 
            this.txtBaños.Location = new System.Drawing.Point(537, 81);
            this.txtBaños.Name = "txtBaños";
            this.txtBaños.Size = new System.Drawing.Size(195, 26);
            this.txtBaños.TabIndex = 15;
            this.txtBaños.Tag = "Baños";
            // 
            // txtHabitaciones
            // 
            this.txtHabitaciones.Location = new System.Drawing.Point(537, 110);
            this.txtHabitaciones.Name = "txtHabitaciones";
            this.txtHabitaciones.Size = new System.Drawing.Size(195, 26);
            this.txtHabitaciones.TabIndex = 16;
            this.txtHabitaciones.Tag = "Habitaciones";
            // 
            // txtMontoVta
            // 
            this.txtMontoVta.Location = new System.Drawing.Point(537, 144);
            this.txtMontoVta.Name = "txtMontoVta";
            this.txtMontoVta.Size = new System.Drawing.Size(195, 26);
            this.txtMontoVta.TabIndex = 18;
            this.txtMontoVta.Tag = "Monto Venta";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(807, 73);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(185, 133);
            this.txtDescripcion.TabIndex = 19;
            this.txtDescripcion.Tag = "Descripcion";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.fechaInicio,
            this.fechaFin});
            this.dataGridView1.Location = new System.Drawing.Point(9, 282);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1008, 260);
            this.dataGridView1.TabIndex = 20;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 8;
            this.nombre.Name = "nombre";
            this.nombre.Width = 150;
            // 
            // fechaInicio
            // 
            this.fechaInicio.HeaderText = "Fecha Desde";
            this.fechaInicio.MinimumWidth = 8;
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Width = 150;
            // 
            // fechaFin
            // 
            this.fechaFin.HeaderText = "Fecha Hasta";
            this.fechaFin.MinimumWidth = 8;
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.Width = 150;
            // 
            // lblEstadoActual
            // 
            this.lblEstadoActual.AutoSize = true;
            this.lblEstadoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoActual.Location = new System.Drawing.Point(422, 52);
            this.lblEstadoActual.Name = "lblEstadoActual";
            this.lblEstadoActual.Size = new System.Drawing.Size(117, 18);
            this.lblEstadoActual.TabIndex = 9;
            this.lblEstadoActual.Text = "Estado Actual:";
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(537, 47);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(197, 28);
            this.cboEstado.TabIndex = 21;
            this.cboEstado.Tag = "Estado Actual";
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::TESTWF2020.Properties.Resources.icons8_editar_48;
            this.btnEditar.Location = new System.Drawing.Point(8, 559);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(73, 46);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = global::TESTWF2020.Properties.Resources.icons8_guardar_48;
            this.btnGrabar.Location = new System.Drawing.Point(94, 559);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(74, 46);
            this.btnGrabar.TabIndex = 23;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // cboTipoInmueble
            // 
            this.cboTipoInmueble.FormattingEnabled = true;
            this.cboTipoInmueble.Location = new System.Drawing.Point(154, 83);
            this.cboTipoInmueble.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTipoInmueble.Name = "cboTipoInmueble";
            this.cboTipoInmueble.Size = new System.Drawing.Size(198, 28);
            this.cboTipoInmueble.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.cboTipoInmueble);
            this.groupBox1.Controls.Add(this.cboEstado);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.txtMontoVta);
            this.groupBox1.Controls.Add(this.txtHabitaciones);
            this.groupBox1.Controls.Add(this.txtBaños);
            this.groupBox1.Controls.Add(this.txtMetrosCuadrados);
            this.groupBox1.Controls.Add(this.txtNro);
            this.groupBox1.Controls.Add(this.txtCalle);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.lblEstadoActual);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.lblMetrosCuadrados);
            this.groupBox1.Controls.Add(this.lblDescrip);
            this.groupBox1.Controls.Add(this.lblMontoVta);
            this.groupBox1.Controls.Add(this.lblHab);
            this.groupBox1.Controls.Add(this.lblBaños);
            this.groupBox1.Controls.Add(this.lblNro);
            this.groupBox1.Controls.Add(this.lblCalle);
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(1010, 251);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Inmueble";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::TESTWF2020.Properties.Resources.icons8_cerrar_ventana_48;
            this.btnCancelar.Location = new System.Drawing.Point(945, 559);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(72, 46);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmABMCInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 609);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmABMCInmueble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inmueble";
            this.Load += new System.EventHandler(this.frmABMCInmueble_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.Label lblBaños;
        private System.Windows.Forms.Label lblHab;
        private System.Windows.Forms.Label lblMontoVta;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.Label lblMetrosCuadrados;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtNro;
        private System.Windows.Forms.TextBox txtMetrosCuadrados;
        private System.Windows.Forms.TextBox txtBaños;
        private System.Windows.Forms.TextBox txtHabitaciones;
        private System.Windows.Forms.TextBox txtMontoVta;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFin;
        private System.Windows.Forms.Label lblEstadoActual;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboTipoInmueble;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}