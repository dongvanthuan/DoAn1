namespace GUI
{
    partial class QuanLyNhaCungCapGUI
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
            this.dtgDSNCC = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btTKNCC = new System.Windows.Forms.Button();
            this.cbbTKNCC = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btLM = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbHTTT = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTNDD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSNCC)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtgDSNCC);
            this.groupBox5.Location = new System.Drawing.Point(3, 132);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox5.Size = new System.Drawing.Size(557, 421);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh Sách Nhà Cung Cấp";
            // 
            // dtgDSNCC
            // 
            this.dtgDSNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDSNCC.Location = new System.Drawing.Point(0, 25);
            this.dtgDSNCC.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtgDSNCC.Name = "dtgDSNCC";
            this.dtgDSNCC.Size = new System.Drawing.Size(560, 396);
            this.dtgDSNCC.TabIndex = 0;
            this.dtgDSNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDSNCC_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btTKNCC);
            this.groupBox4.Controls.Add(this.cbbTKNCC);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(3, 2);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox4.Size = new System.Drawing.Size(557, 106);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tfim Kiếm Cung Cấp";
            // 
            // btTKNCC
            // 
            this.btTKNCC.Location = new System.Drawing.Point(437, 37);
            this.btTKNCC.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btTKNCC.Name = "btTKNCC";
            this.btTKNCC.Size = new System.Drawing.Size(100, 28);
            this.btTKNCC.TabIndex = 2;
            this.btTKNCC.Text = "Tìm Kiếm";
            this.btTKNCC.UseVisualStyleBackColor = true;
            this.btTKNCC.Click += new System.EventHandler(this.btTKNCC_Click);
            // 
            // cbbTKNCC
            // 
            this.cbbTKNCC.FormattingEnabled = true;
            this.cbbTKNCC.Location = new System.Drawing.Point(168, 37);
            this.cbbTKNCC.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbbTKNCC.Name = "cbbTKNCC";
            this.cbbTKNCC.Size = new System.Drawing.Size(237, 24);
            this.cbbTKNCC.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tìm Kiếm NCC";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btXoa);
            this.groupBox3.Controls.Add(this.btSua);
            this.groupBox3.Controls.Add(this.btLM);
            this.groupBox3.Controls.Add(this.btThem);
            this.groupBox3.Location = new System.Drawing.Point(569, 450);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox3.Size = new System.Drawing.Size(496, 102);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(368, 42);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 28);
            this.btXoa.TabIndex = 17;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(260, 42);
            this.btSua.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(100, 28);
            this.btSua.TabIndex = 16;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btLM
            // 
            this.btLM.Location = new System.Drawing.Point(45, 42);
            this.btLM.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btLM.Name = "btLM";
            this.btLM.Size = new System.Drawing.Size(100, 28);
            this.btLM.TabIndex = 15;
            this.btLM.Text = "Làm Mới";
            this.btLM.UseVisualStyleBackColor = true;
            this.btLM.Click += new System.EventHandler(this.btLM_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(153, 42);
            this.btThem.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 28);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbHTTT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTNDD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtDC);
            this.groupBox1.Controls.Add(this.txtTenNCC);
            this.groupBox1.Controls.Add(this.txtMaNCC);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(565, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Size = new System.Drawing.Size(500, 416);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông tin NCC:";
            // 
            // cbbHTTT
            // 
            this.cbbHTTT.FormattingEnabled = true;
            this.cbbHTTT.Items.AddRange(new object[] {
            "Chuyển khoản",
            "Tiền mặt",
            "Chuyển khoản, Tiền mặt"});
            this.cbbHTTT.Location = new System.Drawing.Point(228, 293);
            this.cbbHTTT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbbHTTT.Name = "cbbHTTT";
            this.cbbHTTT.Size = new System.Drawing.Size(256, 24);
            this.cbbHTTT.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 303);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Hình Thức Thanh Toán";
            // 
            // txtTNDD
            // 
            this.txtTNDD.Location = new System.Drawing.Point(228, 121);
            this.txtTNDD.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTNDD.Name = "txtTNDD";
            this.txtTNDD.Size = new System.Drawing.Size(256, 22);
            this.txtTNDD.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên Người Đại Diện";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(228, 245);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(256, 22);
            this.txtEmail.TabIndex = 13;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(228, 206);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(256, 22);
            this.txtSDT.TabIndex = 12;
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(228, 166);
            this.txtDC.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(256, 22);
            this.txtDC.TabIndex = 11;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(228, 76);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(256, 22);
            this.txtTenNCC.TabIndex = 9;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(228, 31);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(256, 22);
            this.txtMaNCC.TabIndex = 8;
            this.txtMaNCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaNCC_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 254);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số Điện Thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Nhà Cung Cấp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Nhà Cung Cấp";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(4, 74);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox2.Size = new System.Drawing.Size(11, 9);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // QuanLyNhaCungCapGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QuanLyNhaCungCapGUI";
            this.Text = "QuanLyNhaCungCapGUI";
            this.Load += new System.EventHandler(this.QuanLyNhaCungCapGUI_Load);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSNCC)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dtgDSNCC;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btTKNCC;
        private System.Windows.Forms.ComboBox cbbTKNCC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btLM;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbHTTT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTNDD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}