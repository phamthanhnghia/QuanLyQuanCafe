namespace QuanLyQuanCafe
{
    partial class fThemMonAnmoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThemMonAnmoi));
            this.label1 = new System.Windows.Forms.Label();
            this.txbTenMonAnmoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbDonGiaMonAnmoi = new System.Windows.Forms.TextBox();
            this.txbDVTMonAnmoi = new System.Windows.Forms.TextBox();
            this.cbbLoaiMonAnmoi = new System.Windows.Forms.ComboBox();
            this.btnXacNhanThemMonAnmoi = new System.Windows.Forms.Button();
            this.btnThoatThemMonAnmoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Món Ăn :";
            // 
            // txbTenMonAnmoi
            // 
            this.txbTenMonAnmoi.Location = new System.Drawing.Point(110, 19);
            this.txbTenMonAnmoi.Name = "txbTenMonAnmoi";
            this.txbTenMonAnmoi.Size = new System.Drawing.Size(180, 22);
            this.txbTenMonAnmoi.TabIndex = 1;
            this.txbTenMonAnmoi.TextChanged += new System.EventHandler(this.txbTenMonAnmoi_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đơn Giá :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đơn Vị Tính :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Loại Món Ăn :";
            // 
            // txbDonGiaMonAnmoi
            // 
            this.txbDonGiaMonAnmoi.Location = new System.Drawing.Point(110, 59);
            this.txbDonGiaMonAnmoi.Name = "txbDonGiaMonAnmoi";
            this.txbDonGiaMonAnmoi.Size = new System.Drawing.Size(180, 22);
            this.txbDonGiaMonAnmoi.TabIndex = 6;
            // 
            // txbDVTMonAnmoi
            // 
            this.txbDVTMonAnmoi.Location = new System.Drawing.Point(111, 98);
            this.txbDVTMonAnmoi.Name = "txbDVTMonAnmoi";
            this.txbDVTMonAnmoi.Size = new System.Drawing.Size(179, 22);
            this.txbDVTMonAnmoi.TabIndex = 7;
            // 
            // cbbLoaiMonAnmoi
            // 
            this.cbbLoaiMonAnmoi.FormattingEnabled = true;
            this.cbbLoaiMonAnmoi.Location = new System.Drawing.Point(111, 138);
            this.cbbLoaiMonAnmoi.Name = "cbbLoaiMonAnmoi";
            this.cbbLoaiMonAnmoi.Size = new System.Drawing.Size(179, 24);
            this.cbbLoaiMonAnmoi.TabIndex = 8;
            // 
            // btnXacNhanThemMonAnmoi
            // 
            this.btnXacNhanThemMonAnmoi.Location = new System.Drawing.Point(96, 200);
            this.btnXacNhanThemMonAnmoi.Name = "btnXacNhanThemMonAnmoi";
            this.btnXacNhanThemMonAnmoi.Size = new System.Drawing.Size(90, 23);
            this.btnXacNhanThemMonAnmoi.TabIndex = 9;
            this.btnXacNhanThemMonAnmoi.Text = "Xác Nhận";
            this.btnXacNhanThemMonAnmoi.UseVisualStyleBackColor = true;
            this.btnXacNhanThemMonAnmoi.Click += new System.EventHandler(this.btnXacNhanThemMonAnmoi_Click);
            // 
            // btnThoatThemMonAnmoi
            // 
            this.btnThoatThemMonAnmoi.Location = new System.Drawing.Point(200, 200);
            this.btnThoatThemMonAnmoi.Name = "btnThoatThemMonAnmoi";
            this.btnThoatThemMonAnmoi.Size = new System.Drawing.Size(90, 23);
            this.btnThoatThemMonAnmoi.TabIndex = 10;
            this.btnThoatThemMonAnmoi.Text = "Thoát";
            this.btnThoatThemMonAnmoi.UseVisualStyleBackColor = true;
            this.btnThoatThemMonAnmoi.Click += new System.EventHandler(this.btnThoatThemMonAnmoi_Click);
            // 
            // fThemMonAnmoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 235);
            this.Controls.Add(this.btnThoatThemMonAnmoi);
            this.Controls.Add(this.btnXacNhanThemMonAnmoi);
            this.Controls.Add(this.cbbLoaiMonAnmoi);
            this.Controls.Add(this.txbDVTMonAnmoi);
            this.Controls.Add(this.txbDonGiaMonAnmoi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbTenMonAnmoi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fThemMonAnmoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm món ăn mới";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTenMonAnmoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbDonGiaMonAnmoi;
        private System.Windows.Forms.TextBox txbDVTMonAnmoi;
        private System.Windows.Forms.ComboBox cbbLoaiMonAnmoi;
        private System.Windows.Forms.Button btnXacNhanThemMonAnmoi;
        private System.Windows.Forms.Button btnThoatThemMonAnmoi;
    }
}