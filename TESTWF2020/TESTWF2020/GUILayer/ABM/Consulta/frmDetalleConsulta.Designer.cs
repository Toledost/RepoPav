namespace TESTWF2020.GUILayer.ABM
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
            this.SuspendLayout();
            // 
            // cboEstadoConsulta
            // 
            this.cboEstadoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoConsulta.FormattingEnabled = true;
            this.cboEstadoConsulta.Location = new System.Drawing.Point(515, 138);
            this.cboEstadoConsulta.Name = "cboEstadoConsulta";
            this.cboEstadoConsulta.Size = new System.Drawing.Size(121, 21);
            this.cboEstadoConsulta.TabIndex = 102;
            this.cboEstadoConsulta.Tag = "Estado de Consulta";
            // 
            // cboViaConsulta
            // 
            this.cboViaConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboViaConsulta.FormattingEnabled = true;
            this.cboViaConsulta.Location = new System.Drawing.Point(515, 91);
            this.cboViaConsulta.Name = "cboViaConsulta";
            this.cboViaConsulta.Size = new System.Drawing.Size(121, 21);
            this.cboViaConsulta.TabIndex = 101;
            this.cboViaConsulta.Tag = "Via de Consulta";
            // 
            // cboIDMedioConocimiento
            // 
            this.cboIDMedioConocimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIDMedioConocimiento.FormattingEnabled = true;
            this.cboIDMedioConocimiento.Location = new System.Drawing.Point(515, 41);
            this.cboIDMedioConocimiento.Name = "cboIDMedioConocimiento";
            this.cboIDMedioConocimiento.Size = new System.Drawing.Size(121, 21);
            this.cboIDMedioConocimiento.TabIndex = 100;
            this.cboIDMedioConocimiento.Tag = "Medio de Conocimiento";
            // 
            // cboIDTipoTrans
            // 
            this.cboIDTipoTrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIDTipoTrans.FormattingEnabled = true;
            this.cboIDTipoTrans.Location = new System.Drawing.Point(217, 91);
            this.cboIDTipoTrans.Name = "cboIDTipoTrans";
            this.cboIDTipoTrans.Size = new System.Drawing.Size(121, 21);
            this.cboIDTipoTrans.TabIndex = 99;
            this.cboIDTipoTrans.Tag = "Tipo Transaccion";
            // 
            // txtDNICliente
            // 
            this.txtDNICliente.Location = new System.Drawing.Point(280, 176);
            this.txtDNICliente.Name = "txtDNICliente";
            this.txtDNICliente.ReadOnly = true;
            this.txtDNICliente.Size = new System.Drawing.Size(58, 20);
            this.txtDNICliente.TabIndex = 95;
            this.txtDNICliente.Tag = "Dni Cliente";
            // 
            // txtIDInmueble
            // 
            this.txtIDInmueble.Location = new System.Drawing.Point(280, 131);
            this.txtIDInmueble.Name = "txtIDInmueble";
            this.txtIDInmueble.ReadOnly = true;
            this.txtIDInmueble.Size = new System.Drawing.Size(58, 20);
            this.txtIDInmueble.TabIndex = 94;
            this.txtIDInmueble.Tag = "Inmueble";
            // 
            // txtIDConsulta
            // 
            this.txtIDConsulta.Location = new System.Drawing.Point(217, 44);
            this.txtIDConsulta.Name = "txtIDConsulta";
            this.txtIDConsulta.ReadOnly = true;
            this.txtIDConsulta.Size = new System.Drawing.Size(126, 20);
            this.txtIDConsulta.TabIndex = 92;
            // 
            // lblViaConsulta
            // 
            this.lblViaConsulta.AutoSize = true;
            this.lblViaConsulta.Location = new System.Drawing.Point(413, 94);
            this.lblViaConsulta.Name = "lblViaConsulta";
            this.lblViaConsulta.Size = new System.Drawing.Size(83, 13);
            this.lblViaConsulta.TabIndex = 89;
            this.lblViaConsulta.Text = "Via de consulta:";
            // 
            // lblEstadoConsulta
            // 
            this.lblEstadoConsulta.AutoSize = true;
            this.lblEstadoConsulta.Location = new System.Drawing.Point(395, 138);
            this.lblEstadoConsulta.Name = "lblEstadoConsulta";
            this.lblEstadoConsulta.Size = new System.Drawing.Size(101, 13);
            this.lblEstadoConsulta.TabIndex = 88;
            this.lblEstadoConsulta.Text = "Estado de consulta:";
            // 
            // lblMedioConocomiento
            // 
            this.lblMedioConocomiento.AutoSize = true;
            this.lblMedioConocomiento.Location = new System.Drawing.Point(376, 49);
            this.lblMedioConocomiento.Name = "lblMedioConocomiento";
            this.lblMedioConocomiento.Size = new System.Drawing.Size(120, 13);
            this.lblMedioConocomiento.TabIndex = 87;
            this.lblMedioConocomiento.Text = "Medio de conocimiento:";
            // 
            // lblDNICliente
            // 
            this.lblDNICliente.AutoSize = true;
            this.lblDNICliente.Location = new System.Drawing.Point(125, 182);
            this.lblDNICliente.Name = "lblDNICliente";
            this.lblDNICliente.Size = new System.Drawing.Size(64, 13);
            this.lblDNICliente.TabIndex = 84;
            this.lblDNICliente.Text = "DNI Cliente:";
            // 
            // lblIDInuemble
            // 
            this.lblIDInuemble.AutoSize = true;
            this.lblIDInuemble.Location = new System.Drawing.Point(134, 138);
            this.lblIDInuemble.Name = "lblIDInuemble";
            this.lblIDInuemble.Size = new System.Drawing.Size(53, 13);
            this.lblIDInuemble.TabIndex = 83;
            this.lblIDInuemble.Text = "Inmueble:";
            // 
            // lblTipoTrans
            // 
            this.lblTipoTrans.AutoSize = true;
            this.lblTipoTrans.Location = new System.Drawing.Point(96, 94);
            this.lblTipoTrans.Name = "lblTipoTrans";
            this.lblTipoTrans.Size = new System.Drawing.Size(93, 13);
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
            this.label1.Location = new System.Drawing.Point(168, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 105;
            this.label1.Text = "ID:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(561, 281);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 106;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(123, 281);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 107;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(222, 281);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 108;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnElegir
            // 
            this.btnElegir.Location = new System.Drawing.Point(217, 128);
            this.btnElegir.Name = "btnElegir";
            this.btnElegir.Size = new System.Drawing.Size(46, 23);
            this.btnElegir.TabIndex = 109;
            this.btnElegir.Text = "Elegir";
            this.btnElegir.UseVisualStyleBackColor = true;
            this.btnElegir.Click += new System.EventHandler(this.btnElegir_Click);
            // 
            // btnElegirCliente
            // 
            this.btnElegirCliente.Location = new System.Drawing.Point(217, 174);
            this.btnElegirCliente.Name = "btnElegirCliente";
            this.btnElegirCliente.Size = new System.Drawing.Size(46, 23);
            this.btnElegirCliente.TabIndex = 110;
            this.btnElegirCliente.Text = "Elegir";
            this.btnElegirCliente.UseVisualStyleBackColor = true;
            this.btnElegirCliente.Click += new System.EventHandler(this.btnElegirCliente_Click);
            // 
            // frmDetalleConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 342);
            this.Controls.Add(this.btnElegirCliente);
            this.Controls.Add(this.btnElegir);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboEstadoConsulta);
            this.Controls.Add(this.cboViaConsulta);
            this.Controls.Add(this.cboIDMedioConocimiento);
            this.Controls.Add(this.cboIDTipoTrans);
            this.Controls.Add(this.txtDNICliente);
            this.Controls.Add(this.txtIDInmueble);
            this.Controls.Add(this.txtIDConsulta);
            this.Controls.Add(this.lblViaConsulta);
            this.Controls.Add(this.lblEstadoConsulta);
            this.Controls.Add(this.lblMedioConocomiento);
            this.Controls.Add(this.lblDNICliente);
            this.Controls.Add(this.lblIDInuemble);
            this.Controls.Add(this.lblTipoTrans);
            this.Controls.Add(this.lblID);
            this.Name = "frmDetalleConsulta";
            this.Text = "Consulta - Detalle";
            this.Load += new System.EventHandler(this.frmDetalleConsulta_Load);
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
    }
}