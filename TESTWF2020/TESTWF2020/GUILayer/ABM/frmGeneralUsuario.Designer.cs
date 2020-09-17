namespace TESTWF2020.GUILayer.ABM
{
    partial class frmGeneralUsuario
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
            this.dgvGeneralUsuario = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboPerfilGeneral = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneralUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGeneralUsuario
            // 
            this.dgvGeneralUsuario.AllowUserToAddRows = false;
            this.dgvGeneralUsuario.AllowUserToDeleteRows = false;
            this.dgvGeneralUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneralUsuario.Location = new System.Drawing.Point(55, 201);
            this.dgvGeneralUsuario.Name = "dgvGeneralUsuario";
            this.dgvGeneralUsuario.ReadOnly = true;
            this.dgvGeneralUsuario.Size = new System.Drawing.Size(486, 150);
            this.dgvGeneralUsuario.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(62, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(76, 72);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(30, 13);
            this.lblPerfil.TabIndex = 3;
            this.lblPerfil.Text = "Perfil";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(205, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // cboPerfilGeneral
            // 
            this.cboPerfilGeneral.FormattingEnabled = true;
            this.cboPerfilGeneral.Location = new System.Drawing.Point(205, 72);
            this.cboPerfilGeneral.Name = "cboPerfilGeneral";
            this.cboPerfilGeneral.Size = new System.Drawing.Size(121, 21);
            this.cboPerfilGeneral.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(428, 70);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(478, 384);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmGeneralUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 443);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cboPerfilGeneral);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvGeneralUsuario);
            this.Name = "frmGeneralUsuario";
            this.Text = "frmGeneralUsuario";
            this.Load += new System.EventHandler(this.frmGeneralUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneralUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGeneralUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboPerfilGeneral;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSalir;
    }
}