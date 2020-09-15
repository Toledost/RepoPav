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
            this.cboTipoInmueble = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(177, 100);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 20);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(177, 151);
            this.lblCalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(48, 20);
            this.lblCalle.TabIndex = 1;
            this.lblCalle.Text = "Calle:";
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Location = new System.Drawing.Point(158, 200);
            this.lblNro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(69, 20);
            this.lblNro.TabIndex = 2;
            this.lblNro.Text = "Numero:";
            // 
            // lblBaños
            // 
            this.lblBaños.AutoSize = true;
            this.lblBaños.Location = new System.Drawing.Point(532, 63);
            this.lblBaños.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaños.Name = "lblBaños";
            this.lblBaños.Size = new System.Drawing.Size(59, 20);
            this.lblBaños.TabIndex = 3;
            this.lblBaños.Text = "Baños:";
            // 
            // lblHab
            // 
            this.lblHab.AutoSize = true;
            this.lblHab.Location = new System.Drawing.Point(488, 112);
            this.lblHab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHab.Name = "lblHab";
            this.lblHab.Size = new System.Drawing.Size(106, 20);
            this.lblHab.TabIndex = 4;
            this.lblHab.Text = "Habitaciones:";
            // 
            // lblMontoAlq
            // 
            this.lblMontoAlq.AutoSize = true;
            this.lblMontoAlq.Location = new System.Drawing.Point(480, 157);
            this.lblMontoAlq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoAlq.Name = "lblMontoAlq";
            this.lblMontoAlq.Size = new System.Drawing.Size(114, 20);
            this.lblMontoAlq.TabIndex = 5;
            this.lblMontoAlq.Text = "Monto Alquiler:";
            // 
            // lblMontoVta
            // 
            this.lblMontoVta.AutoSize = true;
            this.lblMontoVta.Location = new System.Drawing.Point(489, 208);
            this.lblMontoVta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoVta.Name = "lblMontoVta";
            this.lblMontoVta.Size = new System.Drawing.Size(105, 20);
            this.lblMontoVta.TabIndex = 6;
            this.lblMontoVta.Text = "Monto Venta:";
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Location = new System.Drawing.Point(492, 255);
            this.lblDescrip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(96, 20);
            this.lblDescrip.TabIndex = 7;
            this.lblDescrip.Text = "Descripcion:";
            // 
            // lblMetrosCuadrados
            // 
            this.lblMetrosCuadrados.AutoSize = true;
            this.lblMetrosCuadrados.Location = new System.Drawing.Point(86, 245);
            this.lblMetrosCuadrados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMetrosCuadrados.Name = "lblMetrosCuadrados";
            this.lblMetrosCuadrados.Size = new System.Drawing.Size(141, 20);
            this.lblMetrosCuadrados.TabIndex = 8;
            this.lblMetrosCuadrados.Text = "Metros cuadrados:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(195, 63);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 20);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "Id:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(262, 57);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(148, 26);
            this.txtID.TabIndex = 10;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(262, 146);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(148, 26);
            this.txtCalle.TabIndex = 12;
            // 
            // txtNro
            // 
            this.txtNro.Location = new System.Drawing.Point(262, 200);
            this.txtNro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNro.Name = "txtNro";
            this.txtNro.Size = new System.Drawing.Size(148, 26);
            this.txtNro.TabIndex = 13;
            // 
            // txtMetrosCuadrados
            // 
            this.txtMetrosCuadrados.Location = new System.Drawing.Point(262, 245);
            this.txtMetrosCuadrados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMetrosCuadrados.Name = "txtMetrosCuadrados";
            this.txtMetrosCuadrados.Size = new System.Drawing.Size(148, 26);
            this.txtMetrosCuadrados.TabIndex = 14;
            // 
            // txtBaños
            // 
            this.txtBaños.Location = new System.Drawing.Point(628, 63);
            this.txtBaños.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBaños.Name = "txtBaños";
            this.txtBaños.Size = new System.Drawing.Size(148, 26);
            this.txtBaños.TabIndex = 15;
            // 
            // txtHabitaciones
            // 
            this.txtHabitaciones.Location = new System.Drawing.Point(628, 112);
            this.txtHabitaciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHabitaciones.Name = "txtHabitaciones";
            this.txtHabitaciones.Size = new System.Drawing.Size(148, 26);
            this.txtHabitaciones.TabIndex = 16;
            // 
            // txtMontoAlq
            // 
            this.txtMontoAlq.Location = new System.Drawing.Point(628, 157);
            this.txtMontoAlq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMontoAlq.Name = "txtMontoAlq";
            this.txtMontoAlq.Size = new System.Drawing.Size(148, 26);
            this.txtMontoAlq.TabIndex = 17;
            // 
            // txtMontoVta
            // 
            this.txtMontoVta.Location = new System.Drawing.Point(628, 203);
            this.txtMontoVta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMontoVta.Name = "txtMontoVta";
            this.txtMontoVta.Size = new System.Drawing.Size(148, 26);
            this.txtMontoVta.TabIndex = 18;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(628, 251);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(148, 90);
            this.txtDescripcion.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.fechaInicio,
            this.fechaFin});
            this.dataGridView1.Location = new System.Drawing.Point(90, 391);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(724, 212);
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
            this.lblEstadoActual.Location = new System.Drawing.Point(123, 343);
            this.lblEstadoActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoActual.Name = "lblEstadoActual";
            this.lblEstadoActual.Size = new System.Drawing.Size(113, 20);
            this.lblEstadoActual.TabIndex = 9;
            this.lblEstadoActual.Text = "Estado Actual:";
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(262, 337);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(148, 28);
            this.cboEstado.TabIndex = 21;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(152, 623);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 35);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(278, 623);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(81, 35);
            this.btnGrabar.TabIndex = 23;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(410, 623);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 35);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboTipoInmueble
            // 
            this.cboTipoInmueble.FormattingEnabled = true;
            this.cboTipoInmueble.Location = new System.Drawing.Point(262, 100);
            this.cboTipoInmueble.Name = "cboTipoInmueble";
            this.cboTipoInmueble.Size = new System.Drawing.Size(148, 28);
            this.cboTipoInmueble.TabIndex = 25;
            // 
            // frmABMCInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 692);
            this.Controls.Add(this.cboTipoInmueble);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.ComboBox cboTipoInmueble;
    }
}