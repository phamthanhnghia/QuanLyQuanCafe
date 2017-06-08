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
    public partial class fThemMonAnmoi : Form
    {
        public fThemMonAnmoi()
        {
            InitializeComponent();
            AcceptButton = btnXacNhanThemMonAnmoi;
            LoadCBB();
        }

        private void btnThoatThemMonAnmoi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LoadCBB()
        {
            List<DanhMucmoi> danhmuclist = DanhMucmoiDAO.Instance.LoadDanMucmoilist();
            cbbLoaiMonAnmoi.DataSource = danhmuclist;
            cbbLoaiMonAnmoi.DisplayMember = "TENLOAI";
        }

        private void btnXacNhanThemMonAnmoi_Click(object sender, EventArgs e)
        {
            bool kt = false;
            List<MonAnmoi> monanmoilist = MonAnmoiDAO.Instance.LoadMonAnmoiList();
            foreach (MonAnmoi item in monanmoilist)
            {
                if (txbTenMonAnmoi.Text.ToString() == item.TenMonAn)
                {
                    kt = true;
                    MessageBox.Show("Tên Món Ăn Đã Tồn Tại , Vui Lòng Nhập Tên Món Ăn Khác !", "Thông Báo");
                    break;
                }
            }
            if (kt == false)
            {
                string a = ((DanhMucmoi)cbbLoaiMonAnmoi.SelectedItem).MaLoai.ToString();
                MonAnmoiDAO.Instance.InsertMonAnmoi(txbTenMonAnmoi.Text.ToString(), txbDonGiaMonAnmoi.Text.ToString(), txbDVTMonAnmoi.Text.ToString(), a);
                this.Close();

            }
        }

        private void txbTenMonAnmoi_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
