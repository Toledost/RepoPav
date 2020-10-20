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
            this.lblDireccionInmueble.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionInmueble.Location = new System.Drawing.Point(414, 49);
            this.lblDireccionInmueble.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccionInmueble.Name = "lblDireccionInmueble";
            this.lblDireccionInmueble.Size = new System.Drawing.Size(204, 24);
            this.lblDireccionInmueble.TabIndex = 0;
            this.lblDireccionInmueble.Text = "Direccion Inmueble :";
            // 
            // txtDireccionInmueble
            // 
            this.txtDireccionInmueble.Location = new System.Drawing.Point(626, 43);
            this.txtDireccionInmueble.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionInmueble.Name = "txtDireccionInmueble";
            this.txtDireccionInmueble.ReadOnly = true;
            this.txtDireccionInmueble.Size = new System.Drawing.Size(324, 30);
            this.txtDireccionInmueble.TabIndex = 2;
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Location = new System.Drawing.Point(626, 106);
            this.txtDniCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.ReadOnly = true;
            this.txtDniCliente.Size = new System.Drawing.Size(324, 30);
            this.txtDniCliente.TabIndex = 5;
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniCliente.Location = new System.Drawing.Point(497, 111);
            this.lblDniCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(121, 24);
            this.lblDniCliente.TabIndex = 3;
            this.lblDniCliente.Text = "DNI Cliente:";
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVenta.Location = new System.Drawing.Point(25, 50);
            this.lblFechaVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(141, 24);
            this.lblFechaVenta.TabIndex = 6;
            this.lblFechaVenta.Text = "Fecha Venta :";
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEntrega.Location = new System.Drawing.Point(422, 50);
            this.lblFechaEntrega.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(166, 24);
            this.lblFechaEntrega.TabIndex = 7;
            this.lblFechaEntrega.Text = "Fecha Entrega : ";
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.CalendarMonthBackground = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtpFechaVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVenta.Location = new System.Drawing.Point(174, 50);
            this.dtpFechaVenta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(197, 30);
            this.dtpFechaVenta.TabIndex = 8;
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.CalendarMonthBackground = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtpFechaEntrega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(596, 50);
            this.dtpFechaEntrega.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(197, 30);
            this.dtpFechaEntrega.TabIndex = 9;
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotal.Location = new System.Drawing.Point(25, 55);
            this.lblMontoTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(132, 24);
            this.lblMontoTotal.TabIndex = 10;
            this.lblMontoTotal.Text = "Monto Total :";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(165, 50);
            this.txtMontoTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.ReadOnly = true;
            this.txtMontoTotal.Size = new System.Drawing.Size(226, 30);
            this.txtMontoTotal.TabIndex = 11;
            // 
            // chkFinanciada
            // 
            this.chkFinanciada.AutoSize = true;
            this.chkFinanciada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFinanciada.Location = new System.Drawing.Point(29, 137);
            this.chkFinanciada.Margin = new System.Windows.Forms.Padding(4);
            this.chkFinanciada.Name = "chkFinanciada";
            this.chkFinanciada.Size = new System.Drawing.Size(163, 28);
            this.chkFinanciada.TabIndex = 12;
            this.chkFinanciada.Text = "Es financiada ";
            this.chkFinanciada.UseVisualStyleBackColor = true;
            // 
            // gboFechas
            // 
            this.gboFechas.BackColor = System.Drawing.SystemColors.Info;
            this.gboFechas.Controls.Add(this.dtpFechaEntrega);
            this.gboFechas.Controls.Add(this.dtpFechaVenta);
            this.gboFechas.Controls.Add(this.lblFechaEntrega);
            this.gboFechas.Controls.Add(this.lblFechaVenta);
            this.gboFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboFechas.Location = new System.Drawing.Point(13, 234);
            this.gboFechas.Margin = new System.Windows.Forms.Padding(4);
            this.gboFechas.Name = "gboFechas";
            this.gboFechas.Padding = new System.Windows.Forms.Padding(4);
            this.gboFechas.Size = new System.Drawing.Size(1328, 110);
            this.gboFechas.TabIndex = 15;
            this.gboFechas.TabStop = false;
            this.gboFechas.Text = "Fechas";
            // 
            // gboMontoFinanciacion
            // 
            this.gboMontoFinanciacion.BackColor = System.Drawing.SystemColors.Info;
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
            this.gboMontoFinanciacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboMontoFinanciacion.Location = new System.Drawing.Point(13, 371);
            this.gboMontoFinanciacion.Margin = new System.Windows.Forms.Padding(4);
            this.gboMontoFinanciacion.Name = "gboMontoFinanciacion";
            this.gboMontoFinanciacion.Padding = new System.Windows.Forms.Padding(4);
            this.gboMontoFinanciacion.Size = new System.Drawing.Size(1328, 288);
            this.gboMontoFinanciacion.TabIndex = 16;
            this.gboMontoFinanciacion.TabStop = false;
            this.gboMontoFinanciacion.Text = "Monto y Financiacion";
            // 
            // txtMontoCuota
            // 
            this.txtMontoCuota.Location = new System.Drawing.Point(703, 233);
            this.txtMontoCuota.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoCuota.Name = "txtMontoCuota";
            this.txtMontoCuota.ReadOnly = true;
            this.txtMontoCuota.Size = new System.Drawing.Size(257, 30);
            this.txtMontoCuota.TabIndex = 16;
            // 
            // lblMontoCuota
            // 
            this.lblMontoCuota.AutoSize = true;
            this.lblMontoCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoCuota.Location = new System.Drawing.Point(561, 237);
            this.lblMontoCuota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoCuota.Name = "lblMontoCuota";
            this.lblMontoCuota.Size = new System.Drawing.Size(134, 24);
            this.lblMontoCuota.TabIndex = 15;
            this.lblMontoCuota.Text = "Monto Cuota:";
            // 
            // txtFinanciacion
            // 
            this.txtFinanciacion.Location = new System.Drawing.Point(854, 133);
            this.txtFinanciacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtFinanciacion.Name = "txtFinanciacion";
            this.txtFinanciacion.ReadOnly = true;
            this.txtFinanciacion.Size = new System.Drawing.Size(299, 30);
            this.txtFinanciacion.TabIndex = 7;
            // 
            // lblFinanciacion
            // 
            this.lblFinanciacion.AutoSize = true;
            this.lblFinanciacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinanciacion.Location = new System.Drawing.Point(617, 139);
            this.lblFinanciacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinanciacion.Name = "lblFinanciacion";
            this.lblFinanciacion.Size = new System.Drawing.Size(229, 24);
            this.lblFinanciacion.TabIndex = 6;
            this.lblFinanciacion.Text = "Nombre Financiacion : ";
            // 
            // btnSeleccionarFinanciacion
            // 
            this.btnSeleccionarFinanciacion.Image = global::TESTWF2020.Properties.Resources.icons8_natural_user_interface_2_48;
            this.btnSeleccionarFinanciacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionarFinanciacion.Location = new System.Drawing.Point(246, 115);
            this.btnSeleccionarFinanciacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeleccionarFinanciacion.Name = "btnSeleccionarFinanciacion";
            this.btnSeleccionarFinanciacion.Size = new System.Drawing.Size(332, 68);
            this.btnSeleccionarFinanciacion.TabIndex = 6;
            this.btnSeleccionarFinanciacion.Text = "Seleccionar Financiacion";
            this.btnSeleccionarFinanciacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionarFinanciacion.UseVisualStyleBackColor = true;
            this.btnSeleccionarFinanciacion.Click += new System.EventHandler(this.btnSeleccionarFinanciacion_Click);
            // 
            // txtCantCuota
            // 
            this.txtCantCuota.Location = new System.Drawing.Point(237, 233);
            this.txtCantCuota.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantCuota.Name = "txtCantCuota";
            this.txtCantCuota.ReadOnly = true;
            this.txtCantCuota.Size = new System.Drawing.Size(225, 30);
            this.txtCantCuota.TabIndex = 14;
            // 
            // lblCantCuota
            // 
            this.lblCantCuota.AutoSize = true;
            this.lblCantCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantCuota.Location = new System.Drawing.Point(25, 238);
            this.lblCantCuota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantCuota.Name = "lblCantCuota";
            this.lblCantCuota.Size = new System.Drawing.Size(198, 24);
            this.lblCantCuota.TabIndex = 13;
            this.lblCantCuota.Text = "Cantidad de Cuotas:";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = global::TESTWF2020.Properties.Resources.icons8_guardar_48;
            this.btnGrabar.Location = new System.Drawing.Point(13, 682);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(101, 61);
            this.btnGrabar.TabIndex = 17;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Image = global::TESTWF2020.Properties.Resources.icons8_cerrar_ventana_48;
            this.btnSalir.Location = new System.Drawing.Point(1243, 682);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(98, 61);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnSeleccionarConsulta
            // 
            this.btnSeleccionarConsulta.Image = global::TESTWF2020.Properties.Resources.icons8_natural_user_interface_2_48;
            this.btnSeleccionarConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionarConsulta.Location = new System.Drawing.Point(29, 58);
            this.btnSeleccionarConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeleccionarConsulta.Name = "btnSeleccionarConsulta";
            this.btnSeleccionarConsulta.Size = new System.Drawing.Size(332, 68);
            this.btnSeleccionarConsulta.TabIndex = 20;
            this.btnSeleccionarConsulta.Text = "Seleccionar Consulta";
            this.btnSeleccionarConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionarConsulta.UseVisualStyleBackColor = true;
            this.btnSeleccionarConsulta.Click += new System.EventHandler(this.btnSeleccionarConsulta_Click);
            // 
            // gboInmuebleCliente
            // 
            this.gboInmuebleCliente.BackColor = System.Drawing.SystemColors.Info;
            this.gboInmuebleCliente.Controls.Add(this.txtDireccionInmueble);
            this.gboInmuebleCliente.Controls.Add(this.lblDniCliente);
            this.gboInmuebleCliente.Controls.Add(this.lblDireccionInmueble);
            this.gboInmuebleCliente.Controls.Add(this.txtDniCliente);
            this.gboInmuebleCliente.Controls.Add(this.btnSeleccionarConsulta);
            this.gboInmuebleCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboInmuebleCliente.Location = new System.Drawing.Point(13, 27);
            this.gboInmuebleCliente.Margin = new System.Windows.Forms.Padding(4);
            this.gboInmuebleCliente.Name = "gboInmuebleCliente";
            this.gboInmuebleCliente.Padding = new System.Windows.Forms.Padding(4);
            this.gboInmuebleCliente.Size = new System.Drawing.Size(1328, 179);
            this.gboInmuebleCliente.TabIndex = 21;
            this.gboInmuebleCliente.TabStop = false;
            this.gboInmuebleCliente.Text = "Inmueble y Cliente";
            // 
            // frmABMCVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(1356, 756);
            this.Controls.Add(this.gboInmuebleCliente);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.gboMontoFinanciacion);
            this.Controls.Add(this.gboFechas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
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