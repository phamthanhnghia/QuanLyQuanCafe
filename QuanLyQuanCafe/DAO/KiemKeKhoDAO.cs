using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class KiemKeKhoDAO
    {
        private static KiemKeKhoDAO instance;

        public static KiemKeKhoDAO Instance
        {
            get { if (instance == null) instance = new KiemKeKhoDAO(); return instance; }
            private set { instance = value; }
        }


        private KiemKeKhoDAO() { }


        public List<KiemKeKho> LoadKiemKeList(string ngaykk)
        {
            string a = ngaykk.Substring(0, ngaykk.IndexOf(" "));
            List<KiemKeKho> kiemkekhoList = new List<KiemKeKho>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetKiemKeList @ngaykk", new object[] { a });

            foreach (DataRow item in data.Rows)
            {
                KiemKeKho kkk = new KiemKeKho(item);
                kiemkekhoList.Add(kkk);

            }

            return kiemkekhoList;
        }
    }
}
