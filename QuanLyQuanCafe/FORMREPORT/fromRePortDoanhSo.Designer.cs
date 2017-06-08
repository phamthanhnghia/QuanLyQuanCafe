namespace QuanLyQuanCafe.FORMREPORT
{
    partial class fromRePortDoanhSo
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
            this.reportViewerDoanhSo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerDoanhSo
            // 
            this.reportViewerDoanhSo.LocalReport.ReportEmbeddedResource = "QuanLyQuanCafe.REPORT.ReportDoanhSoDoanhThu.rdlc";
            this.reportViewerDoanhSo.Location = new System.Drawing.Point(2, 2);
            this.reportViewerDoanhSo.Name = "reportViewerDoanhSo";
            this.reportViewerDoanhSo.Size = new System.Drawing.Size(868, 554);
            this.reportViewerDoanhSo.TabIndex = 0;
            // 
            // fromRePortDoanhSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 557);
            this.Controls.Add(this.reportViewerDoanhSo);
            this.Name = "fromRePortDoanhSo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo doanh số";
            this.Load += new System.EventHandler(this.fromRePortDoanhSo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerDoanhSo;
    }
}