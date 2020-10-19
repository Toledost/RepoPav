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
            this.rptvInmueble = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblInmueble = new System.Windows.Forms.Label();
            this.txtIdInmueble = new System.Windows.Forms.TextBox();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.inmuebleEstado1 = new TESTWF2020.InmuebleEstado();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.relacionInmuebleEstadoTableAdapter1 = new TESTWF2020.InmuebleEstadoTableAdapters.RelacionInmuebleEstadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmuebleEstado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // rptvInmueble
            // 
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.bindingSource2;
            this.rptvInmueble.LocalReport.DataSources.Add(reportDataSource1);
            this.rptvInmueble.LocalReport.ReportEmbeddedResource = "TESTWF2020.Reportes.Reportes.rptInmueble.rdlc";
            this.rptvInmueble.Location = new System.Drawing.Point(-1, 159);
            this.rptvInmueble.Name = "rptvInmueble";
            this.rptvInmueble.ServerReport.BearerToken = null;
            this.rptvInmueble.Size = new System.Drawing.Size(804, 290);
            this.rptvInmueble.TabIndex = 0;
            // 
            // btnGrafico
            // 
            this.btnGrafico.Location = new System.Drawing.Point(691, 77);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(75, 23);
            this.btnGrafico.TabIndex = 1;
            this.btnGrafico.Text = "Grafico";
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(691, 48);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(113, 80);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDesde.TabIndex = 3;
            this.dtpFechaDesde.Value = new System.DateTime(2020, 10, 17, 18, 49, 17, 0);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(420, 78);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaHasta.TabIndex = 4;
            this.dtpFechaHasta.Value = new System.DateTime(2020, 10, 17, 18, 48, 47, 0);
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(363, 84);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(35, 13);
            this.lblFechaHasta.TabIndex = 5;
            this.lblFechaHasta.Text = "Hasta";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(47, 84);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(38, 13);
            this.lblFechaDesde.TabIndex = 6;
            this.lblFechaDesde.Text = "Desde";
            // 
            // lblInmueble
            // 
            this.lblInmueble.AutoSize = true;
            this.lblInmueble.Location = new System.Drawing.Point(46, 35);
            this.lblInmueble.Name = "lblInmueble";
            this.lblInmueble.Size = new System.Drawing.Size(65, 13);
            this.lblInmueble.TabIndex = 7;
            this.lblInmueble.Text = "Id Inmueble:";
            // 
            // txtIdInmueble
            // 
            this.txtIdInmueble.Location = new System.Drawing.Point(113, 36);
            this.txtIdInmueble.Name = "txtIdInmueble";
            this.txtIdInmueble.Size = new System.Drawing.Size(100, 20);
            this.txtIdInmueble.TabIndex = 8;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "RelacionInmuebleEstado";
            this.bindingSource2.DataSource = this.inmuebleEstado1;
            // 
            // inmuebleEstado1
            // 
            this.inmuebleEstado1.DataSetName = "InmuebleEstado";
            this.inmuebleEstado1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "RelacionInmuebleEstado";
            this.bindingSource1.DataSource = this.inmuebleEstado1;
            // 
            // relacionInmuebleEstadoTableAdapter1
            // 
            this.relacionInmuebleEstadoTableAdapter1.ClearBeforeFill = true;
            // 
            // frmReporteInmueble
            // 
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.txtIdInmueble);
            this.Controls.Add(this.lblInmueble);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.rptvInmueble);
            this.Name = "frmReporteInmueble";
            this.Text = "Reporte de inmueble";
            this.Load += new System.EventHandler(this.frmReportes_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmuebleEstado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblInmueble;
        private System.Windows.Forms.TextBox txtIdInmueble;
    }
}