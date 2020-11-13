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
            this.btnCuotas = new System.Windows.Forms.Button();
            this.btnElegirCliente = new System.Windows.Forms.Button();
            this.txtDNICliente = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBorrarComprador = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.dgvVenta.Location = new System.Drawing.Point(16, 238);
            this.dgvVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvVenta.MultiSelect = false;
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.ReadOnly = true;
            this.dgvVenta.RowHeadersWidth = 51;
            this.dgvVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVenta.Size = new System.Drawing.Size(1328, 428);
            this.dgvVenta.TabIndex = 0;
            this.dgvVenta.SelectionChanged += new System.EventHandler(this.dgvVenta_SelectionChanged);
            // 
            // idVenta
            // 
            this.idVenta.HeaderText = "Id";
            this.idVenta.MinimumWidth = 6;
            this.idVenta.Name = "idVenta";
            this.idVenta.ReadOnly = true;
            this.idVenta.Width = 20;
            // 
            // montoCuota
            // 
            this.montoCuota.HeaderText = "Monto Cuota";
            this.montoCuota.MinimumWidth = 6;
            this.montoCuota.Name = "montoCuota";
            this.montoCuota.ReadOnly = true;
            this.montoCuota.Width = 125;
            // 
            // idInmueble
            // 
            this.idInmueble.HeaderText = "Inmueble";
            this.idInmueble.MinimumWidth = 6;
            this.idInmueble.Name = "idInmueble";
            this.idInmueble.ReadOnly = true;
            this.idInmueble.Width = 125;
            // 
            // dniComprador
            // 
            this.dniComprador.HeaderText = "DNI Comprador";
            this.dniComprador.MinimumWidth = 6;
            this.dniComprador.Name = "dniComprador";
            this.dniComprador.ReadOnly = true;
            this.dniComprador.Width = 125;
            // 
            // nombreComprador
            // 
            this.nombreComprador.HeaderText = "Nombre Comprador";
            this.nombreComprador.MinimumWidth = 6;
            this.nombreComprador.Name = "nombreComprador";
            this.nombreComprador.ReadOnly = true;
            this.nombreComprador.Width = 125;
            // 
            // esFinanciada
            // 
            this.esFinanciada.HeaderText = "Financiada";
            this.esFinanciada.MinimumWidth = 6;
            this.esFinanciada.Name = "esFinanciada";
            this.esFinanciada.ReadOnly = true;
            this.esFinanciada.Width = 125;
            // 
            // vendedor
            // 
            this.vendedor.HeaderText = "Vendedor";
            this.vendedor.MinimumWidth = 6;
            this.vendedor.Name = "vendedor";
            this.vendedor.ReadOnly = true;
            this.vendedor.Width = 125;
            // 
            // usuarioVendedor
            // 
            this.usuarioVendedor.HeaderText = "Usuario Vendedor";
            this.usuarioVendedor.MinimumWidth = 6;
            this.usuarioVendedor.Name = "usuarioVendedor";
            this.usuarioVendedor.ReadOnly = true;
            this.usuarioVendedor.Width = 125;
            // 
            // fechaVenta
            // 
            this.fechaVenta.HeaderText = "Fecha de Venta";
            this.fechaVenta.MinimumWidth = 6;
            this.fechaVenta.Name = "fechaVenta";
            this.fechaVenta.ReadOnly = true;
            this.fechaVenta.Width = 125;
            // 
            // fechaEntrega
            // 
            this.fechaEntrega.HeaderText = "Fecha de Entrega";
            this.fechaEntrega.MinimumWidth = 6;
            this.fechaEntrega.Name = "fechaEntrega";
            this.fechaEntrega.ReadOnly = true;
            this.fechaEntrega.Width = 125;
            // 
            // btnCuotas
            // 
            this.btnCuotas.Enabled = false;
            this.btnCuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuotas.Image = global::TESTWF2020.Properties.Resources.icons8_tarjeta_de_fidelidad_961;
            this.btnCuotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuotas.Location = new System.Drawing.Point(1142, 674);
            this.btnCuotas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCuotas.Name = "btnCuotas";
            this.btnCuotas.Size = new System.Drawing.Size(202, 71);
            this.btnCuotas.TabIndex = 1;
            this.btnCuotas.Text = "Cuotas";
            this.btnCuotas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCuotas.UseVisualStyleBackColor = true;
            this.btnCuotas.Click += new System.EventHandler(this.btnCuotas_Click);
            // 
            // btnElegirCliente
            // 
            this.btnElegirCliente.Image = global::TESTWF2020.Properties.Resources.icons8_natural_user_interface_2_48;
            this.btnElegirCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElegirCliente.Location = new System.Drawing.Point(219, 72);
            this.btnElegirCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnElegirCliente.Name = "btnElegirCliente";
            this.btnElegirCliente.Size = new System.Drawing.Size(190, 59);
            this.btnElegirCliente.TabIndex = 112;
            this.btnElegirCliente.Text = "Elegir";
            this.btnElegirCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnElegirCliente.UseVisualStyleBackColor = true;
            this.btnElegirCliente.Click += new System.EventHandler(this.btnElegirCliente_Click);
            // 
            // txtDNICliente
            // 
            this.txtDNICliente.Location = new System.Drawing.Point(439, 85);
            this.txtDNICliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDNICliente.Name = "txtDNICliente";
            this.txtDNICliente.ReadOnly = true;
            this.txtDNICliente.Size = new System.Drawing.Size(329, 30);
            this.txtDNICliente.TabIndex = 111;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = global::TESTWF2020.Properties.Resources.icons8_fácil_de_encontrar_40;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(1080, 129);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(222, 58);
            this.btnConsultar.TabIndex = 113;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 114;
            this.label1.Text = "Comprador:";
            // 
            // btnBorrarComprador
            // 
            this.btnBorrarComprador.Image = global::TESTWF2020.Properties.Resources.icons8_borrar_48;
            this.btnBorrarComprador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrarComprador.Location = new System.Drawing.Point(1080, 30);
            this.btnBorrarComprador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrarComprador.Name = "btnBorrarComprador";
            this.btnBorrarComprador.Size = new System.Drawing.Size(222, 60);
            this.btnBorrarComprador.TabIndex = 115;
            this.btnBorrarComprador.Text = "Limpiar Campos";
            this.btnBorrarComprador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrarComprador.UseVisualStyleBackColor = true;
            this.btnBorrarComprador.Click += new System.EventHandler(this.btnBorrarComprador_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.btnBorrarComprador);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.btnElegirCliente);
            this.groupBox1.Controls.Add(this.txtDNICliente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1327, 208);
            this.groupBox1.TabIndex = 116;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro de Ventas";
            // 
            // frmVentaGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 758);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCuotas);
            this.Controls.Add(this.dgvVenta);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmVentaGeneral";
            this.Text = "Venta General";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
    }
}