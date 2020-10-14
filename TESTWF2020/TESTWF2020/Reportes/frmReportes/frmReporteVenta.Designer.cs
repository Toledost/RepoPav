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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rptvVenta = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tablaVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDInmobiliariaCasaFelizDataSet = new TESTWF2020.BDInmobiliariaCasaFelizDataSet();
            this.tablaVentaTableAdapter = new TESTWF2020.BDInmobiliariaCasaFelizDataSetTableAdapters.tablaVentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // rptvVenta
            // 
            this.rptvVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tablaVentaBindingSource;
            this.rptvVenta.LocalReport.DataSources.Add(reportDataSource1);
            this.rptvVenta.LocalReport.ReportEmbeddedResource = "TESTWF2020.Reportes.Reportes.rptVenta.rdlc";
            this.rptvVenta.Location = new System.Drawing.Point(0, 0);
            this.rptvVenta.Name = "rptvVenta";
            this.rptvVenta.ServerReport.BearerToken = null;
            this.rptvVenta.Size = new System.Drawing.Size(800, 450);
            this.rptvVenta.TabIndex = 0;
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
            // tablaVentaTableAdapter
            // 
            this.tablaVentaTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptvVenta);
            this.Name = "frmReporteVenta";
            this.Text = "Reporte de venta";
            this.Load += new System.EventHandler(this.frmReporteVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvVenta;
        private BDInmobiliariaCasaFelizDataSet bDInmobiliariaCasaFelizDataSet;
        private System.Windows.Forms.BindingSource tablaVentaBindingSource;
        private BDInmobiliariaCasaFelizDataSetTableAdapters.tablaVentaTableAdapter tablaVentaTableAdapter;
    }
}