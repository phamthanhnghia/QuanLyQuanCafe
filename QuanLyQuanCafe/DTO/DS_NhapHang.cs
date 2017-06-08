using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class DS_NhapHang
    {
        public DS_NhapHang (string manguyenlieu, string tennguyenlieu, string soluong, string dvt, string nguoinhap, string xacnhan)
        {
            this.MaNguyenLieu = manguyenlieu;
            this.TenNguyenLieu = tennguyenlieu;
            this.SoLuong = soluong;
            this.DonViTinh = dvt;
            this.NguoiNhap = nguoinhap;
            this.XacNhan = xacnhan;
        }

        public DS_NhapHang(DataRow row)
        {
            this.MaNguyenLieu = row["MANL"].ToString();
            this.TenNguyenLieu = row["TenNL"].ToString();
            this.SoLuong = row["SL"].ToString();
            this.DonViTinh = row["DVT"].ToString();
            this.NguoiNhap = row["TenTK"].ToString();
            this.XacNhan = row["XacNhan"].ToString();

        }

        private string xacNhan;

        public string XacNhan
        {
            get { return xacNhan; }
            set { xacNhan = value; }
        }

        private string nguoiNhap;

        public string NguoiNhap
        {
            get { return nguoiNhap; }
            set { nguoiNhap = value; }
        }

        private string donViTinh;

        public string DonViTinh
        {
            get { return donViTinh; }
            set { donViTinh = value; }
        }

        private string soLuong;

        public string SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        private string tenNguyenLieu;

        public string TenNguyenLieu
        {
            get { return tenNguyenLieu; }
            set { tenNguyenLieu = value; }
        }

        private string maNguyenLieu;

        public string MaNguyenLieu
        {
            get { return maNguyenLieu; }
            set { maNguyenLieu = value; }
        }



    }
}
