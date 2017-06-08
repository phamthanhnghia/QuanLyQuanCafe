namespace QuanLyQuanCafe.FORMREPORT
{
    partial class formRePortThanhToan
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
            this.reportViewerThanhToan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerThanhToan
            // 
            this.reportViewerThanhToan.LocalReport.ReportEmbeddedResource = "QuanLyQuanCafe.REPORT.ReportThanhToan.rdlc";
            this.reportViewerThanhToan.Location = new System.Drawing.Point(12, 12);
            this.reportViewerThanhToan.Name = "reportViewerThanhToan";
            this.reportViewerThanhToan.Size = new System.Drawing.Size(423, 452);
            this.reportViewerThanhToan.TabIndex = 0;
            // 
            // formRePortThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 476);
            this.Controls.Add(this.reportViewerThanhToan);
            this.Name = "formRePortThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.formRePortThanhToan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerThanhToan;
    }
}