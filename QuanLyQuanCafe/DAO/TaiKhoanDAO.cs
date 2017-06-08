using QuanLyQuanCafe.DTO;
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
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get
            {
                if (instance == null) instance = new TaiKhoanDAO();
                return TaiKhoanDAO.instance; 
            }
            private set { TaiKhoanDAO.instance = value; }
        }
        private TaiKhoanDAO() { }
        /// <summary>
        /// lấy tài khoản từ csdl lên theo tên đăng nhập
        /// </summary>
        /// <param name="UserName">Ten đăng nhập</param>
        /// <returns></returns>
        public TaiKhoanDTO getTaiKhoanbyUserName(string UserName)
        {
            TaiKhoanDTO result = null;
            string query = "TAIKHOANLIST @TenTK";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { UserName });
            foreach (DataRow item in data.Rows)
            {
                result = new TaiKhoanDTO(item);
            }
            return result;
        }
        public void InsertTAIKHOAN(string TENTK,string LOAITK,string MATKHAU){
            string query = null;
            using (SqlConnection cnn = new SqlConnection(DataProvider.connectionSTR))
            {
                query = "INSERT INTO TAIKHOAN(TENTK,LOAITK,MATKHAU) VALUES(@TENTK,@LOAITK,@MATKHAU)";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@TENTK", TENTK);
                    cmd.Parameters.AddWithValue("@LOAITK", LOAITK);
                    cmd.Parameters.AddWithValue("@MATKHAU", MATKHAU);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm thành công !");
                }
            }
        }
        public void DeleteTAIKHOAN(string TENTK)
        {
            string query = null;
            using (SqlConnection cnn = new SqlConnection(DataProvider.connectionSTR))
            {
                query = "DELETE FROM TAIKHOAN WHERE TENTK = @TENTK ";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@TENTK", TENTK);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa thành công !");
                }
            }
        }
        public void UpdateTAIKHOAN(string TENTK, string LOAITK, string MATKHAU)
        {
            string query = null;
            using (SqlConnection cnn = new SqlConnection(DataProvider.connectionSTR))
            {
                query = "DELETE FROM TAIKHOAN WHERE TENTK = @TENTK ";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@TENTK", TENTK);
                    cmd.ExecuteNonQuery();
                }
            }
            using (SqlConnection cnn = new SqlConnection(DataProvider.connectionSTR))
            {
                query = "INSERT INTO TAIKHOAN(TENTK,LOAITK,MATKHAU) VALUES(@TENTK,@LOAITK,@MATKHAU)";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@TENTK", TENTK);
                    cmd.Parameters.AddWithValue("@LOAITK", LOAITK);
                    cmd.Parameters.AddWithValue("@MATKHAU", MATKHAU);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Đã cập nhật thành công !");
        }
        public bool CheckTENTK(string TENTK)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM TAIKHOAN");
            foreach (DataRow item in data.Rows)
            {
                if (string.Equals(item["TENTK"],TENTK))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
