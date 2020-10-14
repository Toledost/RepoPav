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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inmuebleEstado1 = new TESTWF2020.InmuebleEstado();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.relacionInmuebleEstadoTableAdapter1 = new TESTWF2020.InmuebleEstadoTableAdapters.RelacionInmuebleEstadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmuebleEstado1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "RelacionInmuebleEstado";
            this.bindingSource1.DataSource = this.inmuebleEstado1;
            // 
            // inmuebleEstado1
            // 
            this.inmuebleEstado1.DataSetName = "InmuebleEstado";
            this.inmuebleEstado1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.bindingSource1;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "TESTWF2020.Reportes.Reportes.ReporteInmueble.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(804, 461);
            this.reportViewer2.TabIndex = 0;
            // 
            // relacionInmuebleEstadoTableAdapter1
            // 
            this.relacionInmuebleEstadoTableAdapter1.ClearBeforeFill = true;
            // 
            // frmReportes
            // 
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.reportViewer2);
            this.Name = "frmReportes";
            this.Load += new System.EventHandler(this.frmReportes_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmuebleEstado1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private InmuebleEstado inmuebleEstado;
        private System.Windows.Forms.BindingSource relacionInmuebleEstadoBindingSource;
        private InmuebleEstadoTableAdapters.RelacionInmuebleEstadoTableAdapter relacionInmuebleEstadoTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private InmuebleEstado inmuebleEstado1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private InmuebleEstadoTableAdapters.RelacionInmuebleEstadoTableAdapter relacionInmuebleEstadoTableAdapter1;
    }
}