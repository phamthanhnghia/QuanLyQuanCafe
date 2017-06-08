using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class LoaiMonDTO
    {
        private string tenLoai;
        private int mALOAI;

        public int MALOAI
        {
            get { return mALOAI; }
            set { mALOAI = value; }
        }
        public string TenLoai
        {
            get { return tenLoai; }
            set { tenLoai = value; }
        }

        public LoaiMonDTO(int MALOAI,string TenLoai)
        {
            this.TenLoai = TenLoai;
            this.MALOAI = MALOAI;
        }

        public LoaiMonDTO(DataRow row)
        {
            this.TenLoai = row["TENLOAI"].ToString();
            this.MALOAI = (int)row["MALOAI"];
        }
    }
       
}
