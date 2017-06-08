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
    public partial class fromRePortChiTieu : Form
    {
        private DataTable dataChiTieu;
        public fromRePortChiTieu()
        {
            InitializeComponent();
        }
        public fromRePortChiTieu(DataTable _chitieu):this()
        {
            dataChiTieu = _chitieu;
        }
        private void fromRePortChiTieu_Load(object sender, EventArgs e)
        {
            dataChiTieu.TableName = "CHITIEU";
            this.reportViewerChiTieu.ProcessingMode = ProcessingMode.Local;
            ReportDataSource rds = new ReportDataSource("CHITIEU", dataChiTieu);
            this.reportViewerChiTieu.LocalReport.DataSources.Clear();
            this.reportViewerChiTieu.LocalReport.DataSources.Add(rds);
            this.reportViewerChiTieu.RefreshReport();
        }
    }
}
