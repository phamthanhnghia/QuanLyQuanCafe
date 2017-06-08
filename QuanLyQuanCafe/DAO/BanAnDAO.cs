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
    public class BanAnDAO
    {
        private static BanAnDAO instance;

        public static BanAnDAO Instance
        {
            get 
            {
                if (instance == null)
                    instance = new BanAnDAO();
                return BanAnDAO.instance; }
            private set { BanAnDAO.instance = value; }
        }

        private BanAnDAO() { }

        public List<BanAnDTO>  GetTableList()
        {
            List<BanAnDTO> TableList = new List<BanAnDTO>();
            string query = "select * from BANAN where status = 0 ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                BanAnDTO food = new BanAnDTO(item);
                TableList.Add(food);

            }

            
            return TableList;
        }
        public bool InsertTable(string TenBA, string TrangThai, int MAKV)
        {
            string query = string.Format("INSERT BANAN ( TENBA, TRANGTHAI, MAKV) VALUES  (  N'{0}', N'{1}', {2})", TenBA, TrangThai, MAKV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateTable(int idTable, string TenBA, string status, int MAKV)
        {
            string query = string.Format("UPDATE BANAN SET TENBA = N'{0}', TRANGTHAI =N'{1}', MAKV = {2} WHERE MABA = {3}", TenBA, status,MAKV, idTable);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteTable(int idTable)
        {
            //HoaDonDAO.Instance.XoaHoaDonBangMaBA(idTable);
            //string query = string.Format("UPDATE BANAN SET status = 1 where MABA= {0}", idTable);
            //int result = DataProvider.Instance.ExecuteNonQuery(query);
            //return result > 0;

            string connetionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=DoAnQuanLyQuanCafe;Integrated Security=True";
            string query = null;
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                query = "UPDATE BANAN SET status = 1 where MABA= @MABA";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@MABA", idTable);
                    cmd.ExecuteNonQuery();
                }
            }
            return true;
        }

        public void XoaBanAnBangMaKV(int id)
        {
            DataProvider.Instance.ExecuteQuery("DELETE BANAN where  MAKV= " + id);
        }


    }
}
