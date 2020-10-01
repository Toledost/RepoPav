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
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnElegir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinanciacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFinanciacion
            // 
            this.dgvFinanciacion.AllowUserToAddRows = false;
            this.dgvFinanciacion.AllowUserToDeleteRows = false;
            this.dgvFinanciacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinanciacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.PorcAumento,
            this.CantCuotas});
            this.dgvFinanciacion.Location = new System.Drawing.Point(108, 178);
            this.dgvFinanciacion.Name = "dgvFinanciacion";
            this.dgvFinanciacion.ReadOnly = true;
            this.dgvFinanciacion.RowHeadersWidth = 62;
            this.dgvFinanciacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFinanciacion.Size = new System.Drawing.Size(562, 192);
            this.dgvFinanciacion.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 150;
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
            this.btnConsultar.Location = new System.Drawing.Point(321, 120);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(140, 376);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(232, 376);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnDetalle.TabIndex = 3;
            this.btnDetalle.Text = "Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(321, 376);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(571, 376);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblAumentoMaximo
            // 
            this.lblAumentoMaximo.AutoSize = true;
            this.lblAumentoMaximo.Location = new System.Drawing.Point(219, 40);
            this.lblAumentoMaximo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAumentoMaximo.Name = "lblAumentoMaximo";
            this.lblAumentoMaximo.Size = new System.Drawing.Size(88, 13);
            this.lblAumentoMaximo.TabIndex = 6;
            this.lblAumentoMaximo.Text = "Aumento Maximo";
            // 
            // lblCantidadCuotas
            // 
            this.lblCantidadCuotas.AutoSize = true;
            this.lblCantidadCuotas.Location = new System.Drawing.Point(167, 75);
            this.lblCantidadCuotas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadCuotas.Name = "lblCantidadCuotas";
            this.lblCantidadCuotas.Size = new System.Drawing.Size(139, 13);
            this.lblCantidadCuotas.TabIndex = 7;
            this.lblCantidadCuotas.Text = "Cantidad de cuotas minimas";
            // 
            // txtAumentoMaximo
            // 
            this.txtAumentoMaximo.Location = new System.Drawing.Point(321, 38);
            this.txtAumentoMaximo.Margin = new System.Windows.Forms.Padding(2);
            this.txtAumentoMaximo.Name = "txtAumentoMaximo";
            this.txtAumentoMaximo.Size = new System.Drawing.Size(76, 20);
            this.txtAumentoMaximo.TabIndex = 10;
            // 
            // txtCantidadCuotas
            // 
            this.txtCantidadCuotas.Location = new System.Drawing.Point(321, 75);
            this.txtCantidadCuotas.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidadCuotas.Name = "txtCantidadCuotas";
            this.txtCantidadCuotas.Size = new System.Drawing.Size(76, 20);
            this.txtCantidadCuotas.TabIndex = 11;
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(451, 58);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(58, 30);
            this.btnLimpiarFiltros.TabIndex = 12;
            this.btnLimpiarFiltros.Text = "Limpiar";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // btnElegir
            // 
            this.btnElegir.Location = new System.Drawing.Point(451, 376);
            this.btnElegir.Name = "btnElegir";
            this.btnElegir.Size = new System.Drawing.Size(75, 23);
            this.btnElegir.TabIndex = 13;
            this.btnElegir.Text = "Elegir";
            this.btnElegir.UseVisualStyleBackColor = true;
            this.btnElegir.Click += new System.EventHandler(this.btnElegir_Click);
            // 
            // frmConsultaFinanciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnElegir);
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
            this.Name = "frmConsultaFinanciacion";
            this.Text = "frmConsultaFinanciacion";
            this.Load += new System.EventHandler(this.frmConsultaFinanciacion_Load);
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
        private System.Windows.Forms.Label lblAumentoMaximo;
        private System.Windows.Forms.Label lblCantidadCuotas;
        private System.Windows.Forms.TextBox txtAumentoMaximo;
        private System.Windows.Forms.TextBox txtCantidadCuotas;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Button btnElegir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcAumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantCuotas;
    }
}