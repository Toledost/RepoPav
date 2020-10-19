namespace TESTWF2020.Reportes.frmReportes
{
    partial class frmReporteEmpleado
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
            this.rptvEmpleados = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tablaEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDInmobiliariaCasaFelizDataSetEmpleado = new TESTWF2020.BDInmobiliariaCasaFelizDataSetEmpleado();
            this.tablaEmpleadoTableAdapter = new TESTWF2020.BDInmobiliariaCasaFelizDataSetEmpleadoTableAdapters.tablaEmpleadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSetEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // rptvEmpleados
            // 
            reportDataSource1.Name = "DataSetEmpleados";
            reportDataSource1.Value = this.tablaEmpleadoBindingSource;
            this.rptvEmpleados.LocalReport.DataSources.Add(reportDataSource1);
            this.rptvEmpleados.LocalReport.ReportEmbeddedResource = "TESTWF2020.Reportes.Reportes.rptEmpleados.rdlc";
            this.rptvEmpleados.Location = new System.Drawing.Point(0, 79);
            this.rptvEmpleados.Name = "rptvEmpleados";
            this.rptvEmpleados.ServerReport.BearerToken = null;
            this.rptvEmpleados.Size = new System.Drawing.Size(801, 292);
            this.rptvEmpleados.TabIndex = 1;
            this.rptvEmpleados.Load += new System.EventHandler(this.rptvEmpleados_Load);
            // 
            // tablaEmpleadoBindingSource
            // 
            this.tablaEmpleadoBindingSource.DataMember = "tablaEmpleado";
            this.tablaEmpleadoBindingSource.DataSource = this.bDInmobiliariaCasaFelizDataSetEmpleado;
            // 
            // bDInmobiliariaCasaFelizDataSetEmpleado
            // 
            this.bDInmobiliariaCasaFelizDataSetEmpleado.DataSetName = "BDInmobiliariaCasaFelizDataSetEmpleado";
            this.bDInmobiliariaCasaFelizDataSetEmpleado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablaEmpleadoTableAdapter
            // 
            this.tablaEmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptvEmpleados);
            this.Name = "frmReporteEmpleado";
            this.Text = "frmReporteEmpleado";
            this.Load += new System.EventHandler(this.frmReporteEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSetEmpleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvEmpleados;
        private BDInmobiliariaCasaFelizDataSetEmpleado bDInmobiliariaCasaFelizDataSetEmpleado;
        private System.Windows.Forms.BindingSource tablaEmpleadoBindingSource;
        private BDInmobiliariaCasaFelizDataSetEmpleadoTableAdapters.tablaEmpleadoTableAdapter tablaEmpleadoTableAdapter;
    }
}