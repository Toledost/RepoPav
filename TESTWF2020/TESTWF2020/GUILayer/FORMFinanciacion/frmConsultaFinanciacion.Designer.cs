namespace TESTWF2020.GUILayer.FORMFinanciacion
{
    partial class frmConsultaFinanciacion
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
            this.dgvFinanciacion = new System.Windows.Forms.DataGridView();
            this.IdFinanciacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcAumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantCuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblAumentoMaximo = new System.Windows.Forms.Label();
            this.lblCantidadCuotas = new System.Windows.Forms.Label();
            this.txtAumentoMaximo = new System.Windows.Forms.TextBox();
            this.txtCantidadCuotas = new System.Windows.Forms.TextBox();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinanciacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFinanciacion
            // 
            this.dgvFinanciacion.AllowUserToAddRows = false;
            this.dgvFinanciacion.AllowUserToDeleteRows = false;
            this.dgvFinanciacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinanciacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFinanciacion,
            this.Nombre,
            this.PorcAumento,
            this.CantCuotas});
            this.dgvFinanciacion.Location = new System.Drawing.Point(162, 274);
            this.dgvFinanciacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvFinanciacion.Name = "dgvFinanciacion";
            this.dgvFinanciacion.ReadOnly = true;
            this.dgvFinanciacion.RowHeadersWidth = 62;
            this.dgvFinanciacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFinanciacion.Size = new System.Drawing.Size(843, 295);
            this.dgvFinanciacion.TabIndex = 0;
            // 
            // IdFinanciacion
            // 
            this.IdFinanciacion.HeaderText = "Id";
            this.IdFinanciacion.MinimumWidth = 8;
            this.IdFinanciacion.Name = "IdFinanciacion";
            this.IdFinanciacion.ReadOnly = true;
            this.IdFinanciacion.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // PorcAumento
            // 
            this.PorcAumento.HeaderText = "Porcentaje Aumento";
            this.PorcAumento.MinimumWidth = 8;
            this.PorcAumento.Name = "PorcAumento";
            this.PorcAumento.ReadOnly = true;
            this.PorcAumento.Width = 150;
            // 
            // CantCuotas
            // 
            this.CantCuotas.HeaderText = "Cantidad de Cuotas";
            this.CantCuotas.MinimumWidth = 8;
            this.CantCuotas.Name = "CantCuotas";
            this.CantCuotas.ReadOnly = true;
            this.CantCuotas.Width = 150;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(481, 185);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(112, 35);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(210, 579);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(112, 35);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(441, 579);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(112, 35);
            this.btnDetalle.TabIndex = 3;
            this.btnDetalle.Text = "Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(650, 579);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 35);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(856, 579);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 35);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblAumentoMaximo
            // 
            this.lblAumentoMaximo.AutoSize = true;
            this.lblAumentoMaximo.Location = new System.Drawing.Point(328, 62);
            this.lblAumentoMaximo.Name = "lblAumentoMaximo";
            this.lblAumentoMaximo.Size = new System.Drawing.Size(132, 20);
            this.lblAumentoMaximo.TabIndex = 6;
            this.lblAumentoMaximo.Text = "Aumento Maximo";
            // 
            // lblCantidadCuotas
            // 
            this.lblCantidadCuotas.AutoSize = true;
            this.lblCantidadCuotas.Location = new System.Drawing.Point(251, 115);
            this.lblCantidadCuotas.Name = "lblCantidadCuotas";
            this.lblCantidadCuotas.Size = new System.Drawing.Size(209, 20);
            this.lblCantidadCuotas.TabIndex = 7;
            this.lblCantidadCuotas.Text = "Cantidad de cuotas minimas";
            // 
            // txtAumentoMaximo
            // 
            this.txtAumentoMaximo.Location = new System.Drawing.Point(481, 59);
            this.txtAumentoMaximo.Name = "txtAumentoMaximo";
            this.txtAumentoMaximo.Size = new System.Drawing.Size(112, 26);
            this.txtAumentoMaximo.TabIndex = 10;
            // 
            // txtCantidadCuotas
            // 
            this.txtCantidadCuotas.Location = new System.Drawing.Point(481, 115);
            this.txtCantidadCuotas.Name = "txtCantidadCuotas";
            this.txtCantidadCuotas.Size = new System.Drawing.Size(112, 26);
            this.txtCantidadCuotas.TabIndex = 11;
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(677, 89);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(75, 30);
            this.btnLimpiarFiltros.TabIndex = 12;
            this.btnLimpiarFiltros.Text = "Limpiar";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // frmConsultaFinanciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnLimpiarFiltros);
            this.Controls.Add(this.txtCantidadCuotas);
            this.Controls.Add(this.txtAumentoMaximo);
            this.Controls.Add(this.lblCantidadCuotas);
            this.Controls.Add(this.lblAumentoMaximo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvFinanciacion);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConsultaFinanciacion";
            this.Text = "frmConsultaFinanciacion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinanciacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFinanciacion;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFinanciacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcAumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantCuotas;
        private System.Windows.Forms.Label lblAumentoMaximo;
        private System.Windows.Forms.Label lblCantidadCuotas;
        private System.Windows.Forms.TextBox txtAumentoMaximo;
        private System.Windows.Forms.TextBox txtCantidadCuotas;
        private System.Windows.Forms.Button btnLimpiarFiltros;
    }
}