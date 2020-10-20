namespace TESTWF2020.Reportes.frmReportes
{
    partial class frmReporteFinanaciacion
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
            this.dataTableFinanciacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDInmobiliariaCasaFelizDataSetFinanciacion = new TESTWF2020.BDInmobiliariaCasaFelizDataSetFinanciacion();
            this.rptvFinanaciacion = new Microsoft.Reporting.WinForms.ReportViewer();
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
            // rptvFinanaciacion
            // 
            reportDataSource1.Name = "DataSetFinanciacion";
            reportDataSource1.Value = this.dataTableFinanciacionBindingSource;
            this.rptvFinanaciacion.LocalReport.DataSources.Add(reportDataSource1);
            this.rptvFinanaciacion.LocalReport.ReportEmbeddedResource = "TESTWF2020.Reportes.Reportes.rptFinanciacion.rdlc";
            this.rptvFinanaciacion.Location = new System.Drawing.Point(1, 186);
            this.rptvFinanaciacion.Name = "rptvFinanaciacion";
            this.rptvFinanaciacion.ServerReport.BearerToken = null;
            this.rptvFinanaciacion.Size = new System.Drawing.Size(798, 325);
            this.rptvFinanaciacion.TabIndex = 0;
            // 
            // dataTableFinanciacionTableAdapter
            // 
            this.dataTableFinanciacionTableAdapter.ClearBeforeFill = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(687, 87);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGrafico
            // 
            this.btnGrafico.Location = new System.Drawing.Point(687, 143);
            this.btnGrafico.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(100, 28);
            this.btnGrafico.TabIndex = 19;
            this.btnGrafico.Text = "Grafico";
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Location = new System.Drawing.Point(38, 122);
            this.lblFechaVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(86, 17);
            this.lblFechaVenta.TabIndex = 18;
            this.lblFechaVenta.Text = "Fecha venta";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(139, 143);
            this.lblFechaHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(45, 17);
            this.lblFechaHasta.TabIndex = 17;
            this.lblFechaHasta.Text = "Hasta";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(139, 98);
            this.lblFechaDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(49, 17);
            this.lblFechaDesde.TabIndex = 16;
            this.lblFechaDesde.Text = "Desde";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(247, 139);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(155, 22);
            this.dtpFechaHasta.TabIndex = 15;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(247, 90);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(155, 22);
            this.dtpFechaDesde.TabIndex = 14;
            // 
            // lblFinanciacion
            // 
            this.lblFinanciacion.AutoSize = true;
            this.lblFinanciacion.Location = new System.Drawing.Point(47, 50);
            this.lblFinanciacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinanciacion.Name = "lblFinanciacion";
            this.lblFinanciacion.Size = new System.Drawing.Size(141, 17);
            this.lblFinanciacion.TabIndex = 22;
            this.lblFinanciacion.Text = "Nombre Financiacion";
            // 
            // txtFinanciacion
            // 
            this.txtFinanciacion.Location = new System.Drawing.Point(247, 45);
            this.txtFinanciacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtFinanciacion.Name = "txtFinanciacion";
            this.txtFinanciacion.Size = new System.Drawing.Size(155, 22);
            this.txtFinanciacion.TabIndex = 21;
            // 
            // frmReporteFinanaciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.lblFinanciacion);
            this.Controls.Add(this.txtFinanciacion);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.lblFechaVenta);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.rptvFinanaciacion);
            this.Name = "frmReporteFinanaciacion";
            this.Text = "Reporte Finanaciacion";
            this.Load += new System.EventHandler(this.frmReporteFinanaciacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableFinanciacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSetFinanciacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvFinanaciacion;
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