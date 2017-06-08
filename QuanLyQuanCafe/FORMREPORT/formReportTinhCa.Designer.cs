namespace QuanLyQuanCafe.FORMREPORT
{
    partial class formReportTinhCa
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
            this.reportViewerTinhCa = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerTinhCa
            // 
            this.reportViewerTinhCa.LocalReport.ReportEmbeddedResource = "QuanLyQuanCafe.REPORT.ReportTinhCa.rdlc";
            this.reportViewerTinhCa.Location = new System.Drawing.Point(3, 3);
            this.reportViewerTinhCa.Name = "reportViewerTinhCa";
            this.reportViewerTinhCa.Size = new System.Drawing.Size(864, 551);
            this.reportViewerTinhCa.TabIndex = 0;
            // 
            // formReportTinhCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 559);
            this.Controls.Add(this.reportViewerTinhCa);
            this.Name = "formReportTinhCa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách diểm danh và tính lương";
            this.Load += new System.EventHandler(this.formReportTinhCa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerTinhCa;
    }
}