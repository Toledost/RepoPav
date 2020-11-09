namespace TESTWF2020.Reportes.frmEstadisticas
{
    partial class frmEstadisticaMedioConocimiento
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
            this.rptvEstadisticaMedioConocimiento = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptvEstadisticaMedioConocimiento
            // 
            this.rptvEstadisticaMedioConocimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptvEstadisticaMedioConocimiento.LocalReport.ReportEmbeddedResource = "TESTWF2020.Reportes.Estadisticas.rptEstadisticaMedioConocimiento.rdlc";
            this.rptvEstadisticaMedioConocimiento.Location = new System.Drawing.Point(0, 0);
            this.rptvEstadisticaMedioConocimiento.Name = "rptvEstadisticaMedioConocimiento";
            this.rptvEstadisticaMedioConocimiento.ServerReport.BearerToken = null;
            this.rptvEstadisticaMedioConocimiento.Size = new System.Drawing.Size(800, 450);
            this.rptvEstadisticaMedioConocimiento.TabIndex = 0;
            this.rptvEstadisticaMedioConocimiento.Load += new System.EventHandler(this.rptvEstadisticaMedioConocimiento_Load);
            // 
            // frmEstadisticaMedioConocimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptvEstadisticaMedioConocimiento);
            this.Name = "frmEstadisticaMedioConocimiento";
            this.Text = "Estadistica Medio de Conocimiento";
            this.Load += new System.EventHandler(this.frmEstadisticaMedioConocimiento_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvEstadisticaMedioConocimiento;
    }
}