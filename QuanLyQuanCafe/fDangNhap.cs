using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using QuanLyQuanCafe.DTO;
using QuanLyQuanCafe.DAO; 

namespace QuanLyQuanCafe
{
    public partial class fDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string TenDanhNhap = tbUserName.Text;
            string MatKhau = tbPass.Text;
            TaiKhoanDTO TaiKhoanDangNhap = TaiKhoanDAO.Instance.getTaiKhoanbyUserName(TenDanhNhap);
            if (TaiKhoanDangNhap != null && MatKhau==TaiKhoanDangNhap.MATKHAU)
            {
                fGiaoDien f = new fGiaoDien(TaiKhoanDangNhap);
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Mật khẩu hoặc tài khoản đăng nhập không đúng !", "Thông báo");
            }
        }

        private void fDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if(XtraMessageBox.Show("Bạn có thật sự muốn thoát chương trình","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)!= System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel=true;
            }
            Application.ExitThread();
        }

        private void fDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
