namespace TESTWF2020.Reportes.frmReportes
{
    partial class frmReporteVenta
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tablaVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDInmobiliariaCasaFelizDataSet = new TESTWF2020.BDInmobiliariaCasaFelizDataSet();
            this.rptvVenta = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblIdInmueble = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.tablaVentaTableAdapter = new TESTWF2020.BDInmobiliariaCasaFelizDataSetTableAdapters.tablaVentaTableAdapter();
            this.cboInmueble = new System.Windows.Forms.ComboBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaVentaBindingSource
            // 
            this.tablaVentaBindingSource.DataMember = "tablaVenta";
            this.tablaVentaBindingSource.DataSource = this.bDInmobiliariaCasaFelizDataSet;
            // 
            // bDInmobiliariaCasaFelizDataSet
            // 
            this.bDInmobiliariaCasaFelizDataSet.DataSetName = "BDInmobiliariaCasaFelizDataSet";
            this.bDInmobiliariaCasaFelizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptvVenta
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.tablaVentaBindingSource;
            this.rptvVenta.LocalReport.DataSources.Add(reportDataSource4);
            this.rptvVenta.LocalReport.ReportEmbeddedResource = "TESTWF2020.Reportes.Reportes.rptVenta.rdlc";
            this.rptvVenta.Location = new System.Drawing.Point(0, 158);
            this.rptvVenta.Name = "rptvVenta";
            this.rptvVenta.ServerReport.BearerToken = null;
            this.rptvVenta.Size = new System.Drawing.Size(800, 292);
            this.rptvVenta.TabIndex = 0;
            // 
            // lblIdInmueble
            // 
            this.lblIdInmueble.AutoSize = true;
            this.lblIdInmueble.Location = new System.Drawing.Point(54, 28);
            this.lblIdInmueble.Name = "lblIdInmueble";
            this.lblIdInmueble.Size = new System.Drawing.Size(50, 13);
            this.lblIdInmueble.TabIndex = 4;
            this.lblIdInmueble.Text = "Inmueble";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(46, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Comprador";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(501, 59);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(117, 20);
            this.dtpFechaDesde.TabIndex = 7;
            this.dtpFechaDesde.ValueChanged += new System.EventHandler(this.dtpFechaDesde_ValueChanged);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(501, 99);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(117, 20);
            this.dtpFechaHasta.TabIndex = 8;
            this.dtpFechaHasta.ValueChanged += new System.EventHandler(this.dtpFechaHasta_ValueChanged);
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(420, 102);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(35, 13);
            this.lblFechaHasta.TabIndex = 10;
            this.lblFechaHasta.Text = "Hasta";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(420, 66);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(38, 13);
            this.lblFechaDesde.TabIndex = 9;
            this.lblFechaDesde.Text = "Desde";
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Location = new System.Drawing.Point(344, 85);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(67, 13);
            this.lblFechaVenta.TabIndex = 11;
            this.lblFechaVenta.Text = "Fecha venta";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(687, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGrafico
            // 
            this.btnGrafico.Location = new System.Drawing.Point(687, 57);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(75, 23);
            this.btnGrafico.TabIndex = 12;
            this.btnGrafico.Text = "Grafico";
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // tablaVentaTableAdapter
            // 
            this.tablaVentaTableAdapter.ClearBeforeFill = true;
            // 
            // cboInmueble
            // 
            this.cboInmueble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInmueble.FormattingEnabled = true;
            this.cboInmueble.Location = new System.Drawing.Point(164, 28);
            this.cboInmueble.Name = "cboInmueble";
            this.cboInmueble.Size = new System.Drawing.Size(121, 21);
            this.cboInmueble.TabIndex = 14;
            this.cboInmueble.Tag = "inmueble";
            this.cboInmueble.SelectedIndexChanged += new System.EventHandler(this.cboInmueble_SelectedIndexChanged);
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(164, 64);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(121, 21);
            this.cboCliente.TabIndex = 15;
            this.cboCliente.Tag = "dniCliente";
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(687, 92);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(75, 38);
            this.btnLimpiarFiltros.TabIndex = 18;
            this.btnLimpiarFiltros.Text = "Limpiar Filtros";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // frmReporteVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiarFiltros);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.cboInmueble);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.lblFechaVenta);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIdInmueble);
            this.Controls.Add(this.rptvVenta);
            this.Name = "frmReporteVenta";
            this.Text = "Reporte Venta";
            this.Load += new System.EventHandler(this.frmReporteVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvVenta;
        private BDInmobiliariaCasaFelizDataSet bDInmobiliariaCasaFelizDataSet;
        private System.Windows.Forms.BindingSource tablaVentaBindingSource;
        private BDInmobiliariaCasaFelizDataSetTableAdapters.tablaVentaTableAdapter tablaVentaTableAdapter;
        private System.Windows.Forms.Label lblIdInmueble;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaVenta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.ComboBox cboInmueble;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Button btnLimpiarFiltros;
    }
}