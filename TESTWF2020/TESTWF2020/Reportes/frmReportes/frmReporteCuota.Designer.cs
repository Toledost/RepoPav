namespace TESTWF2020.Reportes.frmReportes
{
    partial class frmReporteCuota
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
            this.tablaCuotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDInmobiliariaCasaFelizDataSetCuotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDInmobiliariaCasaFelizDataSetCuota = new TESTWF2020.BDInmobiliariaCasaFelizDataSetCuota();
            this.rptvCuotas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bdInmobiliariaCasaFelizDataSet1 = new TESTWF2020.BDInmobiliariaCasaFelizDataSet();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblNombreComprador = new System.Windows.Forms.Label();
            this.lblCalleInmueble = new System.Windows.Forms.Label();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.tablaCuotaTableAdapter = new TESTWF2020.BDInmobiliariaCasaFelizDataSetCuotaTableAdapters.TablaCuotaTableAdapter();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.cboInmueble = new System.Windows.Forms.ComboBox();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCuotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSetCuotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSetCuota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdInmobiliariaCasaFelizDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablaCuotaBindingSource
            // 
            this.tablaCuotaBindingSource.DataMember = "TablaCuota";
            this.tablaCuotaBindingSource.DataSource = this.bDInmobiliariaCasaFelizDataSetCuotaBindingSource;
            // 
            // bDInmobiliariaCasaFelizDataSetCuotaBindingSource
            // 
            this.bDInmobiliariaCasaFelizDataSetCuotaBindingSource.DataSource = this.bDInmobiliariaCasaFelizDataSetCuota;
            this.bDInmobiliariaCasaFelizDataSetCuotaBindingSource.Position = 0;
            // 
            // bDInmobiliariaCasaFelizDataSetCuota
            // 
            this.bDInmobiliariaCasaFelizDataSetCuota.DataSetName = "BDInmobiliariaCasaFelizDataSetCuota";
            this.bDInmobiliariaCasaFelizDataSetCuota.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptvCuotas
            // 
            reportDataSource1.Name = "DataSetCuota";
            reportDataSource1.Value = this.tablaCuotaBindingSource;
            this.rptvCuotas.LocalReport.DataSources.Add(reportDataSource1);
            this.rptvCuotas.LocalReport.ReportEmbeddedResource = "TESTWF2020.Reportes.Reportes.rptCuotas.rdlc";
            this.rptvCuotas.Location = new System.Drawing.Point(12, 249);
            this.rptvCuotas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rptvCuotas.Name = "rptvCuotas";
            this.rptvCuotas.ServerReport.BearerToken = null;
            this.rptvCuotas.Size = new System.Drawing.Size(1345, 496);
            this.rptvCuotas.TabIndex = 0;
            // 
            // bdInmobiliariaCasaFelizDataSet1
            // 
            this.bdInmobiliariaCasaFelizDataSet1.DataSetName = "BDInmobiliariaCasaFelizDataSet";
            this.bdInmobiliariaCasaFelizDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::TESTWF2020.Properties.Resources.icons8_fácil_de_encontrar_40;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(1067, 30);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(261, 53);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Consultar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGrafico
            // 
            this.btnGrafico.Image = global::TESTWF2020.Properties.Resources.icons8_gráfico_combinado_48;
            this.btnGrafico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrafico.Location = new System.Drawing.Point(1067, 95);
            this.btnGrafico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(261, 53);
            this.btnGrafico.TabIndex = 3;
            this.btnGrafico.Text = "Gráfico";
            this.btnGrafico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(231, 124);
            this.lblFechaDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(75, 25);
            this.lblFechaDesde.TabIndex = 10;
            this.lblFechaDesde.Text = "Desde:";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(237, 186);
            this.lblFechaHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(69, 25);
            this.lblFechaHasta.TabIndex = 9;
            this.lblFechaHasta.Text = "Hasta:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(314, 181);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(265, 30);
            this.dtpFechaHasta.TabIndex = 8;
            this.dtpFechaHasta.Value = new System.DateTime(2020, 10, 17, 18, 48, 47, 0);
            this.dtpFechaHasta.ValueChanged += new System.EventHandler(this.dtpFechaHasta_ValueChanged);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(314, 119);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(265, 30);
            this.dtpFechaDesde.TabIndex = 7;
            this.dtpFechaDesde.Value = new System.DateTime(2020, 10, 17, 18, 49, 17, 0);
            this.dtpFechaDesde.ValueChanged += new System.EventHandler(this.dtpFechaDesde_ValueChanged);
            // 
            // lblNombreComprador
            // 
            this.lblNombreComprador.AutoSize = true;
            this.lblNombreComprador.Location = new System.Drawing.Point(143, 63);
            this.lblNombreComprador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreComprador.Name = "lblNombreComprador";
            this.lblNombreComprador.Size = new System.Drawing.Size(79, 25);
            this.lblNombreComprador.TabIndex = 11;
            this.lblNombreComprador.Text = "Cliente:";
            // 
            // lblCalleInmueble
            // 
            this.lblCalleInmueble.AutoSize = true;
            this.lblCalleInmueble.Location = new System.Drawing.Point(559, 63);
            this.lblCalleInmueble.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalleInmueble.Name = "lblCalleInmueble";
            this.lblCalleInmueble.Size = new System.Drawing.Size(98, 25);
            this.lblCalleInmueble.TabIndex = 15;
            this.lblCalleInmueble.Text = "Inmueble:";
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(42, 156);
            this.lblFechaVencimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(180, 25);
            this.lblFechaVencimiento.TabIndex = 17;
            this.lblFechaVencimiento.Text = "Fecha Vencimiento";
            // 
            // tablaCuotaTableAdapter
            // 
            this.tablaCuotaTableAdapter.ClearBeforeFill = true;
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(242, 60);
            this.cboCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(270, 33);
            this.cboCliente.TabIndex = 18;
            this.cboCliente.Tag = "nombreComprador";
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            // 
            // cboInmueble
            // 
            this.cboInmueble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInmueble.FormattingEnabled = true;
            this.cboInmueble.Location = new System.Drawing.Point(677, 60);
            this.cboInmueble.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboInmueble.Name = "cboInmueble";
            this.cboInmueble.Size = new System.Drawing.Size(270, 33);
            this.cboInmueble.TabIndex = 20;
            this.cboInmueble.Tag = "nombreInmueble";
            this.cboInmueble.SelectedIndexChanged += new System.EventHandler(this.cboInmueble_SelectedIndexChanged);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Image = global::TESTWF2020.Properties.Resources.icons8_borrar_48;
            this.btnLimpiarFiltros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(1067, 156);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(261, 55);
            this.btnLimpiarFiltros.TabIndex = 21;
            this.btnLimpiarFiltros.Text = "Limpiar Campos";
            this.btnLimpiarFiltros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.btnLimpiarFiltros);
            this.groupBox1.Controls.Add(this.cboInmueble);
            this.groupBox1.Controls.Add(this.cboCliente);
            this.groupBox1.Controls.Add(this.lblFechaVencimiento);
            this.groupBox1.Controls.Add(this.lblCalleInmueble);
            this.groupBox1.Controls.Add(this.lblNombreComprador);
            this.groupBox1.Controls.Add(this.lblFechaDesde);
            this.groupBox1.Controls.Add(this.lblFechaHasta);
            this.groupBox1.Controls.Add(this.dtpFechaHasta);
            this.groupBox1.Controls.Add(this.dtpFechaDesde);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnGrafico);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1344, 227);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros Reporte Cuotas";
            // 
            // frmReporteCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 758);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rptvCuotas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReporteCuota";
            this.Text = "Reporte Cuota";
            this.Load += new System.EventHandler(this.frmReporteCuota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCuotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSetCuotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSetCuota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdInmobiliariaCasaFelizDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvCuotas;
        private BDInmobiliariaCasaFelizDataSetCuota bDInmobiliariaCasaFelizDataSetCuota;
        private System.Windows.Forms.BindingSource bDInmobiliariaCasaFelizDataSetCuotaBindingSource;
        private System.Windows.Forms.BindingSource tablaCuotaBindingSource;
        private BDInmobiliariaCasaFelizDataSetCuotaTableAdapters.TablaCuotaTableAdapter tablaCuotaTableAdapter;
        private BDInmobiliariaCasaFelizDataSet bdInmobiliariaCasaFelizDataSet1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblNombreComprador;
        private System.Windows.Forms.Label lblCalleInmueble;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.ComboBox cboInmueble;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}