using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class CTHDDAO
    {
        private static CTHDDAO instance;

        public static CTHDDAO Instance
        {
            get 
            {
                if (instance == null)
                    instance = new CTHDDAO();
                    return CTHDDAO.instance; }
            private set { CTHDDAO.instance = value; }
        }

        private CTHDDAO() { }
        
        public void DeleteBillInfoByFoodID(int id)
        {
            DataProvider.Instance.ExecuteQuery("DELETE CTHD where  MAMA = " + id);
        }

        public List<CTHDDTO> GetListBillInfo(int id)
        {
            List<CTHDDTO> listBillInfo = new List<CTHDDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM CTHD WHERE MAHD = " + id);

            foreach (DataRow item in data.Rows)
            {
                CTHDDTO info = new CTHDDTO(item);
                listBillInfo.Add(info);
            }

            return listBillInfo;
        }

        public void InsertBillInfo(int idBill, int idFood, int count, string DVT)
        {
            DataProvider.Instance.ExecuteNonQuery("InsertCTHHD @MAHD, @MAMA , @SoLuong, @DVT", new object[] { idBill, idFood, count, DVT });
        }

    }
}
