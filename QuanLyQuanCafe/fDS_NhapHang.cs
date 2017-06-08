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
    public partial class fDS_NhapHang : Form
    {
        public fDS_NhapHang()
        {
            InitializeComponent();
            LoadDS_NhapHangList();
        }


        #region Methods
        
        void LoadDS_NhapHangList()
        {
            int i = 1;
            List<DS_NhapHang> monanlist = DS_NhapHangDAO.Instance.LoadDS_NhapHangList();
            foreach (DS_NhapHang item in monanlist)
            {
                ListViewItem lvi = new ListViewItem(item.MaNguyenLieu.ToString());
                lvi.SubItems.Add(item.TenNguyenLieu.ToString());
                lvi.SubItems.Add(item.SoLuong.ToString());
                lvi.SubItems.Add(item.DonViTinh.ToString());
                lvi.SubItems.Add(item.NguoiNhap.ToString());
                lvi.SubItems.Add(item.DonViTinh.ToString());
                livDSNH.Items.Add(lvi);
                i++;
            }



        }


        #endregion


        #region Events
        private void btnThoatDSNH_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void btnThemDS_NH_Click(object sender, EventArgs e)
        {

        }
    }
}
