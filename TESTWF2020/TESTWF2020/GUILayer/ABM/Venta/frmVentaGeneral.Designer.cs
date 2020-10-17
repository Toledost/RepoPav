namespace TESTWF2020.GUILayer.ABM
{
    partial class frmVentaGeneral
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
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.btnCuotas = new System.Windows.Forms.Button();
            this.btnElegirCliente = new System.Windows.Forms.Button();
            this.txtDNICliente = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBorrarComprador = new System.Windows.Forms.Button();
            this.idVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idInmueble = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniComprador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreComprador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esFinanciada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVenta
            // 
            this.dgvVenta.AllowUserToAddRows = false;
            this.dgvVenta.AllowUserToDeleteRows = false;
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVenta,
            this.montoCuota,
            this.idInmueble,
            this.dniComprador,
            this.nombreComprador,
            this.esFinanciada,
            this.vendedor,
            this.usuarioVendedor,
            this.fechaVenta,
            this.fechaEntrega});
            this.dgvVenta.Location = new System.Drawing.Point(12, 193);
            this.dgvVenta.MultiSelect = false;
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.ReadOnly = true;
            this.dgvVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVenta.Size = new System.Drawing.Size(767, 150);
            this.dgvVenta.TabIndex = 0;
            this.dgvVenta.SelectionChanged += new System.EventHandler(this.dgvVenta_SelectionChanged);
            // 
            // btnCuotas
            // 
            this.btnCuotas.Enabled = false;
            this.btnCuotas.Location = new System.Drawing.Point(12, 374);
            this.btnCuotas.Name = "btnCuotas";
            this.btnCuotas.Size = new System.Drawing.Size(75, 23);
            this.btnCuotas.TabIndex = 1;
            this.btnCuotas.Text = "Cuotas";
            this.btnCuotas.UseVisualStyleBackColor = true;
            this.btnCuotas.Click += new System.EventHandler(this.btnCuotas_Click);
            // 
            // btnElegirCliente
            // 
            this.btnElegirCliente.Location = new System.Drawing.Point(277, 80);
            this.btnElegirCliente.Name = "btnElegirCliente";
            this.btnElegirCliente.Size = new System.Drawing.Size(81, 23);
            this.btnElegirCliente.TabIndex = 112;
            this.btnElegirCliente.Text = "Elegir";
            this.btnElegirCliente.UseVisualStyleBackColor = true;
            this.btnElegirCliente.Click += new System.EventHandler(this.btnElegirCliente_Click);
            // 
            // txtDNICliente
            // 
            this.txtDNICliente.Location = new System.Drawing.Point(394, 80);
            this.txtDNICliente.Name = "txtDNICliente";
            this.txtDNICliente.ReadOnly = true;
            this.txtDNICliente.Size = new System.Drawing.Size(93, 20);
            this.txtDNICliente.TabIndex = 111;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(412, 141);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 113;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 114;
            this.label1.Text = "Comprador";
            // 
            // btnBorrarComprador
            // 
            this.btnBorrarComprador.Location = new System.Drawing.Point(277, 141);
            this.btnBorrarComprador.Name = "btnBorrarComprador";
            this.btnBorrarComprador.Size = new System.Drawing.Size(106, 23);
            this.btnBorrarComprador.TabIndex = 115;
            this.btnBorrarComprador.Text = "Borrar Comprador";
            this.btnBorrarComprador.UseVisualStyleBackColor = true;
            this.btnBorrarComprador.Click += new System.EventHandler(this.btnBorrarComprador_Click);
            // 
            // idVenta
            // 
            this.idVenta.HeaderText = "Id";
            this.idVenta.Name = "idVenta";
            this.idVenta.Width = 20;
            // 
            // montoCuota
            // 
            this.montoCuota.HeaderText = "Monto Cuota";
            this.montoCuota.Name = "montoCuota";
            // 
            // idInmueble
            // 
            this.idInmueble.HeaderText = "Inmueble";
            this.idInmueble.Name = "idInmueble";
            // 
            // dniComprador
            // 
            this.dniComprador.HeaderText = "DNI Comprador";
            this.dniComprador.Name = "dniComprador";
            // 
            // nombreComprador
            // 
            this.nombreComprador.HeaderText = "Nombre Comprador";
            this.nombreComprador.Name = "nombreComprador";
            // 
            // esFinanciada
            // 
            this.esFinanciada.HeaderText = "Financiada";
            this.esFinanciada.Name = "esFinanciada";
            // 
            // vendedor
            // 
            this.vendedor.HeaderText = "Vendedor";
            this.vendedor.Name = "vendedor";
            // 
            // usuarioVendedor
            // 
            this.usuarioVendedor.HeaderText = "Usuario Vendedor";
            this.usuarioVendedor.Name = "usuarioVendedor";
            // 
            // fechaVenta
            // 
            this.fechaVenta.HeaderText = "Fecha de Venta";
            this.fechaVenta.Name = "fechaVenta";
            // 
            // fechaEntrega
            // 
            this.fechaEntrega.HeaderText = "Fecha de Entrega";
            this.fechaEntrega.Name = "fechaEntrega";
            // 
            // frmVentaGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.Controls.Add(this.btnBorrarComprador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnElegirCliente);
            this.Controls.Add(this.txtDNICliente);
            this.Controls.Add(this.btnCuotas);
            this.Controls.Add(this.dgvVenta);
            this.Name = "frmVentaGeneral";
            this.Text = "frmVentaGeneral";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVenta;
        private System.Windows.Forms.Button btnCuotas;
        private System.Windows.Forms.Button btnElegirCliente;
        private System.Windows.Forms.TextBox txtDNICliente;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBorrarComprador;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInmueble;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniComprador;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreComprador;
        private System.Windows.Forms.DataGridViewTextBoxColumn esFinanciada;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEntrega;
    }
}