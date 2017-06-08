using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.DAO
{
    class NhanVienDAO
    {
        private static NhanVienDAO instance;
        
        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return NhanVienDAO.instance; }
            private set { NhanVienDAO.instance = value; }
        }
        private NhanVienDAO() { }
        //chinh sua connect string
        private string connetionString = DataProvider.connectionSTR;
        //public List<NhanVien> GetListNhanVien()
        //{
        //    List<NhanVien> list = new List<NhanVien>();

        //    string query = "select * from NHANVIEN";

        //    DataTable data = DataProvider.Instance.ExecuteQuery(query);

        //    foreach (DataRow item in data.Rows)
        //    {
        //        NhanVien nv = new NhanVien(item);
        //        list.Add(nv);
        //    }

        //    return list;
        //}


        public void InsertNhanVien(int MACV,string HOTEN, string PHAI, string NGAYSINH,string CMND,string DIACHI,string DIENTHOAI,string LOAINV)
        {
            string query = null;
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                query = "INSERT INTO NHANVIEN(MACV,HOTEN,PHAI,NGAYSINH,CMND,DIACHI,DIENTHOAI,LOAINV) VALUES(@MACV,@HOTEN,@PHAI,@NGAYSINH,@CMND,@DIACHI,@DIENTHOAI,@LOAINV)";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@MACV", MACV);
                    cmd.Parameters.AddWithValue("@HOTEN", HOTEN);
                    cmd.Parameters.AddWithValue("@PHAI", PHAI);
                    cmd.Parameters.AddWithValue("@NGAYSINH", NGAYSINH);
                    cmd.Parameters.AddWithValue("@CMND", CMND);
                    cmd.Parameters.AddWithValue("@DIACHI", DIACHI);
                    cmd.Parameters.AddWithValue("@DIENTHOAI", DIENTHOAI);
                    cmd.Parameters.AddWithValue("@LOAINV", LOAINV);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm thành công !");
                }
            }
       
        }
        public void UpdateNhanVien(int MANV, int MACV, string HOTEN, string PHAI, string NGAYSINH, string CMND, string DIACHI, string DIENTHOAI, string LOAINV)
        {
            string query = null;
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                query = "UPDATE NHANVIEN SET MACV = @MACV , HOTEN = @HOTEN, PHAI = @PHAI, NGAYSINH = @NGAYSINH, CMND = @CMND,DIACHI = @DIACHI,DIENTHOAI = @DIENTHOAI,LOAINV = @LOAINV WHERE MANV = @MANV";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@MANV", MANV);
                    cmd.Parameters.AddWithValue("@MACV", MACV);
                    cmd.Parameters.AddWithValue("@HOTEN", HOTEN);
                    cmd.Parameters.AddWithValue("@PHAI", PHAI);
                    cmd.Parameters.AddWithValue("@NGAYSINH", NGAYSINH);
                    cmd.Parameters.AddWithValue("@CMND", CMND);
                    cmd.Parameters.AddWithValue("@DIACHI", DIACHI);
                    cmd.Parameters.AddWithValue("@DIENTHOAI", DIENTHOAI);
                    cmd.Parameters.AddWithValue("@LOAINV", LOAINV);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã sửa thành công !");
                }
            }
        }

        public void DeleteNhanVien(int MANV)
        {
            string query = null;
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                query = "UPDATE NHANVIEN SET TRANGTHAI = '0' WHERE MANV = @MANV";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@MANV", MANV);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa thành công !");
                }
            }
        }
        public int MaLoaiNhanVien(string LOAINV)
        {
            if(LOAINV == "Nhân viên thời vụ")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int TinhLuong(int CASANG, int CACHIEU, int CATOI, double HELUONG, int MALOAINV)
        {
            DataTable dataCaTruc = DataProvider.Instance.ExecuteQuery("SELECT * FROM CATRUC");
            int TienCaSang = 0  ,TienCaChieu = 0 , TienCaToi = 0;
            if (MALOAINV == 1) // Nhân Viên thời vụ
            {
                TienCaSang = (int)dataCaTruc.Rows[0]["TIENTHOIVU"];
                TienCaChieu = (int)dataCaTruc.Rows[1]["TIENTHOIVU"];
                TienCaToi = (int)dataCaTruc.Rows[2]["TIENTHOIVU"];
            }
            else // Nhân Viên Chính thức
            {
                TienCaSang = (int)dataCaTruc.Rows[0]["TIENCHINHTHUC"];
                TienCaChieu = (int)dataCaTruc.Rows[1]["TIENCHINHTHUC"];
                TienCaToi = (int)dataCaTruc.Rows[2]["TIENCHINHTHUC"];
            }
            return (CASANG * TienCaSang + CACHIEU * TienCaChieu + CATOI * TienCaToi) * (int)HELUONG;
        }

    }
}
