namespace QuanLyQuanCafe
{
    partial class FormNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENTHOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAINV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.indanhsach = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaNhanVien = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaNhanVien = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemNhanVien = new DevExpress.XtraEditors.SimpleButton();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCHUCVU = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtLOAINV = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDIENTHOAI = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtNGAYSINH = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtPHAI = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDIACHI = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHOTEN = new System.Windows.Forms.TextBox();
            this.NhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgvDanhSach);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 519);
            this.panel1.TabIndex = 1;
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.HOTEN,
            this.PHAI,
            this.NGAYSINH,
            this.CMND,
            this.DIACHI,
            this.DIENTHOAI,
            this.LOAINV,
            this.TENCV});
            this.dgvDanhSach.Location = new System.Drawing.Point(0, 197);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersVisible = false;
            this.dgvDanhSach.Size = new System.Drawing.Size(1170, 325);
            this.dgvDanhSach.TabIndex = 5;
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã NV";
            this.MANV.Name = "MANV";
            this.MANV.Width = 70;
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Họ Tên";
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Width = 175;
            // 
            // PHAI
            // 
            this.PHAI.DataPropertyName = "PHAI";
            this.PHAI.HeaderText = "Giới Tính";
            this.PHAI.Name = "PHAI";
            this.PHAI.Width = 75;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày Sinh";
            this.NGAYSINH.Name = "NGAYSINH";
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa Chỉ";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Width = 275;
            // 
            // DIENTHOAI
            // 
            this.DIENTHOAI.DataPropertyName = "DIENTHOAI";
            this.DIENTHOAI.HeaderText = "Điện Thoại";
            this.DIENTHOAI.Name = "DIENTHOAI";
            this.DIENTHOAI.Width = 110;
            // 
            // LOAINV
            // 
            this.LOAINV.DataPropertyName = "LOAINV";
            this.LOAINV.HeaderText = "Loại Nhân Viên";
            this.LOAINV.Name = "LOAINV";
            this.LOAINV.Width = 140;
            // 
            // TENCV
            // 
            this.TENCV.DataPropertyName = "TENCV";
            this.TENCV.HeaderText = "Chức Vụ";
            this.TENCV.Name = "TENCV";
            this.TENCV.Width = 114;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.indanhsach);
            this.panel2.Controls.Add(this.btnSuaNhanVien);
            this.panel2.Controls.Add(this.btnXoaNhanVien);
            this.panel2.Controls.Add(this.btnThemNhanVien);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 188);
            this.panel2.TabIndex = 4;
            // 
            // indanhsach
            // 
            this.indanhsach.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indanhsach.Appearance.Options.UseFont = true;
            this.indanhsach.Image = ((System.Drawing.Image)(resources.GetObject("indanhsach.Image")));
            this.indanhsach.Location = new System.Drawing.Point(483, 140);
            this.indanhsach.Name = "indanhsach";
            this.indanhsach.Size = new System.Drawing.Size(112, 43);
            this.indanhsach.TabIndex = 19;
            this.indanhsach.Text = "Danh sách";
            this.indanhsach.Click += new System.EventHandler(this.indanhsach_Click_1);
            // 
            // btnSuaNhanVien
            // 
            this.btnSuaNhanVien.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNhanVien.Appearance.Options.UseFont = true;
            this.btnSuaNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaNhanVien.Image")));
            this.btnSuaNhanVien.Location = new System.Drawing.Point(326, 140);
            this.btnSuaNhanVien.Name = "btnSuaNhanVien";
            this.btnSuaNhanVien.Size = new System.Drawing.Size(96, 43);
            this.btnSuaNhanVien.TabIndex = 17;
            this.btnSuaNhanVien.Text = "Sửa";
            this.btnSuaNhanVien.Click += new System.EventHandler(this.btnSuaNhanVien_Click_1);
            // 
            // btnXoaNhanVien
            // 
            this.btnXoaNhanVien.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNhanVien.Appearance.Options.UseFont = true;
            this.btnXoaNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaNhanVien.Image")));
            this.btnXoaNhanVien.Location = new System.Drawing.Point(163, 142);
            this.btnXoaNhanVien.Name = "btnXoaNhanVien";
            this.btnXoaNhanVien.Size = new System.Drawing.Size(108, 43);
            this.btnXoaNhanVien.TabIndex = 16;
            this.btnXoaNhanVien.Text = "Xóa ";
            this.btnXoaNhanVien.Click += new System.EventHandler(this.btnXoaNhanVien_Click_1);
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNhanVien.Appearance.Options.UseFont = true;
            this.btnThemNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNhanVien.Image")));
            this.btnThemNhanVien.Location = new System.Drawing.Point(5, 142);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(105, 43);
            this.btnThemNhanVien.TabIndex = 15;
            this.btnThemNhanVien.Text = "Thêm";
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnThemNhanVien_Click_1);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.txtMANV);
            this.panel11.Controls.Add(this.label9);
            this.panel11.Location = new System.Drawing.Point(5, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(251, 42);
            this.panel11.TabIndex = 8;
            // 
            // txtMANV
            // 
            this.txtMANV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMANV.Location = new System.Drawing.Point(82, 10);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.ReadOnly = true;
            this.txtMANV.Size = new System.Drawing.Size(162, 22);
            this.txtMANV.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "MANV :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtCHUCVU);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(906, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 42);
            this.panel3.TabIndex = 1;
            // 
            // txtCHUCVU
            // 
            this.txtCHUCVU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCHUCVU.FormattingEnabled = true;
            this.txtCHUCVU.Items.AddRange(new object[] {
            "Nhân Viên",
            "Thu Ngân ",
            "Pha Chế",
            "Quản lý"});
            this.txtCHUCVU.Location = new System.Drawing.Point(85, 9);
            this.txtCHUCVU.Name = "txtCHUCVU";
            this.txtCHUCVU.Size = new System.Drawing.Size(167, 24);
            this.txtCHUCVU.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chức vụ  :";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txtLOAINV);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Location = new System.Drawing.Point(566, 51);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(340, 42);
            this.panel10.TabIndex = 7;
            // 
            // txtLOAINV
            // 
            this.txtLOAINV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLOAINV.FormattingEnabled = true;
            this.txtLOAINV.Items.AddRange(new object[] {
            "Nhân Viên Thời Vụ",
            "Nhân Viên Chính Thức"});
            this.txtLOAINV.Location = new System.Drawing.Point(113, 11);
            this.txtLOAINV.Name = "txtLOAINV";
            this.txtLOAINV.Size = new System.Drawing.Size(224, 24);
            this.txtLOAINV.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Loại nhân viên:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label7);
            this.panel9.Controls.Add(this.txtDIENTHOAI);
            this.panel9.Location = new System.Drawing.Point(566, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(340, 42);
            this.panel9.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Điện thoại:";
            // 
            // txtDIENTHOAI
            // 
            this.txtDIENTHOAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDIENTHOAI.Location = new System.Drawing.Point(113, 11);
            this.txtDIENTHOAI.Name = "txtDIENTHOAI";
            this.txtDIENTHOAI.Size = new System.Drawing.Size(221, 22);
            this.txtDIENTHOAI.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtNGAYSINH);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Location = new System.Drawing.Point(5, 44);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(251, 42);
            this.panel8.TabIndex = 5;
            // 
            // txtNGAYSINH
            // 
            this.txtNGAYSINH.CustomFormat = "MM/dd/yyyy";
            this.txtNGAYSINH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNGAYSINH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNGAYSINH.Location = new System.Drawing.Point(82, 13);
            this.txtNGAYSINH.Name = "txtNGAYSINH";
            this.txtNGAYSINH.Size = new System.Drawing.Size(157, 22);
            this.txtNGAYSINH.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày sinh:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtPHAI);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(262, 44);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(301, 42);
            this.panel7.TabIndex = 4;
            // 
            // txtPHAI
            // 
            this.txtPHAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPHAI.FormattingEnabled = true;
            this.txtPHAI.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.txtPHAI.Location = new System.Drawing.Point(85, 9);
            this.txtPHAI.Name = "txtPHAI";
            this.txtPHAI.Size = new System.Drawing.Size(213, 24);
            this.txtPHAI.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Giới tính  :";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtCMND);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(906, 51);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(255, 42);
            this.panel5.TabIndex = 3;
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(85, 11);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(167, 22);
            this.txtCMND.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "CMND :";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.txtDIACHI);
            this.panel6.Location = new System.Drawing.Point(8, 92);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1150, 42);
            this.panel6.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Địa chỉ  :";
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDIACHI.Location = new System.Drawing.Point(79, 11);
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(1068, 22);
            this.txtDIACHI.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtHOTEN);
            this.panel4.Location = new System.Drawing.Point(262, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(301, 42);
            this.panel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên :";
            // 
            // txtHOTEN
            // 
            this.txtHOTEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHOTEN.Location = new System.Drawing.Point(73, 10);
            this.txtHOTEN.Name = "txtHOTEN";
            this.txtHOTEN.Size = new System.Drawing.Size(225, 22);
            this.txtHOTEN.TabIndex = 0;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Coffee";
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1194, 543);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox txtCHUCVU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox txtLOAINV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDIENTHOAI;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DateTimePicker txtNGAYSINH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox txtPHAI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDIACHI;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHOTEN;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource NhanVienBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIENTHOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAINV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENCV;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.SimpleButton btnThemNhanVien;
        private DevExpress.XtraEditors.SimpleButton btnXoaNhanVien;
        private DevExpress.XtraEditors.SimpleButton btnSuaNhanVien;
        private DevExpress.XtraEditors.SimpleButton indanhsach;
    }
}