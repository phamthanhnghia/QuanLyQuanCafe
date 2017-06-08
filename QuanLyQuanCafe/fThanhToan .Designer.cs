namespace QuanLyQuanCafe
{
    partial class fThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThanhToan));
            this.tbcPayBill = new DevExpress.XtraTab.XtraTabControl();
            this.xtbThuChi = new DevExpress.XtraTab.XtraTabPage();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.btnPayBill = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTenBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMaBan = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtbSanVuon = new DevExpress.XtraTab.XtraTabPage();
            this.flpSanVuon = new System.Windows.Forms.FlowLayoutPanel();
            this.xtbSansau = new DevExpress.XtraTab.XtraTabPage();
            this.flpSansau = new System.Windows.Forms.FlowLayoutPanel();
            this.xtbMayLanh = new DevExpress.XtraTab.XtraTabPage();
            this.flpMayLanh = new System.Windows.Forms.FlowLayoutPanel();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbcPayBill)).BeginInit();
            this.tbcPayBill.SuspendLayout();
            this.xtbThuChi.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtbSanVuon.SuspendLayout();
            this.xtbSansau.SuspendLayout();
            this.xtbMayLanh.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcPayBill
            // 
            this.tbcPayBill.Location = new System.Drawing.Point(12, 12);
            this.tbcPayBill.Name = "tbcPayBill";
            this.tbcPayBill.SelectedTabPage = this.xtbThuChi;
            this.tbcPayBill.Size = new System.Drawing.Size(737, 493);
            this.tbcPayBill.TabIndex = 0;
            this.tbcPayBill.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtbThuChi});
            // 
            // xtbThuChi
            // 
            this.xtbThuChi.AllowTouchScroll = true;
            this.xtbThuChi.AutoScroll = true;
            this.xtbThuChi.Controls.Add(this.tbTotalPrice);
            this.xtbThuChi.Controls.Add(this.label3);
            this.xtbThuChi.Controls.Add(this.panel2);
            this.xtbThuChi.Controls.Add(this.panel1);
            this.xtbThuChi.Controls.Add(this.xtraTabControl1);
            this.xtbThuChi.Name = "xtbThuChi";
            this.xtbThuChi.Size = new System.Drawing.Size(733, 469);
            this.xtbThuChi.Text = "Thanh toán ";
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Location = new System.Drawing.Point(591, 384);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.ReadOnly = true;
            this.tbTotalPrice.Size = new System.Drawing.Size(139, 21);
            this.tbTotalPrice.TabIndex = 4;
            this.tbTotalPrice.Text = "0";
            this.tbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(518, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tổng tiền:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHoaDon);
            this.panel2.Controls.Add(this.btnPayBill);
            this.panel2.Location = new System.Drawing.Point(352, 411);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 55);
            this.panel2.TabIndex = 2;
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnHoaDon.Image")));
            this.btnHoaDon.Location = new System.Drawing.Point(157, 3);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(75, 50);
            this.btnHoaDon.TabIndex = 2;
            this.btnHoaDon.Text = "Hóa\r\nđơn";
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnPayBill
            // 
            this.btnPayBill.Location = new System.Drawing.Point(300, 3);
            this.btnPayBill.Name = "btnPayBill";
            this.btnPayBill.Size = new System.Drawing.Size(75, 49);
            this.btnPayBill.TabIndex = 0;
            this.btnPayBill.Text = "Thanh toán ";
            this.btnPayBill.Click += new System.EventHandler(this.btnPayBill_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbTenBan);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbMaBan);
            this.panel1.Controls.Add(this.tbTime);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(352, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 379);
            this.panel1.TabIndex = 1;
            // 
            // tbTenBan
            // 
            this.tbTenBan.Location = new System.Drawing.Point(181, 32);
            this.tbTenBan.Name = "tbTenBan";
            this.tbTenBan.ReadOnly = true;
            this.tbTenBan.Size = new System.Drawing.Size(85, 21);
            this.tbTenBan.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên bàn :";
            // 
            // tbMaBan
            // 
            this.tbMaBan.Location = new System.Drawing.Point(62, 32);
            this.tbMaBan.Name = "tbMaBan";
            this.tbMaBan.ReadOnly = true;
            this.tbMaBan.Size = new System.Drawing.Size(40, 21);
            this.tbMaBan.TabIndex = 6;
            // 
            // tbTime
            // 
            this.tbTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTime.Location = new System.Drawing.Point(62, 9);
            this.tbTime.Name = "tbTime";
            this.tbTime.ReadOnly = true;
            this.tbTime.Size = new System.Drawing.Size(204, 23);
            this.tbTime.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lvBill);
            this.panel3.Location = new System.Drawing.Point(3, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(372, 321);
            this.panel3.TabIndex = 4;
            // 
            // lvBill
            // 
            this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvBill.Location = new System.Drawing.Point(3, 3);
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(369, 318);
            this.lvBill.TabIndex = 0;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            this.lvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món ăn";
            this.columnHeader1.Width = 149;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 59;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 55;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền ";
            this.columnHeader4.Width = 123;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã bàn :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian : ";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(4, 4);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtbSanVuon;
            this.xtraTabControl1.Size = new System.Drawing.Size(342, 465);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtbSanVuon,
            this.xtbSansau,
            this.xtbMayLanh});
            // 
            // xtbSanVuon
            // 
            this.xtbSanVuon.AutoScroll = true;
            this.xtbSanVuon.Controls.Add(this.flpSanVuon);
            this.xtbSanVuon.Name = "xtbSanVuon";
            this.xtbSanVuon.Size = new System.Drawing.Size(338, 441);
            this.xtbSanVuon.Text = "Sân vườn ";
            this.xtbSanVuon.Paint += new System.Windows.Forms.PaintEventHandler(this.xtbSanVuon_Paint);
            // 
            // flpSanVuon
            // 
            this.flpSanVuon.AutoScroll = true;
            this.flpSanVuon.Location = new System.Drawing.Point(4, 4);
            this.flpSanVuon.Name = "flpSanVuon";
            this.flpSanVuon.Size = new System.Drawing.Size(331, 431);
            this.flpSanVuon.TabIndex = 0;
            // 
            // xtbSansau
            // 
            this.xtbSansau.Controls.Add(this.flpSansau);
            this.xtbSansau.Name = "xtbSansau";
            this.xtbSansau.Size = new System.Drawing.Size(338, 441);
            this.xtbSansau.Text = "Sân sau";
            // 
            // flpSansau
            // 
            this.flpSansau.AutoScroll = true;
            this.flpSansau.Location = new System.Drawing.Point(3, 3);
            this.flpSansau.Name = "flpSansau";
            this.flpSansau.Size = new System.Drawing.Size(332, 432);
            this.flpSansau.TabIndex = 0;
            // 
            // xtbMayLanh
            // 
            this.xtbMayLanh.Controls.Add(this.flpMayLanh);
            this.xtbMayLanh.Name = "xtbMayLanh";
            this.xtbMayLanh.Size = new System.Drawing.Size(338, 441);
            this.xtbMayLanh.Text = "Máy lạnh";
            // 
            // flpMayLanh
            // 
            this.flpMayLanh.AutoScroll = true;
            this.flpMayLanh.Location = new System.Drawing.Point(3, 3);
            this.flpMayLanh.Name = "flpMayLanh";
            this.flpMayLanh.Size = new System.Drawing.Size(332, 433);
            this.flpMayLanh.TabIndex = 0;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Coffee";
            // 
            // fThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 508);
            this.Controls.Add(this.tbcPayBill);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán Cafe";
            this.Load += new System.EventHandler(this.fThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbcPayBill)).EndInit();
            this.tbcPayBill.ResumeLayout(false);
            this.xtbThuChi.ResumeLayout(false);
            this.xtbThuChi.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtbSanVuon.ResumeLayout(false);
            this.xtbSansau.ResumeLayout(false);
            this.xtbMayLanh.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tbcPayBill;
        private DevExpress.XtraTab.XtraTabPage xtbThuChi;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnHoaDon;
        private DevExpress.XtraEditors.SimpleButton btnPayBill;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtbSanVuon;
        private System.Windows.Forms.FlowLayoutPanel flpSanVuon;
        private DevExpress.XtraTab.XtraTabPage xtbSansau;
        private System.Windows.Forms.FlowLayoutPanel flpSansau;
        private DevExpress.XtraTab.XtraTabPage xtbMayLanh;
        private System.Windows.Forms.FlowLayoutPanel flpMayLanh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.ListView lvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox tbTotalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTenBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMaBan;
        private System.Windows.Forms.TextBox tbTime;
    }
}