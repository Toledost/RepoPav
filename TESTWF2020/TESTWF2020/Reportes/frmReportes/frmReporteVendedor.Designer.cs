namespace TESTWF2020.Reportes.frmReportes
{
    partial class frmReporteVendedor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataTableVendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDInmobiliariaCasaFelizDataSetVendedor = new TESTWF2020.BDInmobiliariaCasaFelizDataSetVendedor();
            this.rptvVendedor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bDInmobiliariaCasaFelizDataSetVendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableVendedorTableAdapter = new TESTWF2020.BDInmobiliariaCasaFelizDataSetVendedorTableAdapters.DataTableVendedorTableAdapter();
            this.txtNombreVendedor = new System.Windows.Forms.TextBox();
            this.lblNombreVendedor = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.lblTituloFechas = new System.Windows.Forms.Label();
            this.lblCalleInmueble = new System.Windows.Forms.Label();
            this.txtCalleInmueble = new System.Windows.Forms.TextBox();
            this.lblNroCalle = new System.Windows.Forms.Label();
            this.txtNroCalle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableVendedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSetVendedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSetVendedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTableVendedorBindingSource
            // 
            this.dataTableVendedorBindingSource.DataMember = "DataTableVendedor";
            this.dataTableVendedorBindingSource.DataSource = this.bDInmobiliariaCasaFelizDataSetVendedor;
            // 
            // bDInmobiliariaCasaFelizDataSetVendedor
            // 
            this.bDInmobiliariaCasaFelizDataSetVendedor.DataSetName = "BDInmobiliariaCasaFelizDataSetVendedor";
            this.bDInmobiliariaCasaFelizDataSetVendedor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptvVendedor
            // 
            reportDataSource1.Name = "DataSetVendedor";
            reportDataSource1.Value = this.dataTableVendedorBindingSource;
            this.rptvVendedor.LocalReport.DataSources.Add(reportDataSource1);
            this.rptvVendedor.LocalReport.ReportEmbeddedResource = "TESTWF2020.Reportes.Reportes.rptVendedor.rdlc";
            this.rptvVendedor.Location = new System.Drawing.Point(11, 211);
            this.rptvVendedor.Name = "rptvVendedor";
            this.rptvVendedor.ServerReport.BearerToken = null;
            this.rptvVendedor.Size = new System.Drawing.Size(927, 363);
            this.rptvVendedor.TabIndex = 0;
            // 
            // bDInmobiliariaCasaFelizDataSetVendedorBindingSource
            // 
            this.bDInmobiliariaCasaFelizDataSetVendedorBindingSource.DataSource = this.bDInmobiliariaCasaFelizDataSetVendedor;
            this.bDInmobiliariaCasaFelizDataSetVendedorBindingSource.Position = 0;
            // 
            // dataTableVendedorTableAdapter
            // 
            this.dataTableVendedorTableAdapter.ClearBeforeFill = true;
            // 
            // txtNombreVendedor
            // 
            this.txtNombreVendedor.Location = new System.Drawing.Point(189, 49);
            this.txtNombreVendedor.Name = "txtNombreVendedor";
            this.txtNombreVendedor.Size = new System.Drawing.Size(205, 22);
            this.txtNombreVendedor.TabIndex = 1;
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.AutoSize = true;
            this.lblNombreVendedor.Location = new System.Drawing.Point(55, 52);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Size = new System.Drawing.Size(128, 17);
            this.lblNombreVendedor.TabIndex = 2;
            this.lblNombreVendedor.Text = "Nombre Vendedor:";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(55, 88);
            this.lblFechaDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(49, 17);
            this.lblFechaDesde.TabIndex = 16;
            this.lblFechaDesde.Text = "Desde";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(55, 130);
            this.lblFechaHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(45, 17);
            this.lblFechaHasta.TabIndex = 15;
            this.lblFechaHasta.Text = "Hasta";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(129, 125);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaHasta.TabIndex = 14;
            this.dtpFechaHasta.Value = new System.DateTime(2020, 10, 17, 18, 48, 47, 0);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(129, 88);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaDesde.TabIndex = 13;
            this.dtpFechaDesde.Value = new System.DateTime(2020, 10, 17, 18, 49, 17, 0);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(838, 41);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGrafico
            // 
            this.btnGrafico.Location = new System.Drawing.Point(838, 77);
            this.btnGrafico.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(100, 28);
            this.btnGrafico.TabIndex = 11;
            this.btnGrafico.Text = "Grafico";
            this.btnGrafico.UseVisualStyleBackColor = true;
            // 
            // lblTituloFechas
            // 
            this.lblTituloFechas.AutoSize = true;
            this.lblTituloFechas.Location = new System.Drawing.Point(161, 151);
            this.lblTituloFechas.Name = "lblTituloFechas";
            this.lblTituloFechas.Size = new System.Drawing.Size(189, 17);
            this.lblTituloFechas.TabIndex = 17;
            this.lblTituloFechas.Text = "Fecha de Venta de Inmueble";
            // 
            // lblCalleInmueble
            // 
            this.lblCalleInmueble.AutoSize = true;
            this.lblCalleInmueble.Location = new System.Drawing.Point(465, 52);
            this.lblCalleInmueble.Name = "lblCalleInmueble";
            this.lblCalleInmueble.Size = new System.Drawing.Size(104, 17);
            this.lblCalleInmueble.TabIndex = 19;
            this.lblCalleInmueble.Text = "Calle Inmueble:";
            // 
            // txtCalleInmueble
            // 
            this.txtCalleInmueble.Location = new System.Drawing.Point(575, 49);
            this.txtCalleInmueble.Name = "txtCalleInmueble";
            this.txtCalleInmueble.Size = new System.Drawing.Size(205, 22);
            this.txtCalleInmueble.TabIndex = 18;
            // 
            // lblNroCalle
            // 
            this.lblNroCalle.AutoSize = true;
            this.lblNroCalle.Location = new System.Drawing.Point(411, 86);
            this.lblNroCalle.Name = "lblNroCalle";
            this.lblNroCalle.Size = new System.Drawing.Size(158, 17);
            this.lblNroCalle.TabIndex = 21;
            this.lblNroCalle.Text = "Numero Calle Inmueble:";
            // 
            // txtNroCalle
            // 
            this.txtNroCalle.Location = new System.Drawing.Point(575, 83);
            this.txtNroCalle.Name = "txtNroCalle";
            this.txtNroCalle.Size = new System.Drawing.Size(205, 22);
            this.txtNroCalle.TabIndex = 20;
            // 
            // frmReporteVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 603);
            this.Controls.Add(this.lblNroCalle);
            this.Controls.Add(this.txtNroCalle);
            this.Controls.Add(this.lblCalleInmueble);
            this.Controls.Add(this.txtCalleInmueble);
            this.Controls.Add(this.lblTituloFechas);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.lblNombreVendedor);
            this.Controls.Add(this.txtNombreVendedor);
            this.Controls.Add(this.rptvVendedor);
            this.Name = "frmReporteVendedor";
            this.Text = "Reporte Vendedor";
            this.Load += new System.EventHandler(this.frmReporteVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableVendedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSetVendedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSetVendedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvVendedor;
        private System.Windows.Forms.BindingSource bDInmobiliariaCasaFelizDataSetVendedorBindingSource;
        private BDInmobiliariaCasaFelizDataSetVendedor bDInmobiliariaCasaFelizDataSetVendedor;
        private System.Windows.Forms.BindingSource dataTableVendedorBindingSource;
        private BDInmobiliariaCasaFelizDataSetVendedorTableAdapters.DataTableVendedorTableAdapter dataTableVendedorTableAdapter;
        private System.Windows.Forms.TextBox txtNombreVendedor;
        private System.Windows.Forms.Label lblNombreVendedor;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.Label lblTituloFechas;
        private System.Windows.Forms.Label lblCalleInmueble;
        private System.Windows.Forms.TextBox txtCalleInmueble;
        private System.Windows.Forms.Label lblNroCalle;
        private System.Windows.Forms.TextBox txtNroCalle;
    }
}