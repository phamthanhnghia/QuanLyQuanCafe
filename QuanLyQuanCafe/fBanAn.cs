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
using DevExpress.SpreadsheetSource.Implementation;
using QuanLyQuanCafe.DTO;
using QuanLyQuanCafe.DAO;

namespace QuanLyQuanCafe
{
    public partial class fBanAn : DevExpress.XtraEditors.XtraForm
    {
        BindingSource foodList = new BindingSource();
        public fBanAn()
        {
            InitializeComponent();
            LoadTable();
        }
        void LoadTable()
        {
            dgvTable.DataSource = foodList;
            GetListTable();
            AddAreaBinding();
            LoadAreaintoCombo(cbArea);
        }
        void GetListTable()
        {
          foodList.DataSource = BanAnDAO.Instance.GetTableList();
        }
        void AddAreaBinding()
        {
            txbID.DataBindings.Clear();
            txbTenBA.DataBindings.Clear();
            txbTrangThai.DataBindings.Clear();
            txbID.DataBindings.Add(new Binding("Text", dgvTable.DataSource, "MABA"));
            txbTenBA.DataBindings.Add(new Binding("Text", dgvTable.DataSource, "TENBA"));
            txbTrangThai.DataBindings.Add(new Binding("Text", dgvTable.DataSource, "Trangthai"));

        }
        void LoadAreaintoCombo(System.Windows.Forms.ComboBox cb)//Load danh mục trong combobox
        {
            cb.DataSource = KhuVucDAO.Instance.GetListArea();
            cb.DisplayMember = "TENKV";
        }
        

        private void btnWatch_Click(object sender, EventArgs e)
        {
            GetListTable();
        }
        

        #region event
        private event EventHandler insertBanAn;
        public event EventHandler InsertBanAn
        {
            add { insertBanAn += value; }
            remove { insertBanAn -= value; }
        }

        private event EventHandler deleteBanAn;
        public event EventHandler DeleteBanAn
        {
            add { deleteBanAn += value; }
            remove { deleteBanAn -= value; }
        }

        private event EventHandler updateBanAn;
        public event EventHandler UpdateBanAn
        {
            add { updateBanAn += value; }
            remove { updateBanAn -= value; }
        }
        #endregion

        #region Thêm Xóa Sửa BUTTON
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string TenBA = txbTenBA.Text;
            string TrangThai = txbTrangThai.Text;
            int MAKV = (cbArea.SelectedItem as KhuVucDTO).MAKV;

            if (BanAnDAO.Instance.InsertTable(TenBA,TrangThai,MAKV))
            {
                XtraMessageBox.Show("Thêm bàn ăn thành công", "Thông báo");
                GetListTable();
                if (insertBanAn != null)
                    insertBanAn(this, new EventArgs());
            }
            else
            {
                XtraMessageBox.Show("Không thêm được bàn ăn", "Thông báo");

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbID.Text);

            if (BanAnDAO.Instance.DeleteTable(id) == true)
            {
                XtraMessageBox.Show("Xóa thành công", "Thông báo");

                GetListTable();
                if (deleteBanAn != null)
                    deleteBanAn(this, new EventArgs());
            }
            else
            {
                XtraMessageBox.Show("Không xóa được ", "Thông báo");

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string name = txbTenBA.Text;
            string TrangThai = txbTrangThai.Text;
            int id = Convert.ToInt32(txbID.Text);
            int MAKV = (cbArea.SelectedItem as KhuVucDTO).MAKV;
            if (BanAnDAO.Instance.UpdateTable(id,name,TrangThai,MAKV))
            {
                XtraMessageBox.Show("Sửa thành công", "Thông báo");

                GetListTable();
                if (updateBanAn != null)
                    updateBanAn(this, new EventArgs());
            }
            else
            {
                XtraMessageBox.Show("Không sửa được", "Thông báo");

            }
        }
        #endregion

        private void txbID_TextChanged(object sender, EventArgs e) //hiển thị khu vực theo Mã bàn
        {
            if (dgvTable.SelectedCells.Count > 0)
            {
                int id = (int)dgvTable.SelectedCells[0].OwningRow.Cells["MAKV"].Value;

                KhuVucDTO LoaikhuVuc = KhuVucDAO.Instance.LayDanhSachKhuVucTheoID(id);

                cbArea.SelectedItem = LoaikhuVuc;

                int index = -1;
                int i = 0;
                foreach (KhuVucDTO item in cbArea.Items)
                {
                    if (item.TenKV == LoaikhuVuc.TenKV)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }

                cbArea.SelectedIndex = index;

            }
        }

        private void fBanAn_Load(object sender, EventArgs e)
        {

        }

    }
}