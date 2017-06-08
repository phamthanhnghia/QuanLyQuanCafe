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
    public partial class fKiemKeNguyenLieuTonKho : Form
    {
        public fKiemKeNguyenLieuTonKho()
        {
            InitializeComponent();
            AcceptButton = btnTKtheoMNL;
            LoadKiemKe();
        }
        #region Method

        void LoadKiemKe()
        {
            int i = 1;
            List<KiemKeKho> kiemkekholist = KiemKeKhoDAO.Instance.LoadKiemKeList(dtKKKHO.Value.ToString());
            foreach (KiemKeKho item in kiemkekholist)
            {
                ListViewItem lvi = new ListViewItem(i.ToString());
                lvi.SubItems.Add(item.MaNguyenLieu);
                lvi.SubItems.Add(item.TenNguyenLieu);
                lvi.SubItems.Add(item.SoLuong.ToString());
                lvi.SubItems.Add(item.DonViTinh);
                lvi.SubItems.Add(item.TenTaiKhoan);
                livKiemKeKho.Items.Add(lvi);
                i++;
            }
        }

        void ShowKiemKe()
        {
            txbMaNguyenLieuKK.Text = livKiemKeKho.SelectedItems[0].SubItems[1].Text;
            txbTenNguyenLieuKK.Text = livKiemKeKho.SelectedItems[0].SubItems[2].Text;
            txbSoLuongKK.Text = livKiemKeKho.SelectedItems[0].SubItems[3].Text;
            txbDVTKK.Text = livKiemKeKho.SelectedItems[0].SubItems[4].Text;

        }
        void ShowTimKiem(string MaNguyenLieuTK)
        {
            bool kt = false;
            List<KiemKeKho> kiemkekholist = KiemKeKhoDAO.Instance.LoadKiemKeList(dtKKKHO.Value.ToString());
            foreach (KiemKeKho item in kiemkekholist)
            {
                if (MaNguyenLieuTK == item.MaNguyenLieu)
                {
                    txbMaNguyenLieuKK.Text = item.MaNguyenLieu;
                    txbTenNguyenLieuKK.Text = item.TenNguyenLieu;
                    txbSoLuongKK.Text = item.SoLuong.ToString();
                    txbDVTKK.Text = item.DonViTinh;
                    kt = true;
                    break;
                }
            }
            if (kt == false)
                MessageBox.Show("Mã Nguyên Liệu Không Tồn Tại, Vui Lòng Kiểm Tra Lại !", "Thông Báo");

        }

        #endregion

        #region Events
        #endregion
        private void btnThoatKiemKe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void livKiemKeKho_Click(object sender, EventArgs e)
        {
            ShowKiemKe();

        }

        public string liv { get; set; }


        private void dtKKKHO_ValueChanged(object sender, EventArgs e)
        {
            livKiemKeKho.Items.Clear();
            int i = 1;
            List<KiemKeKho> kiemkekholist = KiemKeKhoDAO.Instance.LoadKiemKeList(dtKKKHO.Value.ToString());
            foreach (KiemKeKho item in kiemkekholist)
            {
                ListViewItem lvi = new ListViewItem(i.ToString());
                lvi.SubItems.Add(item.MaNguyenLieu);
                lvi.SubItems.Add(item.TenNguyenLieu);
                lvi.SubItems.Add(item.SoLuong.ToString());
                lvi.SubItems.Add(item.DonViTinh);
                lvi.SubItems.Add(item.TenTaiKhoan);
                livKiemKeKho.Items.Add(lvi);
                i++;
            }
        }

        private void btnThoatKiemKe_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTKtheoMNL_Click_1(object sender, EventArgs e)
        {
            ShowTimKiem(txbMNLTK.Text.ToString().Trim());
        }
    }
}

