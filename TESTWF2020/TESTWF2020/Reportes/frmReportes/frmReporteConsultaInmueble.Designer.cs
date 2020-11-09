namespace TESTWF2020.Reportes.frmReportes
{
    partial class frmReporteConsultaInmueble
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
            this.consultaInmuebleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1ConsultaInmueble = new TESTWF2020.DataSet1ConsultaInmueble();
            this.rptvConsultaInmueble = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCalle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEstadoConsulta = new System.Windows.Forms.ComboBox();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.consultaInmuebleTableAdapter = new TESTWF2020.DataSet1ConsultaInmuebleTableAdapters.ConsultaInmuebleTableAdapter();
            this.consultaxInmuebleEstadisticaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboInmueble = new System.Windows.Forms.ComboBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.consultaInmuebleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1ConsultaInmueble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaxInmuebleEstadisticaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // consultaInmuebleBindingSource
            // 
            this.consultaInmuebleBindingSource.DataMember = "ConsultaInmueble";
            this.consultaInmuebleBindingSource.DataSource = this.dataSet1ConsultaInmueble;
            // 
            // dataSet1ConsultaInmueble
            // 
            this.dataSet1ConsultaInmueble.DataSetName = "DataSet1ConsultaInmueble";
            this.dataSet1ConsultaInmueble.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptvConsultaInmueble
            // 
            reportDataSource1.Name = "DataSetConsultaInmueble";
            reportDataSource1.Value = this.consultaInmuebleBindingSource;
            this.rptvConsultaInmueble.LocalReport.DataSources.Add(reportDataSource1);
            this.rptvConsultaInmueble.LocalReport.ReportEmbeddedResource = "TESTWF2020.Reportes.Reportes.rptConsultaInmueble.rdlc";
            this.rptvConsultaInmueble.Location = new System.Drawing.Point(12, 214);
            this.rptvConsultaInmueble.Name = "rptvConsultaInmueble";
            this.rptvConsultaInmueble.ServerReport.BearerToken = null;
            this.rptvConsultaInmueble.Size = new System.Drawing.Size(843, 255);
            this.rptvConsultaInmueble.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(743, 78);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(75, 27);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(53, 13);
            this.lblCalle.TabIndex = 2;
            this.lblCalle.Text = "Inmueble:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Estado Consulta:";
            // 
            // cboEstadoConsulta
            // 
            this.cboEstadoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoConsulta.FormattingEnabled = true;
            this.cboEstadoConsulta.Location = new System.Drawing.Point(496, 20);
            this.cboEstadoConsulta.Name = "cboEstadoConsulta";
            this.cboEstadoConsulta.Size = new System.Drawing.Size(109, 21);
            this.cboEstadoConsulta.TabIndex = 6;
            this.cboEstadoConsulta.Tag = "estadoConsulta";
            this.cboEstadoConsulta.SelectedIndexChanged += new System.EventHandler(this.cboEstadoConsulta_SelectedIndexChanged);
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(403, 64);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(74, 13);
            this.lblFechaDesde.TabIndex = 8;
            this.lblFechaDesde.Text = "Fecha Desde:";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(403, 97);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(71, 13);
            this.lblFechaHasta.TabIndex = 9;
            this.lblFechaHasta.Text = "Fecha Hasta:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(496, 60);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(107, 20);
            this.dtpFechaDesde.TabIndex = 10;
            this.dtpFechaDesde.Tag = "Fecha Desde";
            this.dtpFechaDesde.ValueChanged += new System.EventHandler(this.dtpFechaDesde_ValueChanged);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(496, 97);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(107, 20);
            this.dtpFechaHasta.TabIndex = 11;
            this.dtpFechaHasta.Tag = "Fecha Hasta";
            this.dtpFechaHasta.ValueChanged += new System.EventHandler(this.dtpFechaHasta_ValueChanged);
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(86, 60);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(42, 13);
            this.lblNombreCliente.TabIndex = 14;
            this.lblNombreCliente.Text = "Cliente:";
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(743, 136);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(75, 38);
            this.btnLimpiarFiltros.TabIndex = 17;
            this.btnLimpiarFiltros.Text = "Limpiar Filtros";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // btnGrafico
            // 
            this.btnGrafico.Enabled = false;
            this.btnGrafico.Location = new System.Drawing.Point(743, 107);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(75, 23);
            this.btnGrafico.TabIndex = 18;
            this.btnGrafico.Text = "Grafico";
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // consultaInmuebleTableAdapter
            // 
            this.consultaInmuebleTableAdapter.ClearBeforeFill = true;
            // 
            // consultaxInmuebleEstadisticaBindingSource
            // 
            this.consultaxInmuebleEstadisticaBindingSource.DataMember = "ConsultaxInmuebleEstadistica";
            this.consultaxInmuebleEstadisticaBindingSource.DataSource = this.dataSet1ConsultaInmueble;
            // 
            // cboInmueble
            // 
            this.cboInmueble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInmueble.FormattingEnabled = true;
            this.cboInmueble.Location = new System.Drawing.Point(159, 24);
            this.cboInmueble.Name = "cboInmueble";
            this.cboInmueble.Size = new System.Drawing.Size(121, 21);
            this.cboInmueble.TabIndex = 19;
            this.cboInmueble.Tag = "inmueble";
            this.cboInmueble.SelectedIndexChanged += new System.EventHandler(this.cboInmueble_SelectedIndexChanged);
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(159, 57);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(121, 21);
            this.cboCliente.TabIndex = 20;
            this.cboCliente.Tag = "dniCliente";
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            // 
            // frmReporteConsultaInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 571);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.cboInmueble);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.btnLimpiarFiltros);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.cboEstadoConsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.rptvConsultaInmueble);
            this.Name = "frmReporteConsultaInmueble";
            this.Text = "Reporte Consulta Inmueble";
            this.Load += new System.EventHandler(this.frmReporteConsultaInmueble_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultaInmuebleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1ConsultaInmueble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaxInmuebleEstadisticaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvConsultaInmueble;
        private DataSet1ConsultaInmueble dataSet1ConsultaInmueble;
        private System.Windows.Forms.BindingSource consultaInmuebleBindingSource;
        private DataSet1ConsultaInmuebleTableAdapters.ConsultaInmuebleTableAdapter consultaInmuebleTableAdapter;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEstadoConsulta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.BindingSource consultaxInmuebleEstadisticaBindingSource;
        private System.Windows.Forms.ComboBox cboInmueble;
        private System.Windows.Forms.ComboBox cboCliente;
    }
}