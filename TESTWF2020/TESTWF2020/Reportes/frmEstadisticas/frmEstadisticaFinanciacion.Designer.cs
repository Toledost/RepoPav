namespace TESTWF2020.Reportes.frmEstadisticas
{
    partial class frmEstadisticaFinanciacion
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
            this.rptvEstadisticaFinanciacion = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptvEstadisticaFinanciacion
            // 
            this.rptvEstadisticaFinanciacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptvEstadisticaFinanciacion.LocalReport.ReportEmbeddedResource = "TESTWF2020.Reportes.Estadisticas.rptEstadisticaFinanaciacion.rdlc";
            this.rptvEstadisticaFinanciacion.Location = new System.Drawing.Point(0, 0);
            this.rptvEstadisticaFinanciacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rptvEstadisticaFinanciacion.Name = "rptvEstadisticaFinanciacion";
            this.rptvEstadisticaFinanciacion.ServerReport.BearerToken = null;
            this.rptvEstadisticaFinanciacion.Size = new System.Drawing.Size(600, 366);
            this.rptvEstadisticaFinanciacion.TabIndex = 0;
            this.rptvEstadisticaFinanciacion.Load += new System.EventHandler(this.rptvEstadisticaFinanciacion_Load);
            // 
            // frmEstadisticaFinanciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.rptvEstadisticaFinanciacion);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmEstadisticaFinanciacion";
            this.Text = "Estadistica Financiacion";
            this.Load += new System.EventHandler(this.frmEstadisticaFinanciacion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvEstadisticaFinanciacion;
    }
}