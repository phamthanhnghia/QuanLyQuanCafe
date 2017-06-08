using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class MenuDTO
    {
        private string tENMA;
        private int soLuong;
        private float donGia;
        private float thanhTien;

        private MenuDTO() { }

        public MenuDTO(string TENMA, int SoLuong, float DonGia,float ThanhTien)
        {
            this.TENMA = TENMA;
            this.SoLuong = SoLuong;
            this.DonGia = DonGia;
            this.ThanhTien = ThanhTien;
            

        }

        public MenuDTO(DataRow row)
        {
            
            this.TENMA = (string)row["TENMA"];
            this.SoLuong = (int) row["SoLuong"];
            this.DonGia =float.Parse( row ["DonGia"].ToString());
            this.ThanhTien = float.Parse(row["ThanhTien"].ToString());
        }
        public float ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }

        public float DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public string TENMA
        {
            get { return tENMA; }
            set { tENMA = value; }
        }
    }
}
