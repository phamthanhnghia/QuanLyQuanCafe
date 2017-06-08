namespace QuanLyQuanCafe
{
    partial class FormThucHienDiemDanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThucHienDiemDanh));
            this.dgvNVChuaDiemDanh = new System.Windows.Forms.DataGridView();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAINV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNVDaDiemDanh = new System.Windows.Forms.DataGridView();
            this.MANV_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAINV_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHUCVU_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.diemdanh = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCATRUC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNGAY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNVChuaDiemDanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNVDaDiemDanh)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNVChuaDiemDanh
            // 
            this.dgvNVChuaDiemDanh.BackgroundColor = System.Drawing.Color.White;
            this.dgvNVChuaDiemDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNVChuaDiemDanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.HOTEN,
            this.NGAYSINH,
            this.LOAINV,
            this.TENCV});
            this.dgvNVChuaDiemDanh.Location = new System.Drawing.Point(3, 69);
            this.dgvNVChuaDiemDanh.Name = "dgvNVChuaDiemDanh";
            this.dgvNVChuaDiemDanh.Size = new System.Drawing.Size(453, 416);
            this.dgvNVChuaDiemDanh.TabIndex = 0;
            this.dgvNVChuaDiemDanh.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNVChuaDiemDanh_CellMouseClick);
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã NV";
            this.MANV.Name = "MANV";
            this.MANV.Width = 50;
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Họ Tên";
            this.HOTEN.Name = "HOTEN";
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày Sinh";
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.Width = 60;
            // 
            // LOAINV
            // 
            this.LOAINV.DataPropertyName = "LOAINV";
            this.LOAINV.HeaderText = "Loại NV";
            this.LOAINV.Name = "LOAINV";
            this.LOAINV.Width = 105;
            // 
            // TENCV
            // 
            this.TENCV.DataPropertyName = "TENCV";
            this.TENCV.HeaderText = "Chức Vụ";
            this.TENCV.Name = "TENCV";
            this.TENCV.Width = 90;
            // 
            // dgvNVDaDiemDanh
            // 
            this.dgvNVDaDiemDanh.BackgroundColor = System.Drawing.Color.White;
            this.dgvNVDaDiemDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNVDaDiemDanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV_2,
            this.HOTEN_2,
            this.NGAYSINH_2,
            this.LOAINV_2,
            this.CHUCVU_2});
            this.dgvNVDaDiemDanh.Location = new System.Drawing.Point(462, 69);
            this.dgvNVDaDiemDanh.Name = "dgvNVDaDiemDanh";
            this.dgvNVDaDiemDanh.Size = new System.Drawing.Size(450, 416);
            this.dgvNVDaDiemDanh.TabIndex = 1;
            // 
            // MANV_2
            // 
            this.MANV_2.DataPropertyName = "MANV";
            this.MANV_2.HeaderText = "Mã NV";
            this.MANV_2.Name = "MANV_2";
            this.MANV_2.Width = 50;
            // 
            // HOTEN_2
            // 
            this.HOTEN_2.DataPropertyName = "HOTEN";
            this.HOTEN_2.HeaderText = "Họ Tên";
            this.HOTEN_2.Name = "HOTEN_2";
            // 
            // NGAYSINH_2
            // 
            this.NGAYSINH_2.DataPropertyName = "NGAYSINH";
            this.NGAYSINH_2.HeaderText = "Ngày Sinh";
            this.NGAYSINH_2.Name = "NGAYSINH_2";
            this.NGAYSINH_2.Width = 60;
            // 
            // LOAINV_2
            // 
            this.LOAINV_2.DataPropertyName = "LOAINV";
            this.LOAINV_2.HeaderText = "Loại NV";
            this.LOAINV_2.Name = "LOAINV_2";
            this.LOAINV_2.Width = 105;
            // 
            // CHUCVU_2
            // 
            this.CHUCVU_2.DataPropertyName = "TENCV";
            this.CHUCVU_2.HeaderText = "Chức Vụ";
            this.CHUCVU_2.Name = "CHUCVU_2";
            this.CHUCVU_2.Width = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhân viên chưa điểm danh";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(462, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhân viên đã điểm danh";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvNVChuaDiemDanh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvNVDaDiemDanh);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 519);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.diemdanh);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txtMANV);
            this.panel5.Location = new System.Drawing.Point(462, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(450, 44);
            this.panel5.TabIndex = 9;
            // 
            // diemdanh
            // 
            this.diemdanh.BackColor = System.Drawing.Color.Transparent;
            this.diemdanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diemdanh.Location = new System.Drawing.Point(348, 3);
            this.diemdanh.Name = "diemdanh";
            this.diemdanh.Size = new System.Drawing.Size(99, 41);
            this.diemdanh.TabIndex = 10;
            this.diemdanh.Text = "Điểm danh";
            this.diemdanh.UseVisualStyleBackColor = false;
            this.diemdanh.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "MANV";
            // 
            // txtMANV
            // 
            this.txtMANV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMANV.Location = new System.Drawing.Point(63, 12);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.ReadOnly = true;
            this.txtMANV.Size = new System.Drawing.Size(180, 22);
            this.txtMANV.TabIndex = 8;
            this.txtMANV.TextChanged += new System.EventHandler(this.txtMANV_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtCATRUC);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(230, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 44);
            this.panel3.TabIndex = 6;
            // 
            // txtCATRUC
            // 
            this.txtCATRUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCATRUC.Location = new System.Drawing.Point(79, 14);
            this.txtCATRUC.Name = "txtCATRUC";
            this.txtCATRUC.ReadOnly = true;
            this.txtCATRUC.Size = new System.Drawing.Size(144, 22);
            this.txtCATRUC.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ca Trực :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtNGAY);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(6, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 44);
            this.panel2.TabIndex = 5;
            // 
            // txtNGAY
            // 
            this.txtNGAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNGAY.Location = new System.Drawing.Point(79, 13);
            this.txtNGAY.Name = "txtNGAY";
            this.txtNGAY.ReadOnly = true;
            this.txtNGAY.Size = new System.Drawing.Size(136, 22);
            this.txtNGAY.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hôm nay :";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Coffee";
            // 
            // FormThucHienDiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(939, 543);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormThucHienDiemDanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thực hiện điểm danh";
            this.Load += new System.EventHandler(this.FormThucHienDiemDanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNVChuaDiemDanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNVDaDiemDanh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNVChuaDiemDanh;
        private System.Windows.Forms.DataGridView dgvNVDaDiemDanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button diemdanh;
        private System.Windows.Forms.TextBox txtCATRUC;
        private System.Windows.Forms.TextBox txtNGAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAINV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAINV_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHUCVU_2;
        private System.Windows.Forms.Label label6;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}