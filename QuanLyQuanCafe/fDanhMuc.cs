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
    public partial class fDanhMuc : DevExpress.XtraEditors.XtraForm
    {
        BindingSource DanhMucList = new BindingSource();
        public fDanhMuc()
        {
            InitializeComponent();
            LoadDanhMuc();

        }


        void LoadDanhMuc()
        {
            dgvLoaiMonAn.DataSource = DanhMucList;
            GetListCatagory();
            AddCatagoryBinding();
        }
        void GetListCatagory()
        {
            DanhMucList.DataSource = DanhMucDAO.Instance.LayDanhSachDanhMuc();
        }
        void AddCatagoryBinding()
        {
            txbIDLoaiMon.DataBindings.Clear();
            txbNameTypeFood.DataBindings.Clear();
            txbIDLoaiMon.DataBindings.Add(new Binding("Text", dgvLoaiMonAn.DataSource, "MALOAI", true, DataSourceUpdateMode.Never));
            txbNameTypeFood.DataBindings.Add(new Binding("Text", dgvLoaiMonAn.DataSource, "TENLOAI", true, DataSourceUpdateMode.Never));
        }
        //Thêm, xóa sửa danh mục
        #region event
        private void btnSee_Click(object sender, EventArgs e)
        {
            GetListCatagory();
        }

        private event EventHandler insertDanhMuc;
        public event EventHandler InsertDanhMuc
        {
            add { insertDanhMuc += value; }
            remove { insertDanhMuc -= value; }
        }

        private event EventHandler deleteDanhMuc;
        public event EventHandler DeleteDanhMuc
        {
            add { deleteDanhMuc += value; }
            remove { deleteDanhMuc -= value; }
        }

        private event EventHandler updateDanhMuc;
        public event EventHandler UpdateDanhMuc
        {
            add { updateDanhMuc += value; }
            remove { updateDanhMuc -= value; }
        }

        #endregion

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string TenLOAI = txbNameTypeFood.Text;


            if (DanhMucDAO.Instance.InsertDanhMuc(TenLOAI))
            {
                XtraMessageBox.Show("Thêm loại món thành công", "Thông báo");
                LoadDanhMuc();
                if (insertDanhMuc != null)
                    insertDanhMuc(this, new EventArgs());
            }
            else
            {
                XtraMessageBox.Show("Không thêm được loại món", "Thông báo");

            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbIDLoaiMon.Text);

            if (DanhMucDAO.Instance.DeleteDanhMuc(id))
            {
                XtraMessageBox.Show("Xóa loại món thành công", "Thông báo");

                LoadDanhMuc();
                if (deleteDanhMuc != null)
                    deleteDanhMuc(this, new EventArgs());
            }
            else
            {
                XtraMessageBox.Show("Không xóa được loại món", "Thông báo");

            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {

            string name = txbNameTypeFood.Text;

            int id = Convert.ToInt32(txbIDLoaiMon.Text);

            if (DanhMucDAO.Instance.UpdateDanhMuc(id, name))
            {
                XtraMessageBox.Show("Sửa loại món thành công", "Thông báo");

                LoadDanhMuc();
                if (updateDanhMuc != null)
                    updateDanhMuc(this, new EventArgs());
            }
            else
            {
                XtraMessageBox.Show("Không sửa được loại món", "Thông báo");

            }
        }


    }
}