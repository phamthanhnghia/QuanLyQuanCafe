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

namespace QuanLyQuanCafe
{
    public partial class FormKiemTraDiemDanh : Form
    {
        private DataTable data;
        public FormKiemTraDiemDanh()
        {
            InitializeComponent();
            this.dateDenNgay.Value = DateTime.Now;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string BATDAU = dateTuNgay.Text;
            string KETTHUC = dateDenNgay.Text;
            string query = "SELECT SONGAY.MANV,SONGAY.HOTEN ,SONGAY.DIENTHOAI, SONGAY.SONGAYDIEMDANH , SANG.CASANG , CHIEU.CACHIEU ,TOI.CATOI FROM(SELECT CHITIETTINHCONG.MANV, NHANVIEN.HOTEN, NHANVIEN.DIENTHOAI, COUNT(CHITIETTINHCONG.MADD) AS SONGAYDIEMDANH FROM DIEMDANH, CHITIETTINHCONG, NHANVIEN WHERE DIEMDANH.MADD = CHITIETTINHCONG.MADD AND NHANVIEN.MANV = CHITIETTINHCONG.MANV AND DIEMDANH.NGAY > '" + BATDAU + "' AND DIEMDANH.NGAY < '" + KETTHUC + "' GROUP BY CHITIETTINHCONG.MANV, NHANVIEN.HOTEN, NHANVIEN.DIENTHOAI) AS SONGAY LEFT JOIN(SELECT CHITIETTINHCONG.MANV, COUNT(CHITIETTINHCONG.MADD) AS CASANG FROM DIEMDANH, CHITIETTINHCONG WHERE DIEMDANH.MADD = CHITIETTINHCONG.MADD AND DIEMDANH.NGAY > '" + BATDAU + "' AND DIEMDANH.NGAY < '" + KETTHUC + "' AND CHITIETTINHCONG.MACT = '1' GROUP BY CHITIETTINHCONG.MANV) AS SANG ON SONGAY.MANV = SANG.MANV LEFT JOIN(SELECT CHITIETTINHCONG.MANV, COUNT(CHITIETTINHCONG.MADD) AS CACHIEU FROM DIEMDANH, CHITIETTINHCONG WHERE DIEMDANH.MADD = CHITIETTINHCONG.MADD AND DIEMDANH.NGAY > '" + BATDAU + "' AND DIEMDANH.NGAY < '" + KETTHUC + "' AND CHITIETTINHCONG.MACT = '2' GROUP BY CHITIETTINHCONG.MANV) AS CHIEU ON SONGAY.MANV = CHIEU.MANV LEFT JOIN(SELECT CHITIETTINHCONG.MANV, COUNT(CHITIETTINHCONG.MADD) AS CATOI FROM DIEMDANH, CHITIETTINHCONG WHERE DIEMDANH.MADD = CHITIETTINHCONG.MADD AND DIEMDANH.NGAY > '" + BATDAU + "' AND DIEMDANH.NGAY < '" + KETTHUC + "' AND CHITIETTINHCONG.MACT = '3' GROUP BY CHITIETTINHCONG.MANV) AS TOI ON SONGAY.MANV = TOI.MANV";
            DataTable dataTinhCa = DataProvider.Instance.ExecuteQuery(query);
            // thêm cột trong datatable
            dataTinhCa.Columns.Add("TINHLUONG", typeof(System.Int32));
            //
            dgvKiemTraDiemDanh.DataSource = dataTinhCa;
            foreach (DataRow item in dataTinhCa.Rows)
            {
                int MANV = (int)item["MANV"];
                int CASANG = 0, CACHIEU = 0, CATOI = 0, TINHLUONG = 0;
                if (!(item["CASANG"] is DBNull))
                {
                    CASANG = (int)item["CASANG"];
                }
                if (!(item["CACHIEU"] is DBNull))
                {
                    CACHIEU = (int)item["CACHIEU"];
                }
                if (!(item["CATOI"] is DBNull))
                {
                    CATOI = (int)item["CATOI"];
                }

                DataTable dataNhanVien = DataProvider.Instance.ExecuteQuery("SELECT * FROM NHANVIEN WHERE MANV = '" + MANV + "'");
                //
                if (dataNhanVien.Rows.Count > 0) { }
                int MACV = (int)dataNhanVien.Rows[0]["MACV"];
                string LOAINV = dataNhanVien.Rows[0]["LOAINV"].ToString();
                int MALOAINV = NhanVienDAO.Instance.MaLoaiNhanVien(LOAINV);
                //
                DataTable dataChucVu = DataProvider.Instance.ExecuteQuery("SELECT * FROM CHUCVU WHERE MACV = '" + MACV + "'");
                double HELUONG = (double)dataChucVu.Rows[0]["HELUONG"];
                TINHLUONG = NhanVienDAO.Instance.TinhLuong(CASANG, CACHIEU, CATOI, HELUONG, MALOAINV);
                item["TINHLUONG"] = TINHLUONG;
            }
            data = dataTinhCa;
        }

        private void FormKiemTraDiemDanh_Load(object sender, EventArgs e)
        {

            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FORMREPORT.formReportTinhCa f = new FORMREPORT.formReportTinhCa(data);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
