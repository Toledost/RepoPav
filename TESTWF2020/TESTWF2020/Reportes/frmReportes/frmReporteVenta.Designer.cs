namespace TESTWF2020.Reportes.frmReportes
{
    partial class frmReporteVenta
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
            this.rptvVenta = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtNombreComprador = new System.Windows.Forms.TextBox();
            this.txtApellidoComprador = new System.Windows.Forms.TextBox();
            this.txtNombreInmueble = new System.Windows.Forms.TextBox();
            this.lblIdInmueble = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.tablaVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDInmobiliariaCasaFelizDataSet = new TESTWF2020.BDInmobiliariaCasaFelizDataSet();
            this.tablaVentaTableAdapter = new TESTWF2020.BDInmobiliariaCasaFelizDataSetTableAdapters.tablaVentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // rptvVenta
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tablaVentaBindingSource;
            this.rptvVenta.LocalReport.DataSources.Add(reportDataSource1);
            this.rptvVenta.LocalReport.ReportEmbeddedResource = "TESTWF2020.Reportes.Reportes.rptVenta.rdlc";
            this.rptvVenta.Location = new System.Drawing.Point(0, 158);
            this.rptvVenta.Name = "rptvVenta";
            this.rptvVenta.ServerReport.BearerToken = null;
            this.rptvVenta.Size = new System.Drawing.Size(800, 292);
            this.rptvVenta.TabIndex = 0;
            // 
            // txtNombreComprador
            // 
            this.txtNombreComprador.Location = new System.Drawing.Point(156, 60);
            this.txtNombreComprador.Name = "txtNombreComprador";
            this.txtNombreComprador.Size = new System.Drawing.Size(100, 20);
            this.txtNombreComprador.TabIndex = 1;
            // 
            // txtApellidoComprador
            // 
            this.txtApellidoComprador.Location = new System.Drawing.Point(156, 103);
            this.txtApellidoComprador.Name = "txtApellidoComprador";
            this.txtApellidoComprador.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoComprador.TabIndex = 2;
            // 
            // txtNombreInmueble
            // 
            this.txtNombreInmueble.Location = new System.Drawing.Point(156, 21);
            this.txtNombreInmueble.Name = "txtNombreInmueble";
            this.txtNombreInmueble.Size = new System.Drawing.Size(100, 20);
            this.txtNombreInmueble.TabIndex = 3;
            // 
            // lblIdInmueble
            // 
            this.lblIdInmueble.AutoSize = true;
            this.lblIdInmueble.Location = new System.Drawing.Point(46, 28);
            this.lblIdInmueble.Name = "lblIdInmueble";
            this.lblIdInmueble.Size = new System.Drawing.Size(90, 13);
            this.lblIdInmueble.TabIndex = 4;
            this.lblIdInmueble.Text = "Nombre Inmueble";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(38, 100);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(98, 13);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Apellido Comprador";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(38, 66);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(98, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre Comprador";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(501, 59);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(117, 20);
            this.dtpFechaDesde.TabIndex = 7;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(501, 99);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(117, 20);
            this.dtpFechaHasta.TabIndex = 8;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(420, 102);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(35, 13);
            this.lblFechaHasta.TabIndex = 10;
            this.lblFechaHasta.Text = "Hasta";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(420, 66);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(38, 13);
            this.lblFechaDesde.TabIndex = 9;
            this.lblFechaDesde.Text = "Desde";
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Location = new System.Drawing.Point(344, 85);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(67, 13);
            this.lblFechaVenta.TabIndex = 11;
            this.lblFechaVenta.Text = "Fecha venta";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(713, 30);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGrafico
            // 
            this.btnGrafico.Location = new System.Drawing.Point(713, 59);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(75, 23);
            this.btnGrafico.TabIndex = 12;
            this.btnGrafico.Text = "Grafico";
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // tablaVentaBindingSource
            // 
            this.tablaVentaBindingSource.DataMember = "tablaVenta";
            this.tablaVentaBindingSource.DataSource = this.bDInmobiliariaCasaFelizDataSet;
            // 
            // bDInmobiliariaCasaFelizDataSet
            // 
            this.bDInmobiliariaCasaFelizDataSet.DataSetName = "BDInmobiliariaCasaFelizDataSet";
            this.bDInmobiliariaCasaFelizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablaVentaTableAdapter
            // 
            this.tablaVentaTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.lblFechaVenta);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblIdInmueble);
            this.Controls.Add(this.txtNombreInmueble);
            this.Controls.Add(this.txtApellidoComprador);
            this.Controls.Add(this.txtNombreComprador);
            this.Controls.Add(this.rptvVenta);
            this.Name = "frmReporteVenta";
            this.Text = "Reporte de venta";
            this.Load += new System.EventHandler(this.frmReporteVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDInmobiliariaCasaFelizDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvVenta;
        private BDInmobiliariaCasaFelizDataSet bDInmobiliariaCasaFelizDataSet;
        private System.Windows.Forms.BindingSource tablaVentaBindingSource;
        private BDInmobiliariaCasaFelizDataSetTableAdapters.tablaVentaTableAdapter tablaVentaTableAdapter;
        private System.Windows.Forms.TextBox txtNombreComprador;
        private System.Windows.Forms.TextBox txtApellidoComprador;
        private System.Windows.Forms.TextBox txtNombreInmueble;
        private System.Windows.Forms.Label lblIdInmueble;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaVenta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGrafico;
    }
}