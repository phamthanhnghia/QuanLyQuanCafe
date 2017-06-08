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
    public partial class fThongKe : DevExpress.XtraEditors.XtraForm
    {
        private DataTable dataChiTieu;
        public fThongKe()
        {
            InitializeComponent();
        }

        private void fThongKe_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            dataChiTieu = DataProvider.Instance.ExecuteQuery("SELECT * FROM PHIEUCHI WHERE NGAYLAP >= '"+dateTimePickerBATDAU.Text+"' AND NGAYLAP <= '"+dateTimePickerKETTHUC.Text+"'");
            dataGridViewChiTieu.DataSource = dataChiTieu;
        }

        private void btIndanhsach_Click(object sender, EventArgs e)
        {
            FORMREPORT.fromRePortChiTieu f = new FORMREPORT.fromRePortChiTieu(dataChiTieu);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }


        private void btnDoanhSoThongKe_Click_1(object sender, EventArgs e)
        {
            dgvDoanhSo.DataSource = ThongKeDAO.Instance.ThongKeDoanhSo(dateTimePickerDoanhSoBatDau.Text, dateTimePickerDoanhSoKetThuc.Text);
        }

        private void btnInBaoCaoDoanhSo_Click_1(object sender, EventArgs e)
        {
            if (ThongKeDAO.Instance.ThongKeDoanhSo(dateTimePickerDoanhSoBatDau.Text, dateTimePickerDoanhSoKetThuc.Text) != null)
            {
                FORMREPORT.fromRePortDoanhSo f = new FORMREPORT.fromRePortDoanhSo(ThongKeDAO.Instance.ThongKeDoanhSo(dateTimePickerDoanhSoBatDau.Text, dateTimePickerDoanhSoKetThuc.Text));
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Chưa có dữ liệu !");
            }
        }

        private void simplebtnChiTien_Click(object sender, EventArgs e)
        {
            if (dataChiTieu != null)
            {
                FORMREPORT.fromRePortChiTieu f = new FORMREPORT.fromRePortChiTieu(dataChiTieu);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Chưa có dữ liệu !");
            }
            
        }


        
    }
}