using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe
{
    public partial class fGiaoDien : DevExpress.XtraEditors.XtraForm
    {
        private TaiKhoanDTO TaiKhoanDangNhap;
        public fGiaoDien(TaiKhoanDTO tk)
        {
            InitializeComponent();
            this.TaiKhoanDangNhap = tk;
            PhanQuyen(tk);
        }

        public fGiaoDien()
        {
            // TODO: Complete member initialization
        }
        private void PhanQuyen(TaiKhoanDTO TaiKhoan)
        {
            switch(TaiKhoan.LOAITK)
            {
                case "Quan li":
                    //khong cho click
                    
                    // An di
                    //tlChiTieu.Visible=false;
                    break;
                case "Thu ngan":
                    tlThongke.Enabled = false; 
                    tlTaiKhoan.Enabled = false;
                    tlCaTruc.Enabled = false;
                    tlDiemDanh.Enabled = false;
                    tlTienLuong.Enabled = false;
                    tlNhanVien.Enabled = false;
                    tlNhapHang.Enabled = false;
                    tlHangTonKho.Enabled = false;
                    tlKiemKe.Enabled = false;
                    tlDanhMuc.Enabled = false;
                    tlBanAn.Enabled = false;
                    tlMonAn.Enabled = false;
                    tlChucVu.Enabled = false;
                    break;
                case "Nhan vien":
                    tlChiTieu.Enabled = false;
                    tlThongke.Enabled = false;
                    tlPayBill.Enabled = false;
                    tlTaiKhoan.Enabled = false;
                    tlCaTruc.Enabled = false;
                    tlDiemDanh.Enabled = false;
                    tlTienLuong.Enabled = false;
                    tlNhanVien.Enabled = false;
                    tlNhapHang.Enabled = false;
                    tlHangTonKho.Enabled = false;
                    tlKiemKe.Enabled = false;
                    tlDanhMuc.Enabled = false;
                    tlBanAn.Enabled = false;
                    tlMonAn.Enabled = false;
                    tlChucVu.Enabled = false;
                    break;
            }
        }
        private void tileItem5_ItemClick(object sender, TileItemEventArgs e)
        {
            fOderStaff f = new fOderStaff();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void fGiaoDien_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (XtraMessageBox.Show("Bạn có thật sự muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                Application.ExitThread();
            }
            
        }

        private void tlChiTieu_ItemClick(object sender, TileItemEventArgs e)
        {
            fChiTieu f = new fChiTieu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void tlThongke_ItemClick(object sender, TileItemEventArgs e)
        {
            fThongKe f = new fThongKe();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void tlKhuVuc_ItemClick(object sender, TileItemEventArgs e)
        {
            fKhuVuc f = new fKhuVuc();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void tlDanhMuc_ItemClick(object sender, TileItemEventArgs e)
        {
            fDanhMuc f = new fDanhMuc();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void tlMonAn_ItemClick(object sender, TileItemEventArgs e)
        {
            fMonAn f = new fMonAn();
            //f.InsertFood += f_InsertFood;
            //f.DeleteFood += f_DeleteFood;
            //f.UpdateFood += f_UpdateFood;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        /*void f_UpdateFood(object sender, EventArgs e)
        {
            GetListFoodByMALOAI((cbLoaiMon.SelectedItem as LoaiMonDTO).MALOAI);

            if (lvShowFood.Tag != null)
                ShowBill((lvShowFood.Tag as BanAnDTO).MABA);
        }

        private void ShowBill(int p)
        {
            throw new NotImplementedException();
        }

        private void GetListFoodByMALOAI(int p)
        {
            throw new NotImplementedException();
        }

        void f_DeleteFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as BanAnDTO).MABA);
            LoadTable();
        }

        void f_InsertFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as BanAnDTO).MABA);
        }

        */
        private void tlTaiKhoan_ItemClick(object sender, TileItemEventArgs e)
        {
            fTaiKhoan f = new fTaiKhoan();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void tlPayBill_ItemClick(object sender, TileItemEventArgs e)
        {
            fThanhToan f = new fThanhToan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void tlBanAn_ItemClick(object sender, TileItemEventArgs e)
        {
            fBanAn f = new fBanAn();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void tlKiemKe_ItemClick(object sender, TileItemEventArgs e)
        {
            fKiemKeNguyenLieuTonKho f = new fKiemKeNguyenLieuTonKho();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void tlHangTonKho_ItemClick(object sender, TileItemEventArgs e)
        {
            fNguyenLieuKho f = new fNguyenLieuKho();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void tlCaTruc_ItemClick(object sender, TileItemEventArgs e)
        {
            FormCaTruc f = new FormCaTruc();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void tlChucVu_ItemClick(object sender, TileItemEventArgs e)
        {
            FormChucVu f = new FormChucVu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void tlDiemDanh_ItemClick(object sender, TileItemEventArgs e)
        {
            FormChonNgayCaTruc f = new FormChonNgayCaTruc();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void tlNhanVien_ItemClick(object sender, TileItemEventArgs e)
        {
            FormNhanVien f = new FormNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void tlTienLuong_ItemClick(object sender, TileItemEventArgs e)
        {
            FormKiemTraDiemDanh f = new FormKiemTraDiemDanh();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void fGiaoDien_Load(object sender, EventArgs e)
        {

        }

        private void tlNhapHang_ItemClick(object sender, TileItemEventArgs e)
        {
            fDS_NhapHang f = new fDS_NhapHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        //private void fGiaoDien_Load(object sender, EventArgs e)
        //{
            //this.Close();
        //}


    }
}