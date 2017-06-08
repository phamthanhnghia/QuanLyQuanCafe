namespace QuanLyQuanCafe
{
    partial class FormCaTruc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCaTruc));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKETTHUC = new System.Windows.Forms.TextBox();
            this.dgvCaTruc = new System.Windows.Forms.DataGridView();
            this.MACT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BATDAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KETTHUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENTHOIVU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENCHINHTHUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtTIENTHOIVU = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtTIENCHINHTHUC = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMACT = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBATDAU = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTENCA = new System.Windows.Forms.TextBox();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaTruc)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTIENTHOIVU)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTIENCHINHTHUC)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Button1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dgvCaTruc);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 477);
            this.panel1.TabIndex = 0;
            // 
            // Button1
            // 
            this.Button1.Image = ((System.Drawing.Image)(resources.GetObject("Button1.Image")));
            this.Button1.Location = new System.Drawing.Point(571, 147);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 39);
            this.Button1.TabIndex = 12;
            this.Button1.Text = "Lưu";
            this.Button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtKETTHUC);
            this.panel3.Location = new System.Drawing.Point(307, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 42);
            this.panel3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thời Gian Kết Thúc :";
            // 
            // txtKETTHUC
            // 
            this.txtKETTHUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKETTHUC.Location = new System.Drawing.Point(152, 10);
            this.txtKETTHUC.Name = "txtKETTHUC";
            this.txtKETTHUC.Size = new System.Drawing.Size(184, 22);
            this.txtKETTHUC.TabIndex = 0;
            // 
            // dgvCaTruc
            // 
            this.dgvCaTruc.AllowDrop = true;
            this.dgvCaTruc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaTruc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MACT,
            this.TENCA,
            this.BATDAU,
            this.KETTHUC,
            this.TIENTHOIVU,
            this.TIENCHINHTHUC});
            this.dgvCaTruc.Location = new System.Drawing.Point(3, 192);
            this.dgvCaTruc.Name = "dgvCaTruc";
            this.dgvCaTruc.Size = new System.Drawing.Size(646, 282);
            this.dgvCaTruc.TabIndex = 10;
            // 
            // MACT
            // 
            this.MACT.DataPropertyName = "MACT";
            this.MACT.HeaderText = "Mã Ca";
            this.MACT.Name = "MACT";
            // 
            // TENCA
            // 
            this.TENCA.DataPropertyName = "TENCA";
            this.TENCA.HeaderText = "Tên Ca";
            this.TENCA.Name = "TENCA";
            // 
            // BATDAU
            // 
            this.BATDAU.DataPropertyName = "BATDAU";
            this.BATDAU.HeaderText = "Bắt Đầu";
            this.BATDAU.Name = "BATDAU";
            // 
            // KETTHUC
            // 
            this.KETTHUC.DataPropertyName = "KETTHUC";
            this.KETTHUC.HeaderText = "Kết Thúc";
            this.KETTHUC.Name = "KETTHUC";
            // 
            // TIENTHOIVU
            // 
            this.TIENTHOIVU.DataPropertyName = "TIENTHOIVU";
            this.TIENTHOIVU.HeaderText = "Tiên NV Thời Vụ";
            this.TIENTHOIVU.Name = "TIENTHOIVU";
            // 
            // TIENCHINHTHUC
            // 
            this.TIENCHINHTHUC.DataPropertyName = "TIENCHINHTHUC";
            this.TIENCHINHTHUC.HeaderText = "Tiền NV Chính Thức";
            this.TIENCHINHTHUC.Name = "TIENCHINHTHUC";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtTIENTHOIVU);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(307, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(342, 42);
            this.panel7.TabIndex = 8;
            // 
            // txtTIENTHOIVU
            // 
            this.txtTIENTHOIVU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTIENTHOIVU.Location = new System.Drawing.Point(152, 11);
            this.txtTIENTHOIVU.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.txtTIENTHOIVU.Name = "txtTIENTHOIVU";
            this.txtTIENTHOIVU.Size = new System.Drawing.Size(187, 22);
            this.txtTIENTHOIVU.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tiền thời vụ:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtTIENCHINHTHUC);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(307, 51);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(342, 42);
            this.panel6.TabIndex = 7;
            // 
            // txtTIENCHINHTHUC
            // 
            this.txtTIENCHINHTHUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTIENCHINHTHUC.Location = new System.Drawing.Point(152, 8);
            this.txtTIENCHINHTHUC.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.txtTIENCHINHTHUC.Name = "txtTIENCHINHTHUC";
            this.txtTIENCHINHTHUC.Size = new System.Drawing.Size(187, 22);
            this.txtTIENCHINHTHUC.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tiền chính thức:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.txtMACT);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(298, 42);
            this.panel5.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mã Ca Trực :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 1;
            // 
            // txtMACT
            // 
            this.txtMACT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMACT.Location = new System.Drawing.Point(152, 10);
            this.txtMACT.Name = "txtMACT";
            this.txtMACT.ReadOnly = true;
            this.txtMACT.Size = new System.Drawing.Size(143, 22);
            this.txtMACT.TabIndex = 0;
            this.txtMACT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtBATDAU);
            this.panel2.Location = new System.Drawing.Point(3, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 42);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thời Gian Bắt Đầu :";
            // 
            // txtBATDAU
            // 
            this.txtBATDAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBATDAU.Location = new System.Drawing.Point(152, 10);
            this.txtBATDAU.Name = "txtBATDAU";
            this.txtBATDAU.Size = new System.Drawing.Size(143, 22);
            this.txtBATDAU.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtTENCA);
            this.panel4.Location = new System.Drawing.Point(3, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(298, 42);
            this.panel4.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Ca :";
            // 
            // txtTENCA
            // 
            this.txtTENCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTENCA.Location = new System.Drawing.Point(152, 7);
            this.txtTENCA.Name = "txtTENCA";
            this.txtTENCA.ReadOnly = true;
            this.txtTENCA.Size = new System.Drawing.Size(143, 22);
            this.txtTENCA.TabIndex = 0;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Coffee";
            // 
            // FormCaTruc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 501);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCaTruc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ca Trực";
            this.Load += new System.EventHandler(this.FormCaTruc_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaTruc)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTIENTHOIVU)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTIENCHINHTHUC)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMACT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBATDAU;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTENCA;
        private System.Windows.Forms.DataGridView dgvCaTruc;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.NumericUpDown txtTIENTHOIVU;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtTIENCHINHTHUC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKETTHUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn BATDAU;
        private System.Windows.Forms.DataGridViewTextBoxColumn KETTHUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENTHOIVU;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENCHINHTHUC;
        private DevExpress.XtraEditors.SimpleButton Button1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}