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
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe
{
    public partial class fMonAn : DevExpress.XtraEditors.XtraForm
    {
        BindingSource foodList = new BindingSource();//Dung source chung
        public fMonAn()
        {
            InitializeComponent();
            LoadFood();
        }
        void LoadFood()
        {
            dtgvFood.DataSource = foodList;
            LoadListFood1();
            AddFoodBinding();
            LoadCatagoryintoCombo(cbType);
        }
        private void LoadDanhMucintoComb(System.Windows.Forms.ComboBox cbType)
        {
            throw new NotImplementedException();
        }

        public int MaMA { get; set; }

        private void btnSee_Click(object sender, EventArgs e)
        {
            LoadListFood1();
        }

        void LoadListFood1()
        {
            foodList.DataSource = MonAnDAO.Instance.GetListFood();

        }

        void AddFoodBinding()// ki thuật binding để hiển thị datagridview ra txt
        {
            txbFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "TENMA", true, DataSourceUpdateMode.Never));
            txbIDFood.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "MAMA", true, DataSourceUpdateMode.Never));
            nmPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "DonGia", true, DataSourceUpdateMode.Never));
            txbDVT.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "DVT", true, DataSourceUpdateMode.Never));

        }

        void LoadCatagoryintoCombo(System.Windows.Forms.ComboBox cb)//Load danh mục trong combobox
        {
            cb.DataSource = DanhMucDAO.Instance.LayDanhSachDanhMuc();
            cb.DisplayMember = "TENLOAI";
        }


        private void fMonAn_Load(object sender, EventArgs e)
        {

        }

        private void txbIDFood_TextChanged(object sender, EventArgs e)// hiển thị loại món ăn theo ID food
        {

            if (dtgvFood.SelectedCells.Count > 0)
            {
                int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["MALOAI"].Value;

                LoaiMonDTO LoaiMA = DanhMucDAO.Instance.LayDanhSachLoaiMonAnTheoID(id);

                cbType.SelectedItem = LoaiMA;

                int index = -1;
                int i = 0;
                foreach (LoaiMonDTO item in cbType.Items)
                {
                    if (item.TenLoai == LoaiMA.TenLoai)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }

                cbType.SelectedIndex = index;

            }
        }

        #region event

        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }
        #endregion
      

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string TenMA = txbFoodName.Text;
            int MALOAI = (cbType.SelectedItem as LoaiMonDTO).MALOAI;
            float DonGia = (float)nmPrice.Value;
            string DVT = txbDVT.Text;

            if (MonAnDAO.Instance.InsertFood(TenMA, MALOAI, DonGia, DVT))
            {
                XtraMessageBox.Show("Thêm món thành công", "Thông báo");
                LoadListFood1();
                if (insertFood != null)
                    insertFood(this, new EventArgs());
            }
            else
            {
                XtraMessageBox.Show("Không thêm được thức ăn", "Thông báo");

            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbIDFood.Text);

            if (MonAnDAO.Instance.DeleteFood(id))
            {
                XtraMessageBox.Show("Xóa món thành công", "Thông báo");

                LoadListFood1();
                if (deleteFood != null)
                    deleteFood(this, new EventArgs());
            }
            else
            {
                XtraMessageBox.Show("Có lỗi khi xóa thức ăn", "Thông báo");

            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int categoryID = (cbType.SelectedItem as LoaiMonDTO).MALOAI;
            float price = (float)nmPrice.Value;
            int id = Convert.ToInt32(txbIDFood.Text);
            string DVT = txbDVT.Text;
            if (MonAnDAO.Instance.UpdateFood(id, name, categoryID, price, DVT))
            {
                XtraMessageBox.Show("Sửa món thành công", "Thông báo");

                LoadListFood1();
                if (updateFood != null)
                    updateFood(this, new EventArgs());
            }
            else
            {
                XtraMessageBox.Show("Có lỗi khi sửa thức ăn", "Thông báo");

            }
        }

    }
}