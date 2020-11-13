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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.consultaInmuebleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1ConsultaInmueble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaxInmuebleEstadisticaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            reportDataSource2.Name = "DataSetConsultaInmueble";
            reportDataSource2.Value = this.consultaInmuebleBindingSource;
            this.rptvConsultaInmueble.LocalReport.DataSources.Add(reportDataSource2);
            this.rptvConsultaInmueble.LocalReport.ReportEmbeddedResource = "TESTWF2020.Reportes.Reportes.rptConsultaInmueble.rdlc";
            this.rptvConsultaInmueble.Location = new System.Drawing.Point(16, 263);
            this.rptvConsultaInmueble.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rptvConsultaInmueble.Name = "rptvConsultaInmueble";
            this.rptvConsultaInmueble.ServerReport.BearerToken = null;
            this.rptvConsultaInmueble.Size = new System.Drawing.Size(1341, 482);
            this.rptvConsultaInmueble.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::TESTWF2020.Properties.Resources.icons8_fácil_de_encontrar_40;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(1102, 30);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(219, 53);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Consultar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(87, 62);
            this.lblCalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(98, 25);
            this.lblCalle.TabIndex = 2;
            this.lblCalle.Text = "Inmueble:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Estado Consulta:";
            // 
            // cboEstadoConsulta
            // 
            this.cboEstadoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoConsulta.FormattingEnabled = true;
            this.cboEstadoConsulta.Location = new System.Drawing.Point(193, 167);
            this.cboEstadoConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboEstadoConsulta.Name = "cboEstadoConsulta";
            this.cboEstadoConsulta.Size = new System.Drawing.Size(229, 33);
            this.cboEstadoConsulta.TabIndex = 6;
            this.cboEstadoConsulta.Tag = "estadoConsulta";
            this.cboEstadoConsulta.SelectedIndexChanged += new System.EventHandler(this.cboEstadoConsulta_SelectedIndexChanged);
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(503, 62);
            this.lblFechaDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(135, 25);
            this.lblFechaDesde.TabIndex = 8;
            this.lblFechaDesde.Text = "Fecha Desde:";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(503, 115);
            this.lblFechaHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(129, 25);
            this.lblFechaHasta.TabIndex = 9;
            this.lblFechaHasta.Text = "Fecha Hasta:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(646, 57);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(218, 30);
            this.dtpFechaDesde.TabIndex = 10;
            this.dtpFechaDesde.Tag = "Fecha Desde";
            this.dtpFechaDesde.ValueChanged += new System.EventHandler(this.dtpFechaDesde_ValueChanged);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(646, 115);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(218, 30);
            this.dtpFechaHasta.TabIndex = 11;
            this.dtpFechaHasta.Tag = "Fecha Hasta";
            this.dtpFechaHasta.ValueChanged += new System.EventHandler(this.dtpFechaHasta_ValueChanged);
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(106, 115);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(79, 25);
            this.lblNombreCliente.TabIndex = 14;
            this.lblNombreCliente.Text = "Cliente:";
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Image = global::TESTWF2020.Properties.Resources.icons8_borrar_48;
            this.btnLimpiarFiltros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(1102, 155);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(219, 55);
            this.btnLimpiarFiltros.TabIndex = 17;
            this.btnLimpiarFiltros.Text = "Limpiar Filtros";
            this.btnLimpiarFiltros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // btnGrafico
            // 
            this.btnGrafico.Enabled = false;
            this.btnGrafico.Image = global::TESTWF2020.Properties.Resources.icons8_gráfico_combinado_48;
            this.btnGrafico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrafico.Location = new System.Drawing.Point(1102, 93);
            this.btnGrafico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(219, 52);
            this.btnGrafico.TabIndex = 18;
            this.btnGrafico.Text = "Gráfico";
            this.btnGrafico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.cboInmueble.Location = new System.Drawing.Point(193, 59);
            this.cboInmueble.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboInmueble.Name = "cboInmueble";
            this.cboInmueble.Size = new System.Drawing.Size(229, 33);
            this.cboInmueble.TabIndex = 19;
            this.cboInmueble.Tag = "inmueble";
            this.cboInmueble.SelectedIndexChanged += new System.EventHandler(this.cboInmueble_SelectedIndexChanged);
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(193, 112);
            this.cboCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(229, 33);
            this.cboCliente.TabIndex = 20;
            this.cboCliente.Tag = "dniCliente";
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.btnGrafico);
            this.groupBox1.Controls.Add(this.cboInmueble);
            this.groupBox1.Controls.Add(this.btnLimpiarFiltros);
            this.groupBox1.Controls.Add(this.cboCliente);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.dtpFechaHasta);
            this.groupBox1.Controls.Add(this.lblNombreCliente);
            this.groupBox1.Controls.Add(this.dtpFechaDesde);
            this.groupBox1.Controls.Add(this.lblCalle);
            this.groupBox1.Controls.Add(this.lblFechaHasta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblFechaDesde);
            this.groupBox1.Controls.Add(this.cboEstadoConsulta);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1341, 232);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro Reporte Consulta Inmueble";
            // 
            // frmReporteConsultaInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 758);
            this.Controls.Add(this.rptvConsultaInmueble);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReporteConsultaInmueble";
            this.Text = "Reporte Consulta Inmueble";
            this.Load += new System.EventHandler(this.frmReporteConsultaInmueble_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultaInmuebleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1ConsultaInmueble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaxInmuebleEstadisticaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
    }
}