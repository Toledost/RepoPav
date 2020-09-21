namespace TESTWF2020.GUILayer.ABM
{
    partial class frmABMCUsuario
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.cboPerfil = new System.Windows.Forms.ComboBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(224, 98);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(224, 124);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 1;
            // 
            // cboPerfil
            // 
            this.cboPerfil.FormattingEnabled = true;
            this.cboPerfil.Location = new System.Drawing.Point(224, 150);
            this.cboPerfil.Name = "cboPerfil";
            this.cboPerfil.Size = new System.Drawing.Size(121, 21);
            this.cboPerfil.TabIndex = 2;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(151, 124);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(67, 13);
            this.lblContraseña.TabIndex = 4;
            this.lblContraseña.Text = "Contraseña: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(168, 102);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(182, 155);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(36, 13);
            this.lblPerfil.TabIndex = 6;
            this.lblPerfil.Text = "Perfil: ";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(224, 292);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 7;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(338, 292);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(108, 292);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            
            // 
            // frmABMCUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 409);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.cboPerfil);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtNombre);
            this.Name = "frmABMCUsuario";
            this.Text = "frmAMBCUsuario";
            this.Load += new System.EventHandler(this.frmABMCUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.ComboBox cboPerfil;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEditar;
    }
}