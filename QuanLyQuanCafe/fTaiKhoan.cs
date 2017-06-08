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
using QuanLyQuanCafe.DAO;

namespace QuanLyQuanCafe
{
    public partial class fTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public fTaiKhoan()
        {
            InitializeComponent();
            LoadAccountList();

        }
        void LoadAccountList()
        {
            string query = "EXEC dbo.TAIKHOANLIST @TenTK ";

            gdChiTieu.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { "staff" });

        }
            
           


        private void simpleButton15_Click(object sender, EventArgs e)
        {
            fChangePass f = new fChangePass(txtTENTK.Text, cbbLOAITK.Text);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void fTaiKhoan_Load(object sender, EventArgs e)
        {
            loadFormTaiKhoan();
        }

        void loadFormTaiKhoan()
        {
            gdChiTieu.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM TAIKHOAN");
            clearTextBox();
            TaiKhoanBinding();
        }
        void clearTextBox()
        {
            txtTENTK.DataBindings.Clear();
            cbbLOAITK.DataBindings.Clear();
            
        }
        void TaiKhoanBinding()
        {
            txtTENTK.DataBindings.Add(new Binding("Text", gdChiTieu.DataSource, "TENTK"));
            cbbLOAITK.DataBindings.Add(new Binding("Text", gdChiTieu.DataSource, "LOAITK"));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (TaiKhoanDAO.Instance.CheckTENTK(txtTENTK.Text) == true)
            {
                MessageBox.Show("Tên tài khoản trùng!");
            }
            else
            {
                if (!CheckNhapMatKhau())
                {
                    MessageBox.Show("Mật khẩu nhập không khớp hoặc chưa nhập mật khẩu !");
                }
                else
                {
                    TaiKhoanDAO.Instance.InsertTAIKHOAN(txtTENTK.Text, cbbLOAITK.Text, txtMATKHAU.Text);
                    loadFormTaiKhoan();
                }
            }
        }
        bool CheckNhapMatKhau()
        {
            if (string.Equals(txtMATKHAU.Text,txtMATKHAULAI.Text) == true && txtMATKHAU.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM TAIKHOAN WHERE LOAITK = 'Quan li'");
            if (data.Rows.Count > 1)
            {
                TaiKhoanDAO.Instance.DeleteTAIKHOAN(txtTENTK.Text);
                loadFormTaiKhoan();
            }
            else
            {
                MessageBox.Show("Không thể xóa !");
            }
        }
    }
}