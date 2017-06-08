using Microsoft.Reporting.WinForms;
using QuanLyQuanCafe.DAO;
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
    public partial class formRePortThanhToan : Form
    {
        private int MABA;
        public formRePortThanhToan()
        {
            InitializeComponent();
        }
        public formRePortThanhToan(int _MABA): this()
        {
            MABA = _MABA;
        }
        private void formRePortThanhToan_Load(object sender, EventArgs e)
        {
            DataTable dataHD = DataProvider.Instance.ExecuteQuery("SELECT * FROM HOADON WHERE status = 0 AND MABA ="+MABA);
            string MAHD = dataHD.Rows[0]["MAHD"].ToString();
            DataTable dataCTHD = DataProvider.Instance.ExecuteQuery("SELECT * FROM CTHD,MONAN WHERE CTHD.MAMA = MONAN.MAMA AND MAHD ="+MAHD);
            dataCTHD.Columns.Add("THANHTIEN", typeof(System.Int32));
            foreach(DataRow item in dataCTHD.Rows){
                int DonGia = Convert.ToInt32(item["DonGia"]);
                int soluong = Convert.ToInt32(item["Soluong"]);
                item["THANHTIEN"] = DonGia * soluong;
            }
            dataCTHD.TableName = "THANHTOAN";
            this.reportViewerThanhToan.ProcessingMode = ProcessingMode.Local;
            ReportDataSource rds = new ReportDataSource("THANHTOAN", dataCTHD);
            this.reportViewerThanhToan.LocalReport.DataSources.Clear();
            this.reportViewerThanhToan.LocalReport.DataSources.Add(rds);
            this.reportViewerThanhToan.RefreshReport();
        }
        
    }
}
