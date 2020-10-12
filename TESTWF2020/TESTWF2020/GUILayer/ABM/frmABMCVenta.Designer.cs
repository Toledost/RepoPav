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
            this.txtDireccionInmueble = new System.Windows.Forms.TextBox();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.lblDniCliente = new System.Windows.Forms.Label();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.chkFinanciada = new System.Windows.Forms.CheckBox();
            this.gboFechas = new System.Windows.Forms.GroupBox();
            this.gboMontoFinanciacion = new System.Windows.Forms.GroupBox();
            this.txtMontoCuota = new System.Windows.Forms.TextBox();
            this.lblMontoCuota = new System.Windows.Forms.Label();
            this.txtFinanciacion = new System.Windows.Forms.TextBox();
            this.lblFinanciacion = new System.Windows.Forms.Label();
            this.btnSeleccionarFinanciacion = new System.Windows.Forms.Button();
            this.txtCantCuota = new System.Windows.Forms.TextBox();
            this.lblCantCuota = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnSeleccionarConsulta = new System.Windows.Forms.Button();
            this.gboInmuebleCliente = new System.Windows.Forms.GroupBox();
            this.gboFechas.SuspendLayout();
            this.gboMontoFinanciacion.SuspendLayout();
            this.gboInmuebleCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDireccionInmueble
            // 
            this.lblDireccionInmueble.AutoSize = true;
            this.lblDireccionInmueble.Location = new System.Drawing.Point(229, 34);
            this.lblDireccionInmueble.Name = "lblDireccionInmueble";
            this.lblDireccionInmueble.Size = new System.Drawing.Size(104, 13);
            this.lblDireccionInmueble.TabIndex = 0;
            this.lblDireccionInmueble.Text = "Direccion Inmueble :";
            // 
            // txtDireccionInmueble
            // 
            this.txtDireccionInmueble.Location = new System.Drawing.Point(351, 31);
            this.txtDireccionInmueble.Name = "txtDireccionInmueble";
            this.txtDireccionInmueble.ReadOnly = true;
            this.txtDireccionInmueble.Size = new System.Drawing.Size(196, 20);
            this.txtDireccionInmueble.TabIndex = 2;
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Location = new System.Drawing.Point(351, 82);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.ReadOnly = true;
            this.txtDniCliente.Size = new System.Drawing.Size(196, 20);
            this.txtDniCliente.TabIndex = 5;
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.Location = new System.Drawing.Point(269, 82);
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
            this.txtMontoTotal.ReadOnly = true;
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
            this.chkFinanciada.CheckedChanged += new System.EventHandler(this.chkFinanciada_CheckedChanged);
            // 
            // gboFechas
            // 
            this.gboFechas.Controls.Add(this.dtpFechaEntrega);
            this.gboFechas.Controls.Add(this.dtpFechaVenta);
            this.gboFechas.Controls.Add(this.lblFechaEntrega);
            this.gboFechas.Controls.Add(this.lblFechaVenta);
            this.gboFechas.Location = new System.Drawing.Point(47, 154);
            this.gboFechas.Name = "gboFechas";
            this.gboFechas.Size = new System.Drawing.Size(575, 58);
            this.gboFechas.TabIndex = 15;
            this.gboFechas.TabStop = false;
            this.gboFechas.Text = "Fechas";
            // 
            // gboMontoFinanciacion
            // 
            this.gboMontoFinanciacion.Controls.Add(this.txtMontoCuota);
            this.gboMontoFinanciacion.Controls.Add(this.lblMontoCuota);
            this.gboMontoFinanciacion.Controls.Add(this.txtFinanciacion);
            this.gboMontoFinanciacion.Controls.Add(this.lblFinanciacion);
            this.gboMontoFinanciacion.Controls.Add(this.btnSeleccionarFinanciacion);
            this.gboMontoFinanciacion.Controls.Add(this.txtCantCuota);
            this.gboMontoFinanciacion.Controls.Add(this.lblCantCuota);
            this.gboMontoFinanciacion.Controls.Add(this.chkFinanciada);
            this.gboMontoFinanciacion.Controls.Add(this.txtMontoTotal);
            this.gboMontoFinanciacion.Controls.Add(this.lblMontoTotal);
            this.gboMontoFinanciacion.Location = new System.Drawing.Point(47, 227);
            this.gboMontoFinanciacion.Name = "gboMontoFinanciacion";
            this.gboMontoFinanciacion.Size = new System.Drawing.Size(575, 168);
            this.gboMontoFinanciacion.TabIndex = 16;
            this.gboMontoFinanciacion.TabStop = false;
            this.gboMontoFinanciacion.Text = "Monto y Financiacion";
            // 
            // txtMontoCuota
            // 
            this.txtMontoCuota.Location = new System.Drawing.Point(346, 131);
            this.txtMontoCuota.Name = "txtMontoCuota";
            this.txtMontoCuota.ReadOnly = true;
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
            this.txtCantCuota.ReadOnly = true;
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
            // btnSeleccionarConsulta
            // 
            this.btnSeleccionarConsulta.Location = new System.Drawing.Point(64, 50);
            this.btnSeleccionarConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeleccionarConsulta.Name = "btnSeleccionarConsulta";
            this.btnSeleccionarConsulta.Size = new System.Drawing.Size(123, 24);
            this.btnSeleccionarConsulta.TabIndex = 20;
            this.btnSeleccionarConsulta.Text = "Seleccionar Consulta";
            this.btnSeleccionarConsulta.UseVisualStyleBackColor = true;
            this.btnSeleccionarConsulta.Click += new System.EventHandler(this.btnSeleccionarConsulta_Click);
            // 
            // gboInmuebleCliente
            // 
            this.gboInmuebleCliente.Controls.Add(this.txtDireccionInmueble);
            this.gboInmuebleCliente.Controls.Add(this.lblDniCliente);
            this.gboInmuebleCliente.Controls.Add(this.lblDireccionInmueble);
            this.gboInmuebleCliente.Controls.Add(this.txtDniCliente);
            this.gboInmuebleCliente.Controls.Add(this.btnSeleccionarConsulta);
            this.gboInmuebleCliente.Location = new System.Drawing.Point(48, 16);
            this.gboInmuebleCliente.Name = "gboInmuebleCliente";
            this.gboInmuebleCliente.Size = new System.Drawing.Size(573, 126);
            this.gboInmuebleCliente.TabIndex = 21;
            this.gboInmuebleCliente.TabStop = false;
            this.gboInmuebleCliente.Text = "Inmueble y Cliente";
            // 
            // frmABMCVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(672, 481);
            this.Controls.Add(this.gboInmuebleCliente);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.gboMontoFinanciacion);
            this.Controls.Add(this.gboFechas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmABMCVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.frmABMCVenta_Load);
            this.gboFechas.ResumeLayout(false);
            this.gboFechas.PerformLayout();
            this.gboMontoFinanciacion.ResumeLayout(false);
            this.gboMontoFinanciacion.PerformLayout();
            this.gboInmuebleCliente.ResumeLayout(false);
            this.gboInmuebleCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDireccionInmueble;
        private System.Windows.Forms.TextBox txtDireccionInmueble;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.Label lblDniCliente;
        private System.Windows.Forms.Label lblFechaVenta;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.CheckBox chkFinanciada;
        private System.Windows.Forms.GroupBox gboFechas;
        private System.Windows.Forms.GroupBox gboMontoFinanciacion;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSeleccionarFinanciacion;
        private System.Windows.Forms.TextBox txtCantCuota;
        private System.Windows.Forms.Label lblCantCuota;
        private System.Windows.Forms.TextBox txtFinanciacion;
        private System.Windows.Forms.Label lblFinanciacion;
        private System.Windows.Forms.TextBox txtMontoCuota;
        private System.Windows.Forms.Label lblMontoCuota;
        private System.Windows.Forms.Button btnSeleccionarConsulta;
        private System.Windows.Forms.GroupBox gboInmuebleCliente;
    }
}