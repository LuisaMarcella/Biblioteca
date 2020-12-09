namespace Biblioteca.Reportes
{
    partial class frmRGeneros
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
            this.rvGeneros = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvGeneros
            // 
            this.rvGeneros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvGeneros.Location = new System.Drawing.Point(0, 0);
            this.rvGeneros.Name = "rvGeneros";
            this.rvGeneros.ServerReport.BearerToken = null;
            this.rvGeneros.Size = new System.Drawing.Size(955, 569);
            this.rvGeneros.TabIndex = 0;
            // 
            // frmRGeneros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 569);
            this.Controls.Add(this.rvGeneros);
            this.Name = "frmRGeneros";
            this.Text = "frmRGeneros";
            this.Load += new System.EventHandler(this.frmRGeneros_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvGeneros;
    }
}