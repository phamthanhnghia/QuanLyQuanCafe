using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class KhuVucDTO
    {
        private int mAKV;

        public int MAKV
        {
            get { return mAKV; }
            set { mAKV = value; }
        }

        
        private string tenKV;

        public string TenKV
        {
            get { return tenKV; }
            set { tenKV = value; }
        }
        public KhuVucDTO() { }
        public KhuVucDTO (int MAKV,string TENKV) 
        {
            this.MAKV = MAKV;
            this.TenKV = TENKV;
        }
         public KhuVucDTO(DataRow row) {
            this.MAKV = (int)row["MAKV"];
            this.TenKV = row["TENKV"].ToString();
           
        }
       

    }
}
