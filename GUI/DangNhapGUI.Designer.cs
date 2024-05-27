namespace GUI
{
    partial class DangNhapGUI
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
            this.txtTDN = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btDN = new System.Windows.Forms.Button();
            this.btDK = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.cbHienThi = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lLQMK = new System.Windows.Forms.LinkLabel();
            this.lLDMK = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTDN
            // 
            this.txtTDN.Location = new System.Drawing.Point(176, 58);
            this.txtTDN.Margin = new System.Windows.Forms.Padding(4);
            this.txtTDN.Name = "txtTDN";
            this.txtTDN.Size = new System.Drawing.Size(245, 22);
            this.txtTDN.TabIndex = 0;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(176, 128);
            this.txtMK.Margin = new System.Windows.Forms.Padding(4);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(245, 22);
            this.txtMK.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật Khẩu";
            // 
            // btDN
            // 
            this.btDN.Location = new System.Drawing.Point(46, 251);
            this.btDN.Margin = new System.Windows.Forms.Padding(4);
            this.btDN.Name = "btDN";
            this.btDN.Size = new System.Drawing.Size(100, 28);
            this.btDN.TabIndex = 4;
            this.btDN.Text = "Đăng Nhập";
            this.btDN.UseVisualStyleBackColor = true;
            this.btDN.Click += new System.EventHandler(this.btDN_Click);
            // 
            // btDK
            // 
            this.btDK.Location = new System.Drawing.Point(219, 251);
            this.btDK.Margin = new System.Windows.Forms.Padding(4);
            this.btDK.Name = "btDK";
            this.btDK.Size = new System.Drawing.Size(100, 28);
            this.btDK.TabIndex = 5;
            this.btDK.Text = "Đăng Ký";
            this.btDK.UseVisualStyleBackColor = true;
            this.btDK.Click += new System.EventHandler(this.btDK_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(390, 251);
            this.btThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(105, 28);
            this.btThoat.TabIndex = 6;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // cbHienThi
            // 
            this.cbHienThi.AutoSize = true;
            this.cbHienThi.Location = new System.Drawing.Point(176, 189);
            this.cbHienThi.Margin = new System.Windows.Forms.Padding(4);
            this.cbHienThi.Name = "cbHienThi";
            this.cbHienThi.Size = new System.Drawing.Size(127, 20);
            this.cbHienThi.TabIndex = 7;
            this.cbHienThi.Text = "Hiển thị mật khẩu";
            this.cbHienThi.UseVisualStyleBackColor = true;
            this.cbHienThi.CheckedChanged += new System.EventHandler(this.cbHienThi_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lLDMK);
            this.panel1.Controls.Add(this.lLQMK);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbHienThi);
            this.panel1.Controls.Add(this.txtTDN);
            this.panel1.Controls.Add(this.btThoat);
            this.panel1.Controls.Add(this.txtMK);
            this.panel1.Controls.Add(this.btDK);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btDN);
            this.panel1.Location = new System.Drawing.Point(461, 84);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 363);
            this.panel1.TabIndex = 8;
            // 
            // lLQMK
            // 
            this.lLQMK.AutoSize = true;
            this.lLQMK.LinkColor = System.Drawing.Color.Red;
            this.lLQMK.Location = new System.Drawing.Point(324, 319);
            this.lLQMK.Name = "lLQMK";
            this.lLQMK.Size = new System.Drawing.Size(97, 16);
            this.lLQMK.TabIndex = 9;
            this.lLQMK.TabStop = true;
            this.lLQMK.Text = "Quên Mật Khẩu";
            this.lLQMK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLQMK_LinkClicked);
            // 
            // lLDMK
            // 
            this.lLDMK.AutoSize = true;
            this.lLDMK.LinkColor = System.Drawing.Color.Red;
            this.lLDMK.Location = new System.Drawing.Point(102, 319);
            this.lLDMK.Name = "lLDMK";
            this.lLDMK.Size = new System.Drawing.Size(85, 16);
            this.lLDMK.TabIndex = 10;
            this.lLDMK.TabStop = true;
            this.lLDMK.Text = "Đổi Mật Khẩu";
            this.lLDMK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLDMK_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(405, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 38);
            this.label3.TabIndex = 20;
            this.label3.Text = "Đăng Nhập";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.images__2_1;
            this.pictureBox1.Location = new System.Drawing.Point(58, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 363);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // DangNhapGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DangNhapGUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DangNhapGUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTDN;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDN;
        private System.Windows.Forms.Button btDK;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.CheckBox cbHienThi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lLDMK;
        private System.Windows.Forms.LinkLabel lLQMK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

