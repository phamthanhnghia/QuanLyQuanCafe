using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class BanAnDTO
    {
        private int mABA;
        private string tENBA;
        private int mAKV;
        private string trangthai;

        public BanAnDTO() { }
        public BanAnDTO(int MABA,string TENBA,int MAKV, string TrangThai) 
        {
            this.MABA= MABA;
            this.TENBA = TENBA;
            this.MAKV=MAKV;
            this.Trangthai= Trangthai;
        }
        public BanAnDTO(DataRow row) {
            this.MABA = (int)row["MABA"];
            this.TENBA = row["TENBA"].ToString();
            this.MAKV= (int)row["MAKV"];
            this.Trangthai=row["TrangThai"].ToString();
        }
        public string TENBA
        {
            get { return tENBA; }
            set { tENBA = value; }
        }
        
        public string Trangthai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }
       

        public int MAKV
        {
            get { return mAKV; }
            set { mAKV = value; }
        }
        public int MABA
        {
            get { return mABA; }
            set { mABA = value; }
        }

        public System.Drawing.ContentAlignment BottomCenter { get; set; }
    }
}
