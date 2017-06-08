using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class DanhMucmoiDAO
    {
        private static DanhMucmoiDAO instance;

        public static DanhMucmoiDAO Instance
        {
            get { if (instance == null) instance = new DanhMucmoiDAO(); return DanhMucmoiDAO.instance; }
            private set { DanhMucmoiDAO.instance = value; }
        }

        private DanhMucmoiDAO() { }

        public List<DanhMucmoi> LoadDanMucmoilist()
        {
            List<DanhMucmoi> danhmuclist = new List<DanhMucmoi>();

            DataTable dt = DataProvider.Instance.ExecuteQuery("USP_GetLoaiMon");
            foreach (DataRow item in dt.Rows)
            {
                DanhMucmoi danhmucmoi = new DanhMucmoi(item);
                danhmuclist.Add(danhmucmoi);

            }

            return danhmuclist;
        }

        public void InsertLoaiMon(string TenLoaimon)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertLoaiMon @tenloaimon", new object[] { TenLoaimon });
        }
    }
}
