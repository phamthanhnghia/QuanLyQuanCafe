using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class ThanhToanDAO
    {
        private static ThanhToanDAO instance;

        public static ThanhToanDAO Instance
        {
            get 
            {
                if (instance == null)
                    instance = new ThanhToanDAO();
                    return ThanhToanDAO.instance; }
            private set { ThanhToanDAO.instance = value; }
        }

        public static int TableWidth = 90;
        public static int TableHeight = 90;


        private ThanhToanDAO() {}

        public ThanhToanDAO (DataRow row)
        {
            this.MABA = (int)row["MABA"];
            this.TENBA = (string)row["TENBA"];
            this.MAKV = (int)row["MAKV"];
            this.Trangthai = (string)row["TrangThai"];
        }

        public List<BanAnDTO> LoadTableList()
        {
            List<BanAnDTO> tableList = new List<BanAnDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from BANAN where MAKV = 1");
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
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from BANAN where MAKV = 2");
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
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from BANAN where MAKV = 3");
            foreach (DataRow item in data.Rows)
            {
                BanAnDTO table = new BanAnDTO(item);
                tableList.Add(table);
            }
            return tableList;
        }
        // nghĩa code

        private string connetionString = DataProvider.connectionSTR;

        public void InsertHoaDonThanhToan(int MAHD)
        {
            int status = 1;
            string query = null;
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                query = "UPDATE HOADON SET status = @status WHERE MAHD = @MAHD";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@MAHD", MAHD);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.ExecuteNonQuery();
                }
            }

        }


        public int MABA { get; set; }

        public string TENBA { get; set; }

        public int MAKV { get; set; }

        public string Trangthai { get; set; }
    }
}
