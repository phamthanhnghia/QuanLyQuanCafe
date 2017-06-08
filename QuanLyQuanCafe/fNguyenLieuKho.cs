
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
    public partial class fNguyenLieuKho : Form
    {
        public fNguyenLieuKho()
        {
            InitializeComponent();
            AcceptButton = btnTimKiemNguyenLieuKho;
            LoadNguyenLieu();
        }

        #region Method

        void LoadNguyenLieu()
        {
            int i = 1;
            List<NguyenLieuKho> nguyenlieukholist = NguyenLieuKhoDAO.Instance.LoadNguyenLieuList();
            foreach (NguyenLieuKho item in nguyenlieukholist)
            {
                ListViewItem lvi = new ListViewItem(i.ToString());
                lvi.SubItems.Add(item.MaNguyenLieu);
                lvi.SubItems.Add(item.TenNguyenLieu);
                string a = item.NgayNhapNguyenLieu;
                string[] _a = a.Substring(0, a.IndexOf(" ")).Split('/');
                lvi.SubItems.Add(_a[1] + "/" + _a[0] + "/" + _a[2]);
                lvi.SubItems.Add(item.NguoiNhapNguyenLieu);
                livNguyenLieuKho.Items.Add(lvi);
                i++;
            }

        }

        void ShowNguyenLieuKho()
        {
            txbMaNguyenLieuKho.Text = livNguyenLieuKho.SelectedItems[0].SubItems[1].Text;
            txbTenNguyenLieuKho.Text = livNguyenLieuKho.SelectedItems[0].SubItems[2].Text;
            txbNgayNhapNguyenLieuKho.Text = livNguyenLieuKho.SelectedItems[0].SubItems[3].Text;
            txbNguoiNhapNguyenLieuKho.Text = livNguyenLieuKho.SelectedItems[0].SubItems[4].Text;

        }
        void ShowTimKiem(string MaNguyenLieuTK)
        {
            bool kt = false;
            List<NguyenLieuKho> nguyenlieukholist = NguyenLieuKhoDAO.Instance.LoadNguyenLieuList();
            foreach (NguyenLieuKho item in nguyenlieukholist)
            {
                if (MaNguyenLieuTK == item.MaNguyenLieu)
                {
                    txbMaNguyenLieuKho.Text = item.MaNguyenLieu;
                    txbTenNguyenLieuKho.Text = item.TenNguyenLieu;
                    string a = item.NgayNhapNguyenLieu;
                    txbNgayNhapNguyenLieuKho.Text = a.Substring(0, a.IndexOf(" "));
                    txbNguoiNhapNguyenLieuKho.Text = item.NguoiNhapNguyenLieu;
                    kt = true;
                    break;
                }
            }
            if (kt == false)
                MessageBox.Show("Mã Nguyên Liệu Không Tồn Tại, Vui Lòng Kiểm Tra Lại !", "Thông Báo");

        }


        #endregion

        #region Events
        private void btnThoatNguyenLieuKho_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion

        private void livNguyenLieuKho_Click(object sender, EventArgs e)
        {
            ShowNguyenLieuKho();
        }

       

       
       

        private void btnThoatNguyenLieuKho_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiemNguyenLieuKho_Click_1(object sender, EventArgs e)
        {
            ShowTimKiem(txbMaNguyenLieuTimKiemKho.Text);
        }

        private void btnThemNguyenLieuKho_Click_1(object sender, EventArgs e)
        {
            fThemNguyenLieuKho themnl = new fThemNguyenLieuKho();
            themnl.ShowDialog();
            livNguyenLieuKho.Items.Clear();
            int i = 1;
            List<NguyenLieuKho> nguyenlieukholist = NguyenLieuKhoDAO.Instance.LoadNguyenLieuList();
            foreach (NguyenLieuKho item in nguyenlieukholist)
            {
                ListViewItem lvi = new ListViewItem(i.ToString());
                lvi.SubItems.Add(item.MaNguyenLieu);
                lvi.SubItems.Add(item.TenNguyenLieu);
                string a = item.NgayNhapNguyenLieu;
                string[] _a = a.Substring(0, a.IndexOf(" ")).Split('/');
                lvi.SubItems.Add(_a[1] + "/" + _a[0] + "/" + _a[2]);
                lvi.SubItems.Add(item.NguoiNhapNguyenLieu);
                livNguyenLieuKho.Items.Add(lvi);
                i++;
            }

        }
    }
}

