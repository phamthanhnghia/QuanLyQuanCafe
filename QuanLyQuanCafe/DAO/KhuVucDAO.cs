using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class KhuVucDAO
    {
        private static KhuVucDAO instance;

        public static KhuVucDAO Instance
        {
            get 
            {
                if(instance == null)
                    instance = new KhuVucDAO();
                return KhuVucDAO.instance;
            }
            private set { KhuVucDAO.instance = value; }
        }
        public List<KhuVucDTO> GetListArea()
        {
            List<KhuVucDTO> listArea = new List<KhuVucDTO>();

            string query = "select * from KHUVUC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                KhuVucDTO Area = new KhuVucDTO(item);
                listArea.Add(Area);

            }

            return listArea;
        }

        public KhuVucDTO LayDanhSachKhuVucTheoID(int MAKV)
        {
            KhuVucDTO KhuVuc = null;

            string query = " select * from KHUVUC where MAKV = " + MAKV;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                KhuVuc = new KhuVucDTO(item);
                return KhuVuc;
            }
            return KhuVuc;
        }

        #region Insert Update Delete
        public bool InsertArea(string name)
        {
            string query = string.Format("INSERT KHUVUC ( TENKV) VALUES  ( N'{0}')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateArea(int MAKV, string name)
        {
            string query = string.Format("UPDATE KHUVUC SET TENKV= N'{0}' WHERE MAKV = {1}", name,MAKV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteArea(int MAKV)
        {
            BanAnDAO.Instance.XoaBanAnBangMaKV(MAKV);

            string query = string.Format("Delete KHUVUC where MAKV = {0}", MAKV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        #endregion

    }

}
