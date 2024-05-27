namespace GUI
{
    partial class HoaDonXuatGUI
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
            this.dtgDSHDX = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btTKHDX = new System.Windows.Forms.Button();
            this.cbbMaHDX = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btLM = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btTHDX = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbTenNV = new System.Windows.Forms.ComboBox();
            this.cbbTenKH = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNX = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbPTTT = new System.Windows.Forms.ComboBox();
            this.txtTTH = new System.Windows.Forms.TextBox();
            this.txtMaHDX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSHDX)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtgDSHDX);
            this.groupBox5.Location = new System.Drawing.Point(1, 138);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(556, 407);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh Sách Hoá Đơn Xuất";
            // 
            // dtgDSHDX
            // 
            this.dtgDSHDX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDSHDX.Location = new System.Drawing.Point(0, 25);
            this.dtgDSHDX.Margin = new System.Windows.Forms.Padding(4);
            this.dtgDSHDX.Name = "dtgDSHDX";
            this.dtgDSHDX.Size = new System.Drawing.Size(560, 375);
            this.dtgDSHDX.TabIndex = 0;
            this.dtgDSHDX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDSHDX_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btTKHDX);
            this.groupBox4.Controls.Add(this.cbbMaHDX);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(1, 10);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(556, 92);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tfim Kiếm Hoá Đơn Xuất";
            // 
            // btTKHDX
            // 
            this.btTKHDX.Location = new System.Drawing.Point(431, 36);
            this.btTKHDX.Margin = new System.Windows.Forms.Padding(4);
            this.btTKHDX.Name = "btTKHDX";
            this.btTKHDX.Size = new System.Drawing.Size(100, 28);
            this.btTKHDX.TabIndex = 2;
            this.btTKHDX.Text = "Tìm Kiếm";
            this.btTKHDX.UseVisualStyleBackColor = true;
            this.btTKHDX.Click += new System.EventHandler(this.btTKHDX_Click);
            // 
            // cbbMaHDX
            // 
            this.cbbMaHDX.FormattingEnabled = true;
            this.cbbMaHDX.Location = new System.Drawing.Point(135, 36);
            this.cbbMaHDX.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMaHDX.Name = "cbbMaHDX";
            this.cbbMaHDX.Size = new System.Drawing.Size(271, 24);
            this.cbbMaHDX.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tìm Kiếm Mã HDX";
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
            this.groupBox3.TabIndex = 9;
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
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
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
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btTHDX);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbbTenNV);
            this.groupBox1.Controls.Add(this.cbbTenKH);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpNX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbPTTT);
            this.groupBox1.Controls.Add(this.txtTTH);
            this.groupBox1.Controls.Add(this.txtMaHDX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(565, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(500, 428);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông tin Hoá Đơn Xuất:";
            // 
            // btTHDX
            // 
            this.btTHDX.Location = new System.Drawing.Point(305, 379);
            this.btTHDX.Margin = new System.Windows.Forms.Padding(4);
            this.btTHDX.Name = "btTHDX";
            this.btTHDX.Size = new System.Drawing.Size(180, 28);
            this.btTHDX.TabIndex = 22;
            this.btTHDX.Text = "Tạo Hoá Đơn Xuất";
            this.btTHDX.UseVisualStyleBackColor = true;
            //this.btTHDX.Click += new System.EventHandler(this.btTHDX_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 267);
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
            // cbbTenKH
            // 
            this.cbbTenKH.FormattingEnabled = true;
            this.cbbTenKH.Location = new System.Drawing.Point(213, 166);
            this.cbbTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTenKH.Name = "cbbTenKH";
            this.cbbTenKH.Size = new System.Drawing.Size(271, 24);
            this.cbbTenKH.TabIndex = 19;
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
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tên Nhân Viên";
            // 
            // dtpNX
            // 
            this.dtpNX.Location = new System.Drawing.Point(213, 76);
            this.dtpNX.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNX.Name = "dtpNX";
            this.dtpNX.Size = new System.Drawing.Size(269, 22);
            this.dtpNX.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ngày Xuất";
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
            // txtMaHDX
            // 
            this.txtMaHDX.Location = new System.Drawing.Point(213, 30);
            this.txtMaHDX.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHDX.Name = "txtMaHDX";
            this.txtMaHDX.Size = new System.Drawing.Size(269, 22);
            this.txtMaHDX.TabIndex = 8;
            this.txtMaHDX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaHDX_KeyPress);
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
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Hoá Đơn Xuất";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // HoaDonXuatGUI
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
            this.Name = "HoaDonXuatGUI";
            this.Text = "HoaDonXuatGUI";
            this.Load += new System.EventHandler(this.HoaDonXuatGUI_Load);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSHDX)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dtgDSHDX;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btTKHDX;
        private System.Windows.Forms.ComboBox cbbMaHDX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btLM;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btTHDX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbTenNV;
        private System.Windows.Forms.ComboBox cbbTenKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbPTTT;
        private System.Windows.Forms.TextBox txtTTH;
        private System.Windows.Forms.TextBox txtMaHDX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}