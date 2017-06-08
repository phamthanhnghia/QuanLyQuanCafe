using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.DAO
{
    class ChucVuDAO
    {
        private static ChucVuDAO instance;

        public static ChucVuDAO Instance
        {
            get { if (instance == null) instance = new ChucVuDAO(); return ChucVuDAO.instance; }
            private set { ChucVuDAO.instance = value; }
        }
        private ChucVuDAO() { }
        //chinh sua connect string
        private string connetionString = DataProvider.connectionSTR;

        public void UpdateChucVu(int MACV, double HELUONG)
        {
            string query = null;
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                query = "UPDATE CHUCVU SET HELUONG = @HELUONG WHERE MACV = @MACV";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@MACV", MACV);
                    cmd.Parameters.AddWithValue("@HELUONG", HELUONG);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã sửa thành công !");
                }
            }
        }
    }
}
