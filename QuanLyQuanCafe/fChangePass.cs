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
    public partial class fChangePass : DevExpress.XtraEditors.XtraForm
    {
        private string TENTK;
        private string LOAITK;
        public fChangePass()
        {
            InitializeComponent();
        }
        public fChangePass(string _tentk,string _loaitk) : this()
        {
            TENTK = _tentk;
            LOAITK = _loaitk;
        }

        private void fChangePass_Load(object sender, EventArgs e)
        {
            tbUserName.Text = TENTK;

            //DataTable tk = DataProvider.Instance.ExecuteQuery("SELECT * FROM TAIKHOAN WHERE TENTK = "+TENTK);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataTable tk = DataProvider.Instance.ExecuteQuery("SELECT * FROM TAIKHOAN WHERE TENTK = '"+ TENTK+"' AND MATKHAU = '"+tbPass.Text+"'");
            
            if (tk.Rows.Count > 0 )
            {
                if (!CheckNhapMatKhau())
                {
                    MessageBox.Show("Mật khẩu nhập không trùng !");
                }
                else
                {
                    TaiKhoanDAO.Instance.UpdateTAIKHOAN(TENTK, LOAITK, tbPassNew.Text);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu nhập chính không khớp !");
            }
        }
        bool CheckNhapMatKhau()
        {
            if (string.Equals(tbPassNew.Text, tbRepeatPass.Text) == true && tbPassNew.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}