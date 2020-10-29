namespace TESTWF2020.Reportes.frmReportes
{
    partial class frmReporteFinanciacion
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataTableFinanciacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDInmobiliariaCasaFelizDataSetFinanciacion = new TESTWF2020.BDInmobiliariaCasaFelizDataSetFinanciacion();
            this.rptvFinanciacion = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataTableFinanciacionTableAdapter = new TESTWF2020.BDInmobiliariaCasaFelizDataSetFinanciacionTableAdapters.DataTableFinanciacionTableAdapter();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFinanciacion = new System.Windows.Forms.Label();
            this.txtFinanciacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableFinanciacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSetFinanciacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTableFinanciacionBindingSource
            // 
            this.dataTableFinanciacionBindingSource.DataMember = "DataTableFinanciacion";
            this.dataTableFinanciacionBindingSource.DataSource = this.bDInmobiliariaCasaFelizDataSetFinanciacion;
            // 
            // bDInmobiliariaCasaFelizDataSetFinanciacion
            // 
            this.bDInmobiliariaCasaFelizDataSetFinanciacion.DataSetName = "BDInmobiliariaCasaFelizDataSetFinanciacion";
            this.bDInmobiliariaCasaFelizDataSetFinanciacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptvFinanciacion
            // 
            reportDataSource2.Name = "DataSetFinanciacion";
            reportDataSource2.Value = this.dataTableFinanciacionBindingSource;
            this.rptvFinanciacion.LocalReport.DataSources.Add(reportDataSource2);
            this.rptvFinanciacion.LocalReport.ReportEmbeddedResource = "TESTWF2020.Reportes.Reportes.rptFinanciacion.rdlc";
            this.rptvFinanciacion.Location = new System.Drawing.Point(1, 151);
            this.rptvFinanciacion.Margin = new System.Windows.Forms.Padding(2);
            this.rptvFinanciacion.Name = "rptvFinanciacion";
            this.rptvFinanciacion.ServerReport.BearerToken = null;
            this.rptvFinanciacion.Size = new System.Drawing.Size(599, 264);
            this.rptvFinanciacion.TabIndex = 0;
            // 
            // dataTableFinanciacionTableAdapter
            // 
            this.dataTableFinanciacionTableAdapter.ClearBeforeFill = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(515, 71);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGrafico
            // 
            this.btnGrafico.Location = new System.Drawing.Point(515, 116);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(75, 23);
            this.btnGrafico.TabIndex = 19;
            this.btnGrafico.Text = "Grafico";
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Location = new System.Drawing.Point(28, 99);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(67, 13);
            this.lblFechaVenta.TabIndex = 18;
            this.lblFechaVenta.Text = "Fecha venta";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(104, 116);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(35, 13);
            this.lblFechaHasta.TabIndex = 17;
            this.lblFechaHasta.Text = "Hasta";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(104, 80);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(38, 13);
            this.lblFechaDesde.TabIndex = 16;
            this.lblFechaDesde.Text = "Desde";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(185, 113);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(117, 20);
            this.dtpFechaHasta.TabIndex = 15;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(185, 73);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(117, 20);
            this.dtpFechaDesde.TabIndex = 14;
            // 
            // lblFinanciacion
            // 
            this.lblFinanciacion.AutoSize = true;
            this.lblFinanciacion.Location = new System.Drawing.Point(35, 41);
            this.lblFinanciacion.Name = "lblFinanciacion";
            this.lblFinanciacion.Size = new System.Drawing.Size(107, 13);
            this.lblFinanciacion.TabIndex = 22;
            this.lblFinanciacion.Text = "Nombre Financiacion";
            // 
            // txtFinanciacion
            // 
            this.txtFinanciacion.Location = new System.Drawing.Point(185, 37);
            this.txtFinanciacion.Name = "txtFinanciacion";
            this.txtFinanciacion.Size = new System.Drawing.Size(117, 20);
            this.txtFinanciacion.TabIndex = 21;
            // 
            // frmReporteFinanciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 414);
            this.Controls.Add(this.lblFinanciacion);
            this.Controls.Add(this.txtFinanciacion);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.lblFechaVenta);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.rptvFinanciacion);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmReporteFinanciacion";
            this.Text = "Reporte Financiacion";
            this.Load += new System.EventHandler(this.frmReporteFinanciacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableFinanciacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSetFinanciacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvFinanciacion;
        private BDInmobiliariaCasaFelizDataSetFinanciacion bDInmobiliariaCasaFelizDataSetFinanciacion;
        private System.Windows.Forms.BindingSource dataTableFinanciacionBindingSource;
        private BDInmobiliariaCasaFelizDataSetFinanciacionTableAdapters.DataTableFinanciacionTableAdapter dataTableFinanciacionTableAdapter;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.Label lblFechaVenta;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFinanciacion;
        private System.Windows.Forms.TextBox txtFinanciacion;
    }
}