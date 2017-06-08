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
    public partial class FormThucHienDiemDanh : Form
    {
        public string _ngay;
        public string _catruc;
        public FormThucHienDiemDanh()
        {
            InitializeComponent();
            //this.txtNGAY.Value = ;
        }
        public FormThucHienDiemDanh(string NGAY, string CATRUC)
            : this()
        {
            _ngay = NGAY;
            _catruc = CATRUC;
            this.txtNGAY.Text = NGAY;
            this.txtCATRUC.Text = CATRUC;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void datetimepicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormThucHienDiemDanh_Load(object sender, EventArgs e)
        {
            loadFormDiemDanh();
            //addccbCaTruc();
        }
        void loadFormDiemDanh()
        {
            int MACT = DiemDanhDAO.Instance.maCaTruc(_catruc);

            if (DiemDanhDAO.Instance.checkInsertDiemDanh(_ngay) == 0)
            {
                DiemDanhDAO.Instance.InsertDiemDanh(_ngay);
            }
            int MADD = DiemDanhDAO.Instance.checkInsertDiemDanh(_ngay);
            dgvNVChuaDiemDanh.DataSource = DataProvider.Instance.ExecuteQuery("(SELECT MANV,HOTEN,NGAYSINH,LOAINV,TENCV FROM NHANVIEN, CHUCVU WHERE NHANVIEN.MACV = CHUCVU.MACV AND NHANVIEN.TRANGTHAI = 1) EXCEPT SELECT NHANVIEN.MANV, NHANVIEN.HOTEN, NHANVIEN.NGAYSINH,NHANVIEN.LOAINV,CHUCVU.TENCV FROM NHANVIEN, DIEMDANH , CHITIETTINHCONG, CHUCVU WHERE NHANVIEN.MANV = CHITIETTINHCONG.MANV AND CHITIETTINHCONG.MADD = DIEMDANH.MADD AND NHANVIEN.MACV = CHUCVU.MACV AND CHITIETTINHCONG.MACT = " + MACT + " AND DIEMDANH.MADD = " + MADD);
            dgvNVDaDiemDanh.DataSource = DataProvider.Instance.ExecuteQuery("SELECT NHANVIEN.MANV, HOTEN, NGAYSINH,LOAINV,TENCV FROM NHANVIEN, DIEMDANH, CHITIETTINHCONG, CHUCVU WHERE NHANVIEN.MANV = CHITIETTINHCONG.MANV AND CHITIETTINHCONG.MADD = DIEMDANH.MADD AND NHANVIEN.MACV = CHUCVU.MACV AND CHITIETTINHCONG.MACT = " + MACT + " AND DIEMDANH.MADD =" + MADD);
            clearBindingDiemDanh();
            DiemDanhBinding();
        }

        private void dgvNVChuaDiemDanh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void điểmDanhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        void DiemDanhBinding()
        {
            txtMANV.DataBindings.Add(new Binding("Text", dgvNVChuaDiemDanh.DataSource, "MANV"));
        }
        void clearBindingDiemDanh()
        {
            txtMANV.DataBindings.Clear();
        }


        private void txtMANV_TextChanged(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void cbbCaTruc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMANV.Text != "")
            {
                int MANV = Convert.ToInt32(txtMANV.Text);
                int MACT = DiemDanhDAO.Instance.maCaTruc(_catruc);

                if (DiemDanhDAO.Instance.checkInsertDiemDanh(_ngay) == 0)
                {
                    DiemDanhDAO.Instance.InsertDiemDanh(_ngay);
                }
                int MADD = DiemDanhDAO.Instance.checkInsertDiemDanh(_ngay);

                DiemDanhDAO.Instance.insertCHITIETTINHCONG(MADD, MANV, MACT);
                dgvNVChuaDiemDanh.DataSource = DataProvider.Instance.ExecuteQuery("(SELECT MANV,HOTEN,NGAYSINH,LOAINV,TENCV FROM NHANVIEN, CHUCVU WHERE NHANVIEN.MACV = CHUCVU.MACV AND NHANVIEN.TRANGTHAI = 1) EXCEPT SELECT NHANVIEN.MANV, NHANVIEN.HOTEN, NHANVIEN.NGAYSINH,NHANVIEN.LOAINV,CHUCVU.TENCV FROM NHANVIEN, DIEMDANH , CHITIETTINHCONG, CHUCVU WHERE NHANVIEN.MANV = CHITIETTINHCONG.MANV AND CHITIETTINHCONG.MADD = DIEMDANH.MADD AND NHANVIEN.MACV = CHUCVU.MACV AND CHITIETTINHCONG.MACT = " + MACT + " AND DIEMDANH.MADD = " + MADD);
                dgvNVDaDiemDanh.DataSource = DataProvider.Instance.ExecuteQuery("SELECT NHANVIEN.MANV, HOTEN, NGAYSINH,LOAINV,TENCV FROM NHANVIEN, DIEMDANH, CHITIETTINHCONG, CHUCVU WHERE NHANVIEN.MANV = CHITIETTINHCONG.MANV AND CHITIETTINHCONG.MADD = DIEMDANH.MADD AND NHANVIEN.MACV = CHUCVU.MACV AND CHITIETTINHCONG.MACT = " + MACT + " AND DIEMDANH.MADD =" + MADD);
                clearBindingDiemDanh();
                DiemDanhBinding();
            }

        }

    }
}
