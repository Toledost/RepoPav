namespace TESTWF2020.Reportes.frmReportes
{
    partial class frmReportes
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
            this.relacionInmuebleEstadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inmuebleEstado = new TESTWF2020.InmuebleEstado();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.relacionInmuebleEstadoTableAdapter = new TESTWF2020.InmuebleEstadoTableAdapters.RelacionInmuebleEstadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.relacionInmuebleEstadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmuebleEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // relacionInmuebleEstadoBindingSource
            // 
            this.relacionInmuebleEstadoBindingSource.DataMember = "RelacionInmuebleEstado";
            this.relacionInmuebleEstadoBindingSource.DataSource = this.inmuebleEstado;
            // 
            // inmuebleEstado
            // 
            this.inmuebleEstado.DataSetName = "InmuebleEstado";
            this.inmuebleEstado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.relacionInmuebleEstadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TESTWF2020.Reportes.Reportes.ReporteInmueble.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // relacionInmuebleEstadoTableAdapter
            // 
            this.relacionInmuebleEstadoTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.relacionInmuebleEstadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmuebleEstado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private InmuebleEstado inmuebleEstado;
        private System.Windows.Forms.BindingSource relacionInmuebleEstadoBindingSource;
        private InmuebleEstadoTableAdapters.RelacionInmuebleEstadoTableAdapter relacionInmuebleEstadoTableAdapter;
    }
}