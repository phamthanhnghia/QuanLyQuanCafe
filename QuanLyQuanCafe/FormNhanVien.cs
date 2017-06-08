using Microsoft.Reporting.WinForms;
using QuanLyQuanCafe.DAO;
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
    public partial class FormNhanVien : Form
    {
        private DataTable data;
        public FormNhanVien()
        {
            InitializeComponent();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            //{
            //    e.Cancel = true;
            //}
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            loadFormNhanVien();
        }

        // hàm sử dụng
        void loadFormNhanVien()
        {
            string query = "SELECT MANV,HOTEN,PHAI,NGAYSINH,CMND,DIACHI,DIENTHOAI,LOAINV,TENCV  FROM NHANVIEN, CHUCVU WHERE NHANVIEN.MACV = CHUCVU.MACV AND NHANVIEN.TRANGTHAI = 1 ";
            dgvDanhSach.DataSource = DataProvider.Instance.ExecuteQuery(query);
            data = DataProvider.Instance.ExecuteQuery(query);
            clearTextBox();
            NhanVienBinding();
        }
        int maCHUCVU(string CHUCVU)
        {
            if(CHUCVU == "Thu Ngân")
            {
                return 2;
            }
            if (CHUCVU == "Pha Chế")
            {
                return 3;
            }
            if (CHUCVU == "Quản Lý")
            {
                return 4;
            }
            return 1;
        }
        void clearTextBox()
        {
            txtMANV.DataBindings.Clear();
            txtHOTEN.DataBindings.Clear();
            txtPHAI.DataBindings.Clear();
            txtNGAYSINH.DataBindings.Clear();
            txtDIACHI.DataBindings.Clear();
            txtDIENTHOAI.DataBindings.Clear();
            txtLOAINV.DataBindings.Clear();
            txtCMND.DataBindings.Clear();
            txtCHUCVU.DataBindings.Clear();
        }
        void NhanVienBinding()
        {
            txtMANV.DataBindings.Add(new Binding("Text", dgvDanhSach.DataSource, "MANV"));
            txtHOTEN.DataBindings.Add(new Binding("Text", dgvDanhSach.DataSource, "HOTEN"));
            txtPHAI.DataBindings.Add(new Binding("Text", dgvDanhSach.DataSource, "PHAI"));
            txtNGAYSINH.DataBindings.Add(new Binding("Text", dgvDanhSach.DataSource, "NGAYSINH"));
            txtDIACHI.DataBindings.Add(new Binding("Text", dgvDanhSach.DataSource, "DIACHI"));
            txtDIENTHOAI.DataBindings.Add(new Binding("Text", dgvDanhSach.DataSource, "DIENTHOAI"));
            txtLOAINV.DataBindings.Add(new Binding("Text", dgvDanhSach.DataSource, "LOAINV"));
            txtCMND.DataBindings.Add(new Binding("Text", dgvDanhSach.DataSource, "CMND"));
            txtCHUCVU.DataBindings.Add(new Binding("Text", dgvDanhSach.DataSource, "TENCV"));
        }
        

        private void indanhsach_Click(object sender, EventArgs e)
        {
            ;
        }

       

        private void btnThemNhanVien_Click_1(object sender, EventArgs e)
        {
            int MACV = maCHUCVU(txtCHUCVU.Text);
            string HOTEN = txtHOTEN.Text;
            string PHAI = txtPHAI.Text;
            string NGAYSINH = txtNGAYSINH.Text;
            string DIACHI = txtDIACHI.Text;
            string DIENTHOAI = txtDIENTHOAI.Text;
            string LOAINV = txtLOAINV.Text;
            string CMND = txtCMND.Text;
            if (HOTEN == null || PHAI == null || NGAYSINH == null || CMND == null || DIACHI == null || DIENTHOAI == null || LOAINV == null)
            {
                MessageBox.Show("Bạn phải nhập đầy đủ các thông tin",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                NhanVienDAO.Instance.InsertNhanVien(MACV, HOTEN, PHAI, NGAYSINH, CMND, DIACHI, DIENTHOAI, LOAINV);
                loadFormNhanVien();
            }
        }

        private void btnXoaNhanVien_Click_1(object sender, EventArgs e)
        {
            int MANV = Convert.ToInt32(txtMANV.Text);
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này ?", "Thông báo !", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                NhanVienDAO.Instance.DeleteNhanVien(MANV);
                loadFormNhanVien();

            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

       
        private void btnSuaNhanVien_Click_1(object sender, EventArgs e)
        {
            int MANV = Convert.ToInt32(txtMANV.Text);
            int MACV = maCHUCVU(txtCHUCVU.Text);
            string HOTEN = txtHOTEN.Text;
            string PHAI = txtPHAI.Text;
            string NGAYSINH = txtNGAYSINH.Text;
            string DIACHI = txtDIACHI.Text;
            string DIENTHOAI = txtDIENTHOAI.Text;
            string LOAINV = txtLOAINV.Text;
            string CMND = txtCMND.Text;
            NhanVienDAO.Instance.UpdateNhanVien(MANV, MACV, HOTEN, PHAI, NGAYSINH, CMND, DIACHI, DIENTHOAI, LOAINV);
            loadFormNhanVien();
        }

        private void indanhsach_Click_1(object sender, EventArgs e)
        {
            FORMREPORT.formRePortNhanVien f = new FORMREPORT.formRePortNhanVien(data);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }



    }
}
