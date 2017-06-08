using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class MonAnDAO
    {
        private static MonAnDAO instance;

        public static MonAnDAO Instance
        {
            get 
            {
                if (instance == null)
                    instance = new MonAnDAO();
                return MonAnDAO.instance;
            }
            private set { MonAnDAO.instance = value; }
        }

        private MonAnDAO() { }

        public List<MonAnDTO> GetListFood()
        {
            List<MonAnDTO> listFood = new List<MonAnDTO>();

            string query = "select * from MONAN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MonAnDTO food  = new MonAnDTO(item);
                listFood.Add(food);
                
            }

            return listFood;
        }

        public List<MonAnDTO> GetListFoodByMALOAI(int id)
        {
            List<MonAnDTO> listFood = new List<MonAnDTO>();

            string query = " Select * from MONAN where MALOAI = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MonAnDTO food = new MonAnDTO(item);

                listFood.Add(food);

            }
            return listFood;
        }

       
        

        #region Insert Update Delete
        public bool InsertFood(string name, int id, float price, string DVT)
        {
            string query = string.Format("INSERT MONAN ( TENMA, MALOAI, DONGIA ,DVT)VALUES  ( N'{0}', {1}, {2}, N'{3}')", name, id, price,DVT);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateFood(int idFood, string name, int id, float price, string DVT)
        {
            string query = string.Format("UPDATE MONAN SET TENMA = N'{0}', MALOAI = {1}, DonGia = {2} , DVT = N'{3}' WHERE MAMA = {4}", name, id, price,DVT, idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteFood(int idFood)
        {
            CTHDDAO.Instance.DeleteBillInfoByFoodID(idFood);

            string query = string.Format("Delete MONAN where MAMA = {0}", idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public void XoaMonAnBangDanhMuc(int id)
        {
            DataProvider.Instance.ExecuteQuery("DELETE MONAN where  MALOAI = " + id);
        }
        #endregion

    }
}
