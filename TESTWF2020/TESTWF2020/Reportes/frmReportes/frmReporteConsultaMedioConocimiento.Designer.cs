namespace TESTWF2020.Reportes.frmReportes
{
    partial class frmReporteConsultaMedioConocimiento
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
            this.consultaMedioConocimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1ConsultaInmueble = new TESTWF2020.DataSet1ConsultaInmueble();
            this.rptvMedioConocimiento = new Microsoft.Reporting.WinForms.ReportViewer();
            this.consultaMedioConocimientoTableAdapter = new TESTWF2020.DataSet1ConsultaInmuebleTableAdapters.ConsultaMedioConocimientoTableAdapter();
            this.txtMedioConocimiento = new System.Windows.Forms.TextBox();
            this.lblMedioConocimiento = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGrafico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.consultaMedioConocimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1ConsultaInmueble)).BeginInit();
            this.SuspendLayout();
            // 
            // consultaMedioConocimientoBindingSource
            // 
            this.consultaMedioConocimientoBindingSource.DataMember = "ConsultaMedioConocimiento";
            this.consultaMedioConocimientoBindingSource.DataSource = this.dataSet1ConsultaInmueble;
            // 
            // dataSet1ConsultaInmueble
            // 
            this.dataSet1ConsultaInmueble.DataSetName = "DataSet1ConsultaInmueble";
            this.dataSet1ConsultaInmueble.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptvMedioConocimiento
            // 
            reportDataSource1.Name = "DataSetConsultaMedioConocimiento";
            reportDataSource1.Value = this.consultaMedioConocimientoBindingSource;
            this.rptvMedioConocimiento.LocalReport.DataSources.Add(reportDataSource1);
            this.rptvMedioConocimiento.LocalReport.ReportEmbeddedResource = "TESTWF2020.Reportes.Reportes.rptConsultaMedioConocimiento.rdlc";
            this.rptvMedioConocimiento.Location = new System.Drawing.Point(12, 161);
            this.rptvMedioConocimiento.Name = "rptvMedioConocimiento";
            this.rptvMedioConocimiento.ServerReport.BearerToken = null;
            this.rptvMedioConocimiento.Size = new System.Drawing.Size(776, 246);
            this.rptvMedioConocimiento.TabIndex = 0;
            // 
            // consultaMedioConocimientoTableAdapter
            // 
            this.consultaMedioConocimientoTableAdapter.ClearBeforeFill = true;
            // 
            // txtMedioConocimiento
            // 
            this.txtMedioConocimiento.Location = new System.Drawing.Point(155, 45);
            this.txtMedioConocimiento.Name = "txtMedioConocimiento";
            this.txtMedioConocimiento.Size = new System.Drawing.Size(100, 20);
            this.txtMedioConocimiento.TabIndex = 16;
            // 
            // lblMedioConocimiento
            // 
            this.lblMedioConocimiento.AutoSize = true;
            this.lblMedioConocimiento.Location = new System.Drawing.Point(43, 45);
            this.lblMedioConocimiento.Name = "lblMedioConocimiento";
            this.lblMedioConocimiento.Size = new System.Drawing.Size(106, 13);
            this.lblMedioConocimiento.TabIndex = 15;
            this.lblMedioConocimiento.Text = "Medio Conocimiento:";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(44, 94);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(38, 13);
            this.lblFechaDesde.TabIndex = 14;
            this.lblFechaDesde.Text = "Desde";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(360, 94);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(35, 13);
            this.lblFechaHasta.TabIndex = 13;
            this.lblFechaHasta.Text = "Hasta";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(417, 88);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaHasta.TabIndex = 12;
            this.dtpFechaHasta.Value = new System.DateTime(2020, 10, 17, 18, 48, 47, 0);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(110, 90);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDesde.TabIndex = 11;
            this.dtpFechaDesde.Value = new System.DateTime(2020, 10, 17, 18, 49, 17, 0);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(688, 58);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGrafico
            // 
            this.btnGrafico.Location = new System.Drawing.Point(688, 87);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(75, 23);
            this.btnGrafico.TabIndex = 9;
            this.btnGrafico.Text = "Grafico";
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // frmReporteConsultaMedioConocimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMedioConocimiento);
            this.Controls.Add(this.lblMedioConocimiento);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.rptvMedioConocimiento);
            this.Name = "frmReporteConsultaMedioConocimiento";
            this.Text = "Reporte Consulta Medio de Conocimiento";
            this.Load += new System.EventHandler(this.frmReporteConsultaMedioConocimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultaMedioConocimientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1ConsultaInmueble)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvMedioConocimiento;
        private DataSet1ConsultaInmueble dataSet1ConsultaInmueble;
        private System.Windows.Forms.BindingSource consultaMedioConocimientoBindingSource;
        private DataSet1ConsultaInmuebleTableAdapters.ConsultaMedioConocimientoTableAdapter consultaMedioConocimientoTableAdapter;
        private System.Windows.Forms.TextBox txtMedioConocimiento;
        private System.Windows.Forms.Label lblMedioConocimiento;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGrafico;
    }
}