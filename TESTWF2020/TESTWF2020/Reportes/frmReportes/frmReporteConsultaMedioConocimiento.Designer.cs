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
            this.lblMedioConocimiento = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.cboMedioDeConocimiento = new System.Windows.Forms.ComboBox();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.consultaMedioConocimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1ConsultaInmueble)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.rptvMedioConocimiento.Location = new System.Drawing.Point(13, 248);
            this.rptvMedioConocimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rptvMedioConocimiento.Name = "rptvMedioConocimiento";
            this.rptvMedioConocimiento.ServerReport.BearerToken = null;
            this.rptvMedioConocimiento.Size = new System.Drawing.Size(1344, 497);
            this.rptvMedioConocimiento.TabIndex = 0;
            // 
            // consultaMedioConocimientoTableAdapter
            // 
            this.consultaMedioConocimientoTableAdapter.ClearBeforeFill = true;
            // 
            // lblMedioConocimiento
            // 
            this.lblMedioConocimiento.AutoSize = true;
            this.lblMedioConocimiento.Location = new System.Drawing.Point(39, 69);
            this.lblMedioConocimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedioConocimiento.Name = "lblMedioConocimiento";
            this.lblMedioConocimiento.Size = new System.Drawing.Size(197, 25);
            this.lblMedioConocimiento.TabIndex = 15;
            this.lblMedioConocimiento.Text = "Medio Conocimiento:";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(39, 168);
            this.lblFechaDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(75, 25);
            this.lblFechaDesde.TabIndex = 14;
            this.lblFechaDesde.Text = "Desde:";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(457, 168);
            this.lblFechaHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(69, 25);
            this.lblFechaHasta.TabIndex = 13;
            this.lblFechaHasta.Text = "Hasta:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(534, 163);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(265, 30);
            this.dtpFechaHasta.TabIndex = 12;
            this.dtpFechaHasta.Value = new System.DateTime(2020, 10, 17, 18, 48, 47, 0);
            this.dtpFechaHasta.ValueChanged += new System.EventHandler(this.dtpFechaHasta_ValueChanged);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(122, 163);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(265, 30);
            this.dtpFechaDesde.TabIndex = 11;
            this.dtpFechaDesde.Value = new System.DateTime(2020, 10, 17, 18, 49, 17, 0);
            this.dtpFechaDesde.ValueChanged += new System.EventHandler(this.dtpFechaDesde_ValueChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::TESTWF2020.Properties.Resources.icons8_fácil_de_encontrar_40;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(1098, 24);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(239, 51);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Consultar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGrafico
            // 
            this.btnGrafico.Image = global::TESTWF2020.Properties.Resources.icons8_gráfico_combinado_48;
            this.btnGrafico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrafico.Location = new System.Drawing.Point(1098, 90);
            this.btnGrafico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(239, 51);
            this.btnGrafico.TabIndex = 9;
            this.btnGrafico.Text = "Gráfico";
            this.btnGrafico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // cboMedioDeConocimiento
            // 
            this.cboMedioDeConocimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMedioDeConocimiento.FormattingEnabled = true;
            this.cboMedioDeConocimiento.Location = new System.Drawing.Point(244, 66);
            this.cboMedioDeConocimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMedioDeConocimiento.Name = "cboMedioDeConocimiento";
            this.cboMedioDeConocimiento.Size = new System.Drawing.Size(322, 33);
            this.cboMedioDeConocimiento.TabIndex = 16;
            this.cboMedioDeConocimiento.Tag = "nombreMedioConocimiento";
            this.cboMedioDeConocimiento.SelectedIndexChanged += new System.EventHandler(this.cboMedioDeConocimiento_SelectedIndexChanged);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Image = global::TESTWF2020.Properties.Resources.icons8_borrar_48;
            this.btnLimpiarFiltros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(1098, 154);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(239, 53);
            this.btnLimpiarFiltros.TabIndex = 18;
            this.btnLimpiarFiltros.Text = "Limpiar Filtros";
            this.btnLimpiarFiltros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.btnLimpiarFiltros);
            this.groupBox1.Controls.Add(this.cboMedioDeConocimiento);
            this.groupBox1.Controls.Add(this.lblMedioConocimiento);
            this.groupBox1.Controls.Add(this.lblFechaDesde);
            this.groupBox1.Controls.Add(this.lblFechaHasta);
            this.groupBox1.Controls.Add(this.dtpFechaHasta);
            this.groupBox1.Controls.Add(this.dtpFechaDesde);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnGrafico);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1344, 220);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro Reportes Medios de Conocimiento";
            // 
            // frmReporteConsultaMedioConocimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 758);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rptvMedioConocimiento);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReporteConsultaMedioConocimiento";
            this.Text = "Reporte Consulta Medio de Conocimiento";
            this.Load += new System.EventHandler(this.frmReporteConsultaMedioConocimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultaMedioConocimientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1ConsultaInmueble)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvMedioConocimiento;
        private DataSet1ConsultaInmueble dataSet1ConsultaInmueble;
        private System.Windows.Forms.BindingSource consultaMedioConocimientoBindingSource;
        private DataSet1ConsultaInmuebleTableAdapters.ConsultaMedioConocimientoTableAdapter consultaMedioConocimientoTableAdapter;
        private System.Windows.Forms.Label lblMedioConocimiento;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.ComboBox cboMedioDeConocimiento;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}