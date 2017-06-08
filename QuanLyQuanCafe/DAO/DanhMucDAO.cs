using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class DanhMucDAO
    {
        private static DanhMucDAO instance;

        public static DanhMucDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DanhMucDAO();
                return DanhMucDAO.instance; 
            }
            private set { DanhMucDAO.instance = value; }
        }

        private DanhMucDAO() { }

        public List<LoaiMonDTO> LayDanhSachDanhMuc()
        {
            List<LoaiMonDTO> List = new List<LoaiMonDTO>();
            string query = " select * from LOAIMON";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                LoaiMonDTO menu = new LoaiMonDTO(item);
                List.Add(menu);
            }
            return List;
        }
        public LoaiMonDTO LayDanhSachLoaiMonAnTheoID(int MALOAI)
        {
            LoaiMonDTO Loaimon = null;
           
            string query = " select * from LOAIMON where MALOAI = "+ MALOAI;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Loaimon = new LoaiMonDTO(item);
                return Loaimon;
            }
            return Loaimon;
        }

        #region Insert Update Delete
        public bool DeleteDanhMuc(int MALOAI)
        {
            MonAnDAO.Instance.XoaMonAnBangDanhMuc(MALOAI);
            string query = string.Format("Delete LOAIMON where MALOAI= {0}", MALOAI);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool InsertDanhMuc(string name)
        {
            string query = string.Format("INSERT LOAIMON ( TENLOAI )VALUES  ( N'{0}')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateDanhMuc(int MaLoai, string name)
        {
            string query = string.Format("UPDATE LOAIMON SET TENLOAI = N'{0}' WHERE MALOAI = {1}", name, MaLoai);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        #endregion

    }
}
