using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.DAO
{
    class ThongKeDAO
    {
        private static ThongKeDAO instance;
        
        public static ThongKeDAO Instance
        {
            get { if (instance == null) instance = new ThongKeDAO(); return ThongKeDAO.instance; }
            private set { ThongKeDAO.instance = value; }
        }
        private ThongKeDAO() { }

        public DataTable ThongKeDoanhSo(string BATDAU, string KETTHUC)
        {
            DataTable hoadon = DataProvider.Instance.ExecuteQuery("SELECT * FROM HOADON WHERE DateCheckIn >= '"+BATDAU+"' AND DateCheckIn <= '"+KETTHUC+"'");
            if (hoadon.Rows.Count > 0)
            {
                string MAHDDAU = hoadon.Rows[0]["MAHD"].ToString();
                string MAHDCUOI = hoadon.Rows[hoadon.Rows.Count - 1]["MAHD"].ToString();
                DataTable chitiethoadon = DataProvider.Instance.ExecuteQuery("SELECT * FROM CTHD WHERE MAHD >=" + MAHDDAU + " AND MAHD <= " + MAHDCUOI);
                DataTable monan = DataProvider.Instance.ExecuteQuery("SELECT MAMA, DonGia,DVT, TENLOAI,TENMA FROM MONAN,LOAIMON WHERE MONAN.MALOAI = LOAIMON.MALOAI");
                int soluong = 0;
                monan.Columns.Add("SOLUONG", typeof(System.Int32));
                foreach (DataRow item_monan in monan.Rows)
                {
                    foreach (DataRow item_chitiet in chitiethoadon.Rows)
                    {
                        if (string.Equals(item_monan["MAMA"].ToString(), item_chitiet["MAMA"].ToString()) == true)
                        {
                            soluong = soluong + Convert.ToInt32(item_chitiet["Soluong"]);
                        }
                    }
                    item_monan["SOLUONG"] = soluong;
                    soluong = 0;
                }
                monan.Columns.Add("DOANHTHU", typeof(System.Int32));
                foreach (DataRow item_monan in monan.Rows)
                {
                    item_monan["DOANHTHU"] = Convert.ToInt32(item_monan["DonGia"]) * Convert.ToInt32(item_monan["SOLUONG"]);
                }
                return monan;
            }
            else
            {
                DataTable monan = DataProvider.Instance.ExecuteQuery("SELECT * FROM MONAN");
                int soluong = 0;
                monan.Columns.Add("SOLUONG", typeof(System.Int32));
                foreach (DataRow item_monan in monan.Rows)
                {
                    item_monan["SOLUONG"] = soluong;
                }
                return monan;
            }
            
        }
    }
}
