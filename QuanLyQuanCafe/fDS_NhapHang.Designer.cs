namespace QuanLyQuanCafe
{
    partial class fDS_NhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDS_NhapHang));
            this.livDSNH = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label29 = new System.Windows.Forms.Label();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.btnSuaDSNH = new System.Windows.Forms.Button();
            this.btnXoaDSNH = new System.Windows.Forms.Button();
            this.btnThemDS_NH = new System.Windows.Forms.Button();
            this.btnXacNhanNH = new System.Windows.Forms.Button();
            this.chbXNNH = new System.Windows.Forms.CheckBox();
            this.btnThoatDSNH = new System.Windows.Forms.Button();
            this.lbNNNH = new System.Windows.Forms.Label();
            this.lbDVTNH = new System.Windows.Forms.Label();
            this.lbSLNH = new System.Windows.Forms.Label();
            this.lbTNLNH = new System.Windows.Forms.Label();
            this.lbMNLNH = new System.Windows.Forms.Label();
            this.lbMDSNH = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txbMNLNH = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // livDSNH
            // 
            this.livDSNH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21});
            this.livDSNH.FullRowSelect = true;
            this.livDSNH.Location = new System.Drawing.Point(12, 70);
            this.livDSNH.Name = "livDSNH";
            this.livDSNH.Size = new System.Drawing.Size(693, 312);
            this.livDSNH.TabIndex = 1;
            this.livDSNH.UseCompatibleStateImageBehavior = false;
            this.livDSNH.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "STT";
            this.columnHeader3.Width = 43;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã Nguyên Liệu";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 125;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Tên Nguyên Liệu";
            this.columnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader17.Width = 140;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Số Lượng";
            this.columnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader18.Width = 81;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Đơn Vị Tính";
            this.columnHeader19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader19.Width = 97;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Người Nhập";
            this.columnHeader20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader20.Width = 101;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Xác Nhận";
            this.columnHeader21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader21.Width = 73;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(12, 44);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(232, 16);
            this.label29.TabIndex = 32;
            this.label29.Text = "Danh Sách Nhập Hàng Của Ngày   :";
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.CustomFormat = "MM/dd/yyyy";
            this.dtNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayNhap.Location = new System.Drawing.Point(250, 43);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(136, 22);
            this.dtNgayNhap.TabIndex = 33;
            // 
            // btnSuaDSNH
            // 
            this.btnSuaDSNH.Location = new System.Drawing.Point(513, 398);
            this.btnSuaDSNH.Name = "btnSuaDSNH";
            this.btnSuaDSNH.Size = new System.Drawing.Size(192, 28);
            this.btnSuaDSNH.TabIndex = 36;
            this.btnSuaDSNH.Text = "Sửa Mặt Hàng";
            this.btnSuaDSNH.UseVisualStyleBackColor = true;
            // 
            // btnXoaDSNH
            // 
            this.btnXoaDSNH.Location = new System.Drawing.Point(263, 395);
            this.btnXoaDSNH.Name = "btnXoaDSNH";
            this.btnXoaDSNH.Size = new System.Drawing.Size(185, 28);
            this.btnXoaDSNH.TabIndex = 35;
            this.btnXoaDSNH.Text = "Xóa Mặt Hàng";
            this.btnXoaDSNH.UseVisualStyleBackColor = true;
            // 
            // btnThemDS_NH
            // 
            this.btnThemDS_NH.Location = new System.Drawing.Point(15, 398);
            this.btnThemDS_NH.Name = "btnThemDS_NH";
            this.btnThemDS_NH.Size = new System.Drawing.Size(174, 28);
            this.btnThemDS_NH.TabIndex = 34;
            this.btnThemDS_NH.Text = "Thêm Mặt Hàng";
            this.btnThemDS_NH.UseVisualStyleBackColor = true;
            this.btnThemDS_NH.Click += new System.EventHandler(this.btnThemDS_NH_Click);
            // 
            // btnXacNhanNH
            // 
            this.btnXacNhanNH.Location = new System.Drawing.Point(779, 401);
            this.btnXacNhanNH.Name = "btnXacNhanNH";
            this.btnXacNhanNH.Size = new System.Drawing.Size(106, 23);
            this.btnXacNhanNH.TabIndex = 62;
            this.btnXacNhanNH.Text = "Xác Nhận";
            this.btnXacNhanNH.UseVisualStyleBackColor = true;
            // 
            // chbXNNH
            // 
            this.chbXNNH.AutoSize = true;
            this.chbXNNH.Location = new System.Drawing.Point(973, 364);
            this.chbXNNH.Name = "chbXNNH";
            this.chbXNNH.Size = new System.Drawing.Size(15, 14);
            this.chbXNNH.TabIndex = 61;
            this.chbXNNH.UseVisualStyleBackColor = true;
            // 
            // btnThoatDSNH
            // 
            this.btnThoatDSNH.Location = new System.Drawing.Point(955, 403);
            this.btnThoatDSNH.Name = "btnThoatDSNH";
            this.btnThoatDSNH.Size = new System.Drawing.Size(98, 23);
            this.btnThoatDSNH.TabIndex = 60;
            this.btnThoatDSNH.Text = "Thoát";
            this.btnThoatDSNH.UseVisualStyleBackColor = true;
            this.btnThoatDSNH.Click += new System.EventHandler(this.btnThoatDSNH_Click);
            // 
            // lbNNNH
            // 
            this.lbNNNH.AutoSize = true;
            this.lbNNNH.Location = new System.Drawing.Point(930, 326);
            this.lbNNNH.Name = "lbNNNH";
            this.lbNNNH.Size = new System.Drawing.Size(0, 16);
            this.lbNNNH.TabIndex = 59;
            // 
            // lbDVTNH
            // 
            this.lbDVTNH.AutoSize = true;
            this.lbDVTNH.Location = new System.Drawing.Point(930, 287);
            this.lbDVTNH.Name = "lbDVTNH";
            this.lbDVTNH.Size = new System.Drawing.Size(0, 16);
            this.lbDVTNH.TabIndex = 58;
            // 
            // lbSLNH
            // 
            this.lbSLNH.AutoSize = true;
            this.lbSLNH.Location = new System.Drawing.Point(930, 248);
            this.lbSLNH.Name = "lbSLNH";
            this.lbSLNH.Size = new System.Drawing.Size(0, 16);
            this.lbSLNH.TabIndex = 57;
            // 
            // lbTNLNH
            // 
            this.lbTNLNH.AutoSize = true;
            this.lbTNLNH.Location = new System.Drawing.Point(930, 210);
            this.lbTNLNH.Name = "lbTNLNH";
            this.lbTNLNH.Size = new System.Drawing.Size(0, 16);
            this.lbTNLNH.TabIndex = 56;
            // 
            // lbMNLNH
            // 
            this.lbMNLNH.AutoSize = true;
            this.lbMNLNH.Location = new System.Drawing.Point(930, 171);
            this.lbMNLNH.Name = "lbMNLNH";
            this.lbMNLNH.Size = new System.Drawing.Size(0, 16);
            this.lbMNLNH.TabIndex = 55;
            // 
            // lbMDSNH
            // 
            this.lbMDSNH.AutoSize = true;
            this.lbMDSNH.Location = new System.Drawing.Point(930, 132);
            this.lbMDSNH.Name = "lbMDSNH";
            this.lbMDSNH.Size = new System.Drawing.Size(0, 16);
            this.lbMDSNH.TabIndex = 54;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(727, 364);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(189, 16);
            this.label22.TabIndex = 53;
            this.label22.Text = "Xác Nhận Đã Nhập Vào Kho:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(728, 326);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(92, 16);
            this.label21.TabIndex = 52;
            this.label21.Text = "Người Nhập :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(728, 287);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 16);
            this.label20.TabIndex = 51;
            this.label20.Text = "Đơn Vị Tính :";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(729, 246);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(79, 16);
            this.label28.TabIndex = 50;
            this.label28.Text = "Số Lượng :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(728, 248);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 16);
            this.label19.TabIndex = 49;
            this.label19.Text = "Số Lượng :";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(729, 208);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(124, 16);
            this.label27.TabIndex = 48;
            this.label27.Text = "Tên Nguyên Liệu :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(728, 210);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(124, 16);
            this.label18.TabIndex = 47;
            this.label18.Text = "Tên Nguyên Liệu :";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(729, 169);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(119, 16);
            this.label26.TabIndex = 46;
            this.label26.Text = "Mã Nguyên Liệu :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(728, 171);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 16);
            this.label17.TabIndex = 45;
            this.label17.Text = "Mã Nguyên Liệu :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(729, 130);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(108, 16);
            this.label25.TabIndex = 44;
            this.label25.Text = "Mã Danh Sách :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(728, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 16);
            this.label16.TabIndex = 43;
            this.label16.Text = "Mã Danh Sách :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(942, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txbMNLNH
            // 
            this.txbMNLNH.Location = new System.Drawing.Point(885, 46);
            this.txbMNLNH.Name = "txbMNLNH";
            this.txbMNLNH.Size = new System.Drawing.Size(153, 22);
            this.txbMNLNH.TabIndex = 39;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(729, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 16);
            this.label15.TabIndex = 37;
            this.label15.Text = "Mã Nguyên Liệu    :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 32);
            this.label1.TabIndex = 63;
            this.label1.Text = "DANH SÁCH NHẬP HÀNG";
            // 
            // fDS_NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 438);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXacNhanNH);
            this.Controls.Add(this.chbXNNH);
            this.Controls.Add(this.btnThoatDSNH);
            this.Controls.Add(this.lbNNNH);
            this.Controls.Add(this.lbDVTNH);
            this.Controls.Add(this.lbSLNH);
            this.Controls.Add(this.lbTNLNH);
            this.Controls.Add(this.lbMNLNH);
            this.Controls.Add(this.lbMDSNH);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbMNLNH);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnSuaDSNH);
            this.Controls.Add(this.btnXoaDSNH);
            this.Controls.Add(this.btnThemDS_NH);
            this.Controls.Add(this.dtNgayNhap);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.livDSNH);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fDS_NhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Nhập Hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView livDSNH;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DateTimePicker dtNgayNhap;
        private System.Windows.Forms.Button btnSuaDSNH;
        private System.Windows.Forms.Button btnXoaDSNH;
        private System.Windows.Forms.Button btnThemDS_NH;
        private System.Windows.Forms.Button btnXacNhanNH;
        private System.Windows.Forms.CheckBox chbXNNH;
        private System.Windows.Forms.Button btnThoatDSNH;
        private System.Windows.Forms.Label lbNNNH;
        private System.Windows.Forms.Label lbDVTNH;
        private System.Windows.Forms.Label lbSLNH;
        private System.Windows.Forms.Label lbTNLNH;
        private System.Windows.Forms.Label lbMNLNH;
        private System.Windows.Forms.Label lbMDSNH;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbMNLNH;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
    }
}