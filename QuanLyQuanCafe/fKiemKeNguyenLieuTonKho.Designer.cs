namespace QuanLyQuanCafe
{
    partial class fKiemKeNguyenLieuTonKho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fKiemKeNguyenLieuTonKho));
            this.livKiemKeKho = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.dtKKKHO = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbMaNguyenLieuKK = new System.Windows.Forms.TextBox();
            this.txbTenNguyenLieuKK = new System.Windows.Forms.TextBox();
            this.txbSoLuongKK = new System.Windows.Forms.TextBox();
            this.txbDVTKK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbMNLTK = new System.Windows.Forms.TextBox();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.btnTKtheoMNL = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoatKiemKe = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // livKiemKeKho
            // 
            this.livKiemKeKho.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.livKiemKeKho.FullRowSelect = true;
            this.livKiemKeKho.Location = new System.Drawing.Point(12, 58);
            this.livKiemKeKho.Name = "livKiemKeKho";
            this.livKiemKeKho.Size = new System.Drawing.Size(587, 308);
            this.livKiemKeKho.TabIndex = 0;
            this.livKiemKeKho.UseCompatibleStateImageBehavior = false;
            this.livKiemKeKho.View = System.Windows.Forms.View.Details;
            this.livKiemKeKho.Click += new System.EventHandler(this.livKiemKeKho_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã Nguyên Liệu";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên Nguyên Liệu";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số Lượng";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 76;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Đơn Vị Tính";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 91;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Người Kiểm Kê";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 113;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày Kiểm Kê  :";
            // 
            // dtKKKHO
            // 
            this.dtKKKHO.Location = new System.Drawing.Point(137, 16);
            this.dtKKKHO.Name = "dtKKKHO";
            this.dtKKKHO.Size = new System.Drawing.Size(228, 22);
            this.dtKKKHO.TabIndex = 2;
            this.dtKKKHO.ValueChanged += new System.EventHandler(this.dtKKKHO_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(605, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã Nguyên Liệu  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(605, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên Nguyên Liệu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(606, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số Lượng :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(606, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Đơn Vị Tính  :";
            // 
            // txbMaNguyenLieuKK
            // 
            this.txbMaNguyenLieuKK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMaNguyenLieuKK.Location = new System.Drawing.Point(734, 111);
            this.txbMaNguyenLieuKK.Name = "txbMaNguyenLieuKK";
            this.txbMaNguyenLieuKK.Size = new System.Drawing.Size(178, 15);
            this.txbMaNguyenLieuKK.TabIndex = 9;
            this.txbMaNguyenLieuKK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbTenNguyenLieuKK
            // 
            this.txbTenNguyenLieuKK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTenNguyenLieuKK.Location = new System.Drawing.Point(735, 176);
            this.txbTenNguyenLieuKK.Name = "txbTenNguyenLieuKK";
            this.txbTenNguyenLieuKK.Size = new System.Drawing.Size(177, 15);
            this.txbTenNguyenLieuKK.TabIndex = 10;
            this.txbTenNguyenLieuKK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbSoLuongKK
            // 
            this.txbSoLuongKK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSoLuongKK.Location = new System.Drawing.Point(735, 241);
            this.txbSoLuongKK.Name = "txbSoLuongKK";
            this.txbSoLuongKK.Size = new System.Drawing.Size(177, 15);
            this.txbSoLuongKK.TabIndex = 11;
            this.txbSoLuongKK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbDVTKK
            // 
            this.txbDVTKK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDVTKK.Location = new System.Drawing.Point(738, 295);
            this.txbDVTKK.Name = "txbDVTKK";
            this.txbDVTKK.Size = new System.Drawing.Size(176, 15);
            this.txbDVTKK.TabIndex = 12;
            this.txbDVTKK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(596, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nhập Mã Nguyên Liêu :";
            // 
            // txbMNLTK
            // 
            this.txbMNLTK.Location = new System.Drawing.Point(758, 19);
            this.txbMNLTK.Name = "txbMNLTK";
            this.txbMNLTK.Size = new System.Drawing.Size(153, 22);
            this.txbMNLTK.TabIndex = 14;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Coffee";
            // 
            // btnTKtheoMNL
            // 
            this.btnTKtheoMNL.Image = ((System.Drawing.Image)(resources.GetObject("btnTKtheoMNL.Image")));
            this.btnTKtheoMNL.Location = new System.Drawing.Point(917, 12);
            this.btnTKtheoMNL.Name = "btnTKtheoMNL";
            this.btnTKtheoMNL.Size = new System.Drawing.Size(51, 33);
            this.btnTKtheoMNL.TabIndex = 16;
            this.btnTKtheoMNL.Click += new System.EventHandler(this.btnTKtheoMNL_Click_1);
            // 
            // btnThoatKiemKe
            // 
            this.btnThoatKiemKe.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatKiemKe.Appearance.Options.UseFont = true;
            this.btnThoatKiemKe.Location = new System.Drawing.Point(905, 343);
            this.btnThoatKiemKe.Name = "btnThoatKiemKe";
            this.btnThoatKiemKe.Size = new System.Drawing.Size(60, 31);
            this.btnThoatKiemKe.TabIndex = 17;
            this.btnThoatKiemKe.Text = "Thoát";
            this.btnThoatKiemKe.Click += new System.EventHandler(this.btnThoatKiemKe_Click_1);
            // 
            // fKiemKeNguyenLieuTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 378);
            this.Controls.Add(this.btnThoatKiemKe);
            this.Controls.Add(this.btnTKtheoMNL);
            this.Controls.Add(this.txbMNLTK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbDVTKK);
            this.Controls.Add(this.txbSoLuongKK);
            this.Controls.Add(this.txbTenNguyenLieuKK);
            this.Controls.Add(this.txbMaNguyenLieuKK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtKKKHO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.livKiemKeKho);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fKiemKeNguyenLieuTonKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiểm Kê Nguyên Liệu Tồn Kho";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView livKiemKeKho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtKKKHO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbMaNguyenLieuKK;
        private System.Windows.Forms.TextBox txbTenNguyenLieuKK;
        private System.Windows.Forms.TextBox txbSoLuongKK;
        private System.Windows.Forms.TextBox txbDVTKK;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbMNLTK;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.SimpleButton btnTKtheoMNL;
        private DevExpress.XtraEditors.SimpleButton btnThoatKiemKe;
    }
}