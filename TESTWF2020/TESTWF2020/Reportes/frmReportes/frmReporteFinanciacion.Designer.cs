namespace TESTWF2020.Reportes.frmReportes
{
    partial class frmReporteFinanciacion
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
            this.dataTableFinanciacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDInmobiliariaCasaFelizDataSetFinanciacion = new TESTWF2020.BDInmobiliariaCasaFelizDataSetFinanciacion();
            this.rptvFinanciacion = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataTableFinanciacionTableAdapter = new TESTWF2020.BDInmobiliariaCasaFelizDataSetFinanciacionTableAdapters.DataTableFinanciacionTableAdapter();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFinanciacion = new System.Windows.Forms.Label();
            this.cboNombreFinanciacion = new System.Windows.Forms.ComboBox();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableFinanciacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSetFinanciacion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTableFinanciacionBindingSource
            // 
            this.dataTableFinanciacionBindingSource.DataMember = "DataTableFinanciacion";
            this.dataTableFinanciacionBindingSource.DataSource = this.bDInmobiliariaCasaFelizDataSetFinanciacion;
            // 
            // bDInmobiliariaCasaFelizDataSetFinanciacion
            // 
            this.bDInmobiliariaCasaFelizDataSetFinanciacion.DataSetName = "BDInmobiliariaCasaFelizDataSetFinanciacion";
            this.bDInmobiliariaCasaFelizDataSetFinanciacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptvFinanciacion
            // 
            reportDataSource1.Name = "DataSetFinanciacion";
            reportDataSource1.Value = this.dataTableFinanciacionBindingSource;
            this.rptvFinanciacion.LocalReport.DataSources.Add(reportDataSource1);
            this.rptvFinanciacion.LocalReport.ReportEmbeddedResource = "TESTWF2020.Reportes.Reportes.rptFinanciacion.rdlc";
            this.rptvFinanciacion.Location = new System.Drawing.Point(12, 249);
            this.rptvFinanciacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rptvFinanciacion.Name = "rptvFinanciacion";
            this.rptvFinanciacion.ServerReport.BearerToken = null;
            this.rptvFinanciacion.Size = new System.Drawing.Size(1346, 498);
            this.rptvFinanciacion.TabIndex = 0;
            // 
            // dataTableFinanciacionTableAdapter
            // 
            this.dataTableFinanciacionTableAdapter.ClearBeforeFill = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::TESTWF2020.Properties.Resources.icons8_fácil_de_encontrar_40;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(1093, 19);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(245, 54);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Consultar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGrafico
            // 
            this.btnGrafico.Image = global::TESTWF2020.Properties.Resources.icons8_gráfico_combinado_48;
            this.btnGrafico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrafico.Location = new System.Drawing.Point(1093, 91);
            this.btnGrafico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(245, 54);
            this.btnGrafico.TabIndex = 19;
            this.btnGrafico.Text = "Gráfico";
            this.btnGrafico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Location = new System.Drawing.Point(28, 146);
            this.lblFechaVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(124, 25);
            this.lblFechaVenta.TabIndex = 18;
            this.lblFechaVenta.Text = "Fecha Venta";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(161, 174);
            this.lblFechaHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(69, 25);
            this.lblFechaHasta.TabIndex = 17;
            this.lblFechaHasta.Text = "Hasta:";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(155, 120);
            this.lblFechaDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(75, 25);
            this.lblFechaDesde.TabIndex = 16;
            this.lblFechaDesde.Text = "Desde:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(238, 174);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(197, 30);
            this.dtpFechaHasta.TabIndex = 15;
            this.dtpFechaHasta.ValueChanged += new System.EventHandler(this.dtpFechaHasta_ValueChanged);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(238, 115);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(197, 30);
            this.dtpFechaDesde.TabIndex = 14;
            this.dtpFechaDesde.ValueChanged += new System.EventHandler(this.dtpFechaDesde_ValueChanged);
            // 
            // lblFinanciacion
            // 
            this.lblFinanciacion.AutoSize = true;
            this.lblFinanciacion.Location = new System.Drawing.Point(28, 48);
            this.lblFinanciacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinanciacion.Name = "lblFinanciacion";
            this.lblFinanciacion.Size = new System.Drawing.Size(202, 25);
            this.lblFinanciacion.TabIndex = 22;
            this.lblFinanciacion.Text = "Nombre Financiación:";
            // 
            // cboNombreFinanciacion
            // 
            this.cboNombreFinanciacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNombreFinanciacion.FormattingEnabled = true;
            this.cboNombreFinanciacion.Location = new System.Drawing.Point(238, 45);
            this.cboNombreFinanciacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboNombreFinanciacion.Name = "cboNombreFinanciacion";
            this.cboNombreFinanciacion.Size = new System.Drawing.Size(328, 33);
            this.cboNombreFinanciacion.TabIndex = 23;
            this.cboNombreFinanciacion.Tag = "idFinanciacion";
            this.cboNombreFinanciacion.SelectedIndexChanged += new System.EventHandler(this.cboNombreFinanciacion_SelectedIndexChanged);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Image = global::TESTWF2020.Properties.Resources.icons8_borrar_48;
            this.btnLimpiarFiltros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(1093, 159);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(245, 54);
            this.btnLimpiarFiltros.TabIndex = 24;
            this.btnLimpiarFiltros.Text = "Limpiar Filtros";
            this.btnLimpiarFiltros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.btnLimpiarFiltros);
            this.groupBox1.Controls.Add(this.cboNombreFinanciacion);
            this.groupBox1.Controls.Add(this.lblFinanciacion);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnGrafico);
            this.groupBox1.Controls.Add(this.lblFechaVenta);
            this.groupBox1.Controls.Add(this.lblFechaHasta);
            this.groupBox1.Controls.Add(this.lblFechaDesde);
            this.groupBox1.Controls.Add(this.dtpFechaHasta);
            this.groupBox1.Controls.Add(this.dtpFechaDesde);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1345, 220);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro Reportes Financiacion";
            // 
            // frmReporteFinanciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 758);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rptvFinanciacion);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmReporteFinanciacion";
            this.Text = "Reporte Financiacion";
            this.Load += new System.EventHandler(this.frmReporteFinanciacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableFinanciacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSetFinanciacion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvFinanciacion;
        private BDInmobiliariaCasaFelizDataSetFinanciacion bDInmobiliariaCasaFelizDataSetFinanciacion;
        private System.Windows.Forms.BindingSource dataTableFinanciacionBindingSource;
        private BDInmobiliariaCasaFelizDataSetFinanciacionTableAdapters.DataTableFinanciacionTableAdapter dataTableFinanciacionTableAdapter;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.Label lblFechaVenta;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFinanciacion;
        private System.Windows.Forms.ComboBox cboNombreFinanciacion;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}