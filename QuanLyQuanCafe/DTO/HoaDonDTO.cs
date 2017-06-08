using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class HoaDonDTO
    {
        private int mAHD;
        private DateTime? dateCheckIn;//cho phép null
        private DateTime? dateChecOut;
        private int status;
        private int mABA;
        private int giamGia;

        public int GiamGia
        {
            get { return giamGia; }
            set { giamGia = value; }
        }

        public int MABA
        {
            get { return mABA; }
            set { mABA = value; }
        }

        public DateTime? DateCheckIn
        {
            get { return dateCheckIn; }
            set { dateCheckIn = value; }
        }
       

        public DateTime? DateChecOut
        {
            get { return dateChecOut; }
            set { dateChecOut = value; }
        }
        
        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        public HoaDonDTO() { }
        public HoaDonDTO(int MAHD, DateTime? DateCheckIn, DateTime? DateChecOut, int status,int MABA,int GiamGia = 0)
        {
            this.MAHD = MAHD;
            this.DateCheckIn = DateCheckIn;
            this.DateChecOut = DateCheckIn;
            this.Status = status;
            this.MABA = MABA;
            this.GiamGia = GiamGia;
        }
        public HoaDonDTO (DataRow row)
        {
            this.MAHD = (int)row["MAHD"];
            this.DateCheckIn=(DateTime?) row["DateCheckIn"];
            var dateChecOutTemp = row["DatecheckOut"];
            if ((string)dateChecOutTemp != " ")
                this.DateChecOut = (DateTime?)dateChecOutTemp;
            this.status=(int)row["status"];
            this.MABA = (int)row["MABA"];
            this.GiamGia = (int)row["GiamGia"];

        }
        
        public int MAHD
        {
            get { return mAHD; }
            set { mAHD = value; }
        }





        public int id { get; set; }

        public int MaHD { get; set; }
    }
}
