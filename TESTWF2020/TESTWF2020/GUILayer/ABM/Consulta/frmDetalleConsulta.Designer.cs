﻿namespace TESTWF2020.GUILayer.ABM
{
    partial class frmDetalleConsulta
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
            this.cboEstadoConsulta = new System.Windows.Forms.ComboBox();
            this.cboViaConsulta = new System.Windows.Forms.ComboBox();
            this.cboIDMedioConocimiento = new System.Windows.Forms.ComboBox();
            this.cboIDTipoTrans = new System.Windows.Forms.ComboBox();
            this.txtDNICliente = new System.Windows.Forms.TextBox();
            this.txtIDInmueble = new System.Windows.Forms.TextBox();
            this.txtIDConsulta = new System.Windows.Forms.TextBox();
            this.lblViaConsulta = new System.Windows.Forms.Label();
            this.lblEstadoConsulta = new System.Windows.Forms.Label();
            this.lblMedioConocomiento = new System.Windows.Forms.Label();
            this.lblDNICliente = new System.Windows.Forms.Label();
            this.lblIDInuemble = new System.Windows.Forms.Label();
            this.lblTipoTrans = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnElegir = new System.Windows.Forms.Button();
            this.btnElegirCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboEstadoConsulta
            // 
            this.cboEstadoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoConsulta.FormattingEnabled = true;
            this.cboEstadoConsulta.Location = new System.Drawing.Point(579, 134);
            this.cboEstadoConsulta.Name = "cboEstadoConsulta";
            this.cboEstadoConsulta.Size = new System.Drawing.Size(181, 28);
            this.cboEstadoConsulta.TabIndex = 102;
            this.cboEstadoConsulta.Tag = "Estado de Consulta";
            // 
            // cboViaConsulta
            // 
            this.cboViaConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboViaConsulta.FormattingEnabled = true;
            this.cboViaConsulta.Location = new System.Drawing.Point(579, 87);
            this.cboViaConsulta.Name = "cboViaConsulta";
            this.cboViaConsulta.Size = new System.Drawing.Size(181, 28);
            this.cboViaConsulta.TabIndex = 101;
            this.cboViaConsulta.Tag = "Via de Consulta";
            // 
            // cboIDMedioConocimiento
            // 
            this.cboIDMedioConocimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIDMedioConocimiento.FormattingEnabled = true;
            this.cboIDMedioConocimiento.Location = new System.Drawing.Point(579, 40);
            this.cboIDMedioConocimiento.Name = "cboIDMedioConocimiento";
            this.cboIDMedioConocimiento.Size = new System.Drawing.Size(181, 28);
            this.cboIDMedioConocimiento.TabIndex = 100;
            this.cboIDMedioConocimiento.Tag = "Medio de Conocimiento";
            // 
            // cboIDTipoTrans
            // 
            this.cboIDTipoTrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIDTipoTrans.FormattingEnabled = true;
            this.cboIDTipoTrans.Location = new System.Drawing.Point(166, 73);
            this.cboIDTipoTrans.Name = "cboIDTipoTrans";
            this.cboIDTipoTrans.Size = new System.Drawing.Size(162, 28);
            this.cboIDTipoTrans.TabIndex = 99;
            this.cboIDTipoTrans.Tag = "Tipo Transaccion";
            // 
            // txtDNICliente
            // 
            this.txtDNICliente.Location = new System.Drawing.Point(232, 160);
            this.txtDNICliente.Name = "txtDNICliente";
            this.txtDNICliente.ReadOnly = true;
            this.txtDNICliente.Size = new System.Drawing.Size(96, 26);
            this.txtDNICliente.TabIndex = 95;
            this.txtDNICliente.Tag = "Dni Cliente";
            // 
            // txtIDInmueble
            // 
            this.txtIDInmueble.Location = new System.Drawing.Point(232, 109);
            this.txtIDInmueble.Name = "txtIDInmueble";
            this.txtIDInmueble.ReadOnly = true;
            this.txtIDInmueble.Size = new System.Drawing.Size(96, 26);
            this.txtIDInmueble.TabIndex = 94;
            this.txtIDInmueble.Tag = "Inmueble";
            // 
            // txtIDConsulta
            // 
            this.txtIDConsulta.Location = new System.Drawing.Point(166, 40);
            this.txtIDConsulta.Name = "txtIDConsulta";
            this.txtIDConsulta.ReadOnly = true;
            this.txtIDConsulta.Size = new System.Drawing.Size(162, 26);
            this.txtIDConsulta.TabIndex = 92;
            // 
            // lblViaConsulta
            // 
            this.lblViaConsulta.AutoSize = true;
            this.lblViaConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViaConsulta.Location = new System.Drawing.Point(426, 92);
            this.lblViaConsulta.Name = "lblViaConsulta";
            this.lblViaConsulta.Size = new System.Drawing.Size(128, 18);
            this.lblViaConsulta.TabIndex = 89;
            this.lblViaConsulta.Text = "Via de consulta:";
            // 
            // lblEstadoConsulta
            // 
            this.lblEstadoConsulta.AutoSize = true;
            this.lblEstadoConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoConsulta.Location = new System.Drawing.Point(396, 139);
            this.lblEstadoConsulta.Name = "lblEstadoConsulta";
            this.lblEstadoConsulta.Size = new System.Drawing.Size(158, 18);
            this.lblEstadoConsulta.TabIndex = 88;
            this.lblEstadoConsulta.Text = "Estado de consulta:";
            // 
            // lblMedioConocomiento
            // 
            this.lblMedioConocomiento.AutoSize = true;
            this.lblMedioConocomiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedioConocomiento.Location = new System.Drawing.Point(365, 45);
            this.lblMedioConocomiento.Name = "lblMedioConocomiento";
            this.lblMedioConocomiento.Size = new System.Drawing.Size(189, 18);
            this.lblMedioConocomiento.TabIndex = 87;
            this.lblMedioConocomiento.Text = "Medio de conocimiento:";
            // 
            // lblDNICliente
            // 
            this.lblDNICliente.AutoSize = true;
            this.lblDNICliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNICliente.Location = new System.Drawing.Point(62, 160);
            this.lblDNICliente.Name = "lblDNICliente";
            this.lblDNICliente.Size = new System.Drawing.Size(98, 18);
            this.lblDNICliente.TabIndex = 84;
            this.lblDNICliente.Text = "DNI Cliente:";
            // 
            // lblIDInuemble
            // 
            this.lblIDInuemble.AutoSize = true;
            this.lblIDInuemble.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDInuemble.Location = new System.Drawing.Point(80, 114);
            this.lblIDInuemble.Name = "lblIDInuemble";
            this.lblIDInuemble.Size = new System.Drawing.Size(80, 18);
            this.lblIDInuemble.TabIndex = 83;
            this.lblIDInuemble.Text = "Inmueble:";
            // 
            // lblTipoTrans
            // 
            this.lblTipoTrans.AutoSize = true;
            this.lblTipoTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoTrans.Location = new System.Drawing.Point(16, 74);
            this.lblTipoTrans.Name = "lblTipoTrans";
            this.lblTipoTrans.Size = new System.Drawing.Size(144, 18);
            this.lblTipoTrans.TabIndex = 82;
            this.lblTipoTrans.Text = "Tipo Transaccion:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(-68, 74);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 79;
            this.lblID.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 105;
            this.label1.Text = "ID:";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::TESTWF2020.Properties.Resources.icons8_cerrar_ventana_48;
            this.btnSalir.Location = new System.Drawing.Point(702, 305);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 47);
            this.btnSalir.TabIndex = 106;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::TESTWF2020.Properties.Resources.icons8_editar_48;
            this.btnEditar.Location = new System.Drawing.Point(12, 305);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(76, 47);
            this.btnEditar.TabIndex = 107;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = global::TESTWF2020.Properties.Resources.icons8_guardar_48;
            this.btnGrabar.Location = new System.Drawing.Point(109, 305);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 47);
            this.btnGrabar.TabIndex = 108;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnElegir
            // 
            this.btnElegir.Location = new System.Drawing.Point(166, 107);
            this.btnElegir.Name = "btnElegir";
            this.btnElegir.Size = new System.Drawing.Size(57, 31);
            this.btnElegir.TabIndex = 109;
            this.btnElegir.Text = "Elegir";
            this.btnElegir.UseVisualStyleBackColor = true;
            this.btnElegir.Click += new System.EventHandler(this.btnElegir_Click);
            // 
            // btnElegirCliente
            // 
            this.btnElegirCliente.Location = new System.Drawing.Point(166, 156);
            this.btnElegirCliente.Name = "btnElegirCliente";
            this.btnElegirCliente.Size = new System.Drawing.Size(57, 30);
            this.btnElegirCliente.TabIndex = 110;
            this.btnElegirCliente.Text = "Elegir";
            this.btnElegirCliente.UseVisualStyleBackColor = true;
            this.btnElegirCliente.Click += new System.EventHandler(this.btnElegirCliente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btnElegirCliente);
            this.groupBox1.Controls.Add(this.btnElegir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboEstadoConsulta);
            this.groupBox1.Controls.Add(this.cboViaConsulta);
            this.groupBox1.Controls.Add(this.cboIDMedioConocimiento);
            this.groupBox1.Controls.Add(this.cboIDTipoTrans);
            this.groupBox1.Controls.Add(this.txtDNICliente);
            this.groupBox1.Controls.Add(this.txtIDInmueble);
            this.groupBox1.Controls.Add(this.txtIDConsulta);
            this.groupBox1.Controls.Add(this.lblViaConsulta);
            this.groupBox1.Controls.Add(this.lblEstadoConsulta);
            this.groupBox1.Controls.Add(this.lblMedioConocomiento);
            this.groupBox1.Controls.Add(this.lblDNICliente);
            this.groupBox1.Controls.Add(this.lblIDInuemble);
            this.groupBox1.Controls.Add(this.lblTipoTrans);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(784, 268);
            this.groupBox1.TabIndex = 111;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Detalle de Consulta";
            // 
            // frmDetalleConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 364);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblID);
            this.Name = "frmDetalleConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle Consulta";
            this.Load += new System.EventHandler(this.frmDetalleConsulta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboEstadoConsulta;
        private System.Windows.Forms.ComboBox cboViaConsulta;
        private System.Windows.Forms.ComboBox cboIDMedioConocimiento;
        private System.Windows.Forms.ComboBox cboIDTipoTrans;
        private System.Windows.Forms.TextBox txtDNICliente;
        private System.Windows.Forms.TextBox txtIDInmueble;
        private System.Windows.Forms.TextBox txtIDConsulta;
        private System.Windows.Forms.Label lblViaConsulta;
        private System.Windows.Forms.Label lblEstadoConsulta;
        private System.Windows.Forms.Label lblMedioConocomiento;
        private System.Windows.Forms.Label lblDNICliente;
        private System.Windows.Forms.Label lblIDInuemble;
        private System.Windows.Forms.Label lblTipoTrans;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnElegir;
        private System.Windows.Forms.Button btnElegirCliente;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}