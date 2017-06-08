using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonDAO();
                return HoaDonDAO.instance;
            }
            private set { HoaDonDAO.instance = value;}
        }
        /// <summary>
        /// thành công: billID
        /// thất bại : -1;
        /// </summary>
        private HoaDonDAO() {}
        
        public void XoaHoaDonBangMaBA(int id)
        {
            DataProvider.Instance.ExecuteQuery("DELETE HOADON where  MABA = " + id);
        }

        public int GetUncheckBillIDByTableID(int id)
        {
            string query = "SELECT * FROM HOADON WHERE MABA= " + id + " AND status = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query );

            if (data.Rows.Count > 0)
            {
                HoaDonDTO bill = new HoaDonDTO(data.Rows[0]);
                return bill.MaHD;
            }

            return -1;
        }

        public void CheckOut(int id, int discount, float totalPrice)
        {
            string query = "UPDATE HOADON SET dateCheckOut = GETDATE(), status = 1, " + "discount = " + discount + ", totalPrice = " + totalPrice + " WHERE id = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
     
        public void InsertHoaDon(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec InsertBill @MABA", new object[] { id });
        }

        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(MAHD) FROM HOADON");
            }
            catch
            {
                return 1;
            }
        }
        
    }
}
