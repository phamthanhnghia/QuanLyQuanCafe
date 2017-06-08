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
    class DiemDanhDAO
    {
        private static DiemDanhDAO instance;

        public static DiemDanhDAO Instance
        {
            get { if (instance == null) instance = new DiemDanhDAO(); return DiemDanhDAO.instance; }
            private set { DiemDanhDAO.instance = value; }
        }
        private DiemDanhDAO() { }

        private string connetionString = DataProvider.connectionSTR;

        public void InsertDiemDanh(string NGAY)
        {
            string query = null;
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                query = "INSERT INTO DIEMDANH(NGAY) VALUES(@NGAY)";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@NGAY", NGAY);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public int checkInsertDiemDanh(string NGAY)
        {
            int MADD = 0;
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM DIEMDANH WHERE NGAY = '" +NGAY+"'");
            if (data.Rows.Count > 0)
            {
                MADD = Convert.ToInt32(data.Rows[0]["MADD"]);
            }
            
            return MADD;
        }
        public int maCaTruc(string TENCA)
        {
            int MACT = 0;
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM CATRUC WHERE TENCA= N'"+TENCA+"'");
            if (data.Rows.Count > 0)
            {
                MACT = Convert.ToInt32(data.Rows[0]["MACT"]);
            }
            return MACT;
        }
        public void insertCHITIETTINHCONG(int MADD,int MANV,int MACT)
        {
            string query = null;
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                query = "INSERT INTO CHITIETTINHCONG(MADD,MANV,MACT) VALUES(@MADD,@MANV,@MACT)";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@MADD", MADD);
                    cmd.Parameters.AddWithValue("@MANV", MANV);
                    cmd.Parameters.AddWithValue("@MACT", MACT);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
