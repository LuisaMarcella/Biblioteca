namespace Biblioteca.Reportes
{
    partial class frmRLibros
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
            this.rvRepLibros = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvRepLibros
            // 
            this.rvRepLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvRepLibros.Location = new System.Drawing.Point(0, 0);
            this.rvRepLibros.Name = "rvRepLibros";
            this.rvRepLibros.ServerReport.BearerToken = null;
            this.rvRepLibros.Size = new System.Drawing.Size(1200, 692);
            this.rvRepLibros.TabIndex = 0;
            // 
            // frmRLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.rvRepLibros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRLibros";
            this.Text = "Reporte de Libros";
            this.Load += new System.EventHandler(this.frmRLibros_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvRepLibros;
    }
}