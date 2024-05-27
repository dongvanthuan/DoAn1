namespace GUI
{
    partial class HoaDonNhapGUI
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtgDSHDN = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btTKHDN = new System.Windows.Forms.Button();
            this.cbbTHDN = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btLM = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btTHDN = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbTenNV = new System.Windows.Forms.ComboBox();
            this.cbbTenNCC = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNN = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbPTTT = new System.Windows.Forms.ComboBox();
            this.txtTTH = new System.Windows.Forms.TextBox();
            this.txtMaHDN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSHDN)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtgDSHDN);
            this.groupBox5.Location = new System.Drawing.Point(1, 138);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(556, 407);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh Sách Hoá Đơn Nhập";
            // 
            // dtgDSHDN
            // 
            this.dtgDSHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDSHDN.Location = new System.Drawing.Point(0, 25);
            this.dtgDSHDN.Margin = new System.Windows.Forms.Padding(4);
            this.dtgDSHDN.Name = "dtgDSHDN";
            this.dtgDSHDN.Size = new System.Drawing.Size(560, 375);
            this.dtgDSHDN.TabIndex = 0;
            this.dtgDSHDN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDSHDN_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btTKHDN);
            this.groupBox4.Controls.Add(this.cbbTHDN);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(1, 10);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(556, 92);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tfim Kiếm Hoá Đơn Nhập";
            // 
            // btTKHDN
            // 
            this.btTKHDN.Location = new System.Drawing.Point(437, 36);
            this.btTKHDN.Margin = new System.Windows.Forms.Padding(4);
            this.btTKHDN.Name = "btTKHDN";
            this.btTKHDN.Size = new System.Drawing.Size(100, 28);
            this.btTKHDN.TabIndex = 2;
            this.btTKHDN.Text = "Tìm Kiếm";
            this.btTKHDN.UseVisualStyleBackColor = true;
            this.btTKHDN.Click += new System.EventHandler(this.btTKHDN_Click);
            // 
            // cbbTHDN
            // 
            this.cbbTHDN.FormattingEnabled = true;
            this.cbbTHDN.Location = new System.Drawing.Point(135, 36);
            this.cbbTHDN.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTHDN.Name = "cbbTHDN";
            this.cbbTHDN.Size = new System.Drawing.Size(271, 24);
            this.cbbTHDN.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tìm Kiếm HDN";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btXoa);
            this.groupBox3.Controls.Add(this.btSua);
            this.groupBox3.Controls.Add(this.btLM);
            this.groupBox3.Controls.Add(this.btThem);
            this.groupBox3.Location = new System.Drawing.Point(569, 458);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(496, 87);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(368, 41);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 28);
            this.btXoa.TabIndex = 17;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(260, 41);
            this.btSua.Margin = new System.Windows.Forms.Padding(4);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(100, 28);
            this.btSua.TabIndex = 16;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btLM
            // 
            this.btLM.Location = new System.Drawing.Point(44, 41);
            this.btLM.Margin = new System.Windows.Forms.Padding(4);
            this.btLM.Name = "btLM";
            this.btLM.Size = new System.Drawing.Size(100, 28);
            this.btLM.TabIndex = 15;
            this.btLM.Text = "Làm Mới";
            this.btLM.UseVisualStyleBackColor = true;
            this.btLM.Click += new System.EventHandler(this.btLM_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(152, 41);
            this.btThem.Margin = new System.Windows.Forms.Padding(4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 28);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btTHDN);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbbTenNV);
            this.groupBox1.Controls.Add(this.cbbTenNCC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpNN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbPTTT);
            this.groupBox1.Controls.Add(this.txtTTH);
            this.groupBox1.Controls.Add(this.txtMaHDN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(565, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(500, 428);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông tin Hoá Đơn Nhập::";
            // 
            // btTHDN
            // 
            this.btTHDN.Location = new System.Drawing.Point(305, 379);
            this.btTHDN.Margin = new System.Windows.Forms.Padding(4);
            this.btTHDN.Name = "btTHDN";
            this.btTHDN.Size = new System.Drawing.Size(180, 28);
            this.btTHDN.TabIndex = 22;
            this.btTHDN.Text = "Tạo Hoá Đơn Nhập";
            this.btTHDN.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 267);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tổng Tiền Hàng";
            // 
            // cbbTenNV
            // 
            this.cbbTenNV.FormattingEnabled = true;
            this.cbbTenNV.Location = new System.Drawing.Point(213, 212);
            this.cbbTenNV.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTenNV.Name = "cbbTenNV";
            this.cbbTenNV.Size = new System.Drawing.Size(269, 24);
            this.cbbTenNV.TabIndex = 20;
            // 
            // cbbTenNCC
            // 
            this.cbbTenNCC.FormattingEnabled = true;
            this.cbbTenNCC.Location = new System.Drawing.Point(213, 166);
            this.cbbTenNCC.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTenNCC.Name = "cbbTenNCC";
            this.cbbTenNCC.Size = new System.Drawing.Size(271, 24);
            this.cbbTenNCC.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Phương Thức Thanh Toán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = " Nhân Viên";
            // 
            // dtpNN
            // 
            this.dtpNN.Location = new System.Drawing.Point(213, 76);
            this.dtpNN.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNN.Name = "dtpNN";
            this.dtpNN.Size = new System.Drawing.Size(269, 22);
            this.dtpNN.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ngày Nhập";
            // 
            // cbbPTTT
            // 
            this.cbbPTTT.FormattingEnabled = true;
            this.cbbPTTT.Items.AddRange(new object[] {
            "Chuyển khoản",
            "Tiền mặt",
            "Chuyển khoản, Tiền mặt"});
            this.cbbPTTT.Location = new System.Drawing.Point(209, 118);
            this.cbbPTTT.Margin = new System.Windows.Forms.Padding(4);
            this.cbbPTTT.Name = "cbbPTTT";
            this.cbbPTTT.Size = new System.Drawing.Size(269, 24);
            this.cbbPTTT.TabIndex = 14;
            // 
            // txtTTH
            // 
            this.txtTTH.Location = new System.Drawing.Point(213, 258);
            this.txtTTH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTTH.Name = "txtTTH";
            this.txtTTH.Size = new System.Drawing.Size(269, 22);
            this.txtTTH.TabIndex = 11;
            // 
            // txtMaHDN
            // 
            this.txtMaHDN.Location = new System.Drawing.Point(213, 30);
            this.txtMaHDN.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHDN.Name = "txtMaHDN";
            this.txtMaHDN.Size = new System.Drawing.Size(269, 22);
            this.txtMaHDN.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Nhà Cung Cấp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Hoá Đơn Nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(4, 74);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(11, 10);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // HoaDonNhapGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HoaDonNhapGUI";
            this.Text = "HoaDonNhapGUI";
            this.Load += new System.EventHandler(this.HoaDonNhapGUI_Load);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSHDN)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dtgDSHDN;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btTKHDN;
        private System.Windows.Forms.ComboBox cbbTHDN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btLM;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btTHDN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbTenNV;
        private System.Windows.Forms.ComboBox cbbTenNCC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbPTTT;
        private System.Windows.Forms.TextBox txtTTH;
        private System.Windows.Forms.TextBox txtMaHDN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}