using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class MonAnmoi
    {
        public MonAnmoi(int mamonan, string dongiamonan, string donvitinh, string tenmonan, int maloaimonan)
        {
            this.MaMonAn = mamonan;
            this.DonGiaMonAn = dongiamonan;
            this.DonViTinh = donvitinh;
            this.TenMonAn = tenmonan;
            this.MaLoaiMonAn = maloaimonan;
        }

        public MonAnmoi(DataRow row)
        {
            this.MaMonAn = (int)row["MAMA"];
            this.DonGiaMonAn = row["DonGia"].ToString();
            this.DonViTinh = row["DVT"].ToString();
            this.TenMonAn = row["TENMA"].ToString();
            this.MaLoaiMonAn = (int)row["MALOAI"];

        }



        private int maLoaiMonAn;

        public int MaLoaiMonAn
        {
            get { return maLoaiMonAn; }
            set { maLoaiMonAn = value; }
        }

        private string tenMonAn;

        public string TenMonAn
        {
            get { return tenMonAn; }
            set { tenMonAn = value; }
        }

        private string donViTinh;

        public string DonViTinh
        {
            get { return donViTinh; }
            set { donViTinh = value; }
        }

        private string donGiaMonAn;

        public string DonGiaMonAn
        {
            get { return donGiaMonAn; }
            set { donGiaMonAn = value; }
        }

        private int maMonAn;

        public int MaMonAn
        {
            get { return maMonAn; }
            set { maMonAn = value; }
        }

    }
}
