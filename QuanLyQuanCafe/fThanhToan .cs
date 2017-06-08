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
using System.Globalization;

namespace QuanLyQuanCafe
{
    public partial class fThanhToan : DevExpress.XtraEditors.XtraForm
    {
        public fThanhToan()
        {
            InitializeComponent();
            this.tbTime.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            LoadTable();
        }

        void LoadTable()
        {
            flpSanVuon.Controls.Clear();
            flpSansau.Controls.Clear();
            flpMayLanh.Controls.Clear();
            List<BanAnDTO> tableList = ThanhToanDAO.Instance.LoadTableList();
            List<BanAnDTO> tableList2 = ThanhToanDAO.Instance.LoadTableList2();
            List<BanAnDTO> tableList3 = ThanhToanDAO.Instance.LoadTableList3();// lay danh sách table 
            foreach (BanAnDTO item in tableList)
            {
                Button btn = new Button();
                btn.Width = ThanhToanDAO.TableWidth;
                btn.Height = ThanhToanDAO.TableHeight;
                btn.Text = item.TENBA;
                btn.Tag = item;

                flpSanVuon.Controls.Add(btn);
                //
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
                //btn.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Xoan\Downloads\Imagebook\1_1.png");
                btn.Click += btn_Click;

            }
            foreach (BanAnDTO item in tableList2)
            {
                Button btn = new Button();
                btn.Width = ThanhToanDAO.TableWidth;
                btn.Height = ThanhToanDAO.TableHeight;
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
                
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.BackgroundImage = Properties.Resources._1_1;

                btn.TextAlign = ContentAlignment.BottomRight;
                //btn.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Xoan\Downloads\Imagebook\1_1.png");
                btn.Click += btn_Click;

            }
            foreach (BanAnDTO item in tableList3)
            {
                Button btn = new Button();
                btn.Width = ThanhToanDAO.TableWidth;
                btn.Height = ThanhToanDAO.TableHeight;
                btn.Text = item.TENBA;
                btn.Tag = item;

                flpMayLanh.Controls.Add(btn);
                //
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
                //btn.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Xoan\Downloads\Imagebook\1_1.png");
                btn.Click += btn_Click;

            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BanAnDTO).MABA;
            ShowBill(tableID);
        }


        void ShowBill(int MABA)
        {
            lvBill.Items.Clear();
            float ThanhTien = 0;
            List<MenuDTO> listBillInfo = MenuDAO.Instance.GetListMenuByTable(MABA);

            foreach (QuanLyQuanCafe.DTO.MenuDTO item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.TENMA.ToString());
                lsvItem.SubItems.Add(item.SoLuong.ToString());
                lsvItem.SubItems.Add(item.DonGia.ToString());
                lsvItem.SubItems.Add(item.ThanhTien.ToString());
                ThanhTien += item.ThanhTien;
                lvBill.Items.Add(lsvItem);

            }
            tbMaBan.Text = MABA.ToString();
            tbTenBan.Text = DataProvider.Instance.ExecuteQuery("SELECT * FROM BANAN WHERE MABA = "+ MABA).Rows[0]["TENBA"].ToString();
            CultureInfo culture = new CultureInfo("vi-VN");
            tbTotalPrice.Text = ThanhTien.ToString("c", culture);
        }
        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChangePass f = new fChangePass();
            f.ShowDialog();
        }

        private void đăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xtbSanVuon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPayBill_Click(object sender, EventArgs e)
        {
           
            // phần Nghĩa code
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM HOADON WHERE MABA = '" + tbMaBan.Text + "' AND status = " + 0);
            if (data.Rows.Count > 0)
            {
                DialogResult dialogResult = XtraMessageBox.Show("Bạn có chắc thanh toán hóa đơn: \nTên bàn: " + tbTenBan.Text+ "\nTổng tiền: " + tbTotalPrice.Text, "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //lvBill.Items.Clear();
                    int MAHD = Convert.ToInt32(data.Rows[0]["MAHD"]);
                    ThanhToanDAO.Instance.InsertHoaDonThanhToan(MAHD);
                    ShowBill(Convert.ToInt32(tbMaBan.Text));
                    LoadTable();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }

        }

        private void fThanhToan_Load(object sender, EventArgs e)
        {

        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            
            if (tbMaBan.Text == "")
            {   
                MessageBox.Show("Bạn chưa chọn bàn !");
            }
            else
            {
                DataTable dataHD = DataProvider.Instance.ExecuteQuery("SELECT * FROM HOADON WHERE status = 0 AND MABA =" + Convert.ToInt32(tbMaBan.Text));
                if (dataHD.Rows.Count > 0)
                {
                    FORMREPORT.formRePortThanhToan f = new FORMREPORT.formRePortThanhToan(Convert.ToInt32(tbMaBan.Text));
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Bàn đã chọn chưa có hóa đơn !");
                }
                
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
