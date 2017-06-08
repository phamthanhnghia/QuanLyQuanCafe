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
    public partial class fromRePortDoanhSo : Form
    {
        private DataTable dataDoanhSo;
        public fromRePortDoanhSo()
        {
            InitializeComponent();
        }
        public fromRePortDoanhSo(DataTable _doanhso) : this()
        {
            dataDoanhSo = _doanhso;
        }

        private void fromRePortDoanhSo_Load(object sender, EventArgs e)
        {
            dataDoanhSo.TableName = "DOANHSO";
            this.reportViewerDoanhSo.ProcessingMode = ProcessingMode.Local;
            ReportDataSource rds = new ReportDataSource("DOANHSO", dataDoanhSo);
            this.reportViewerDoanhSo.LocalReport.DataSources.Clear();
            this.reportViewerDoanhSo.LocalReport.DataSources.Add(rds);
            this.reportViewerDoanhSo.RefreshReport();
        }
    }
}
