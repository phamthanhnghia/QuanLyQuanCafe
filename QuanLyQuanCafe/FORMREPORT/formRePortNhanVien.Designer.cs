namespace QuanLyQuanCafe.FORMREPORT
{
    partial class formRePortNhanVien
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
            this.reportViewerNhanVien = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerNhanVien
            // 
            this.reportViewerNhanVien.LocalReport.ReportEmbeddedResource = "QuanLyQuanCafe.REPORT.ReportNhanVien.rdlc";
            this.reportViewerNhanVien.Location = new System.Drawing.Point(3, 3);
            this.reportViewerNhanVien.Name = "reportViewerNhanVien";
            this.reportViewerNhanVien.Size = new System.Drawing.Size(864, 554);
            this.reportViewerNhanVien.TabIndex = 0;
            // 
            // formRePortNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 559);
            this.Controls.Add(this.reportViewerNhanVien);
            this.Name = "formRePortNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formRePortNhanVien";
            this.Load += new System.EventHandler(this.formRePortNhanVien_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerNhanVien;
    }
}