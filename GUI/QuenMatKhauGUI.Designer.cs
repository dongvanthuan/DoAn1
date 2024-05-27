namespace GUI
{
    partial class QuenMatKhauGUI
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
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btTL = new System.Windows.Forms.Button();
            this.btDMK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbHTMK = new System.Windows.Forms.CheckBox();
            this.txtXNMKM = new System.Windows.Forms.TextBox();
            this.txtMKM = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTDN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(376, 20);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(245, 38);
            this.label12.TabIndex = 24;
            this.label12.Text = "Quên Mật Khẩu";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.btThoat);
            this.groupBox2.Controls.Add(this.btTL);
            this.groupBox2.Controls.Add(this.btDMK);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1, 394);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(1064, 149);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.White;
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(604, 54);
            this.btThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(129, 49);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "Thoát";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btTL
            // 
            this.btTL.BackColor = System.Drawing.Color.White;
            this.btTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTL.Location = new System.Drawing.Point(328, 54);
            this.btTL.Margin = new System.Windows.Forms.Padding(2);
            this.btTL.Name = "btTL";
            this.btTL.Size = new System.Drawing.Size(137, 49);
            this.btTL.TabIndex = 1;
            this.btTL.Text = "Trở lại";
            this.btTL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTL.UseVisualStyleBackColor = false;
            this.btTL.Click += new System.EventHandler(this.btTL_Click);
            // 
            // btDMK
            // 
            this.btDMK.BackColor = System.Drawing.Color.White;
            this.btDMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDMK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDMK.Location = new System.Drawing.Point(46, 54);
            this.btDMK.Margin = new System.Windows.Forms.Padding(2);
            this.btDMK.Name = "btDMK";
            this.btDMK.Size = new System.Drawing.Size(157, 49);
            this.btDMK.TabIndex = 0;
            this.btDMK.Text = "Đổi mật khẩu";
            this.btDMK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDMK.UseVisualStyleBackColor = false;
            this.btDMK.Click += new System.EventHandler(this.btDMK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbHTMK);
            this.groupBox1.Controls.Add(this.txtXNMKM);
            this.groupBox1.Controls.Add(this.txtMKM);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtTDN);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1064, 302);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(189, 253);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(413, 26);
            this.txtSDT.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 259);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Số Điện Thoại";
            // 
            // cbHTMK
            // 
            this.cbHTMK.AutoSize = true;
            this.cbHTMK.Location = new System.Drawing.Point(189, 163);
            this.cbHTMK.Margin = new System.Windows.Forms.Padding(2);
            this.cbHTMK.Name = "cbHTMK";
            this.cbHTMK.Size = new System.Drawing.Size(152, 24);
            this.cbHTMK.TabIndex = 8;
            this.cbHTMK.Text = "Hiển thị mật khẩu";
            this.cbHTMK.UseVisualStyleBackColor = true;
            // 
            // txtXNMKM
            // 
            this.txtXNMKM.Location = new System.Drawing.Point(189, 124);
            this.txtXNMKM.Margin = new System.Windows.Forms.Padding(2);
            this.txtXNMKM.Name = "txtXNMKM";
            this.txtXNMKM.PasswordChar = '*';
            this.txtXNMKM.Size = new System.Drawing.Size(413, 26);
            this.txtXNMKM.TabIndex = 7;
            // 
            // txtMKM
            // 
            this.txtMKM.Location = new System.Drawing.Point(189, 86);
            this.txtMKM.Margin = new System.Windows.Forms.Padding(2);
            this.txtMKM.Name = "txtMKM";
            this.txtMKM.PasswordChar = '*';
            this.txtMKM.Size = new System.Drawing.Size(413, 26);
            this.txtMKM.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(189, 203);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(413, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // txtTDN
            // 
            this.txtTDN.Location = new System.Drawing.Point(189, 37);
            this.txtTDN.Margin = new System.Windows.Forms.Padding(2);
            this.txtTDN.Name = "txtTDN";
            this.txtTDN.Size = new System.Drawing.Size(413, 26);
            this.txtTDN.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Xác nhận mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập";
            // 
            // QuenMatKhauGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuenMatKhauGUI";
            this.Text = "QuenMatKhauGUI";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btTL;
        private System.Windows.Forms.Button btDMK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbHTMK;
        private System.Windows.Forms.TextBox txtXNMKM;
        private System.Windows.Forms.TextBox txtMKM;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTDN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}