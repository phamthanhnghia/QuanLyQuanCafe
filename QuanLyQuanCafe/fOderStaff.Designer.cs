namespace QuanLyQuanCafe
{
    partial class fOderStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fOderStaff));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbLoaiMon = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvShowFood = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.flpTableFood = new System.Windows.Forms.FlowLayoutPanel();
            this.fjjfj = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.flpSanVuon = new System.Windows.Forms.FlowLayoutPanel();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.flpSansau = new System.Windows.Forms.FlowLayoutPanel();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.flpMayLanh = new System.Windows.Forms.FlowLayoutPanel();
            this.imageDanhMuc = new System.Windows.Forms.ImageList(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXacNhan = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lsvShowBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFind = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTenBan = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMaBan = new System.Windows.Forms.TextBox();
            this.btnDeleteFood = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flpTableFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fjjfj)).BeginInit();
            this.fjjfj.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel4.SuspendLayout();
            this.btnFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbLoaiMon);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(752, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 488);
            this.panel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Chọn Loại :";
            // 
            // cbLoaiMon
            // 
            this.cbLoaiMon.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiMon.FormattingEnabled = true;
            this.cbLoaiMon.Location = new System.Drawing.Point(79, 18);
            this.cbLoaiMon.Name = "cbLoaiMon";
            this.cbLoaiMon.Size = new System.Drawing.Size(169, 24);
            this.cbLoaiMon.TabIndex = 15;
            this.cbLoaiMon.SelectedIndexChanged += new System.EventHandler(this.cbLoaiMon_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lvShowFood);
            this.panel3.Location = new System.Drawing.Point(3, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(297, 421);
            this.panel3.TabIndex = 0;
            // 
            // lvShowFood
            // 
            this.lvShowFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvShowFood.FullRowSelect = true;
            this.lvShowFood.Location = new System.Drawing.Point(0, 3);
            this.lvShowFood.Name = "lvShowFood";
            this.lvShowFood.Size = new System.Drawing.Size(294, 415);
            this.lvShowFood.TabIndex = 0;
            this.lvShowFood.UseCompatibleStateImageBehavior = false;
            this.lvShowFood.View = System.Windows.Forms.View.Details;
            this.lvShowFood.Click += new System.EventHandler(this.lvShowFood_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên món ";
            this.columnHeader2.Width = 135;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ĐVT";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá";
            this.columnHeader4.Width = 94;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Coffee";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1060, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // flpTableFood
            // 
            this.flpTableFood.Controls.Add(this.fjjfj);
            this.flpTableFood.Location = new System.Drawing.Point(0, 27);
            this.flpTableFood.Name = "flpTableFood";
            this.flpTableFood.Size = new System.Drawing.Size(332, 488);
            this.flpTableFood.TabIndex = 5;
            // 
            // fjjfj
            // 
            this.fjjfj.Location = new System.Drawing.Point(3, 3);
            this.fjjfj.Name = "fjjfj";
            this.fjjfj.SelectedTabPage = this.xtraTabPage1;
            this.fjjfj.Size = new System.Drawing.Size(324, 478);
            this.fjjfj.TabIndex = 0;
            this.fjjfj.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.AllowTouchScroll = true;
            this.xtraTabPage1.Controls.Add(this.flpSanVuon);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(320, 454);
            this.xtraTabPage1.Text = "Sân vườn ";
            // 
            // flpSanVuon
            // 
            this.flpSanVuon.AutoScroll = true;
            this.flpSanVuon.Location = new System.Drawing.Point(0, 4);
            this.flpSanVuon.Name = "flpSanVuon";
            this.flpSanVuon.Size = new System.Drawing.Size(322, 450);
            this.flpSanVuon.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.flpSansau);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(320, 454);
            this.xtraTabPage2.Text = "Sân sau";
            // 
            // flpSansau
            // 
            this.flpSansau.AutoScroll = true;
            this.flpSansau.Location = new System.Drawing.Point(0, 3);
            this.flpSansau.Name = "flpSansau";
            this.flpSansau.Size = new System.Drawing.Size(322, 448);
            this.flpSansau.TabIndex = 0;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.flpMayLanh);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(320, 454);
            this.xtraTabPage3.Text = "Máy lạnh";
            // 
            // flpMayLanh
            // 
            this.flpMayLanh.AutoScroll = true;
            this.flpMayLanh.Location = new System.Drawing.Point(4, 4);
            this.flpMayLanh.Name = "flpMayLanh";
            this.flpMayLanh.Size = new System.Drawing.Size(314, 447);
            this.flpMayLanh.TabIndex = 0;
            // 
            // imageDanhMuc
            // 
            this.imageDanhMuc.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageDanhMuc.ImageStream")));
            this.imageDanhMuc.TransparentColor = System.Drawing.Color.Transparent;
            this.imageDanhMuc.Images.SetKeyName(0, "1.jpg");
            this.imageDanhMuc.Images.SetKeyName(1, "2.jpg");
            this.imageDanhMuc.Images.SetKeyName(2, "3.jpg");
            this.imageDanhMuc.Images.SetKeyName(3, "4.jpg");
            this.imageDanhMuc.Images.SetKeyName(4, "5.jpg");
            this.imageDanhMuc.Images.SetKeyName(5, "6.png");
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thời gian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Appearance.Options.UseFont = true;
            this.btnXacNhan.Location = new System.Drawing.Point(332, 433);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(54, 48);
            this.btnXacNhan.TabIndex = 13;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lsvShowBill);
            this.panel4.Location = new System.Drawing.Point(3, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(389, 365);
            this.panel4.TabIndex = 14;
            // 
            // lsvShowBill
            // 
            this.lsvShowBill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvShowBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lsvShowBill.FullRowSelect = true;
            this.lsvShowBill.GridLines = true;
            this.lsvShowBill.Location = new System.Drawing.Point(3, 3);
            this.lsvShowBill.MultiSelect = false;
            this.lsvShowBill.Name = "lsvShowBill";
            this.lsvShowBill.Size = new System.Drawing.Size(383, 359);
            this.lsvShowBill.TabIndex = 0;
            this.lsvShowBill.UseCompatibleStateImageBehavior = false;
            this.lsvShowBill.View = System.Windows.Forms.View.Details;
            this.lsvShowBill.Click += new System.EventHandler(this.lsvShowBill_Click);
            this.lsvShowBill.DoubleClick += new System.EventHandler(this.lsvShowBill_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món ăn";
            this.columnHeader1.Width = 119;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số lượng";
            this.columnHeader5.Width = 69;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Đơn giá";
            this.columnHeader6.Width = 82;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Thành tiền ";
            this.columnHeader7.Width = 116;
            // 
            // btnFind
            // 
            this.btnFind.Controls.Add(this.label1);
            this.btnFind.Controls.Add(this.tbTenBan);
            this.btnFind.Controls.Add(this.tbTime);
            this.btnFind.Controls.Add(this.label4);
            this.btnFind.Controls.Add(this.tbMaBan);
            this.btnFind.Controls.Add(this.btnDeleteFood);
            this.btnFind.Controls.Add(this.panel4);
            this.btnFind.Controls.Add(this.btnXacNhan);
            this.btnFind.Controls.Add(this.label3);
            this.btnFind.Controls.Add(this.label2);
            this.btnFind.Location = new System.Drawing.Point(352, 27);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(395, 488);
            this.btnFind.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tên Bàn";
            // 
            // tbTenBan
            // 
            this.tbTenBan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenBan.Location = new System.Drawing.Point(157, 34);
            this.tbTenBan.Name = "tbTenBan";
            this.tbTenBan.ReadOnly = true;
            this.tbTenBan.Size = new System.Drawing.Size(93, 23);
            this.tbTenBan.TabIndex = 19;
            // 
            // tbTime
            // 
            this.tbTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTime.Location = new System.Drawing.Point(59, 7);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(191, 23);
            this.tbTime.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Mã Bàn";
            // 
            // tbMaBan
            // 
            this.tbMaBan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaBan.Location = new System.Drawing.Point(59, 34);
            this.tbMaBan.Name = "tbMaBan";
            this.tbMaBan.ReadOnly = true;
            this.tbMaBan.Size = new System.Drawing.Size(39, 23);
            this.tbMaBan.TabIndex = 16;
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteFood.Image")));
            this.btnDeleteFood.Location = new System.Drawing.Point(316, 11);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(70, 37);
            this.btnDeleteFood.TabIndex = 15;
            this.btnDeleteFood.Text = "Xóa";
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // fOderStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 527);
            this.Controls.Add(this.flpTableFood);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fOderStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán Cafe ";
            this.Load += new System.EventHandler(this.fOderStaff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.flpTableFood.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fjjfj)).EndInit();
            this.fjjfj.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.btnFind.ResumeLayout(false);
            this.btnFind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListView lvShowFood;
        private System.Windows.Forms.FlowLayoutPanel flpTableFood;
        private DevExpress.XtraTab.XtraTabControl fjjfj;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.FlowLayoutPanel flpSanVuon;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.FlowLayoutPanel flpSansau;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private System.Windows.Forms.FlowLayoutPanel flpMayLanh;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ImageList imageDanhMuc;
        private System.Windows.Forms.ComboBox cbLoaiMon;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel btnFind;
        private DevExpress.XtraEditors.SimpleButton btnDeleteFood;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView lsvShowBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private DevExpress.XtraEditors.SimpleButton btnXacNhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMaBan;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTenBan;
        private System.Windows.Forms.Label label5;
    }
}