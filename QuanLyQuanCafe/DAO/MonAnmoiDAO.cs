using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class MonAnmoiDAO
    {
        private static MonAnmoiDAO instance;

        public static MonAnmoiDAO Instance
        {
            get { if (instance == null) instance = new MonAnmoiDAO(); return MonAnmoiDAO.instance; }
            private set { MonAnmoiDAO.instance = value; }
        }
        private MonAnmoiDAO() { }

        public List<MonAnmoi> LoadMonAnmoiList()
        {
            List<MonAnmoi> MonAnmoiList = new List<MonAnmoi>();

            DataTable dt = DataProvider.Instance.ExecuteQuery("USP_GetMonAn");
            foreach (DataRow item in dt.Rows)
            {
                MonAnmoi monanmoi = new MonAnmoi(item);
                MonAnmoiList.Add(monanmoi);

            }

            return MonAnmoiList;

        }

        public List<MonAnmoi> LoadMonAnmoiListTheoCBB(string loaimonan)
        {
            List<MonAnmoi> MonAnmoiList = new List<MonAnmoi>();

            DataTable dt = DataProvider.Instance.ExecuteQuery("select * from LOAIMON inner join MONAN on LOAIMON.MALOAI = MONAN.MALOAI where LOAIMON.TENLOAI = N'" + loaimonan + "' ");
            foreach (DataRow item in dt.Rows)
            {
                MonAnmoi monanmoi = new MonAnmoi(item);
                MonAnmoiList.Add(monanmoi);

            }

            return MonAnmoiList;

        }



        public void InsertMonAnmoi(string tenmonanmoi, string dongiamonanmoi, string dvtmonanmoi, string maloaimonan)
        {
            float f;
            if (float.TryParse(dongiamonanmoi, out f))
            {
                DataProvider.Instance.ExecuteNonQuery("USP_InsertMonAnmoi @dongia , @dvt , @tenmonan , @maloai", new object[] { f, dvtmonanmoi, tenmonanmoi, maloaimonan });
            }

        }
    }
}
