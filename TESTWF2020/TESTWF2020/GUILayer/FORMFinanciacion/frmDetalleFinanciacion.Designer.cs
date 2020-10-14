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
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtCantCuotas = new System.Windows.Forms.TextBox();
            this.lblCantCuotas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(231, 94);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPorcAumento
            // 
            this.lblPorcAumento.AutoSize = true;
            this.lblPorcAumento.Location = new System.Drawing.Point(231, 134);
            this.lblPorcAumento.Name = "lblPorcAumento";
            this.lblPorcAumento.Size = new System.Drawing.Size(103, 13);
            this.lblPorcAumento.TabIndex = 1;
            this.lblPorcAumento.Text = "Porcentaje Aumento";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(357, 94);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtPorcAumento
            // 
            this.txtPorcAumento.Location = new System.Drawing.Point(357, 134);
            this.txtPorcAumento.Name = "txtPorcAumento";
            this.txtPorcAumento.Size = new System.Drawing.Size(100, 20);
            this.txtPorcAumento.TabIndex = 4;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(234, 312);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(343, 312);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 6;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(458, 312);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtCantCuotas
            // 
            this.txtCantCuotas.Location = new System.Drawing.Point(357, 175);
            this.txtCantCuotas.Name = "txtCantCuotas";
            this.txtCantCuotas.Size = new System.Drawing.Size(100, 20);
            this.txtCantCuotas.TabIndex = 9;
            // 
            // lblCantCuotas
            // 
            this.lblCantCuotas.AutoSize = true;
            this.lblCantCuotas.Location = new System.Drawing.Point(231, 175);
            this.lblCantCuotas.Name = "lblCantCuotas";
            this.lblCantCuotas.Size = new System.Drawing.Size(99, 13);
            this.lblCantCuotas.TabIndex = 8;
            this.lblCantCuotas.Text = "Cantidad de cuotas";
            // 
            // frmDetalleFinanciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCantCuotas);
            this.Controls.Add(this.lblCantCuotas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtPorcAumento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblPorcAumento);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmDetalleFinanciacion";
            this.Text = "Financiación - Detalle";
            this.Load += new System.EventHandler(this.frmDetalleFinanciacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}