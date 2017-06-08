using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.DAO
{
    class ChiTieuDAO
    {
        private static ChiTieuDAO instance;

        public static ChiTieuDAO Instance
        {
            get { if (instance == null) instance = new ChiTieuDAO(); return ChiTieuDAO.instance; }
            private set { ChiTieuDAO.instance = value; }
        }
        private ChiTieuDAO() { }

        private string connetionString = DataProvider.connectionSTR;

        public void InsertChiTieu(string NOIDUNG,int SOTIEN,string GHICHU,string NGUOINHAN)
        {
            string query = null;
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                query = "insert into PHIEUCHI (NOIDUNG,SOTIEN,NGAYLAP,GHICHU,NGUOINHAN) values (@NOIDUNG,@SOTIEN,@NGAYLAP,@GHICHU,@NGUOINHAN)";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@NOIDUNG", NOIDUNG);
                    cmd.Parameters.AddWithValue("@SOTIEN", SOTIEN);
                    cmd.Parameters.AddWithValue("@NGAYLAP", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@GHICHU", GHICHU);
                    cmd.Parameters.AddWithValue("@NGUOINHAN", NGUOINHAN);
                    cmd.ExecuteNonQuery();
                    XtraMessageBox.Show("Đã thêm thành công !", "Thông báo");
                }
            }
        }
        public void UpdateChiTieu(int MAPC, string NOIDUNG, int SOTIEN, string GHICHU, string NGUOINHAN)
        {
            string query = null;
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                query = "UPDATE PHIEUCHI SET NOIDUNG = @NOIDUNG, SOTIEN= @SOTIEN, NGAYLAP = @NGAYLAP, GHICHU = @GHICHU, NGUOINHAN = @NGUOINHAN WHERE MAPC = @MAPC";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@MAPC", MAPC);
                    cmd.Parameters.AddWithValue("@NOIDUNG", NOIDUNG);
                    cmd.Parameters.AddWithValue("@SOTIEN", SOTIEN);
                    cmd.Parameters.AddWithValue("@NGAYLAP", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@GHICHU", GHICHU);
                    cmd.Parameters.AddWithValue("@NGUOINHAN", NGUOINHAN);
                    cmd.ExecuteNonQuery();
                    XtraMessageBox.Show("Đã sửa thành công !","Thông báo");
                }
            }
        }
        public void DeleteChiTieu(int MAPC)
        {
            string query = null;
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                query = "DELETE FROM PHIEUCHI WHERE MAPC = @MAPC";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@MAPC", MAPC);
                    cmd.ExecuteNonQuery();
                    XtraMessageBox.Show("Đã xóa thành công !","Thông báo");
                }
            }
        }
    }
}
