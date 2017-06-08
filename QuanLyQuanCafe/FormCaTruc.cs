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
    public partial class FormCaTruc : Form
    {
        public FormCaTruc()
        {
            InitializeComponent();
        }

        private void FormCaTruc_Load(object sender, EventArgs e)
        {
            LoadFormCaTruc();
        }
        void LoadFormCaTruc()
        {
            dgvCaTruc.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM CATRUC");
            clearTextBox();
            caTrucBinding();
        }
        void clearTextBox()
        {
            txtMACT.DataBindings.Clear();
            txtBATDAU.DataBindings.Clear();
            txtKETTHUC.DataBindings.Clear();
            txtTENCA.DataBindings.Clear();
            txtTIENCHINHTHUC.DataBindings.Clear();
            txtTIENTHOIVU.DataBindings.Clear();
        }
        void caTrucBinding()
        {
            txtMACT.DataBindings.Add(new Binding("Text", dgvCaTruc.DataSource, "MACT"));
            txtBATDAU.DataBindings.Add(new Binding("Text", dgvCaTruc.DataSource, "BATDAU"));
            txtKETTHUC.DataBindings.Add(new Binding("Text", dgvCaTruc.DataSource, "KETTHUC"));
            txtTENCA.DataBindings.Add(new Binding("Text", dgvCaTruc.DataSource, "TENCA"));
            txtTIENCHINHTHUC.DataBindings.Add(new Binding("Text", dgvCaTruc.DataSource, "TIENCHINHTHUC"));
            txtTIENTHOIVU.DataBindings.Add(new Binding("Text", dgvCaTruc.DataSource, "TIENTHOIVU"));
        }
        //
        

        private void Button1_Click_1(object sender, EventArgs e)
        {
            CaTrucDAO.Instance.UpdateCATRUC(Convert.ToInt32(txtMACT.Text), txtTENCA.Text, txtBATDAU.Text, txtKETTHUC.Text, Convert.ToInt32(txtTIENCHINHTHUC.Value), Convert.ToInt32(txtTIENTHOIVU.Value));
            LoadFormCaTruc();
        }

    }
}
