namespace GUI
{
    partial class MenuGUI
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btTG = new System.Windows.Forms.Button();
            this.btBCTK = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.btHoaDon = new System.Windows.Forms.Button();
            this.btQuanLy = new System.Windows.Forms.Button();
            this.btHeThong = new System.Windows.Forms.Button();
            this.btTrangchu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(172, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1083, 593);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.pane3_Paint);
            this.panel3.Resize += new System.EventHandler(this.panel3_Resize);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(172, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 95);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(425, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOY STORE";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btTG);
            this.panel1.Controls.Add(this.btBCTK);
            this.panel1.Controls.Add(this.btTimKiem);
            this.panel1.Controls.Add(this.btHoaDon);
            this.panel1.Controls.Add(this.btQuanLy);
            this.panel1.Controls.Add(this.btHeThong);
            this.panel1.Controls.Add(this.btTrangchu);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 694);
            this.panel1.TabIndex = 2;
            // 
            // btTG
            // 
            this.btTG.Location = new System.Drawing.Point(3, 586);
            this.btTG.Name = "btTG";
            this.btTG.Size = new System.Drawing.Size(158, 91);
            this.btTG.TabIndex = 6;
            this.btTG.Text = "Trợ Giúp";
            this.btTG.UseVisualStyleBackColor = true;
            this.btTG.Click += new System.EventHandler(this.btTG_Click);
            // 
            // btBCTK
            // 
            this.btBCTK.Location = new System.Drawing.Point(0, 489);
            this.btBCTK.Name = "btBCTK";
            this.btBCTK.Size = new System.Drawing.Size(158, 91);
            this.btBCTK.TabIndex = 5;
            this.btBCTK.Text = "Báo Cáo -----------------------------------Thống Kê";
            this.btBCTK.UseVisualStyleBackColor = true;
            this.btBCTK.Click += new System.EventHandler(this.btBCTK_Click);
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(4, 392);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(158, 91);
            this.btTimKiem.TabIndex = 4;
            this.btTimKiem.Text = "Tìm Kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // btHoaDon
            // 
            this.btHoaDon.Location = new System.Drawing.Point(3, 295);
            this.btHoaDon.Name = "btHoaDon";
            this.btHoaDon.Size = new System.Drawing.Size(158, 91);
            this.btHoaDon.TabIndex = 3;
            this.btHoaDon.Text = "Hoá Đơn";
            this.btHoaDon.UseVisualStyleBackColor = true;
            this.btHoaDon.Click += new System.EventHandler(this.btHoaDon_Click);
            // 
            // btQuanLy
            // 
            this.btQuanLy.Location = new System.Drawing.Point(7, 198);
            this.btQuanLy.Name = "btQuanLy";
            this.btQuanLy.Size = new System.Drawing.Size(158, 91);
            this.btQuanLy.TabIndex = 2;
            this.btQuanLy.Text = "Quản Lý";
            this.btQuanLy.UseVisualStyleBackColor = true;
            this.btQuanLy.Click += new System.EventHandler(this.btQuanLy_Click);
            // 
            // btHeThong
            // 
            this.btHeThong.Location = new System.Drawing.Point(4, 101);
            this.btHeThong.Name = "btHeThong";
            this.btHeThong.Size = new System.Drawing.Size(158, 91);
            this.btHeThong.TabIndex = 1;
            this.btHeThong.Text = "Hệ Thống";
            this.btHeThong.UseVisualStyleBackColor = true;
            this.btHeThong.Click += new System.EventHandler(this.btHeThong_Click);
            // 
            // btTrangchu
            // 
            this.btTrangchu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btTrangchu.Location = new System.Drawing.Point(0, 0);
            this.btTrangchu.Margin = new System.Windows.Forms.Padding(2);
            this.btTrangchu.Name = "btTrangchu";
            this.btTrangchu.Size = new System.Drawing.Size(161, 91);
            this.btTrangchu.TabIndex = 0;
            this.btTrangchu.Text = "Trang Chủ";
            this.btTrangchu.UseVisualStyleBackColor = true;
            this.btTrangchu.Click += new System.EventHandler(this.btTrangchu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::GUI.Properties.Resources.cua_hang_do_choi_tre_em_3_1;
            this.pictureBox1.Location = new System.Drawing.Point(1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1080, 587);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MenuGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 707);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuGUI";
            this.Text = "MenuGUI";
            this.Load += new System.EventHandler(this.MenuGUI_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btTG;
        private System.Windows.Forms.Button btBCTK;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Button btHoaDon;
        private System.Windows.Forms.Button btQuanLy;
        private System.Windows.Forms.Button btHeThong;
        private System.Windows.Forms.Button btTrangchu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}