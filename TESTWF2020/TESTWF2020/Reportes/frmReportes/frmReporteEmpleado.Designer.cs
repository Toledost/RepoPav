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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tablaEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDInmobiliariaCasaFelizDataSetEmpleado = new TESTWF2020.BDInmobiliariaCasaFelizDataSetEmpleado();
            this.rptvEmpleados = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bdInmobiliariaCasaFelizDataSet1 = new TESTWF2020.BDInmobiliariaCasaFelizDataSet();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tablaEmpleadoTableAdapter = new TESTWF2020.BDInmobiliariaCasaFelizDataSetEmpleadoTableAdapters.tablaEmpleadoTableAdapter();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.cboNombreEmpleado = new System.Windows.Forms.ComboBox();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSetEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdInmobiliariaCasaFelizDataSet1)).BeginInit();
            this.SuspendLayout();
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
            // rptvEmpleados
            // 
            reportDataSource9.Name = "DataSetEmpleados";
            reportDataSource9.Value = this.tablaEmpleadoBindingSource;
            this.rptvEmpleados.LocalReport.DataSources.Add(reportDataSource9);
            this.rptvEmpleados.LocalReport.ReportEmbeddedResource = "TESTWF2020.Reportes.Reportes.rptEmpleados.rdlc";
            this.rptvEmpleados.Location = new System.Drawing.Point(0, 159);
            this.rptvEmpleados.Name = "rptvEmpleados";
            this.rptvEmpleados.ServerReport.BearerToken = null;
            this.rptvEmpleados.Size = new System.Drawing.Size(788, 279);
            this.rptvEmpleados.TabIndex = 1;
            // 
            // bdInmobiliariaCasaFelizDataSet1
            // 
            this.bdInmobiliariaCasaFelizDataSet1.DataSetName = "BDInmobiliariaCasaFelizDataSet";
            this.bdInmobiliariaCasaFelizDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(677, 36);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGrafico
            // 
            this.btnGrafico.Location = new System.Drawing.Point(677, 65);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(75, 23);
            this.btnGrafico.TabIndex = 3;
            this.btnGrafico.Text = "Grafico";
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(366, 85);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(38, 13);
            this.lblFechaDesde.TabIndex = 10;
            this.lblFechaDesde.Text = "Desde";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(369, 111);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(35, 13);
            this.lblFechaHasta.TabIndex = 9;
            this.lblFechaHasta.Text = "Hasta";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(426, 105);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaHasta.TabIndex = 8;
            this.dtpFechaHasta.Value = new System.DateTime(2020, 10, 17, 18, 48, 47, 0);
            this.dtpFechaHasta.ValueChanged += new System.EventHandler(this.dtpFechaHasta_ValueChanged);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(426, 79);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDesde.TabIndex = 7;
            this.dtpFechaDesde.Value = new System.DateTime(2020, 10, 17, 18, 49, 17, 0);
            this.dtpFechaDesde.ValueChanged += new System.EventHandler(this.dtpFechaDesde_ValueChanged);
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Location = new System.Drawing.Point(308, 105);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(55, 13);
            this.lblFechaAlta.TabIndex = 11;
            this.lblFechaAlta.Text = "FechaAlta";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(76, 68);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 15;
            this.lblUsuario.Text = "Usuario";
            // 
            // tablaEmpleadoTableAdapter
            // 
            this.tablaEmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // cboUsuario
            // 
            this.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(125, 65);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(121, 21);
            this.cboUsuario.TabIndex = 19;
            this.cboUsuario.Tag = "nombreUsuario";
            this.cboUsuario.SelectedIndexChanged += new System.EventHandler(this.cboUsuario_SelectedIndexChanged);
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(25, 29);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(93, 13);
            this.lblNombreEmpleado.TabIndex = 14;
            this.lblNombreEmpleado.Text = "Nombre empleado";
            // 
            // cboNombreEmpleado
            // 
            this.cboNombreEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNombreEmpleado.FormattingEnabled = true;
            this.cboNombreEmpleado.Location = new System.Drawing.Point(125, 26);
            this.cboNombreEmpleado.Name = "cboNombreEmpleado";
            this.cboNombreEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cboNombreEmpleado.TabIndex = 18;
            this.cboNombreEmpleado.Tag = "legajoEmpleado";
            this.cboNombreEmpleado.SelectedIndexChanged += new System.EventHandler(this.cboNombreEmpleado_SelectedIndexChanged);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(677, 98);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(75, 38);
            this.btnLimpiarFiltros.TabIndex = 20;
            this.btnLimpiarFiltros.Text = "Limpiar Filtros";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // frmReporteEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiarFiltros);
            this.Controls.Add(this.cboUsuario);
            this.Controls.Add(this.cboNombreEmpleado);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblNombreEmpleado);
            this.Controls.Add(this.lblFechaAlta);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.rptvEmpleados);
            this.Name = "frmReporteEmpleado";
            this.Text = "Reporte Empleado";
            this.Load += new System.EventHandler(this.frmReporteEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSetEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdInmobiliariaCasaFelizDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvEmpleados;
        private BDInmobiliariaCasaFelizDataSetEmpleado bDInmobiliariaCasaFelizDataSetEmpleado;
        private System.Windows.Forms.BindingSource tablaEmpleadoBindingSource;
        private BDInmobiliariaCasaFelizDataSetEmpleadoTableAdapters.tablaEmpleadoTableAdapter tablaEmpleadoTableAdapter;
        private BDInmobiliariaCasaFelizDataSet bdInmobiliariaCasaFelizDataSet1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cboUsuario;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.ComboBox cboNombreEmpleado;
        private System.Windows.Forms.Button btnLimpiarFiltros;
    }
}