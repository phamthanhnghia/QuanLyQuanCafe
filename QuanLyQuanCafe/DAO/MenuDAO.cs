using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new MenuDAO();
                return MenuDAO.instance;
            }
            private set { MenuDAO.instance = value; }
        }
        private MenuDAO() { }
        public List<MenuDTO> GetListMenuByTable(int MABA)
        {
            List<MenuDTO> listMenu = new List<MenuDTO>();

            string query = " select TENMA, SoLuong,DonGia, Dongia*Soluong as ThanhTien from CTHD b ,MONAN a, HOADON d where b.MAMA = a.MAMA  and d.MAHD = b.MAHD and d.status = 0 and  d.MABA= " + MABA;// +id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                MenuDTO menu = new MenuDTO(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
    
}
