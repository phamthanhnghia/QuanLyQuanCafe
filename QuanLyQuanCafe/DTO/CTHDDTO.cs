using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class CTHDDTO
    {
        private int mAMA;
        private int mAHD;
        private float donGia;
        private int sOLUONG;
        private string dVT;
        public CTHDDTO() { }
        public CTHDDTO(int MAMA, int MAHD,  int DonGia, int SOLUONG, string DVT)
        {
            this.MAMA = MAMA;
            this.MAHD = MAHD;
            this.DonGia = DonGia;
            this.SOLUONG = SOLUONG;
            this.DVT = DVT;
        }
        public CTHDDTO(DataRow row) {
            this.MAMA = (int)row["MaMA"];
            this.MAHD = (int)row["MaHD"];
      
            this.DonGia = (int)row["DonGia"];
            this.SOLUONG = (int)row["SoLuong"];
            this.DVT= (string)row["DVT"];
        }

        public float DonGia1
        {
            get { return donGia; }
            set { donGia = value; }
        }
        public int SOLUONG
        {
            get { return sOLUONG; }
            set { sOLUONG = value; }
        }
        public string DVT
        {
            get { return dVT; }
            set { dVT = value; }
        }

        public float DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        public int MAHD
        {
            get { return mAHD; }
            set { mAHD = value; }
        }
        public int MAMA
        {
            get { return mAMA; }
            set { mAMA = value; }
        }

        
       
    }
}
