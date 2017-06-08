namespace QuanLyQuanCafe
{
    partial class fTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTaiKhoan));
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.gdChiTieu = new DevExpress.XtraGrid.GridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMATKHAULAI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMATKHAU = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton15 = new DevExpress.XtraEditors.SimpleButton();
            this.panel11 = new System.Windows.Forms.Panel();
            this.cbbLOAITK = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtTENTK = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdChiTieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENTK.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnThem);
            this.panel8.Controls.Add(this.btnXoa);
            this.panel8.Location = new System.Drawing.Point(12, 12);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(719, 50);
            this.panel8.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 43);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm ";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(105, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 43);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // gdChiTieu
            // 
            this.gdChiTieu.Location = new System.Drawing.Point(14, 68);
            this.gdChiTieu.MainView = this.gridView5;
            this.gdChiTieu.Name = "gdChiTieu";
            this.gdChiTieu.Size = new System.Drawing.Size(400, 395);
            this.gdChiTieu.TabIndex = 2;
            this.gdChiTieu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn11,
            this.gridColumn12});
            this.gridView5.GridControl = this.gdChiTieu;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Tên tài khoản";
            this.gridColumn11.FieldName = "TENTK";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 0;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Loại tài khoản";
            this.gridColumn12.FieldName = "LOAITK";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel2);
            this.panel9.Controls.Add(this.panel1);
            this.panel9.Controls.Add(this.simpleButton15);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(416, 72);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(318, 391);
            this.panel9.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMATKHAULAI);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(6, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 44);
            this.panel2.TabIndex = 11;
            // 
            // txtMATKHAULAI
            // 
            this.txtMATKHAULAI.Location = new System.Drawing.Point(115, 14);
            this.txtMATKHAULAI.Name = "txtMATKHAULAI";
            this.txtMATKHAULAI.Size = new System.Drawing.Size(185, 21);
            this.txtMATKHAULAI.TabIndex = 3;
            this.txtMATKHAULAI.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lại mật khẩu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMATKHAU);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 44);
            this.panel1.TabIndex = 10;
            // 
            // txtMATKHAU
            // 
            this.txtMATKHAU.Location = new System.Drawing.Point(115, 14);
            this.txtMATKHAU.Name = "txtMATKHAU";
            this.txtMATKHAU.Size = new System.Drawing.Size(185, 21);
            this.txtMATKHAU.TabIndex = 2;
            this.txtMATKHAU.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu";
            // 
            // simpleButton15
            // 
            this.simpleButton15.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton15.Image")));
            this.simpleButton15.Location = new System.Drawing.Point(210, 335);
            this.simpleButton15.Name = "simpleButton15";
            this.simpleButton15.Size = new System.Drawing.Size(96, 53);
            this.simpleButton15.TabIndex = 9;
            this.simpleButton15.Text = "Đặt lại\r\nmật khẩu ";
            this.simpleButton15.Click += new System.EventHandler(this.simpleButton15_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.cbbLOAITK);
            this.panel11.Controls.Add(this.label10);
            this.panel11.Location = new System.Drawing.Point(6, 99);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(306, 44);
            this.panel11.TabIndex = 1;
            // 
            // cbbLOAITK
            // 
            this.cbbLOAITK.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLOAITK.FormattingEnabled = true;
            this.cbbLOAITK.Items.AddRange(new object[] {
            "Quan li",
            "Nhan vien",
            "Thu ngan"});
            this.cbbLOAITK.Location = new System.Drawing.Point(115, 14);
            this.cbbLOAITK.Name = "cbbLOAITK";
            this.cbbLOAITK.Size = new System.Drawing.Size(185, 24);
            this.cbbLOAITK.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Loại tài khoản: ";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txtTENTK);
            this.panel10.Controls.Add(this.label9);
            this.panel10.Location = new System.Drawing.Point(6, 49);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(306, 44);
            this.panel10.TabIndex = 0;
            // 
            // txtTENTK
            // 
            this.txtTENTK.Location = new System.Drawing.Point(115, 13);
            this.txtTENTK.Name = "txtTENTK";
            this.txtTENTK.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTENTK.Properties.Appearance.Options.UseFont = true;
            this.txtTENTK.Size = new System.Drawing.Size(185, 22);
            this.txtTENTK.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tên tài khoản";
            // 
            // fTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 475);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.gdChiTieu);
            this.Controls.Add(this.panel8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán Cafe";
            this.Load += new System.EventHandler(this.fTaiKhoan_Load);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdChiTieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENTK.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraGrid.GridControl gdChiTieu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private System.Windows.Forms.Panel panel9;
        private DevExpress.XtraEditors.SimpleButton simpleButton15;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel10;
        private DevExpress.XtraEditors.TextEdit txtTENTK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbLOAITK;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMATKHAULAI;
        private System.Windows.Forms.TextBox txtMATKHAU;
    }
}