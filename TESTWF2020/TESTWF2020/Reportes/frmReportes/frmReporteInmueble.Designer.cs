namespace TESTWF2020.Reportes.frmReportes
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inmuebleEstado1 = new TESTWF2020.InmuebleEstado();
            this.rptvInmueble = new Microsoft.Reporting.WinForms.ReportViewer();
            this.relacionInmuebleEstadoTableAdapter1 = new TESTWF2020.InmuebleEstadoTableAdapters.RelacionInmuebleEstadoTableAdapter();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmuebleEstado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
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
            // rptvInmueble
            // 
            this.rptvInmueble.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.bindingSource2;
            this.rptvInmueble.LocalReport.DataSources.Add(reportDataSource1);
            this.rptvInmueble.LocalReport.ReportEmbeddedResource = "TESTWF2020.Reportes.Reportes.rptInmueble.rdlc";
            this.rptvInmueble.Location = new System.Drawing.Point(0, 0);
            this.rptvInmueble.Name = "rptvInmueble";
            this.rptvInmueble.ServerReport.BearerToken = null;
            this.rptvInmueble.Size = new System.Drawing.Size(804, 461);
            this.rptvInmueble.TabIndex = 0;
            // 
            // relacionInmuebleEstadoTableAdapter1
            // 
            this.relacionInmuebleEstadoTableAdapter1.ClearBeforeFill = true;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "RelacionInmuebleEstado";
            this.bindingSource2.DataSource = this.inmuebleEstado1;
            // 
            // frmReporteInmueble
            // 
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.rptvInmueble);
            this.Name = "frmReporteInmueble";
            this.Text = "Reporte de inmueble";
            this.Load += new System.EventHandler(this.frmReportes_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmuebleEstado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private InmuebleEstado inmuebleEstado;
        private System.Windows.Forms.BindingSource relacionInmuebleEstadoBindingSource;
        private InmuebleEstadoTableAdapters.RelacionInmuebleEstadoTableAdapter relacionInmuebleEstadoTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rptvInmueble;
        private InmuebleEstado inmuebleEstado1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private InmuebleEstadoTableAdapters.RelacionInmuebleEstadoTableAdapter relacionInmuebleEstadoTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource2;
    }
}