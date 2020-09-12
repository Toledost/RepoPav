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
            this.lblMetrosCuadrados = new System.Windows.Forms.Label();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtMetrosCuadradosMax = new System.Windows.Forms.TextBox();
            this.txtHabitaciones = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.txtMontoAlquilerMax = new System.Windows.Forms.TextBox();
            this.txtMontoAlquilerMin = new System.Windows.Forms.TextBox();
            this.lblMontoMaxAlq = new System.Windows.Forms.Label();
            this.lblMontoMinAlq = new System.Windows.Forms.Label();
            this.lblMontoAlq = new System.Windows.Forms.Label();
            this.txtMontoVentaMax = new System.Windows.Forms.TextBox();
            this.txtMontoVentaMin = new System.Windows.Forms.TextBox();
            this.lblMontoMaxVta = new System.Windows.Forms.Label();
            this.lblMontoMinVta = new System.Windows.Forms.Label();
            this.lblMontoVta = new System.Windows.Forms.Label();
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
            // lblMetrosCuadrados
            // 
            this.lblMetrosCuadrados.AutoSize = true;
            this.lblMetrosCuadrados.Location = new System.Drawing.Point(92, 128);
            this.lblMetrosCuadrados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMetrosCuadrados.Name = "lblMetrosCuadrados";
            this.lblMetrosCuadrados.Size = new System.Drawing.Size(141, 20);
            this.lblMetrosCuadrados.TabIndex = 1;
            this.lblMetrosCuadrados.Text = "Metros cuadrados:";
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
            this.lblBaños.Location = new System.Drawing.Point(675, 54);
            this.lblBaños.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaños.Name = "lblBaños";
            this.lblBaños.Size = new System.Drawing.Size(59, 20);
            this.lblBaños.TabIndex = 4;
            this.lblBaños.Text = "Baños:";
            // 
            // txtCalle
            // 
            this.txtCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalle.Location = new System.Drawing.Point(165, 66);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(148, 26);
            this.txtCalle.TabIndex = 6;
            // 
            // txtBaños
            // 
            this.txtBaños.Location = new System.Drawing.Point(812, 43);
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
            this.txtMetrosCuadradosMin.TabIndex = 9;
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
            this.dataGridView1.Location = new System.Drawing.Point(74, 492);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(674, 142);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 669);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(195, 669);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 35);
            this.button4.TabIndex = 15;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(316, 669);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 35);
            this.button5.TabIndex = 16;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(452, 669);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 35);
            this.button6.TabIndex = 17;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(579, 669);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(112, 35);
            this.button7.TabIndex = 18;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(716, 669);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(112, 35);
            this.button8.TabIndex = 19;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(812, 123);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(148, 26);
            this.txtTipo.TabIndex = 29;
            // 
            // txtMetrosCuadradosMax
            // 
            this.txtMetrosCuadradosMax.Location = new System.Drawing.Point(402, 180);
            this.txtMetrosCuadradosMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMetrosCuadradosMax.Name = "txtMetrosCuadradosMax";
            this.txtMetrosCuadradosMax.Size = new System.Drawing.Size(148, 26);
            this.txtMetrosCuadradosMax.TabIndex = 28;
            // 
            // txtHabitaciones
            // 
            this.txtHabitaciones.Location = new System.Drawing.Point(812, 83);
            this.txtHabitaciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHabitaciones.Name = "txtHabitaciones";
            this.txtHabitaciones.Size = new System.Drawing.Size(148, 26);
            this.txtHabitaciones.TabIndex = 25;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(675, 123);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 20);
            this.lblTipo.TabIndex = 21;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Location = new System.Drawing.Point(675, 83);
            this.lblHabitacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(106, 20);
            this.lblHabitacion.TabIndex = 20;
            this.lblHabitacion.Text = "Habitaciones:";
            // 
            // txtMontoAlquilerMax
            // 
            this.txtMontoAlquilerMax.Location = new System.Drawing.Point(402, 300);
            this.txtMontoAlquilerMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMontoAlquilerMax.Name = "txtMontoAlquilerMax";
            this.txtMontoAlquilerMax.Size = new System.Drawing.Size(148, 26);
            this.txtMontoAlquilerMax.TabIndex = 34;
            // 
            // txtMontoAlquilerMin
            // 
            this.txtMontoAlquilerMin.Location = new System.Drawing.Point(165, 300);
            this.txtMontoAlquilerMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMontoAlquilerMin.Name = "txtMontoAlquilerMin";
            this.txtMontoAlquilerMin.Size = new System.Drawing.Size(148, 26);
            this.txtMontoAlquilerMin.TabIndex = 33;
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
            // txtMontoVentaMax
            // 
            this.txtMontoVentaMax.Location = new System.Drawing.Point(402, 412);
            this.txtMontoVentaMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMontoVentaMax.Name = "txtMontoVentaMax";
            this.txtMontoVentaMax.Size = new System.Drawing.Size(148, 26);
            this.txtMontoVentaMax.TabIndex = 39;
            // 
            // txtMontoVentaMin
            // 
            this.txtMontoVentaMin.Location = new System.Drawing.Point(165, 412);
            this.txtMontoVentaMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMontoVentaMin.Name = "txtMontoVentaMin";
            this.txtMontoVentaMin.Size = new System.Drawing.Size(148, 26);
            this.txtMontoVentaMin.TabIndex = 38;
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
            // frmInmuebles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 740);
            this.Controls.Add(this.txtMontoVentaMax);
            this.Controls.Add(this.txtMontoVentaMin);
            this.Controls.Add(this.lblMontoMaxVta);
            this.Controls.Add(this.lblMontoMinVta);
            this.Controls.Add(this.lblMontoVta);
            this.Controls.Add(this.txtMontoAlquilerMax);
            this.Controls.Add(this.txtMontoAlquilerMin);
            this.Controls.Add(this.lblMontoMaxAlq);
            this.Controls.Add(this.lblMontoMinAlq);
            this.Controls.Add(this.lblMontoAlq);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtMetrosCuadradosMax);
            this.Controls.Add(this.txtHabitaciones);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblHabitacion);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMetrosCuadradosMin);
            this.Controls.Add(this.txtBaños);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.lblBaños);
            this.Controls.Add(this.lblMtsMax);
            this.Controls.Add(this.lblMtsMin);
            this.Controls.Add(this.lblMetrosCuadrados);
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
        private System.Windows.Forms.Label lblMetrosCuadrados;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtMetrosCuadradosMax;
        private System.Windows.Forms.TextBox txtHabitaciones;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.TextBox txtMontoAlquilerMax;
        private System.Windows.Forms.TextBox txtMontoAlquilerMin;
        private System.Windows.Forms.Label lblMontoMaxAlq;
        private System.Windows.Forms.Label lblMontoMinAlq;
        private System.Windows.Forms.Label lblMontoAlq;
        private System.Windows.Forms.TextBox txtMontoVentaMax;
        private System.Windows.Forms.TextBox txtMontoVentaMin;
        private System.Windows.Forms.Label lblMontoMaxVta;
        private System.Windows.Forms.Label lblMontoMinVta;
        private System.Windows.Forms.Label lblMontoVta;
    }
}