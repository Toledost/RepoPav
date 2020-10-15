namespace TESTWF2020.GUILayer.ABM
{
    partial class frmCuotasDetalle
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
            this.dgvCuotas = new System.Windows.Forms.DataGridView();
            this.nroCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCuotas
            // 
            this.dgvCuotas.AllowUserToAddRows = false;
            this.dgvCuotas.AllowUserToDeleteRows = false;
            this.dgvCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroCuota,
            this.fechaPago,
            this.fechaVencimiento,
            this.pagado});
            this.dgvCuotas.Location = new System.Drawing.Point(12, 50);
            this.dgvCuotas.Name = "dgvCuotas";
            this.dgvCuotas.ReadOnly = true;
            this.dgvCuotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuotas.Size = new System.Drawing.Size(463, 253);
            this.dgvCuotas.TabIndex = 0;
            // 
            // nroCuota
            // 
            this.nroCuota.HeaderText = "Número Cuota";
            this.nroCuota.Name = "nroCuota";
            // 
            // fechaPago
            // 
            this.fechaPago.HeaderText = "Fecha Pago";
            this.fechaPago.Name = "fechaPago";
            // 
            // fechaVencimiento
            // 
            this.fechaVencimiento.HeaderText = "Fecha Vencimiento";
            this.fechaVencimiento.Name = "fechaVencimiento";
            // 
            // pagado
            // 
            this.pagado.HeaderText = "Pagado";
            this.pagado.Name = "pagado";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(24, 330);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 23);
            this.btnPagar.TabIndex = 1;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(396, 330);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmCuotasDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 404);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.dgvCuotas);
            this.Name = "frmCuotasDetalle";
            this.Text = "Cuotas - Detalle";
            this.Load += new System.EventHandler(this.frmCuotasDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCuotas;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagado;
        private System.Windows.Forms.Button btnSalir;
    }
}