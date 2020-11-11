namespace TESTWF2020.Reportes.frmReportes
{
    partial class frmReporteVendedor
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
            this.dataTableVendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDInmobiliariaCasaFelizDataSetVendedor = new TESTWF2020.BDInmobiliariaCasaFelizDataSetVendedor();
            this.rptvVendedor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bDInmobiliariaCasaFelizDataSetVendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableVendedorTableAdapter = new TESTWF2020.BDInmobiliariaCasaFelizDataSetVendedorTableAdapters.DataTableVendedorTableAdapter();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.lblTituloFechas = new System.Windows.Forms.Label();
            this.cboInmueble = new System.Windows.Forms.ComboBox();
            this.lblInmueble = new System.Windows.Forms.Label();
            this.cboNombreEmpleado = new System.Windows.Forms.ComboBox();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableVendedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSetVendedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSetVendedorBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTableVendedorBindingSource
            // 
            this.dataTableVendedorBindingSource.DataMember = "DataTableVendedor";
            this.dataTableVendedorBindingSource.DataSource = this.bDInmobiliariaCasaFelizDataSetVendedor;
            // 
            // bDInmobiliariaCasaFelizDataSetVendedor
            // 
            this.bDInmobiliariaCasaFelizDataSetVendedor.DataSetName = "BDInmobiliariaCasaFelizDataSetVendedor";
            this.bDInmobiliariaCasaFelizDataSetVendedor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptvVendedor
            // 
            reportDataSource1.Name = "DataSetVendedor";
            reportDataSource1.Value = this.dataTableVendedorBindingSource;
            this.rptvVendedor.LocalReport.DataSources.Add(reportDataSource1);
            this.rptvVendedor.LocalReport.ReportEmbeddedResource = "TESTWF2020.Reportes.Reportes.rptVendedor.rdlc";
            this.rptvVendedor.Location = new System.Drawing.Point(11, 238);
            this.rptvVendedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rptvVendedor.Name = "rptvVendedor";
            this.rptvVendedor.ServerReport.BearerToken = null;
            this.rptvVendedor.Size = new System.Drawing.Size(1347, 509);
            this.rptvVendedor.TabIndex = 0;
            // 
            // bDInmobiliariaCasaFelizDataSetVendedorBindingSource
            // 
            this.bDInmobiliariaCasaFelizDataSetVendedorBindingSource.DataSource = this.bDInmobiliariaCasaFelizDataSetVendedor;
            this.bDInmobiliariaCasaFelizDataSetVendedorBindingSource.Position = 0;
            // 
            // dataTableVendedorTableAdapter
            // 
            this.dataTableVendedorTableAdapter.ClearBeforeFill = true;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(317, 120);
            this.lblFechaDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(75, 25);
            this.lblFechaDesde.TabIndex = 16;
            this.lblFechaDesde.Text = "Desde:";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(317, 161);
            this.lblFechaHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(69, 25);
            this.lblFechaHasta.TabIndex = 15;
            this.lblFechaHasta.Text = "Hasta:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(400, 158);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(265, 30);
            this.dtpFechaHasta.TabIndex = 14;
            this.dtpFechaHasta.Value = new System.DateTime(2020, 10, 17, 18, 48, 47, 0);
            this.dtpFechaHasta.ValueChanged += new System.EventHandler(this.dtpFechaHasta_ValueChanged);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(400, 120);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(265, 30);
            this.dtpFechaDesde.TabIndex = 13;
            this.dtpFechaDesde.Value = new System.DateTime(2020, 10, 17, 18, 49, 17, 0);
            this.dtpFechaDesde.ValueChanged += new System.EventHandler(this.dtpFechaDesde_ValueChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::TESTWF2020.Properties.Resources.icons8_fácil_de_encontrar_40;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(1060, 21);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(278, 54);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Consultar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGrafico
            // 
            this.btnGrafico.Image = global::TESTWF2020.Properties.Resources.icons8_gráfico_combinado_48;
            this.btnGrafico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrafico.Location = new System.Drawing.Point(1060, 89);
            this.btnGrafico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(278, 55);
            this.btnGrafico.TabIndex = 11;
            this.btnGrafico.Text = "Grafico";
            this.btnGrafico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // lblTituloFechas
            // 
            this.lblTituloFechas.AutoSize = true;
            this.lblTituloFechas.Location = new System.Drawing.Point(36, 139);
            this.lblTituloFechas.Name = "lblTituloFechas";
            this.lblTituloFechas.Size = new System.Drawing.Size(263, 25);
            this.lblTituloFechas.TabIndex = 17;
            this.lblTituloFechas.Text = "Fecha de Venta de Inmueble";
            // 
            // cboInmueble
            // 
            this.cboInmueble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInmueble.FormattingEnabled = true;
            this.cboInmueble.Location = new System.Drawing.Point(705, 47);
            this.cboInmueble.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboInmueble.Name = "cboInmueble";
            this.cboInmueble.Size = new System.Drawing.Size(292, 33);
            this.cboInmueble.TabIndex = 19;
            this.cboInmueble.Tag = "inmueble";
            this.cboInmueble.SelectedIndexChanged += new System.EventHandler(this.cboInmueble_SelectedIndexChanged);
            // 
            // lblInmueble
            // 
            this.lblInmueble.AutoSize = true;
            this.lblInmueble.Location = new System.Drawing.Point(599, 50);
            this.lblInmueble.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInmueble.Name = "lblInmueble";
            this.lblInmueble.Size = new System.Drawing.Size(98, 25);
            this.lblInmueble.TabIndex = 18;
            this.lblInmueble.Text = "Inmueble:";
            // 
            // cboNombreEmpleado
            // 
            this.cboNombreEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNombreEmpleado.FormattingEnabled = true;
            this.cboNombreEmpleado.Location = new System.Drawing.Point(253, 47);
            this.cboNombreEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboNombreEmpleado.Name = "cboNombreEmpleado";
            this.cboNombreEmpleado.Size = new System.Drawing.Size(292, 33);
            this.cboNombreEmpleado.TabIndex = 21;
            this.cboNombreEmpleado.Tag = "legajoEmpleado";
            this.cboNombreEmpleado.SelectedIndexChanged += new System.EventHandler(this.cboNombreEmpleado_SelectedIndexChanged);
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(36, 50);
            this.lblNombreEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(180, 25);
            this.lblNombreEmpleado.TabIndex = 20;
            this.lblNombreEmpleado.Text = "Nombre Empleado:";
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Image = global::TESTWF2020.Properties.Resources.icons8_borrar_48;
            this.btnLimpiarFiltros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(1060, 158);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(278, 60);
            this.btnLimpiarFiltros.TabIndex = 22;
            this.btnLimpiarFiltros.Text = "Limpiar Filtros";
            this.btnLimpiarFiltros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.btnLimpiarFiltros);
            this.groupBox1.Controls.Add(this.cboNombreEmpleado);
            this.groupBox1.Controls.Add(this.lblNombreEmpleado);
            this.groupBox1.Controls.Add(this.cboInmueble);
            this.groupBox1.Controls.Add(this.lblInmueble);
            this.groupBox1.Controls.Add(this.lblTituloFechas);
            this.groupBox1.Controls.Add(this.lblFechaDesde);
            this.groupBox1.Controls.Add(this.lblFechaHasta);
            this.groupBox1.Controls.Add(this.dtpFechaHasta);
            this.groupBox1.Controls.Add(this.dtpFechaDesde);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnGrafico);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1345, 225);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro Reporte Vendedores";
            // 
            // frmReporteVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 758);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rptvVendedor);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmReporteVendedor";
            this.Text = "Reporte Vendedor";
            this.Load += new System.EventHandler(this.frmReporteVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableVendedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSetVendedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSetVendedorBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvVendedor;
        private System.Windows.Forms.BindingSource bDInmobiliariaCasaFelizDataSetVendedorBindingSource;
        private BDInmobiliariaCasaFelizDataSetVendedor bDInmobiliariaCasaFelizDataSetVendedor;
        private System.Windows.Forms.BindingSource dataTableVendedorBindingSource;
        private BDInmobiliariaCasaFelizDataSetVendedorTableAdapters.DataTableVendedorTableAdapter dataTableVendedorTableAdapter;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.Label lblTituloFechas;
        private System.Windows.Forms.ComboBox cboInmueble;
        private System.Windows.Forms.Label lblInmueble;
        private System.Windows.Forms.ComboBox cboNombreEmpleado;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}