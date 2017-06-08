using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class DS_NhapHangDAO
    {
        private static DS_NhapHangDAO instance;

        public static DS_NhapHangDAO Instance
        {
            get { if (instance == null) instance = new DS_NhapHangDAO(); return DS_NhapHangDAO.instance; }
            private set { DS_NhapHangDAO.instance = value; }
        }
        private DS_NhapHangDAO() { }


        public List<DS_NhapHang> LoadDS_NhapHangList()
        {
            List<DS_NhapHang> DS_NhapHanglist = new List<DS_NhapHang>();

            DataTable dt = DataProvider.Instance.ExecuteQuery("select distinct CTDS_NHAPHANG.MaNL, NGUYENLIEU.TenNL, CTDS_NHAPHANG.SL,CTDS_NHAPHANG.DVT,DANHSACH_NHAPHANG.TenTK,CTDS_NHAPHANG.XacNhan from (DANHSACH_NHAPHANG inner join CTDS_NHAPHANG on DANHSACH_NHAPHANG.NgayNhapHang = CTDS_NHAPHANG.NgayNhapHang) inner join NGUYENLIEU on CTDS_NHAPHANG.NgayNhapHang = NGUYENLIEU.NgayNhap ");
            foreach (DataRow item in dt.Rows)
            {
                DS_NhapHang dsnhlist = new DS_NhapHang(item);
                DS_NhapHanglist.Add(dsnhlist);

            }

            return DS_NhapHanglist;
        }

    }
}
