namespace TESTWF2020.Reportes.frmEstadisticas
{
    partial class frmEstadisticaConsultaInmueble
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
            this.rptvEstadisticaConsultaInmueble = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptvEstadisticaConsultaInmueble
            // 
            this.rptvEstadisticaConsultaInmueble.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptvEstadisticaConsultaInmueble.LocalReport.ReportEmbeddedResource = "TESTWF2020.Reportes.Estadisticas.rptEstadisticaConsultaInmueble.rdlc";
            this.rptvEstadisticaConsultaInmueble.Location = new System.Drawing.Point(0, 0);
            this.rptvEstadisticaConsultaInmueble.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rptvEstadisticaConsultaInmueble.Name = "rptvEstadisticaConsultaInmueble";
            this.rptvEstadisticaConsultaInmueble.ServerReport.BearerToken = null;
            this.rptvEstadisticaConsultaInmueble.Size = new System.Drawing.Size(1370, 758);
            this.rptvEstadisticaConsultaInmueble.TabIndex = 0;
            this.rptvEstadisticaConsultaInmueble.Load += new System.EventHandler(this.rptvEstadisticaConsultaInmueble_Load);
            // 
            // frmEstadisticaConsultaInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 758);
            this.Controls.Add(this.rptvEstadisticaConsultaInmueble);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEstadisticaConsultaInmueble";
            this.Text = "Estadísticas de Consultas";
            this.Load += new System.EventHandler(this.frmEstadisticaConsultaInmueble_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvEstadisticaConsultaInmueble;
    }
}