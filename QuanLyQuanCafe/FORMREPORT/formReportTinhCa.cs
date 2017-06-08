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
    public partial class formReportTinhCa : Form
    {
        private DataTable dataTinhCa;
        public formReportTinhCa()
        {
            InitializeComponent();
        }
        public formReportTinhCa(DataTable _tinhca):this()
        {
            dataTinhCa = _tinhca;
        }

        private void formReportTinhCa_Load(object sender, EventArgs e)
        {
            dataTinhCa.TableName = "TINHCA";
            this.reportViewerTinhCa.ProcessingMode = ProcessingMode.Local;
            ReportDataSource rds = new ReportDataSource("TINHCA", dataTinhCa);
            this.reportViewerTinhCa.LocalReport.DataSources.Clear();
            this.reportViewerTinhCa.LocalReport.DataSources.Add(rds);
            this.reportViewerTinhCa.RefreshReport();
            this.reportViewerTinhCa.RefreshReport();
        }
    }
}
