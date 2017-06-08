namespace QuanLyQuanCafe
{
    partial class fThongKe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThongKe));
            this.xtbChitieu = new DevExpress.XtraTab.XtraTabControl();
            this.xtbDoanhSo = new DevExpress.XtraTab.XtraTabPage();
            this.dgvDoanhSo = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDoanhSoThongKe = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimePickerDoanhSoBatDau = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDoanhSoKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.dataGridViewChiTieu = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimePickerBATDAU = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerKETTHUC = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInBaoCaoDoanhSo = new DevExpress.XtraEditors.SimpleButton();
            this.MAPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOIDUNG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYLAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GHICHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGUOINHAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simplebtnChiTien = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtbChitieu)).BeginInit();
            this.xtbChitieu.SuspendLayout();
            this.xtbDoanhSo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhSo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTieu)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtbChitieu
            // 
            this.xtbChitieu.Location = new System.Drawing.Point(12, 12);
            this.xtbChitieu.Name = "xtbChitieu";
            this.xtbChitieu.SelectedTabPage = this.xtbDoanhSo;
            this.xtbChitieu.Size = new System.Drawing.Size(777, 521);
            this.xtbChitieu.TabIndex = 0;
            this.xtbChitieu.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtbDoanhSo,
            this.xtraTabPage2});
            // 
            // xtbDoanhSo
            // 
            this.xtbDoanhSo.Controls.Add(this.btnInBaoCaoDoanhSo);
            this.xtbDoanhSo.Controls.Add(this.dgvDoanhSo);
            this.xtbDoanhSo.Controls.Add(this.panel1);
            this.xtbDoanhSo.Name = "xtbDoanhSo";
            this.xtbDoanhSo.Size = new System.Drawing.Size(773, 497);
            this.xtbDoanhSo.Text = "Doanh số ";
            // 
            // dgvDoanhSo
            // 
            this.dgvDoanhSo.Location = new System.Drawing.Point(6, 59);
            this.dgvDoanhSo.MainView = this.gridView1;
            this.dgvDoanhSo.Name = "dgvDoanhSo";
            this.dgvDoanhSo.Size = new System.Drawing.Size(756, 378);
            this.dgvDoanhSo.TabIndex = 3;
            this.dgvDoanhSo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvDoanhSo;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDoanhSoThongKe);
            this.panel1.Controls.Add(this.dateTimePickerDoanhSoBatDau);
            this.panel1.Controls.Add(this.dateTimePickerDoanhSoKetThuc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 53);
            this.panel1.TabIndex = 2;
            // 
            // btnDoanhSoThongKe
            // 
            this.btnDoanhSoThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnDoanhSoThongKe.Image")));
            this.btnDoanhSoThongKe.Location = new System.Drawing.Point(671, 3);
            this.btnDoanhSoThongKe.Name = "btnDoanhSoThongKe";
            this.btnDoanhSoThongKe.Size = new System.Drawing.Size(85, 44);
            this.btnDoanhSoThongKe.TabIndex = 8;
            this.btnDoanhSoThongKe.Text = "Thống kê";
            this.btnDoanhSoThongKe.Click += new System.EventHandler(this.btnDoanhSoThongKe_Click_1);
            // 
            // dateTimePickerDoanhSoBatDau
            // 
            this.dateTimePickerDoanhSoBatDau.CustomFormat = "";
            this.dateTimePickerDoanhSoBatDau.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDoanhSoBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDoanhSoBatDau.Location = new System.Drawing.Point(52, 16);
            this.dateTimePickerDoanhSoBatDau.Name = "dateTimePickerDoanhSoBatDau";
            this.dateTimePickerDoanhSoBatDau.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerDoanhSoBatDau.TabIndex = 3;
            // 
            // dateTimePickerDoanhSoKetThuc
            // 
            this.dateTimePickerDoanhSoKetThuc.CustomFormat = "";
            this.dateTimePickerDoanhSoKetThuc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDoanhSoKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDoanhSoKetThuc.Location = new System.Drawing.Point(321, 14);
            this.dateTimePickerDoanhSoKetThuc.Name = "dateTimePickerDoanhSoKetThuc";
            this.dateTimePickerDoanhSoKetThuc.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerDoanhSoKetThuc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến ngày ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày ";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.simplebtnChiTien);
            this.xtraTabPage2.Controls.Add(this.dataGridViewChiTieu);
            this.xtraTabPage2.Controls.Add(this.panel2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(771, 493);
            this.xtraTabPage2.Text = "Chi tiêu";
            // 
            // dataGridViewChiTieu
            // 
            this.dataGridViewChiTieu.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewChiTieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPC,
            this.NOIDUNG,
            this.NGAYLAP,
            this.GHICHU,
            this.NGUOINHAN,
            this.SOTIEN});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewChiTieu.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewChiTieu.Location = new System.Drawing.Point(4, 62);
            this.dataGridViewChiTieu.Name = "dataGridViewChiTieu";
            this.dataGridViewChiTieu.Size = new System.Drawing.Size(762, 366);
            this.dataGridViewChiTieu.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.simpleButton2);
            this.panel2.Controls.Add(this.dateTimePickerBATDAU);
            this.panel2.Controls.Add(this.dateTimePickerKETTHUC);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 53);
            this.panel2.TabIndex = 1;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(674, 6);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(85, 44);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "Thống kê";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // dateTimePickerBATDAU
            // 
            this.dateTimePickerBATDAU.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBATDAU.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBATDAU.Location = new System.Drawing.Point(56, 13);
            this.dateTimePickerBATDAU.Name = "dateTimePickerBATDAU";
            this.dateTimePickerBATDAU.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerBATDAU.TabIndex = 3;
            // 
            // dateTimePickerKETTHUC
            // 
            this.dateTimePickerKETTHUC.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerKETTHUC.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerKETTHUC.Location = new System.Drawing.Point(337, 13);
            this.dateTimePickerKETTHUC.Name = "dateTimePickerKETTHUC";
            this.dateTimePickerKETTHUC.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerKETTHUC.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Đến ngày ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Từ ngày";
            // 
            // btnInBaoCaoDoanhSo
            // 
            this.btnInBaoCaoDoanhSo.Image = ((System.Drawing.Image)(resources.GetObject("btnInBaoCaoDoanhSo.Image")));
            this.btnInBaoCaoDoanhSo.Location = new System.Drawing.Point(674, 443);
            this.btnInBaoCaoDoanhSo.Name = "btnInBaoCaoDoanhSo";
            this.btnInBaoCaoDoanhSo.Size = new System.Drawing.Size(85, 44);
            this.btnInBaoCaoDoanhSo.TabIndex = 6;
            this.btnInBaoCaoDoanhSo.Text = "In";
            this.btnInBaoCaoDoanhSo.Click += new System.EventHandler(this.btnInBaoCaoDoanhSo_Click_1);
            // 
            // MAPC
            // 
            this.MAPC.DataPropertyName = "MAPC";
            this.MAPC.HeaderText = "Mã PC";
            this.MAPC.Name = "MAPC";
            // 
            // NOIDUNG
            // 
            this.NOIDUNG.DataPropertyName = "NOIDUNG";
            this.NOIDUNG.HeaderText = "Nội dung";
            this.NOIDUNG.Name = "NOIDUNG";
            this.NOIDUNG.Width = 200;
            // 
            // NGAYLAP
            // 
            this.NGAYLAP.DataPropertyName = "NGAYLAP";
            this.NGAYLAP.HeaderText = "Ngày lập";
            this.NGAYLAP.Name = "NGAYLAP";
            // 
            // GHICHU
            // 
            this.GHICHU.DataPropertyName = "GHICHU";
            this.GHICHU.HeaderText = "Ghi chú";
            this.GHICHU.Name = "GHICHU";
            // 
            // NGUOINHAN
            // 
            this.NGUOINHAN.DataPropertyName = "NGUOINHAN";
            this.NGUOINHAN.HeaderText = "Người nhận";
            this.NGUOINHAN.Name = "NGUOINHAN";
            this.NGUOINHAN.Width = 120;
            // 
            // SOTIEN
            // 
            this.SOTIEN.DataPropertyName = "SOTIEN";
            this.SOTIEN.HeaderText = "Số tiền";
            this.SOTIEN.Name = "SOTIEN";
            // 
            // simplebtnChiTien
            // 
            this.simplebtnChiTien.Image = ((System.Drawing.Image)(resources.GetObject("simplebtnChiTien.Image")));
            this.simplebtnChiTien.Location = new System.Drawing.Point(677, 443);
            this.simplebtnChiTien.Name = "simplebtnChiTien";
            this.simplebtnChiTien.Size = new System.Drawing.Size(85, 44);
            this.simplebtnChiTien.TabIndex = 7;
            this.simplebtnChiTien.Text = "In";
            this.simplebtnChiTien.Click += new System.EventHandler(this.simplebtnChiTien_Click);
            // 
            // fThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 534);
            this.Controls.Add(this.xtbChitieu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán Cafe";
            this.Load += new System.EventHandler(this.fThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtbChitieu)).EndInit();
            this.xtbChitieu.ResumeLayout(false);
            this.xtbDoanhSo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhSo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTieu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtbChitieu;
        private DevExpress.XtraTab.XtraTabPage xtbDoanhSo;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDoanhSoBatDau;
        private System.Windows.Forms.DateTimePicker dateTimePickerDoanhSoKetThuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl dgvDoanhSo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.DateTimePicker dateTimePickerBATDAU;
        private System.Windows.Forms.DateTimePicker dateTimePickerKETTHUC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewChiTieu;
        private DevExpress.XtraEditors.SimpleButton btnDoanhSoThongKe;
        private DevExpress.XtraEditors.SimpleButton btnInBaoCaoDoanhSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOIDUNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYLAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GHICHU;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGUOINHAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOTIEN;
        private DevExpress.XtraEditors.SimpleButton simplebtnChiTien;
    }
}