namespace TESTWF2020.GUILayer.Reportes
{
    partial class frmReporteInmueble
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bDInmobiliariaCasaFelizDataSet = new TESTWF2020.BDInmobiliariaCasaFelizDataSet();
            this.bDInmobiliariaCasaFelizDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bDInmobiliariaCasaFelizDataSetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TESTWF2020.GUILayer.Reportes.ReporteInmueble.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(107, 83);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(615, 292);
            this.reportViewer1.TabIndex = 0;
            // 
            // bDInmobiliariaCasaFelizDataSet
            // 
            this.bDInmobiliariaCasaFelizDataSet.DataSetName = "BDInmobiliariaCasaFelizDataSet";
            this.bDInmobiliariaCasaFelizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bDInmobiliariaCasaFelizDataSetBindingSource
            // 
            this.bDInmobiliariaCasaFelizDataSetBindingSource.DataSource = this.bDInmobiliariaCasaFelizDataSet;
            this.bDInmobiliariaCasaFelizDataSetBindingSource.Position = 0;
            // 
            // frmReporteInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteInmueble";
            this.Text = "frmReporteInmueble";
            this.Load += new System.EventHandler(this.frmReporteInmueble_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bDInmobiliariaCasaFelizDataSetBindingSource;
        private BDInmobiliariaCasaFelizDataSet bDInmobiliariaCasaFelizDataSet;
    }
}