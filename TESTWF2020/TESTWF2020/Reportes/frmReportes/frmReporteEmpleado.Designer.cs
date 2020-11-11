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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSetEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdInmobiliariaCasaFelizDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            reportDataSource1.Name = "DataSetEmpleados";
            reportDataSource1.Value = this.tablaEmpleadoBindingSource;
            this.rptvEmpleados.LocalReport.DataSources.Add(reportDataSource1);
            this.rptvEmpleados.LocalReport.ReportEmbeddedResource = "TESTWF2020.Reportes.Reportes.rptEmpleados.rdlc";
            this.rptvEmpleados.Location = new System.Drawing.Point(13, 225);
            this.rptvEmpleados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rptvEmpleados.Name = "rptvEmpleados";
            this.rptvEmpleados.ServerReport.BearerToken = null;
            this.rptvEmpleados.Size = new System.Drawing.Size(1344, 520);
            this.rptvEmpleados.TabIndex = 1;
            // 
            // bdInmobiliariaCasaFelizDataSet1
            // 
            this.bdInmobiliariaCasaFelizDataSet1.DataSetName = "BDInmobiliariaCasaFelizDataSet";
            this.bdInmobiliariaCasaFelizDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::TESTWF2020.Properties.Resources.icons8_gráfico_combinado_48;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(1074, 19);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(263, 53);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Consultar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGrafico
            // 
            this.btnGrafico.Image = global::TESTWF2020.Properties.Resources.icons8_fácil_de_encontrar_40;
            this.btnGrafico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrafico.Location = new System.Drawing.Point(1074, 80);
            this.btnGrafico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(263, 56);
            this.btnGrafico.TabIndex = 3;
            this.btnGrafico.Text = "Gráfico";
            this.btnGrafico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(634, 54);
            this.lblFechaDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(75, 25);
            this.lblFechaDesde.TabIndex = 10;
            this.lblFechaDesde.Text = "Desde:";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(634, 143);
            this.lblFechaHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(69, 25);
            this.lblFechaHasta.TabIndex = 9;
            this.lblFechaHasta.Text = "Hasta:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(722, 138);
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
            this.dtpFechaDesde.Location = new System.Drawing.Point(722, 52);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(265, 30);
            this.dtpFechaDesde.TabIndex = 7;
            this.dtpFechaDesde.Value = new System.DateTime(2020, 10, 17, 18, 49, 17, 0);
            this.dtpFechaDesde.ValueChanged += new System.EventHandler(this.dtpFechaDesde_ValueChanged);
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Location = new System.Drawing.Point(527, 96);
            this.lblFechaAlta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(133, 25);
            this.lblFechaAlta.TabIndex = 11;
            this.lblFechaAlta.Text = "Fecha de Alta";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(143, 130);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(85, 25);
            this.lblUsuario.TabIndex = 15;
            this.lblUsuario.Text = "Usuario:";
            // 
            // tablaEmpleadoTableAdapter
            // 
            this.tablaEmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // cboUsuario
            // 
            this.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(236, 127);
            this.cboUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(212, 33);
            this.cboUsuario.TabIndex = 19;
            this.cboUsuario.Tag = "nombreUsuario";
            this.cboUsuario.SelectedIndexChanged += new System.EventHandler(this.cboUsuario_SelectedIndexChanged);
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(48, 57);
            this.lblNombreEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(180, 25);
            this.lblNombreEmpleado.TabIndex = 14;
            this.lblNombreEmpleado.Text = "Nombre Empleado:";
            // 
            // cboNombreEmpleado
            // 
            this.cboNombreEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNombreEmpleado.FormattingEnabled = true;
            this.cboNombreEmpleado.Location = new System.Drawing.Point(236, 54);
            this.cboNombreEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboNombreEmpleado.Name = "cboNombreEmpleado";
            this.cboNombreEmpleado.Size = new System.Drawing.Size(212, 33);
            this.cboNombreEmpleado.TabIndex = 18;
            this.cboNombreEmpleado.Tag = "legajoEmpleado";
            this.cboNombreEmpleado.SelectedIndexChanged += new System.EventHandler(this.cboNombreEmpleado_SelectedIndexChanged);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Image = global::TESTWF2020.Properties.Resources.icons8_borrar_48;
            this.btnLimpiarFiltros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(1074, 143);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(263, 55);
            this.btnLimpiarFiltros.TabIndex = 20;
            this.btnLimpiarFiltros.Text = "Limpiar Filtros";
            this.btnLimpiarFiltros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.btnLimpiarFiltros);
            this.groupBox1.Controls.Add(this.dtpFechaDesde);
            this.groupBox1.Controls.Add(this.cboUsuario);
            this.groupBox1.Controls.Add(this.btnGrafico);
            this.groupBox1.Controls.Add(this.cboNombreEmpleado);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.lblUsuario);
            this.groupBox1.Controls.Add(this.dtpFechaHasta);
            this.groupBox1.Controls.Add(this.lblNombreEmpleado);
            this.groupBox1.Controls.Add(this.lblFechaHasta);
            this.groupBox1.Controls.Add(this.lblFechaAlta);
            this.groupBox1.Controls.Add(this.lblFechaDesde);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1344, 206);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro Reporte Empleado";
            // 
            // frmReporteEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 758);
            this.Controls.Add(this.rptvEmpleados);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReporteEmpleado";
            this.Text = "Reporte Empleado";
            this.Load += new System.EventHandler(this.frmReporteEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSetEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdInmobiliariaCasaFelizDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
    }
}