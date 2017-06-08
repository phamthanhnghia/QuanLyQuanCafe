using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.DAO
{
    class CaTrucDAO
    {
        private static CaTrucDAO instance;

        public static CaTrucDAO Instance
        {
            get { if (instance == null) instance = new CaTrucDAO(); return CaTrucDAO.instance; }
            private set { CaTrucDAO.instance = value; }
        }
        private CaTrucDAO() { }
        //chinh sua connect string
        private string connetionString = DataProvider.connectionSTR;
        
        public void UpdateCATRUC(int MACT, string TENCA, string BATDAU, string KETTHUC , int TIENCHINHTHUC, int TIENTHOIVU)
        {
            string query = null;
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                query = "UPDATE CATRUC SET TENCA = @TENCA , BATDAU = @BATDAU ,KETTHUC = @KETTHUC ,TIENCHINHTHUC = @TIENCHINHTHUC ,TIENTHOIVU = @TIENTHOIVU WHERE MACT = @MACT";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@MACT", MACT);
                    cmd.Parameters.AddWithValue("@TENCA", TENCA);
                    cmd.Parameters.AddWithValue("@BATDAU", BATDAU);
                    cmd.Parameters.AddWithValue("@KETTHUC", KETTHUC);
                    cmd.Parameters.AddWithValue("@TIENCHINHTHUC", TIENCHINHTHUC);
                    cmd.Parameters.AddWithValue("@TIENTHOIVU", TIENTHOIVU);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã sửa thành công !");
                }
            }
        }

    }
}
