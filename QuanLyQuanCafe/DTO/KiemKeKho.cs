using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{

    public class KiemKeKho
    {
        public KiemKeKho(string ngaykiemke, string tentaikhoan, string manguyenlieu, string tennguyenlieu, int soluong, string donvitinh)
        {
            this.NgayKiemKe = ngaykiemke;
            this.TenTaiKhoan = tentaikhoan;
            this.MaNguyenLieu = manguyenlieu;
            this.TenNguyenLieu = tennguyenlieu;
            this.SoLuong = soluong;
            this.DonViTinh = donvitinh;

        }

        public KiemKeKho(DataRow row)
        {
            this.NgayKiemKe = row["NgayKiemKe"].ToString();
            this.TenTaiKhoan = row["TenTK"].ToString();
            this.MaNguyenLieu = row["MaNL"].ToString();
            this.TenNguyenLieu = row["TenNL"].ToString();
            this.SoLuong = (int)row["SL"];
            this.DonViTinh = row["DVT"].ToString();

        }

        private KiemKeKho item;
        public KiemKeKho(KiemKeKho item)
        {
            this.item = item;
        }


        private string donViTinh;

        public string DonViTinh
        {
            get { return donViTinh; }
            set { donViTinh = value; }
        }

        private int soLuong;

        public int SoLuong
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

        private string tenTaiKhoan;

        public string TenTaiKhoan
        {
            get { return tenTaiKhoan; }
            set { tenTaiKhoan = value; }
        }

        private string ngayKiemKe;

        public string NgayKiemKe
        {
            get { return ngayKiemKe; }
            set { ngayKiemKe = value; }
        }
    }
}

