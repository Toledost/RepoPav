namespace TESTWF2020.Reportes.frmReportes
{
    partial class frmReporteCuota
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tablaCuotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDInmobiliariaCasaFelizDataSetCuotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDInmobiliariaCasaFelizDataSetCuota = new TESTWF2020.BDInmobiliariaCasaFelizDataSetCuota();
            this.rptvCuotas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bdInmobiliariaCasaFelizDataSet1 = new TESTWF2020.BDInmobiliariaCasaFelizDataSet();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblNombreComprador = new System.Windows.Forms.Label();
            this.lblCalleInmueble = new System.Windows.Forms.Label();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.tablaCuotaTableAdapter = new TESTWF2020.BDInmobiliariaCasaFelizDataSetCuotaTableAdapters.TablaCuotaTableAdapter();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.cboInmueble = new System.Windows.Forms.ComboBox();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCuotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSetCuotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSetCuota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdInmobiliariaCasaFelizDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaCuotaBindingSource
            // 
            this.tablaCuotaBindingSource.DataMember = "TablaCuota";
            this.tablaCuotaBindingSource.DataSource = this.bDInmobiliariaCasaFelizDataSetCuotaBindingSource;
            // 
            // bDInmobiliariaCasaFelizDataSetCuotaBindingSource
            // 
            this.bDInmobiliariaCasaFelizDataSetCuotaBindingSource.DataSource = this.bDInmobiliariaCasaFelizDataSetCuota;
            this.bDInmobiliariaCasaFelizDataSetCuotaBindingSource.Position = 0;
            // 
            // bDInmobiliariaCasaFelizDataSetCuota
            // 
            this.bDInmobiliariaCasaFelizDataSetCuota.DataSetName = "BDInmobiliariaCasaFelizDataSetCuota";
            this.bDInmobiliariaCasaFelizDataSetCuota.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptvCuotas
            // 
            reportDataSource7.Name = "DataSetCuota";
            reportDataSource7.Value = this.tablaCuotaBindingSource;
            this.rptvCuotas.LocalReport.DataSources.Add(reportDataSource7);
            this.rptvCuotas.LocalReport.ReportEmbeddedResource = "TESTWF2020.Reportes.Reportes.rptCuotas.rdlc";
            this.rptvCuotas.Location = new System.Drawing.Point(2, 160);
            this.rptvCuotas.Name = "rptvCuotas";
            this.rptvCuotas.ServerReport.BearerToken = null;
            this.rptvCuotas.Size = new System.Drawing.Size(801, 292);
            this.rptvCuotas.TabIndex = 0;
            // 
            // bdInmobiliariaCasaFelizDataSet1
            // 
            this.bdInmobiliariaCasaFelizDataSet1.DataSetName = "BDInmobiliariaCasaFelizDataSet";
            this.bdInmobiliariaCasaFelizDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(682, 47);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGrafico
            // 
            this.btnGrafico.Location = new System.Drawing.Point(682, 76);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(75, 23);
            this.btnGrafico.TabIndex = 3;
            this.btnGrafico.Text = "Grafico";
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(238, 85);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(38, 13);
            this.lblFechaDesde.TabIndex = 10;
            this.lblFechaDesde.Text = "Desde";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(238, 119);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(35, 13);
            this.lblFechaHasta.TabIndex = 9;
            this.lblFechaHasta.Text = "Hasta";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(295, 113);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaHasta.TabIndex = 8;
            this.dtpFechaHasta.Value = new System.DateTime(2020, 10, 17, 18, 48, 47, 0);
            this.dtpFechaHasta.ValueChanged += new System.EventHandler(this.dtpFechaHasta_ValueChanged);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(295, 79);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDesde.TabIndex = 7;
            this.dtpFechaDesde.Value = new System.DateTime(2020, 10, 17, 18, 49, 17, 0);
            this.dtpFechaDesde.ValueChanged += new System.EventHandler(this.dtpFechaDesde_ValueChanged);
            // 
            // lblNombreComprador
            // 
            this.lblNombreComprador.AutoSize = true;
            this.lblNombreComprador.Location = new System.Drawing.Point(44, 23);
            this.lblNombreComprador.Name = "lblNombreComprador";
            this.lblNombreComprador.Size = new System.Drawing.Size(42, 13);
            this.lblNombreComprador.TabIndex = 11;
            this.lblNombreComprador.Text = "Cliente:";
            // 
            // lblCalleInmueble
            // 
            this.lblCalleInmueble.AutoSize = true;
            this.lblCalleInmueble.Location = new System.Drawing.Point(292, 26);
            this.lblCalleInmueble.Name = "lblCalleInmueble";
            this.lblCalleInmueble.Size = new System.Drawing.Size(50, 13);
            this.lblCalleInmueble.TabIndex = 15;
            this.lblCalleInmueble.Text = "Inmueble";
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(124, 104);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(98, 13);
            this.lblFechaVencimiento.TabIndex = 17;
            this.lblFechaVencimiento.Text = "Fecha Vencimiento";
            // 
            // tablaCuotaTableAdapter
            // 
            this.tablaCuotaTableAdapter.ClearBeforeFill = true;
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(131, 20);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(121, 21);
            this.cboCliente.TabIndex = 18;
            this.cboCliente.Tag = "nombreComprador";
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            // 
            // cboInmueble
            // 
            this.cboInmueble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInmueble.FormattingEnabled = true;
            this.cboInmueble.Location = new System.Drawing.Point(371, 20);
            this.cboInmueble.Name = "cboInmueble";
            this.cboInmueble.Size = new System.Drawing.Size(121, 21);
            this.cboInmueble.TabIndex = 20;
            this.cboInmueble.Tag = "nombreInmueble";
            this.cboInmueble.SelectedIndexChanged += new System.EventHandler(this.cboInmueble_SelectedIndexChanged);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(587, 47);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(75, 52);
            this.btnLimpiarFiltros.TabIndex = 21;
            this.btnLimpiarFiltros.Text = "Limpiar Filtros";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // frmReporteCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiarFiltros);
            this.Controls.Add(this.cboInmueble);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.lblFechaVencimiento);
            this.Controls.Add(this.lblCalleInmueble);
            this.Controls.Add(this.lblNombreComprador);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.rptvCuotas);
            this.Name = "frmReporteCuota";
            this.Text = "Reporte Cuota";
            this.Load += new System.EventHandler(this.frmReporteCuota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCuotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSetCuotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSetCuota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdInmobiliariaCasaFelizDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvCuotas;
        private BDInmobiliariaCasaFelizDataSetCuota bDInmobiliariaCasaFelizDataSetCuota;
        private System.Windows.Forms.BindingSource bDInmobiliariaCasaFelizDataSetCuotaBindingSource;
        private System.Windows.Forms.BindingSource tablaCuotaBindingSource;
        private BDInmobiliariaCasaFelizDataSetCuotaTableAdapters.TablaCuotaTableAdapter tablaCuotaTableAdapter;
        private BDInmobiliariaCasaFelizDataSet bdInmobiliariaCasaFelizDataSet1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblNombreComprador;
        private System.Windows.Forms.Label lblCalleInmueble;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.ComboBox cboInmueble;
        private System.Windows.Forms.Button btnLimpiarFiltros;
    }
}