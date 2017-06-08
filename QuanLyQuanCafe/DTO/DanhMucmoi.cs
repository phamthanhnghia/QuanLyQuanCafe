using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class DanhMucmoi
    {
        public DanhMucmoi(int maloai, string tenloai)
        {
            this.MaLoai = maloai;
            this.TenLoai = tenloai;
        }

        public DanhMucmoi(DataRow row)
        {
            this.MaLoai = (int)row["MALOAI"];
            this.TenLoai = row["TENLOAI"].ToString();

        }



        private string tenLoai;

        public string TenLoai
        {
            get { return tenLoai; }
            set { tenLoai = value; }
        }
        private int maLoai;

        public int MaLoai
        {
            get { return maLoai; }
            set { maLoai = value; }
        }
    }
}
