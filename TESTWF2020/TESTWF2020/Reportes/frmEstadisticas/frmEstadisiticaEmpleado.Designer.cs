namespace TESTWF2020.Reportes.frmEstadisticas
{
    partial class frmEstadisiticaEmpleado
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
            this.rptvEmpleado = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptvEmpleado
            // 
            this.rptvEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptvEmpleado.LocalReport.ReportEmbeddedResource = "TESTWF2020.Reportes.Estadisticas.rptEstadisticasEmpleado.rdlc";
            this.rptvEmpleado.Location = new System.Drawing.Point(0, 0);
            this.rptvEmpleado.Name = "rptvEmpleado";
            this.rptvEmpleado.ServerReport.BearerToken = null;
            this.rptvEmpleado.Size = new System.Drawing.Size(800, 450);
            this.rptvEmpleado.TabIndex = 0;
            this.rptvEmpleado.Load += new System.EventHandler(this.rptvEmpleado_Load);
            // 
            // frmEstadisiticaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptvEmpleado);
            this.Name = "frmEstadisiticaEmpleado";
            this.Text = "frmEstadisiticaEmpleado";
            this.Load += new System.EventHandler(this.frmEstadisiticaEmpleado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvEmpleado;
    }
}