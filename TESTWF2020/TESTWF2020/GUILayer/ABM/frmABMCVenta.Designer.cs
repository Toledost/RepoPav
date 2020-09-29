namespace TESTWF2020.GUILayer.ABM
{
    partial class frmABMCVenta
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
            this.lblDireccionInmueble = new System.Windows.Forms.Label();
            this.btnSeleccionarInmueble = new System.Windows.Forms.Button();
            this.txtDireccionInmueble = new System.Windows.Forms.TextBox();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.btnSeleccionarCliente = new System.Windows.Forms.Button();
            this.lblDniCliente = new System.Windows.Forms.Label();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.chkFinanciada = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMontoCuota = new System.Windows.Forms.TextBox();
            this.lblMontoCuota = new System.Windows.Forms.Label();
            this.txtFinanciacion = new System.Windows.Forms.TextBox();
            this.lblFinanciacion = new System.Windows.Forms.Label();
            this.btnSeleccionarFinanciacion = new System.Windows.Forms.Button();
            this.txtCantCuota = new System.Windows.Forms.TextBox();
            this.lblCantCuota = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDireccionInmueble
            // 
            this.lblDireccionInmueble.AutoSize = true;
            this.lblDireccionInmueble.Location = new System.Drawing.Point(237, 24);
            this.lblDireccionInmueble.Name = "lblDireccionInmueble";
            this.lblDireccionInmueble.Size = new System.Drawing.Size(104, 13);
            this.lblDireccionInmueble.TabIndex = 0;
            this.lblDireccionInmueble.Text = "Direccion Inmueble :";
            // 
            // btnSeleccionarInmueble
            // 
            this.btnSeleccionarInmueble.Location = new System.Drawing.Point(23, 19);
            this.btnSeleccionarInmueble.Name = "btnSeleccionarInmueble";
            this.btnSeleccionarInmueble.Size = new System.Drawing.Size(150, 23);
            this.btnSeleccionarInmueble.TabIndex = 1;
            this.btnSeleccionarInmueble.Text = "Seleccionar Inmueble";
            this.btnSeleccionarInmueble.UseVisualStyleBackColor = true;
            this.btnSeleccionarInmueble.Click += new System.EventHandler(this.btnSeleccionarInmueble_Click);
            // 
            // txtDireccionInmueble
            // 
            this.txtDireccionInmueble.Location = new System.Drawing.Point(347, 21);
            this.txtDireccionInmueble.Name = "txtDireccionInmueble";
            this.txtDireccionInmueble.ReadOnly = true;
            this.txtDireccionInmueble.Size = new System.Drawing.Size(196, 20);
            this.txtDireccionInmueble.TabIndex = 2;
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Location = new System.Drawing.Point(345, 23);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.ReadOnly = true;
            this.txtDniCliente.Size = new System.Drawing.Size(196, 20);
            this.txtDniCliente.TabIndex = 5;
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(21, 21);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(150, 23);
            this.btnSeleccionarCliente.TabIndex = 4;
            this.btnSeleccionarCliente.Text = "Seleccionar Cliente";
            this.btnSeleccionarCliente.UseVisualStyleBackColor = true;
            this.btnSeleccionarCliente.Click += new System.EventHandler(this.btnSeleccionarCliente_Click);
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.Location = new System.Drawing.Point(275, 26);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(64, 13);
            this.lblDniCliente.TabIndex = 3;
            this.lblDniCliente.Text = "DNI Cliente:";
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Location = new System.Drawing.Point(19, 24);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(74, 13);
            this.lblFechaVenta.TabIndex = 6;
            this.lblFechaVenta.Text = "Fecha Venta :";
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Location = new System.Drawing.Point(254, 25);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(86, 13);
            this.lblFechaEntrega.TabIndex = 7;
            this.lblFechaEntrega.Text = "Fecha Entrega : ";
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVenta.Location = new System.Drawing.Point(99, 19);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(113, 20);
            this.dtpFechaVenta.TabIndex = 8;
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(346, 19);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(113, 20);
            this.dtpFechaEntrega.TabIndex = 9;
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Location = new System.Drawing.Point(19, 29);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(70, 13);
            this.lblMontoTotal.TabIndex = 10;
            this.lblMontoTotal.Text = "Monto Total :";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(99, 26);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(113, 20);
            this.txtMontoTotal.TabIndex = 11;
            // 
            // chkFinanciada
            // 
            this.chkFinanciada.AutoSize = true;
            this.chkFinanciada.Location = new System.Drawing.Point(22, 61);
            this.chkFinanciada.Name = "chkFinanciada";
            this.chkFinanciada.Size = new System.Drawing.Size(93, 17);
            this.chkFinanciada.TabIndex = 12;
            this.chkFinanciada.Text = "Es financiada ";
            this.chkFinanciada.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDireccionInmueble);
            this.groupBox1.Controls.Add(this.btnSeleccionarInmueble);
            this.groupBox1.Controls.Add(this.lblDireccionInmueble);
            this.groupBox1.Location = new System.Drawing.Point(46, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 52);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inmueble";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDniCliente);
            this.groupBox2.Controls.Add(this.btnSeleccionarCliente);
            this.groupBox2.Controls.Add(this.lblDniCliente);
            this.groupBox2.Location = new System.Drawing.Point(48, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 55);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpFechaEntrega);
            this.groupBox3.Controls.Add(this.dtpFechaVenta);
            this.groupBox3.Controls.Add(this.lblFechaEntrega);
            this.groupBox3.Controls.Add(this.lblFechaVenta);
            this.groupBox3.Location = new System.Drawing.Point(47, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(575, 58);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fechas";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtMontoCuota);
            this.groupBox4.Controls.Add(this.lblMontoCuota);
            this.groupBox4.Controls.Add(this.txtFinanciacion);
            this.groupBox4.Controls.Add(this.lblFinanciacion);
            this.groupBox4.Controls.Add(this.btnSeleccionarFinanciacion);
            this.groupBox4.Controls.Add(this.txtCantCuota);
            this.groupBox4.Controls.Add(this.lblCantCuota);
            this.groupBox4.Controls.Add(this.chkFinanciada);
            this.groupBox4.Controls.Add(this.txtMontoTotal);
            this.groupBox4.Controls.Add(this.lblMontoTotal);
            this.groupBox4.Location = new System.Drawing.Point(47, 227);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(575, 168);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Monto y Financiacion";
            // 
            // txtMontoCuota
            // 
            this.txtMontoCuota.Location = new System.Drawing.Point(346, 131);
            this.txtMontoCuota.Name = "txtMontoCuota";
            this.txtMontoCuota.Size = new System.Drawing.Size(113, 20);
            this.txtMontoCuota.TabIndex = 16;
            // 
            // lblMontoCuota
            // 
            this.lblMontoCuota.AutoSize = true;
            this.lblMontoCuota.Location = new System.Drawing.Point(266, 135);
            this.lblMontoCuota.Name = "lblMontoCuota";
            this.lblMontoCuota.Size = new System.Drawing.Size(74, 13);
            this.lblMontoCuota.TabIndex = 15;
            this.lblMontoCuota.Text = "Monto Cuota :";
            // 
            // txtFinanciacion
            // 
            this.txtFinanciacion.Location = new System.Drawing.Point(346, 91);
            this.txtFinanciacion.Name = "txtFinanciacion";
            this.txtFinanciacion.ReadOnly = true;
            this.txtFinanciacion.Size = new System.Drawing.Size(196, 20);
            this.txtFinanciacion.TabIndex = 7;
            // 
            // lblFinanciacion
            // 
            this.lblFinanciacion.AutoSize = true;
            this.lblFinanciacion.Location = new System.Drawing.Point(224, 94);
            this.lblFinanciacion.Name = "lblFinanciacion";
            this.lblFinanciacion.Size = new System.Drawing.Size(116, 13);
            this.lblFinanciacion.TabIndex = 6;
            this.lblFinanciacion.Text = "Nombre Financiacion : ";
            // 
            // btnSeleccionarFinanciacion
            // 
            this.btnSeleccionarFinanciacion.Location = new System.Drawing.Point(22, 89);
            this.btnSeleccionarFinanciacion.Name = "btnSeleccionarFinanciacion";
            this.btnSeleccionarFinanciacion.Size = new System.Drawing.Size(150, 23);
            this.btnSeleccionarFinanciacion.TabIndex = 6;
            this.btnSeleccionarFinanciacion.Text = "Seleccionar Financiacion";
            this.btnSeleccionarFinanciacion.UseVisualStyleBackColor = true;
            this.btnSeleccionarFinanciacion.Click += new System.EventHandler(this.btnSeleccionarFinanciacion_Click);
            // 
            // txtCantCuota
            // 
            this.txtCantCuota.Location = new System.Drawing.Point(131, 131);
            this.txtCantCuota.Name = "txtCantCuota";
            this.txtCantCuota.Size = new System.Drawing.Size(113, 20);
            this.txtCantCuota.TabIndex = 14;
            // 
            // lblCantCuota
            // 
            this.lblCantCuota.AutoSize = true;
            this.lblCantCuota.Location = new System.Drawing.Point(19, 134);
            this.lblCantCuota.Name = "lblCantCuota";
            this.lblCantCuota.Size = new System.Drawing.Size(106, 13);
            this.lblCantCuota.TabIndex = 13;
            this.lblCantCuota.Text = "Cantidad de Cuotas :";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(48, 419);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(98, 43);
            this.btnGrabar.TabIndex = 17;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(524, 419);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(98, 43);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmABMCVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(672, 481);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmABMCVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDireccionInmueble;
        private System.Windows.Forms.Button btnSeleccionarInmueble;
        private System.Windows.Forms.TextBox txtDireccionInmueble;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.Button btnSeleccionarCliente;
        private System.Windows.Forms.Label lblDniCliente;
        private System.Windows.Forms.Label lblFechaVenta;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.CheckBox chkFinanciada;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSeleccionarFinanciacion;
        private System.Windows.Forms.TextBox txtCantCuota;
        private System.Windows.Forms.Label lblCantCuota;
        private System.Windows.Forms.TextBox txtFinanciacion;
        private System.Windows.Forms.Label lblFinanciacion;
        private System.Windows.Forms.TextBox txtMontoCuota;
        private System.Windows.Forms.Label lblMontoCuota;
    }
}