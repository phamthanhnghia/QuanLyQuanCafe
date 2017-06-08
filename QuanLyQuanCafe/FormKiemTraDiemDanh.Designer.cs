namespace QuanLyQuanCafe
{
    partial class FormKiemTraDiemDanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKiemTraDiemDanh));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvKiemTraDiemDanh = new System.Windows.Forms.DataGridView();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENTHOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SONGAYDIEMDANH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CASANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CACHIEU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATOI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TINHLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateDenNgay = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTuNgay = new System.Windows.Forms.DateTimePicker();
            this.NhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiemTraDiemDanh)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dgvKiemTraDiemDanh);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 463);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(720, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 44);
            this.button2.TabIndex = 11;
            this.button2.Text = "In danh sách";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvKiemTraDiemDanh
            // 
            this.dgvKiemTraDiemDanh.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvKiemTraDiemDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKiemTraDiemDanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.HOTEN,
            this.DIENTHOAI,
            this.SONGAYDIEMDANH,
            this.CASANG,
            this.CACHIEU,
            this.CATOI,
            this.TINHLUONG});
            this.dgvKiemTraDiemDanh.Location = new System.Drawing.Point(3, 53);
            this.dgvKiemTraDiemDanh.Name = "dgvKiemTraDiemDanh";
            this.dgvKiemTraDiemDanh.Size = new System.Drawing.Size(840, 407);
            this.dgvKiemTraDiemDanh.TabIndex = 10;
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã NV";
            this.MANV.Name = "MANV";
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Họ Tên";
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Width = 105;
            // 
            // DIENTHOAI
            // 
            this.DIENTHOAI.DataPropertyName = "DIENTHOAI";
            this.DIENTHOAI.HeaderText = "Điện Thoại";
            this.DIENTHOAI.Name = "DIENTHOAI";
            // 
            // SONGAYDIEMDANH
            // 
            this.SONGAYDIEMDANH.DataPropertyName = "SONGAYDIEMDANH";
            this.SONGAYDIEMDANH.HeaderText = "Lần Điểm Danh";
            this.SONGAYDIEMDANH.Name = "SONGAYDIEMDANH";
            this.SONGAYDIEMDANH.Width = 120;
            // 
            // CASANG
            // 
            this.CASANG.DataPropertyName = "CASANG";
            this.CASANG.HeaderText = "Ca sáng";
            this.CASANG.Name = "CASANG";
            this.CASANG.Width = 90;
            // 
            // CACHIEU
            // 
            this.CACHIEU.DataPropertyName = "CACHIEU";
            this.CACHIEU.HeaderText = "Ca chiều";
            this.CACHIEU.Name = "CACHIEU";
            this.CACHIEU.Width = 90;
            // 
            // CATOI
            // 
            this.CATOI.DataPropertyName = "CATOI";
            this.CATOI.HeaderText = "Ca tối";
            this.CATOI.Name = "CATOI";
            this.CATOI.Width = 90;
            // 
            // TINHLUONG
            // 
            this.TINHLUONG.DataPropertyName = "TINHLUONG";
            this.TINHLUONG.HeaderText = "Tính Lương";
            this.TINHLUONG.Name = "TINHLUONG";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(619, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "Kiểm Tra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dateDenNgay);
            this.panel3.Location = new System.Drawing.Point(313, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 44);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Đến ngày  :";
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.CustomFormat = "MM/dd/yyyy";
            this.dateDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDenNgay.Location = new System.Drawing.Point(94, 10);
            this.dateDenNgay.Name = "dateDenNgay";
            this.dateDenNgay.Size = new System.Drawing.Size(203, 22);
            this.dateDenNgay.TabIndex = 4;
            this.dateDenNgay.Value = new System.DateTime(2017, 5, 4, 12, 22, 30, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dateTuNgay);
            this.panel2.Location = new System.Drawing.Point(3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 44);
            this.panel2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Từ ngày :";
            // 
            // dateTuNgay
            // 
            this.dateTuNgay.CustomFormat = "MM/dd/yyyy";
            this.dateTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTuNgay.Location = new System.Drawing.Point(81, 10);
            this.dateTuNgay.Name = "dateTuNgay";
            this.dateTuNgay.Size = new System.Drawing.Size(207, 22);
            this.dateTuNgay.TabIndex = 4;
            this.dateTuNgay.Value = new System.DateTime(2017, 5, 4, 12, 22, 30, 0);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Coffee";
            // 
            // FormKiemTraDiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 487);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKiemTraDiemDanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiểm tra điểm danh và tính lương";
            this.Load += new System.EventHandler(this.FormKiemTraDiemDanh_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiemTraDiemDanh)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvKiemTraDiemDanh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateDenNgay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTuNgay;
        private System.Windows.Forms.BindingSource NhanVienBindingSource;
        private System.Windows.Forms.BindingSource TINHCABindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIENTHOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SONGAYDIEMDANH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CASANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn CACHIEU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATOI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TINHLUONG;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}