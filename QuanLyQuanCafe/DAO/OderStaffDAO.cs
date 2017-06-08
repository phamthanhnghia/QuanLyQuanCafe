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
    public class OderStaffDAO
    {
        
        private static OderStaffDAO instance;

        public static OderStaffDAO Instance
        {
            get 
            {
                if (instance == null)
                    instance = new OderStaffDAO();
                return OderStaffDAO.instance; 
            }
            private set { OderStaffDAO.instance = value; }
        }

        public static int TableWidth = 90;
        public static int TableHeight = 90;

        private OderStaffDAO() { }
        public OderStaffDAO (DataRow row) // tao danh sách bàn 
        {
            this.MABA = (int)row["MABA"];
            this.TENBA = (string)row["LOAITK"];
            this.MAKV = (int)row["MATKHAU"];
            this.Trangthai = (string)row["TrangThai"];
        }
     
        public List<BanAnDTO> LoadTableList()
        {
            List<BanAnDTO> tableList = new List<BanAnDTO>();

            string query = "select * from BANAN where MAKV = 1";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                BanAnDTO table = new BanAnDTO(item);
                tableList.Add(table);
            }
            return tableList;
        }

        public List<BanAnDTO> LoadTableList2()
        {
            List<BanAnDTO> tableList = new List<BanAnDTO>();

            string query = "select * from BANAN where MAKV = 2";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                BanAnDTO table = new BanAnDTO(item);
                tableList.Add(table);
            }
            return tableList;
        }
        public List<BanAnDTO> LoadTableList3()
        {
            List<BanAnDTO> tableList = new List<BanAnDTO>();

            string query = "select * from BANAN where MAKV = 3";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                BanAnDTO table = new BanAnDTO(item);
                tableList.Add(table);
            }
            return tableList;
        }
        /// code Xác nhận bill // nghĩa code
        private string connetionString = DataProvider.connectionSTR;

        public void InsertHoaDon(int MABA)
        {
            string query = null;
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                query = "INSERT INTO HOADON(MABA) VALUES(@MABA)";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@MABA", MABA);
                    cmd.ExecuteNonQuery();
                }
            }

        }
        public void InsertCTHD(int MAMA, int MAHD , int SOLUONG , string DVT)
        {
            string query = null;
            DataTable dataCTHD = DataProvider.Instance.ExecuteQuery("SELECT * FROM CTHD WHERE MAMA = '"+MAMA+"' AND MAHD = "+MAHD);
            if (dataCTHD.Rows.Count > 0)
            {
                using (SqlConnection cnn = new SqlConnection(connetionString))
                {
                    query = "UPDATE CTHD SET Soluong = @SOLUONG WHERE MAMA = @MAMA AND MAHD = @MAHD";
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@MAMA", MAMA);
                        cmd.Parameters.AddWithValue("@MAHD", MAHD);
                        cmd.Parameters.AddWithValue("@SOLUONG", SOLUONG);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            else{
                using (SqlConnection cnn = new SqlConnection(connetionString))
                {
                    query = "INSERT INTO CTHD(MAMA,MAHD,Soluong, DVT) VALUES(@MAMA,@MAHD,@SOLUONG,@DVT)";
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@MAMA", MAMA);
                        cmd.Parameters.AddWithValue("@MAHD", MAHD);
                        cmd.Parameters.AddWithValue("@SOLUONG", SOLUONG);
                        cmd.Parameters.AddWithValue("@DVT", DVT);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            

        }


        public int MABA { get; set; }

        public string TENBA { get; set; }

        public int MAKV { get; set; }














       
































        public string Trangthai { get; set; }

    }
}
