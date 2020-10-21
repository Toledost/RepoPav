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
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tablaEmpleadoTableAdapter = new TESTWF2020.BDInmobiliariaCasaFelizDataSetEmpleadoTableAdapters.tablaEmpleadoTableAdapter();
            this.txtApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.lblApellidoEmpleado = new System.Windows.Forms.Label();
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
            reportDataSource1.Name = "DataSetEmpleados";
            reportDataSource1.Value = this.tablaEmpleadoBindingSource;
            this.rptvEmpleados.LocalReport.DataSources.Add(reportDataSource1);
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
            this.lblFechaDesde.Location = new System.Drawing.Point(360, 83);
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
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(426, 79);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDesde.TabIndex = 7;
            this.dtpFechaDesde.Value = new System.DateTime(2020, 10, 17, 18, 49, 17, 0);
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
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(124, 12);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEmpleado.TabIndex = 12;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(124, 68);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 13;
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(5, 16);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(94, 13);
            this.lblNombreEmpleado.TabIndex = 14;
            this.lblNombreEmpleado.Text = "Nombre Empleado";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(56, 68);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 15;
            this.lblUsuario.Text = "Usuario";
            // 
            // tablaEmpleadoTableAdapter
            // 
            this.tablaEmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // txtApellidoEmpleado
            // 
            this.txtApellidoEmpleado.Location = new System.Drawing.Point(124, 39);
            this.txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            this.txtApellidoEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoEmpleado.TabIndex = 16;
            // 
            // lblApellidoEmpleado
            // 
            this.lblApellidoEmpleado.AutoSize = true;
            this.lblApellidoEmpleado.Location = new System.Drawing.Point(5, 46);
            this.lblApellidoEmpleado.Name = "lblApellidoEmpleado";
            this.lblApellidoEmpleado.Size = new System.Drawing.Size(94, 13);
            this.lblApellidoEmpleado.TabIndex = 17;
            this.lblApellidoEmpleado.Text = "Apellido Empleado";
            // 
            // frmReporteEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblApellidoEmpleado);
            this.Controls.Add(this.txtApellidoEmpleado);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblNombreEmpleado);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.lblFechaAlta);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.rptvEmpleados);
            this.Name = "frmReporteEmpleado";
            this.Text = "frmReporteEmpleado";
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
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtApellidoEmpleado;
        private System.Windows.Forms.Label lblApellidoEmpleado;
    }
}