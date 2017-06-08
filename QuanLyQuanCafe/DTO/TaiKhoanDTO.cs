using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class TaiKhoanDTO
    {
        private string tENTK;
        private string lOAITK;
        private string mATKHAU;
        public TaiKhoanDTO() { }
        public TaiKhoanDTO(string TENTK,string LOAITK,string MATKHAU) {
            this.TENTK = TENTK;
            this.LOAITK = LOAITK;
            this.MATKHAU = MATKHAU;
        }
        public TaiKhoanDTO(DataRow row) {
            this.TENTK = (string)row["TENTK"];
            this.LOAITK = (string)row["LOAITK"];
            this.MATKHAU = (string)row["MATKHAU"];
        }
        public string MATKHAU
        {
            get { return mATKHAU; }
            set { mATKHAU = value; }
        }

        public string LOAITK
        {
            get { return lOAITK; }
            set { lOAITK = value; }
        }

        public string TENTK
        {
            get { return tENTK; }
            set { tENTK = value; }
        }


    }
}
