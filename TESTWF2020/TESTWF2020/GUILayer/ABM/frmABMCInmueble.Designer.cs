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
            this.lblMontoAlq = new System.Windows.Forms.Label();
            this.lblMontoVta = new System.Windows.Forms.Label();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.lblMetrosCuadrados = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtNro = new System.Windows.Forms.TextBox();
            this.txtMetrosCuadrados = new System.Windows.Forms.TextBox();
            this.txtBaños = new System.Windows.Forms.TextBox();
            this.txtHabitaciones = new System.Windows.Forms.TextBox();
            this.txtMontoAlq = new System.Windows.Forms.TextBox();
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
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(118, 65);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(118, 98);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(33, 13);
            this.lblCalle.TabIndex = 1;
            this.lblCalle.Text = "Calle:";
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Location = new System.Drawing.Point(105, 130);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(47, 13);
            this.lblNro.TabIndex = 2;
            this.lblNro.Text = "Numero:";
            // 
            // lblBaños
            // 
            this.lblBaños.AutoSize = true;
            this.lblBaños.Location = new System.Drawing.Point(355, 41);
            this.lblBaños.Name = "lblBaños";
            this.lblBaños.Size = new System.Drawing.Size(40, 13);
            this.lblBaños.TabIndex = 3;
            this.lblBaños.Text = "Baños:";
            // 
            // lblHab
            // 
            this.lblHab.AutoSize = true;
            this.lblHab.Location = new System.Drawing.Point(325, 73);
            this.lblHab.Name = "lblHab";
            this.lblHab.Size = new System.Drawing.Size(72, 13);
            this.lblHab.TabIndex = 4;
            this.lblHab.Text = "Habitaciones:";
            // 
            // lblMontoAlq
            // 
            this.lblMontoAlq.AutoSize = true;
            this.lblMontoAlq.Location = new System.Drawing.Point(320, 102);
            this.lblMontoAlq.Name = "lblMontoAlq";
            this.lblMontoAlq.Size = new System.Drawing.Size(77, 13);
            this.lblMontoAlq.TabIndex = 5;
            this.lblMontoAlq.Text = "Monto Alquiler:";
            // 
            // lblMontoVta
            // 
            this.lblMontoVta.AutoSize = true;
            this.lblMontoVta.Location = new System.Drawing.Point(326, 135);
            this.lblMontoVta.Name = "lblMontoVta";
            this.lblMontoVta.Size = new System.Drawing.Size(71, 13);
            this.lblMontoVta.TabIndex = 6;
            this.lblMontoVta.Text = "Monto Venta:";
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Location = new System.Drawing.Point(328, 166);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(66, 13);
            this.lblDescrip.TabIndex = 7;
            this.lblDescrip.Text = "Descripcion:";
            // 
            // lblMetrosCuadrados
            // 
            this.lblMetrosCuadrados.AutoSize = true;
            this.lblMetrosCuadrados.Location = new System.Drawing.Point(57, 159);
            this.lblMetrosCuadrados.Name = "lblMetrosCuadrados";
            this.lblMetrosCuadrados.Size = new System.Drawing.Size(95, 13);
            this.lblMetrosCuadrados.TabIndex = 8;
            this.lblMetrosCuadrados.Text = "Metros cuadrados:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(130, 41);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "Id:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(175, 37);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 10;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(175, 65);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 11;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(175, 95);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(100, 20);
            this.txtCalle.TabIndex = 12;
            // 
            // txtNro
            // 
            this.txtNro.Location = new System.Drawing.Point(175, 130);
            this.txtNro.Name = "txtNro";
            this.txtNro.Size = new System.Drawing.Size(100, 20);
            this.txtNro.TabIndex = 13;
            // 
            // txtMetrosCuadrados
            // 
            this.txtMetrosCuadrados.Location = new System.Drawing.Point(175, 159);
            this.txtMetrosCuadrados.Name = "txtMetrosCuadrados";
            this.txtMetrosCuadrados.Size = new System.Drawing.Size(100, 20);
            this.txtMetrosCuadrados.TabIndex = 14;
            // 
            // txtBaños
            // 
            this.txtBaños.Location = new System.Drawing.Point(419, 41);
            this.txtBaños.Name = "txtBaños";
            this.txtBaños.Size = new System.Drawing.Size(100, 20);
            this.txtBaños.TabIndex = 15;
            // 
            // txtHabitaciones
            // 
            this.txtHabitaciones.Location = new System.Drawing.Point(419, 73);
            this.txtHabitaciones.Name = "txtHabitaciones";
            this.txtHabitaciones.Size = new System.Drawing.Size(100, 20);
            this.txtHabitaciones.TabIndex = 16;
            // 
            // txtMontoAlq
            // 
            this.txtMontoAlq.Location = new System.Drawing.Point(419, 102);
            this.txtMontoAlq.Name = "txtMontoAlq";
            this.txtMontoAlq.Size = new System.Drawing.Size(100, 20);
            this.txtMontoAlq.TabIndex = 17;
            // 
            // txtMontoVta
            // 
            this.txtMontoVta.Location = new System.Drawing.Point(419, 132);
            this.txtMontoVta.Name = "txtMontoVta";
            this.txtMontoVta.Size = new System.Drawing.Size(100, 20);
            this.txtMontoVta.TabIndex = 18;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(419, 163);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.fechaInicio,
            this.fechaFin});
            this.dataGridView1.Location = new System.Drawing.Point(60, 254);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(483, 138);
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
            this.lblEstadoActual.Location = new System.Drawing.Point(82, 223);
            this.lblEstadoActual.Name = "lblEstadoActual";
            this.lblEstadoActual.Size = new System.Drawing.Size(76, 13);
            this.lblEstadoActual.TabIndex = 9;
            this.lblEstadoActual.Text = "Estado Actual:";
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(175, 219);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(100, 21);
            this.cboEstado.TabIndex = 21;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(101, 405);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(57, 23);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(185, 405);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(54, 23);
            this.btnGrabar.TabIndex = 23;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(273, 405);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(57, 23);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmABMCInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtMontoVta);
            this.Controls.Add(this.txtMontoAlq);
            this.Controls.Add(this.txtHabitaciones);
            this.Controls.Add(this.txtBaños);
            this.Controls.Add(this.txtMetrosCuadrados);
            this.Controls.Add(this.txtNro);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblEstadoActual);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblMetrosCuadrados);
            this.Controls.Add(this.lblDescrip);
            this.Controls.Add(this.lblMontoVta);
            this.Controls.Add(this.lblMontoAlq);
            this.Controls.Add(this.lblHab);
            this.Controls.Add(this.lblBaños);
            this.Controls.Add(this.lblNro);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.lblTipo);
            this.Name = "frmABMCInmueble";
            this.Text = "frmABMCInmueble";
            this.Load += new System.EventHandler(this.frmABMCInmueble_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.Label lblBaños;
        private System.Windows.Forms.Label lblHab;
        private System.Windows.Forms.Label lblMontoAlq;
        private System.Windows.Forms.Label lblMontoVta;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.Label lblMetrosCuadrados;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtNro;
        private System.Windows.Forms.TextBox txtMetrosCuadrados;
        private System.Windows.Forms.TextBox txtBaños;
        private System.Windows.Forms.TextBox txtHabitaciones;
        private System.Windows.Forms.TextBox txtMontoAlq;
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
    }
}