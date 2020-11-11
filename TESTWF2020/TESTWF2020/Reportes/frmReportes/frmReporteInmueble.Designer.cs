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
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.inmuebleEstado1 = new TESTWF2020.InmuebleEstado();
            this.rptvInmueble = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblInmueble = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.relacionInmuebleEstadoTableAdapter1 = new TESTWF2020.InmuebleEstadoTableAdapters.RelacionInmuebleEstadoTableAdapter();
            this.cboInmueble = new System.Windows.Forms.ComboBox();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmuebleEstado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // rptvInmueble
            // 
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.bindingSource2;
            this.rptvInmueble.LocalReport.DataSources.Add(reportDataSource1);
            this.rptvInmueble.LocalReport.ReportEmbeddedResource = "TESTWF2020.Reportes.Reportes.rptInmueble.rdlc";
            this.rptvInmueble.Location = new System.Drawing.Point(12, 233);
            this.rptvInmueble.Name = "rptvInmueble";
            this.rptvInmueble.ServerReport.BearerToken = null;
            this.rptvInmueble.Size = new System.Drawing.Size(1346, 513);
            this.rptvInmueble.TabIndex = 0;
            // 
            // btnGrafico
            // 
            this.btnGrafico.Image = global::TESTWF2020.Properties.Resources.icons8_gráfico_combinado_48;
            this.btnGrafico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrafico.Location = new System.Drawing.Point(1078, 80);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(257, 52);
            this.btnGrafico.TabIndex = 1;
            this.btnGrafico.Text = "Gráfico";
            this.btnGrafico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::TESTWF2020.Properties.Resources.icons8_fácil_de_encontrar_40;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(1078, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(257, 49);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Consultar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(105, 142);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 30);
            this.dtpFechaDesde.TabIndex = 3;
            this.dtpFechaDesde.Value = new System.DateTime(2020, 10, 17, 18, 49, 17, 0);
            this.dtpFechaDesde.ValueChanged += new System.EventHandler(this.dtpFechaDesde_ValueChanged);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(436, 142);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 30);
            this.dtpFechaHasta.TabIndex = 4;
            this.dtpFechaHasta.Value = new System.DateTime(2020, 10, 17, 18, 48, 47, 0);
            this.dtpFechaHasta.ValueChanged += new System.EventHandler(this.dtpFechaHasta_ValueChanged);
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(361, 142);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(69, 25);
            this.lblFechaHasta.TabIndex = 5;
            this.lblFechaHasta.Text = "Hasta:";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(30, 142);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(75, 25);
            this.lblFechaDesde.TabIndex = 6;
            this.lblFechaDesde.Text = "Desde:";
            // 
            // lblInmueble
            // 
            this.lblInmueble.AutoSize = true;
            this.lblInmueble.Location = new System.Drawing.Point(30, 57);
            this.lblInmueble.Name = "lblInmueble";
            this.lblInmueble.Size = new System.Drawing.Size(98, 25);
            this.lblInmueble.TabIndex = 7;
            this.lblInmueble.Text = "Inmueble:";
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
            // cboInmueble
            // 
            this.cboInmueble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInmueble.FormattingEnabled = true;
            this.cboInmueble.Location = new System.Drawing.Point(134, 54);
            this.cboInmueble.Name = "cboInmueble";
            this.cboInmueble.Size = new System.Drawing.Size(280, 33);
            this.cboInmueble.TabIndex = 8;
            this.cboInmueble.Tag = "inmueble";
            this.cboInmueble.SelectedIndexChanged += new System.EventHandler(this.cboInmueble_SelectedIndexChanged);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Image = global::TESTWF2020.Properties.Resources.icons8_borrar_48;
            this.btnLimpiarFiltros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(1078, 147);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(257, 54);
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
            this.groupBox1.Controls.Add(this.cboInmueble);
            this.groupBox1.Controls.Add(this.lblInmueble);
            this.groupBox1.Controls.Add(this.lblFechaDesde);
            this.groupBox1.Controls.Add(this.lblFechaHasta);
            this.groupBox1.Controls.Add(this.dtpFechaHasta);
            this.groupBox1.Controls.Add(this.dtpFechaDesde);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnGrafico);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1341, 207);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro Reporte Inmuebles";
            // 
            // frmReporteInmueble
            // 
            this.ClientSize = new System.Drawing.Size(1370, 758);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rptvInmueble);
            this.Name = "frmReporteInmueble";
            this.Text = "Reporte Inmueble";
            this.Load += new System.EventHandler(this.frmReportes_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmuebleEstado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblInmueble;
        private System.Windows.Forms.ComboBox cboInmueble;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}