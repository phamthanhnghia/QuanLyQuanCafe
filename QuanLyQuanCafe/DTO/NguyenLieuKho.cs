using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyQuanCafe.DTO
{
    public class NguyenLieuKho
    {



        public NguyenLieuKho(string manguyenlieu, string tennguyenlieu, string ngaynhap, string nguoinhap)
        {
            this.maNguyenLieu = manguyenlieu;
            this.tenNguyenLieu = tennguyenlieu;
            this.ngayNhapNguyenLieu = ngaynhap;
            this.nguoiNhapNguyenLieu = nguoinhap;

        }


        public NguyenLieuKho(DataRow row)
        {
            this.maNguyenLieu = row["MaNL"].ToString();
            this.tenNguyenLieu = row["TenNL"].ToString();
            this.ngayNhapNguyenLieu = row["NgayNhap"].ToString();
            this.nguoiNhapNguyenLieu = row["TenTK"].ToString();

        }
        private NguyenLieuKho item;
        public NguyenLieuKho(NguyenLieuKho item)
        {
            // TODO: Complete member initialization
            this.item = item;
        }

        private string maNguyenLieu;

        public string MaNguyenLieu
        {
            get { return maNguyenLieu; }
            set { maNguyenLieu = value; }
        }
        private string tenNguyenLieu;

        public string TenNguyenLieu
        {
            get { return tenNguyenLieu; }
            set { tenNguyenLieu = value; }
        }

        private string ngayNhapNguyenLieu;

        public string NgayNhapNguyenLieu
        {
            get { return ngayNhapNguyenLieu; }
            set { ngayNhapNguyenLieu = value; }
        }

        private string nguoiNhapNguyenLieu;


        public string NguoiNhapNguyenLieu
        {
            get { return nguoiNhapNguyenLieu; }
            set { nguoiNhapNguyenLieu = value; }
        }
    }
}
