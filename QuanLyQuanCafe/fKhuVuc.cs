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
    public partial class fKhuVuc : DevExpress.XtraEditors.XtraForm
    {
        BindingSource AreaList = new BindingSource();
        public fKhuVuc()
        {
            InitializeComponent();
            LoadArea();
        }

        void LoadArea()
        {
            dgvArea.DataSource = AreaList;
            GetListArea();
            AddAreaBinding();
        }
        void GetListArea()
        {
            AreaList.DataSource = KhuVucDAO.Instance.GetListArea();
        }
        void AddAreaBinding()
        {
            txtIDArea.DataBindings.Add(new Binding("Text", dgvArea.DataSource, "MAKV"));
            txbNameArea.DataBindings.Add(new Binding("Text", dgvArea.DataSource, "TENKV"));
           
        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            GetListArea();
        }

        private event EventHandler insertArea;
        public event EventHandler InsertArea
        {
            add { insertArea += value; }
            remove { insertArea -= value; }
        }

        private event EventHandler deleteArea;
        public event EventHandler DeleteArea
        {
            add { deleteArea += value; }
            remove { deleteArea -= value; }
        }

        private event EventHandler updateArea;
        public event EventHandler UpdateArea
        {
            add { updateArea += value; }
            remove { updateArea -= value; }
        }

        

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string TenKV = txbNameArea.Text;


            if (KhuVucDAO.Instance.InsertArea(TenKV))
            {
                XtraMessageBox.Show("Thêm khu vực thành công", "Thông báo");
                GetListArea();
                if (insertArea != null)
                    insertArea(this, new EventArgs());
            }
            else
            {
                XtraMessageBox.Show("Không thêm được khu vực", "Thông báo");

            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            string name = txbNameArea.Text;

            int id = Convert.ToInt32(txtIDArea.Text);

            if (KhuVucDAO.Instance.UpdateArea(id, name))
            {
                XtraMessageBox.Show("Sửa khu vực thành công", "Thông báo");

                GetListArea();
                if (updateArea != null)
                    updateArea(this, new EventArgs());
            }
            else
            {
                XtraMessageBox.Show("Không sửa được khu vực", "Thông báo");

            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDArea.Text);

            if (MonAnDAO.Instance.DeleteFood(id))
            {
                XtraMessageBox.Show("Xóa khu vực thành công", "Thông báo");

                GetListArea();
                if (deleteArea != null)
                    deleteArea(this, new EventArgs());
            }
            else
            {
                XtraMessageBox.Show("Không xóa được khu vực", "Thông báo");

            }
        }

    }
}