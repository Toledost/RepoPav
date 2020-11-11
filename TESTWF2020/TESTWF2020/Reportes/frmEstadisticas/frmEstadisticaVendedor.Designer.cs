namespace TESTWF2020.Reportes.frmEstadisticas
{
    partial class frmEstadisticaVendedor
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
            this.rptvEstadisticaVendedor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptvEstadisticaVendedor
            // 
            this.rptvEstadisticaVendedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptvEstadisticaVendedor.LocalReport.ReportEmbeddedResource = "TESTWF2020.Reportes.Estadisticas.rptEstadisticaVendedor.rdlc";
            this.rptvEstadisticaVendedor.Location = new System.Drawing.Point(0, 0);
            this.rptvEstadisticaVendedor.Name = "rptvEstadisticaVendedor";
            this.rptvEstadisticaVendedor.ServerReport.BearerToken = null;
            this.rptvEstadisticaVendedor.Size = new System.Drawing.Size(1370, 758);
            this.rptvEstadisticaVendedor.TabIndex = 0;
            this.rptvEstadisticaVendedor.Load += new System.EventHandler(this.rptvEstadisticaVendedor_Load);
            // 
            // frmEstadisticaVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 758);
            this.Controls.Add(this.rptvEstadisticaVendedor);
            this.Name = "frmEstadisticaVendedor";
            this.Text = "Estadistica Vendedor";
            this.Load += new System.EventHandler(this.frmEstadisticaVendedor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvEstadisticaVendedor;
    }
}