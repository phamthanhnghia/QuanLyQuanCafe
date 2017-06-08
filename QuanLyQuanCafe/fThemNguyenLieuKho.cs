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
    public partial class fThemNguyenLieuKho : Form
    {
        public fThemNguyenLieuKho()
        {
            InitializeComponent();
            AcceptButton = btnXacNhanThemNL;
        }

        private void btnThoatThemNL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhanThemNL_Click(object sender, EventArgs e)
        {
            bool kt = false;
            List<NguyenLieuKho> nguyenlieukholist = NguyenLieuKhoDAO.Instance.LoadNguyenLieuList();
            foreach (NguyenLieuKho item in nguyenlieukholist)
            {
                if (txbMaNguyenLieuThem.Text.ToString().Trim() == item.MaNguyenLieu)
                {
                    kt = true;
                    MessageBox.Show("Mã Nguyên Liệu Đã Tồn Tại , Vui Lòng Nhập Mã Nguyên Liệu Khác !", "Thông Báo");
                    break;
                }
            }
            if (kt == false)
            {

                NguyenLieuKhoDAO.Instance.InsertNguyenLieuKho(txbMaNguyenLieuThem.Text, txbTenNguyenLieuThem.Text, dtNgayNhapThemNL.Value.ToString(), txbNguoiNhapThemNL.Text);
                this.Close();

            }
        }
    }
}

