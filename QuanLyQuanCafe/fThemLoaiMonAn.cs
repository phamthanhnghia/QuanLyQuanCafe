using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fThemLoaiMonAn : Form
    {
        public fThemLoaiMonAn()
        {
            InitializeComponent();
            AcceptButton = btnXacNhan;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            bool kt = false;
            List<DanhMucmoi> danhmuclist = DanhMucmoiDAO.Instance.LoadDanMucmoilist();
            foreach (DanhMucmoi item in danhmuclist)
            {
                if (txbTenLoaiMonAnMoi.Text.ToString() == item.TenLoai)
                {
                    kt = true;
                    MessageBox.Show("Mã Nguyên Liệu Đã Tồn Tại , Vui Lòng Nhập Mã Nguyên Liệu Khác !", "Thông Báo");
                    break;
                }
            }
            if (kt == false)
            {

                DanhMucDAO.Instance.InsertDanhMuc(txbTenLoaiMonAnMoi.Text.ToString());
                this.Close();

            }
        }
    }
}
