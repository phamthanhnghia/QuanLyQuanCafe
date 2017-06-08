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
    public partial class FormChucVu : Form
    {
        public FormChucVu()
        {
            InitializeComponent();
        }

        private void FormChucVu_Load(object sender, EventArgs e)
        {
            LoadFormChucVu();
        }
        void LoadFormChucVu()
        {
            dgvChucVu.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM CHUCVU");
            clearTextBox();
            chucVuBinding();
        }
        void clearTextBox()
        {
            txtMACV.DataBindings.Clear();
            txtTENCV.DataBindings.Clear();
            numberHELUONG.DataBindings.Clear();
        }
        void chucVuBinding()
        {
            txtMACV.DataBindings.Add(new Binding("Text", dgvChucVu.DataSource, "MACV"));
            txtTENCV.DataBindings.Add(new Binding("Text", dgvChucVu.DataSource, "TENCV"));
            numberHELUONG.DataBindings.Add(new Binding("Text", dgvChucVu.DataSource, "HELUONG"));
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            double HELUONG = Convert.ToDouble(numberHELUONG.Text);
            int MACV = Convert.ToInt32(txtMACV.Text);
            ChucVuDAO.Instance.UpdateChucVu(MACV, HELUONG);
            LoadFormChucVu();
        }
    }
}

