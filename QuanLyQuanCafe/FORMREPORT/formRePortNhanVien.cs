using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.FORMREPORT
{
    public partial class formRePortNhanVien : Form
    {
        private DataTable dataNhanVien;
        public formRePortNhanVien()
        {
            InitializeComponent();
        }
        public formRePortNhanVien(DataTable _nhanvien):this()
        {
            dataNhanVien = _nhanvien;
        }
        private void formRePortNhanVien_Load(object sender, EventArgs e)
        {
            dataNhanVien.TableName = "NHANVIEN";
            this.reportViewerNhanVien.ProcessingMode = ProcessingMode.Local;
            ReportDataSource rds = new ReportDataSource("NHANVIEN", dataNhanVien);
            this.reportViewerNhanVien.LocalReport.DataSources.Clear();
            this.reportViewerNhanVien.LocalReport.DataSources.Add(rds);
            this.reportViewerNhanVien.RefreshReport();
        }
    }
}
