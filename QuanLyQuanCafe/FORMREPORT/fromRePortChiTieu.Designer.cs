﻿namespace QuanLyQuanCafe.FORMREPORT
{
    partial class fromRePortChiTieu
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
            this.reportViewerChiTieu = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerChiTieu
            // 
            this.reportViewerChiTieu.LocalReport.ReportEmbeddedResource = "QuanLyQuanCafe.REPORT.ReportChiTieu.rdlc";
            this.reportViewerChiTieu.Location = new System.Drawing.Point(3, 3);
            this.reportViewerChiTieu.Name = "reportViewerChiTieu";
            this.reportViewerChiTieu.Size = new System.Drawing.Size(913, 461);
            this.reportViewerChiTieu.TabIndex = 0;
            // 
            // fromRePortChiTieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 467);
            this.Controls.Add(this.reportViewerChiTieu);
            this.Name = "fromRePortChiTieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê chi tiêu";
            this.Load += new System.EventHandler(this.fromRePortChiTieu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerChiTieu;
    }
}