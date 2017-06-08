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
    public partial class fChiTieu : DevExpress.XtraEditors.XtraForm
    {
        public fChiTieu()
        {
            InitializeComponent();
        }

        private void fChiTieu_Load(object sender, EventArgs e)
        {
            loadFormChiTieu();
        }
        void loadFormChiTieu()
        {
            cbbNGUOINHAN.Items.Clear();
            txtNGAYLAP.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM NHANVIEN");
            foreach (DataRow item in data.Rows)
            {
                cbbNGUOINHAN.Items.Add(item["HOTEN"]);
            }
            dataGridViewChiTieu.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM PHIEUCHI");
            clearTextBox();
            ChiTieuBinding();
        }
        void clearTextBox()
        {
            txtNOIDUNG.DataBindings.Clear();
            txtMAPC.DataBindings.Clear();
            txtNGAYLAP.DataBindings.Clear();
            txtSOTIEN.DataBindings.Clear();
            txtGHICHU.DataBindings.Clear();
            cbbNGUOINHAN.DataBindings.Clear();
        }
        void ChiTieuBinding()
        {
            txtNOIDUNG.DataBindings.Add(new Binding("Text", dataGridViewChiTieu.DataSource, "NOIDUNG"));
            txtMAPC.DataBindings.Add(new Binding("Text", dataGridViewChiTieu.DataSource, "MAPC"));
            txtNGAYLAP.DataBindings.Add(new Binding("Text", dataGridViewChiTieu.DataSource, "NGAYLAP"));
            txtSOTIEN.DataBindings.Add(new Binding("Text", dataGridViewChiTieu.DataSource, "SOTIEN"));
            txtGHICHU.DataBindings.Add(new Binding("Text", dataGridViewChiTieu.DataSource, "GHICHU"));
            cbbNGUOINHAN.DataBindings.Add(new Binding("Text", dataGridViewChiTieu.DataSource, "NGUOINHAN"));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string NOIDUNG = txtNOIDUNG.Text;
            string GHICHU = txtGHICHU.Text;
            string NGUOINHAN = cbbNGUOINHAN.Text;
            ChiTieuDAO.Instance.InsertChiTieu(NOIDUNG, Convert.ToInt32(txtSOTIEN.Value),GHICHU,NGUOINHAN);
            loadFormChiTieu();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string NOIDUNG = txtNOIDUNG.Text;
            string GHICHU = txtGHICHU.Text;
            string NGUOINHAN = cbbNGUOINHAN.Text;
            ChiTieuDAO.Instance.UpdateChiTieu(Convert.ToInt32(txtMAPC.Text),NOIDUNG, Convert.ToInt32(txtSOTIEN.Value), GHICHU, NGUOINHAN);
            loadFormChiTieu();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ChiTieuDAO.Instance.DeleteChiTieu(Convert.ToInt32(txtMAPC.Text));
            loadFormChiTieu();
        }
    }
}