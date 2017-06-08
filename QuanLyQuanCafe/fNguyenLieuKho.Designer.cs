namespace QuanLyQuanCafe
{
    partial class fNguyenLieuKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNguyenLieuKho));
            this.livNguyenLieuKho = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txbMaNguyenLieuTimKiemKho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbMaNguyenLieuKho = new System.Windows.Forms.TextBox();
            this.txbTenNguyenLieuKho = new System.Windows.Forms.TextBox();
            this.txbNgayNhapNguyenLieuKho = new System.Windows.Forms.TextBox();
            this.txbNguoiNhapNguyenLieuKho = new System.Windows.Forms.TextBox();
            this.btnThoatNguyenLieuKho = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemNguyenLieuKho = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimKiemNguyenLieuKho = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // livNguyenLieuKho
            // 
            this.livNguyenLieuKho.AllowDrop = true;
            this.livNguyenLieuKho.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.livNguyenLieuKho.FullRowSelect = true;
            this.livNguyenLieuKho.Location = new System.Drawing.Point(12, 56);
            this.livNguyenLieuKho.Name = "livNguyenLieuKho";
            this.livNguyenLieuKho.Size = new System.Drawing.Size(619, 337);
            this.livNguyenLieuKho.TabIndex = 0;
            this.livNguyenLieuKho.UseCompatibleStateImageBehavior = false;
            this.livNguyenLieuKho.View = System.Windows.Forms.View.Details;
            this.livNguyenLieuKho.Click += new System.EventHandler(this.livNguyenLieuKho_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 37;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã Nguyên Liệu";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 126;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên Nguyên Liệu";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 123;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày Nhập Vào Kho";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 145;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Người Nhập Vào Kho ";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 156;
            // 
            // txbMaNguyenLieuTimKiemKho
            // 
            this.txbMaNguyenLieuTimKiemKho.Location = new System.Drawing.Point(680, 21);
            this.txbMaNguyenLieuTimKiemKho.Name = "txbMaNguyenLieuTimKiemKho";
            this.txbMaNguyenLieuTimKiemKho.Size = new System.Drawing.Size(218, 22);
            this.txbMaNguyenLieuTimKiemKho.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(675, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Nguyên Liệu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(671, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên Nguyên Liệu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(670, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày Nhập Vào Kho :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(669, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Người Nhập Vào Kho :";
            // 
            // txbMaNguyenLieuKho
            // 
            this.txbMaNguyenLieuKho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMaNguyenLieuKho.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaNguyenLieuKho.Location = new System.Drawing.Point(809, 99);
            this.txbMaNguyenLieuKho.Name = "txbMaNguyenLieuKho";
            this.txbMaNguyenLieuKho.ReadOnly = true;
            this.txbMaNguyenLieuKho.Size = new System.Drawing.Size(179, 18);
            this.txbMaNguyenLieuKho.TabIndex = 14;
            this.txbMaNguyenLieuKho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbTenNguyenLieuKho
            // 
            this.txbTenNguyenLieuKho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTenNguyenLieuKho.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenNguyenLieuKho.Location = new System.Drawing.Point(809, 155);
            this.txbTenNguyenLieuKho.Name = "txbTenNguyenLieuKho";
            this.txbTenNguyenLieuKho.ReadOnly = true;
            this.txbTenNguyenLieuKho.Size = new System.Drawing.Size(179, 18);
            this.txbTenNguyenLieuKho.TabIndex = 15;
            this.txbTenNguyenLieuKho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbNgayNhapNguyenLieuKho
            // 
            this.txbNgayNhapNguyenLieuKho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNgayNhapNguyenLieuKho.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNgayNhapNguyenLieuKho.Location = new System.Drawing.Point(819, 205);
            this.txbNgayNhapNguyenLieuKho.Name = "txbNgayNhapNguyenLieuKho";
            this.txbNgayNhapNguyenLieuKho.ReadOnly = true;
            this.txbNgayNhapNguyenLieuKho.Size = new System.Drawing.Size(169, 18);
            this.txbNgayNhapNguyenLieuKho.TabIndex = 16;
            this.txbNgayNhapNguyenLieuKho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbNguoiNhapNguyenLieuKho
            // 
            this.txbNguoiNhapNguyenLieuKho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNguoiNhapNguyenLieuKho.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNguoiNhapNguyenLieuKho.Location = new System.Drawing.Point(825, 256);
            this.txbNguoiNhapNguyenLieuKho.Name = "txbNguoiNhapNguyenLieuKho";
            this.txbNguoiNhapNguyenLieuKho.ReadOnly = true;
            this.txbNguoiNhapNguyenLieuKho.Size = new System.Drawing.Size(163, 18);
            this.txbNguoiNhapNguyenLieuKho.TabIndex = 17;
            this.txbNguoiNhapNguyenLieuKho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnThoatNguyenLieuKho
            // 
            this.btnThoatNguyenLieuKho.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatNguyenLieuKho.Appearance.Options.UseFont = true;
            this.btnThoatNguyenLieuKho.Location = new System.Drawing.Point(921, 370);
            this.btnThoatNguyenLieuKho.Name = "btnThoatNguyenLieuKho";
            this.btnThoatNguyenLieuKho.Size = new System.Drawing.Size(60, 31);
            this.btnThoatNguyenLieuKho.TabIndex = 19;
            this.btnThoatNguyenLieuKho.Text = "Thoát";
            this.btnThoatNguyenLieuKho.Click += new System.EventHandler(this.btnThoatNguyenLieuKho_Click_1);
            // 
            // btnThemNguyenLieuKho
            // 
            this.btnThemNguyenLieuKho.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNguyenLieuKho.Image")));
            this.btnThemNguyenLieuKho.Location = new System.Drawing.Point(556, 5);
            this.btnThemNguyenLieuKho.Name = "btnThemNguyenLieuKho";
            this.btnThemNguyenLieuKho.Size = new System.Drawing.Size(75, 43);
            this.btnThemNguyenLieuKho.TabIndex = 20;
            this.btnThemNguyenLieuKho.Text = "Thêm";
            this.btnThemNguyenLieuKho.Click += new System.EventHandler(this.btnThemNguyenLieuKho_Click_1);
            // 
            // btnTimKiemNguyenLieuKho
            // 
            this.btnTimKiemNguyenLieuKho.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemNguyenLieuKho.Image")));
            this.btnTimKiemNguyenLieuKho.Location = new System.Drawing.Point(916, 10);
            this.btnTimKiemNguyenLieuKho.Name = "btnTimKiemNguyenLieuKho";
            this.btnTimKiemNguyenLieuKho.Size = new System.Drawing.Size(65, 38);
            this.btnTimKiemNguyenLieuKho.TabIndex = 18;
            this.btnTimKiemNguyenLieuKho.Click += new System.EventHandler(this.btnTimKiemNguyenLieuKho_Click_1);
            // 
            // fNguyenLieuKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 411);
            this.Controls.Add(this.btnThemNguyenLieuKho);
            this.Controls.Add(this.btnThoatNguyenLieuKho);
            this.Controls.Add(this.btnTimKiemNguyenLieuKho);
            this.Controls.Add(this.txbNguoiNhapNguyenLieuKho);
            this.Controls.Add(this.txbNgayNhapNguyenLieuKho);
            this.Controls.Add(this.txbTenNguyenLieuKho);
            this.Controls.Add(this.txbMaNguyenLieuKho);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbMaNguyenLieuTimKiemKho);
            this.Controls.Add(this.livNguyenLieuKho);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fNguyenLieuKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nguyên Liệu Kho";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView livNguyenLieuKho;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txbMaNguyenLieuTimKiemKho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbMaNguyenLieuKho;
        private System.Windows.Forms.TextBox txbTenNguyenLieuKho;
        private System.Windows.Forms.TextBox txbNgayNhapNguyenLieuKho;
        private System.Windows.Forms.TextBox txbNguoiNhapNguyenLieuKho;
        private DevExpress.XtraEditors.SimpleButton btnTimKiemNguyenLieuKho;
        private DevExpress.XtraEditors.SimpleButton btnThoatNguyenLieuKho;
        private DevExpress.XtraEditors.SimpleButton btnThemNguyenLieuKho;
    }
}