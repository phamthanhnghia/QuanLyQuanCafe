﻿using QuanLyQuanCafe.DAO;
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
    public partial class FormChonNgayCaTruc : Form
    {
        public string NGAY;
        public int MACT;
        public FormChonNgayCaTruc()
        {
            InitializeComponent();
            this.dateDiemDanh.Value = DateTime.Now;
        }

        private void FormChonNgayCaTruc_Load(object sender, EventArgs e)
        {
            addccbCaTruc();
        }
        void addccbCaTruc()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM CATRUC");
            foreach (DataRow item in data.Rows)
            {
                cbbCaTruc.Items.Add(item["TENCA"]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbbCaTruc.Text != "")
            {
                FormThucHienDiemDanh f = new FormThucHienDiemDanh(dateDiemDanh.Text, cbbCaTruc.Text);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn phải chọn ca trực !",
                                   "Thông báo",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Exclamation,
                                   MessageBoxDefaultButton.Button1);
            }
        }
    }
}
