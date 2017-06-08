using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe.DAO
{
    public class NguyenLieuKhoDAO
    {
        private static NguyenLieuKhoDAO instance;

        public static NguyenLieuKhoDAO Instance
        {
            get { if (instance == null) instance = new NguyenLieuKhoDAO(); return NguyenLieuKhoDAO.instance; }
            private set { NguyenLieuKhoDAO.instance = value; }
        }

        private NguyenLieuKhoDAO() { }

        public List<NguyenLieuKho> LoadNguyenLieuList()
        {
            List<NguyenLieuKho> nguyenlieukhoList = new List<NguyenLieuKho>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetNguyenLieuList");

            foreach (DataRow item in data.Rows)
            {
                NguyenLieuKho nguyenlieukho = new NguyenLieuKho(item);
                nguyenlieukhoList.Add(nguyenlieukho);

            }
            return nguyenlieukhoList;
        }

        public void InsertNguyenLieuKho(string MaNL, string TenNL, string NgayNhap, string NguoiNhap)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertNguyenLieu @manl , @tennl , @ngaynhap , @nguoinhap", new object[] { MaNL, TenNL, NgayNhap, NguoiNhap });
        }

    }
}

