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
using QuanLyQuanCafe.DTO;
using QuanLyQuanCafe.DAO;


namespace QuanLyQuanCafe
{
    public partial class fOderStaff : DevExpress.XtraEditors.XtraForm
    {

        public fOderStaff()
        {
            InitializeComponent();
            LoadTable();
            this.tbTime.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            LoadDanhMuc();
            //LoadFoodListByDanhMuc();
        }

        #region DangNhap
        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChangePass F = new fChangePass();
            F.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region HienThiBanAn
        void LoadTable()
        {

            List<BanAnDTO> tableList = OderStaffDAO.Instance.LoadTableList();
            List<BanAnDTO> tableList2 = OderStaffDAO.Instance.LoadTableList2();
            List<BanAnDTO> tableList3 = OderStaffDAO.Instance.LoadTableList3();// lay danh sách table 


            foreach (BanAnDTO item in tableList)
            {
                Button btn = new Button();
                btn.Width = OderStaffDAO.TableWidth;
                btn.Height = OderStaffDAO.TableHeight;
                btn.Text = item.TENBA;
                btn.Tag = item;
                //btn.TextAlign = item.BottomCenter;

                flpSanVuon.Controls.Add(btn);

                DataTable dataHD = DataProvider.Instance.ExecuteQuery("SELECT * FROM HOADON WHERE MABA = '" + item.MABA + "' AND status = " + 0);
                if (dataHD.Rows.Count > 0)
                {
                    btn.BackColor = Color.Aquamarine;
                }
                else
                {
                    btn.BackColor = Color.White;
                }
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.BackgroundImage = Properties.Resources._1_1;
               
                btn.TextAlign = ContentAlignment.BottomRight;
           
                btn.Click += btn_Click;

            }
            foreach (BanAnDTO item in tableList2)
            {
                Button btn = new Button();
                btn.Width = OderStaffDAO.TableWidth;
                btn.Height = OderStaffDAO.TableHeight;
                btn.Text = item.TENBA;
                btn.Tag = item;

                flpSansau.Controls.Add(btn);

                DataTable dataHD = DataProvider.Instance.ExecuteQuery("SELECT * FROM HOADON WHERE MABA = '" + item.MABA + "' AND status = " + 0);
                if (dataHD.Rows.Count > 0)
                {
                    btn.BackColor = Color.Aquamarine;
                }
                else
                {
                    btn.BackColor = Color.White;
                }
                //btn.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Xoan\Downloads\Imagebook\1_1.png");
                btn.BackgroundImage = Properties.Resources._1_1;

                btn.TextAlign = ContentAlignment.BottomRight;
                btn.Click += btn_Click;

            }
            foreach (BanAnDTO item in tableList3)
            {
                Button btn = new Button();
                btn.Width = OderStaffDAO.TableWidth;
                btn.Height = OderStaffDAO.TableHeight;
                btn.Text = item.TENBA;
                btn.Tag = item;

                flpMayLanh.Controls.Add(btn);

                DataTable dataHD = DataProvider.Instance.ExecuteQuery("SELECT * FROM HOADON WHERE MABA = '" + item.MABA + "' AND status = " + 0);
                if (dataHD.Rows.Count > 0)
                {
                    btn.BackColor = Color.Aquamarine;
                }
                else
                {
                    btn.BackColor = Color.White;
                }
                //btn.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Xoan\Downloads\Imagebook\1_1.png");
                btn.BackgroundImage = Properties.Resources._1_1;

                btn.TextAlign = ContentAlignment.BottomRight;
                btn.Click += btn_Click;

            }



        }
        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BanAnDTO).MABA;
            lsvShowBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        #endregion
        void ShowBill(int MABA)
        {
            lsvShowBill.Items.Clear();
            List<MenuDTO> listBillInfo = MenuDAO.Instance.GetListMenuByTable(MABA);

            foreach (QuanLyQuanCafe.DTO.MenuDTO item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.TENMA.ToString());
                lsvItem.SubItems.Add(item.SoLuong.ToString());
                lsvItem.SubItems.Add(item.DonGia.ToString());
                lsvItem.SubItems.Add(item.ThanhTien.ToString());

                lsvShowBill.Items.Add(lsvItem);
            }
            tbMaBan.Text = MABA.ToString();
            tbTenBan.Text = DataProvider.Instance.ExecuteQuery("SELECT * FROM BANAN WHERE MABA = " + MABA).Rows[0]["TENBA"].ToString();
        }



        void LoadFoodListByMALOAI(int ID)
        {
            List<MonAnDTO> listFood = MonAnDAO.Instance.GetListFoodByMALOAI(ID);
            foreach (MonAnDTO item in listFood)
            {
                ListViewItem lsvItem = new ListViewItem(item.TENMA.ToString());
                lsvItem.SubItems.Add(item.DVT.ToString());
                lsvItem.SubItems.Add(item.DonGia.ToString());
                lvShowFood.Items.Add(lsvItem);
            }

        }
        void LoadDanhMuc()
        {
            List<LoaiMonDTO> list = DanhMucDAO.Instance.LayDanhSachDanhMuc();
            cbLoaiMon.DataSource = list;
            cbLoaiMon.DisplayMember = "TENLOAI";
        }

        #region 
        private void fOderStaff_Load(object sender, EventArgs e)
        {
            lvShowFood.Items.Clear();
            listMonAn = MonAnDAO.Instance.GetListFood();
            foreach (MonAnDTO item in listMonAn)
            {
                ListViewItem itemLv = new ListViewItem(item.TENMA);
                itemLv.SubItems.Add(item.DVT);
                itemLv.SubItems.Add(item.DonGia.ToString());
                lvShowFood.Items.Add(itemLv);
            }      
        }

       
        List<MonAnDTO> listMonAn = new List<MonAnDTO>();
        #endregion

        private void cbLoaiMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoaiMonDTO LoaiMAselected = (LoaiMonDTO)cbLoaiMon.SelectedItem;
            if (LoaiMAselected == null) return;
            lvShowFood.Items.Clear();
            listMonAn = MonAnDAO.Instance.GetListFoodByMALOAI(LoaiMAselected.MALOAI);
            foreach (MonAnDTO item in listMonAn)
            {
                ListViewItem itemLv = new ListViewItem(item.TENMA);
                itemLv.SubItems.Add(item.DVT);
                itemLv.SubItems.Add(item.DonGia.ToString());
                lvShowFood.Items.Add(itemLv);
            }
           
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            BanAnDTO table = lsvShowBill.Tag as BanAnDTO;

            int MAHD = HoaDonDAO.Instance.GetUncheckBillIDByTableID(table.MABA);
          

            if (MAHD == -1)
            {
                HoaDonDAO.Instance.InsertHoaDon(table.MABA);
           
            }
            else
            {
               // CTHDDAO.Instance.InsertBillInfo(MAHD, , count);
            }

            ShowBill(table.MABA);
        }
        // 
        private void lvShowFood_Click(object sender, EventArgs e)
        {
            string food_TenMon = lvShowFood.SelectedItems[0].SubItems[0].Text;
            string food_Gia = lvShowFood.SelectedItems[0].SubItems[2].Text;
            ///
            int check_TenMon = 0;

            if (tbMaBan.Text == "")
            {
                XtraMessageBox.Show("Bạn Chưa chọn bàn !");
            }
            else
            {
                int MaBan = Convert.ToInt32(tbMaBan.Text);

                if (lsvShowBill.Items.Count > 0)
                {
                    foreach (ListViewItem itemRow in lsvShowBill.Items)
                    {
                        if (food_TenMon == itemRow.SubItems[0].Text)
                        {
                            check_TenMon = 1;
                            int soluong = Convert.ToInt32(itemRow.SubItems[1].Text);
                            soluong++;
                            itemRow.SubItems[1].Text = soluong.ToString();
                            int thanhtien = Convert.ToInt32(itemRow.SubItems[2].Text)*soluong;
                            itemRow.SubItems[3].Text = thanhtien.ToString();
                        }
                    
                    }
                }

                if (lsvShowBill.Items.Count <= 0 || check_TenMon == 0)
                {
                    ListViewItem lsvItem = new ListViewItem(food_TenMon);
                    lsvItem.SubItems.Add("1");
                    lsvItem.SubItems.Add(food_Gia);
                    int ThanhTien = Convert.ToInt32("1")*Convert.ToInt32(food_Gia);
                    lsvItem.SubItems.Add(ThanhTien.ToString());
                    lsvShowBill.Items.Add(lsvItem);
                    check_TenMon = 0;
                }
            }
        }

        private void lsvShowBill_DoubleClick(object sender, EventArgs e)
        {
            if (lsvShowBill.Items.Count > 0)
            {
                int soluong = Convert.ToInt32(lsvShowBill.SelectedItems[0].SubItems[1].Text);
                if (soluong == 1)
                {
                    lsvShowBill.SelectedItems[0].Remove();
                }
                else
                {
                    soluong--;
                    int thanhtien = Convert.ToInt32(lsvShowBill.SelectedItems[0].SubItems[2].Text) * soluong;
                    lsvShowBill.SelectedItems[0].SubItems[1].Text = soluong.ToString();
                    lsvShowBill.SelectedItems[0].SubItems[3].Text = thanhtien.ToString();
                }
            }
        }

        private void lsvShowBill_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            if (lsvShowBill.SelectedItems.Count >0 )
            {
                lsvShowBill.SelectedItems[0].Remove();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa chọn món trong hóa đơn !");
            }
            
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int MaBan = Convert.ToInt32(tbMaBan.Text);
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM HOADON WHERE MABA = '"+MaBan+"' AND status = "+0 );
            if (data.Rows.Count > 0)
            {
                string MAHD = data.Rows[0]["MAHD"].ToString();
                string MAMA = "" ,DVT = "";
                int SOLUONG = 0;
                
                if (lsvShowBill.Items.Count > 0)
                {
                    foreach (ListViewItem itemRow in lsvShowBill.Items)
                    {
                        DataTable MonAn = DataProvider.Instance.ExecuteQuery("SELECT * FROM MONAN WHERE TENMA = N'" + itemRow.SubItems[0].Text + "'");
                        MAMA = MonAn.Rows[0]["MAMA"].ToString();
                        DVT = MonAn.Rows[0]["DVT"].ToString();
                        SOLUONG = Convert.ToInt32(itemRow.SubItems[1].Text);
                        OderStaffDAO.Instance.InsertCTHD(Convert.ToInt32(MAMA), Convert.ToInt32(MAHD), SOLUONG,DVT);
                    }
                    XtraMessageBox.Show("Đã thêm thành công !");
                    flpSanVuon.Controls.Clear();
                    flpSansau.Controls.Clear();
                    flpMayLanh.Controls.Clear();
                    LoadTable();
                }
            }
            else
            {
               OderStaffDAO.Instance.InsertHoaDon(MaBan);
            }
            
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        
    }
}