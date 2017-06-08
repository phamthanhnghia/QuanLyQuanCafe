using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class PhieuChiDTO
    {
        private int mAPC;
        private string noiDung;
        private double soTien;
        private DateTime ngayLap;
        private string ghiChu;
        private string nguoiNhan;


        public PhieuChiDTO() { }
        public PhieuChiDTO (int MAPC, string NoiDung, double SoTien,DateTime NgayLap,string GhiChu,string NguoiNhan)
        {
            this.MAPC = MAPC;
            this.NoiDung = NoiDung;
            this.SoTien = SoTien;
            this.NgayLap = NgayLap;
            this.GhiChu = GhiChu;
            this.NguoiNhan = NguoiNhan;
        }
       public PhieuChiDTO(DataRow row)
        {
            this.MAPC = (int)row["MAPC"];
            this.NoiDung = (string)row["NoiDung"];
            this.SoTien = (double)row["SoTien"];
            this.NgayLap = (DateTime)row["NgayLap"];
            this.GhiChu = (string)row["GhiChu"];
            this.NguoiNhan = (string)row["NguoiNhan"];
        }
        public string NguoiNhan
        {
            get { return nguoiNhan; }
            set { nguoiNhan = value; }
        }
        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }
        
        public DateTime NgayLap
        {
            get { return ngayLap; }
            set { ngayLap = value; }
        }
        
        public double SoTien
        {
            get { return soTien; }
            set { soTien = value; }
        }
       
        public string NoiDung
        {
            get { return noiDung; }
            set { noiDung = value; }
        }
        
        public int MAPC
        {
            get { return mAPC; }
            set { mAPC = value; }
        }
        
    }
}
