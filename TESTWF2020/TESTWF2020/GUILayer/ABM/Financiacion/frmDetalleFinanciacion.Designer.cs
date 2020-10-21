namespace TESTWF2020.GUILayer.FORMFinanciacion
{
    partial class frmDetalleFinanciacion
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPorcAumento = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPorcAumento = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtCantCuotas = new System.Windows.Forms.TextBox();
            this.lblCantCuotas = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(76, 45);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(173, 24);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre del Plan:";
            // 
            // lblPorcAumento
            // 
            this.lblPorcAumento.AutoSize = true;
            this.lblPorcAumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcAumento.Location = new System.Drawing.Point(13, 113);
            this.lblPorcAumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPorcAumento.Name = "lblPorcAumento";
            this.lblPorcAumento.Size = new System.Drawing.Size(236, 24);
            this.lblPorcAumento.TabIndex = 1;
            this.lblPorcAumento.Text = "Porcentaje de Aumento:\r\n";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(271, 40);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(268, 30);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Tag = "Nombre";
            // 
            // txtPorcAumento
            // 
            this.txtPorcAumento.Location = new System.Drawing.Point(271, 108);
            this.txtPorcAumento.Margin = new System.Windows.Forms.Padding(4);
            this.txtPorcAumento.Name = "txtPorcAumento";
            this.txtPorcAumento.Size = new System.Drawing.Size(268, 30);
            this.txtPorcAumento.TabIndex = 4;
            this.txtPorcAumento.Tag = "Porcentaje Aumento";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::TESTWF2020.Properties.Resources.icons8_cerrar_ventana_48;
            this.btnSalir.Location = new System.Drawing.Point(500, 284);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 57);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtCantCuotas
            // 
            this.txtCantCuotas.Location = new System.Drawing.Point(271, 175);
            this.txtCantCuotas.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantCuotas.Name = "txtCantCuotas";
            this.txtCantCuotas.Size = new System.Drawing.Size(268, 30);
            this.txtCantCuotas.TabIndex = 9;
            this.txtCantCuotas.Tag = "Candtidad de cuotas";
            // 
            // lblCantCuotas
            // 
            this.lblCantCuotas.AutoSize = true;
            this.lblCantCuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantCuotas.Location = new System.Drawing.Point(51, 180);
            this.lblCantCuotas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantCuotas.Name = "lblCantCuotas";
            this.lblCantCuotas.Size = new System.Drawing.Size(198, 24);
            this.lblCantCuotas.TabIndex = 8;
            this.lblCantCuotas.Text = "Cantidad de Cuotas:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.txtCantCuotas);
            this.groupBox1.Controls.Add(this.lblCantCuotas);
            this.groupBox1.Controls.Add(this.txtPorcAumento);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblPorcAumento);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 242);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Financiacion";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = global::TESTWF2020.Properties.Resources.icons8_guardar_48;
            this.btnGrabar.Location = new System.Drawing.Point(162, 284);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(100, 57);
            this.btnGrabar.TabIndex = 6;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::TESTWF2020.Properties.Resources.icons8_editar_48;
            this.btnEditar.Location = new System.Drawing.Point(39, 284);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 57);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmDetalleFinanciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 354);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnEditar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDetalleFinanciacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle Financiacion";
            this.Load += new System.EventHandler(this.frmDetalleFinanciacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPorcAumento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPorcAumento;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtCantCuotas;
        private System.Windows.Forms.Label lblCantCuotas;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}