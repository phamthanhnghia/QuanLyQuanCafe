using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class MonAnDTO
    {
        private int mAMA;
        private string tENMA;
       
         private int mAlOAI;
         private float donGia;
         private string dVT;

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
        public MonAnDTO() { }
        public MonAnDTO(int MAMA, string TENMA,int MALOAI,float DonGia,string DVT)
        {
            this.MAMA = MAMA;
            this.TENMA = TENMA;
            this.MAlOAI = MAlOAI;
            this.DVT = DVT;
            this.DonGia = DonGia;
            

        }
        public MonAnDTO(DataRow row)
        {
            this.DVT = (string)row["DVT"];
            this.MAMA = (int)row["MAMA"];
            this.TENMA = (string)row["TENMA"];
            this.MAlOAI= (int)row["MALOAI"];
            this.DonGia = float.Parse(row["DonGia"].ToString());

        }
        public int MAMA
        {
            get { return mAMA; }
            set { mAMA = value; }
        }
       

        public string TENMA
        {
            get { return tENMA; }
            set { tENMA = value; }
        }
        
       

        public int MAlOAI
        {
            get { return mAlOAI; }
            set { mAlOAI = value; }
        }

    }
}
