namespace GUI
{
    partial class FrmHT
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
            this.btThoat = new System.Windows.Forms.Button();
            this.btDK = new System.Windows.Forms.Button();
            this.btDN = new System.Windows.Forms.Button();
            this.ptbThoat = new System.Windows.Forms.PictureBox();
            this.ptbDN = new System.Windows.Forms.PictureBox();
            this.ptbDK = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbThoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDK)).BeginInit();
            this.SuspendLayout();
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(531, 282);
            this.btThoat.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(447, 220);
            this.btThoat.TabIndex = 9;
            this.btThoat.Text = "Thoát";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btDK
            // 
            this.btDK.BackColor = System.Drawing.Color.White;
            this.btDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDK.Location = new System.Drawing.Point(531, 29);
            this.btDK.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btDK.Name = "btDK";
            this.btDK.Size = new System.Drawing.Size(447, 235);
            this.btDK.TabIndex = 8;
            this.btDK.Text = "Đăng Ký";
            this.btDK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDK.UseVisualStyleBackColor = false;
            this.btDK.Click += new System.EventHandler(this.btDK_Click);
            // 
            // btDN
            // 
            this.btDN.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDN.Location = new System.Drawing.Point(68, 29);
            this.btDN.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btDN.Name = "btDN";
            this.btDN.Size = new System.Drawing.Size(439, 473);
            this.btDN.TabIndex = 7;
            this.btDN.Text = "Đăng Nhập";
            this.btDN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btDN.UseVisualStyleBackColor = true;
            // 
            // ptbThoat
            // 
            this.ptbThoat.BackColor = System.Drawing.Color.White;
            this.ptbThoat.Image = global::GUI.Properties.Resources.tải_xuống__1_;
            this.ptbThoat.Location = new System.Drawing.Point(559, 300);
            this.ptbThoat.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ptbThoat.Name = "ptbThoat";
            this.ptbThoat.Size = new System.Drawing.Size(243, 186);
            this.ptbThoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbThoat.TabIndex = 12;
            this.ptbThoat.TabStop = false;
            this.ptbThoat.Click += new System.EventHandler(this.ptbThoat_Click);
            // 
            // ptbDN
            // 
            this.ptbDN.BackColor = System.Drawing.Color.White;
            this.ptbDN.Image = global::GUI.Properties.Resources.images;
            this.ptbDN.Location = new System.Drawing.Point(68, 104);
            this.ptbDN.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ptbDN.Name = "ptbDN";
            this.ptbDN.Size = new System.Drawing.Size(439, 297);
            this.ptbDN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbDN.TabIndex = 11;
            this.ptbDN.TabStop = false;
            this.ptbDN.Click += new System.EventHandler(this.ptbDN_Click);
            // 
            // ptbDK
            // 
            this.ptbDK.BackColor = System.Drawing.Color.White;
            this.ptbDK.Image = global::GUI.Properties.Resources.tải_xuống__4_;
            this.ptbDK.Location = new System.Drawing.Point(559, 38);
            this.ptbDK.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ptbDK.Name = "ptbDK";
            this.ptbDK.Size = new System.Drawing.Size(243, 208);
            this.ptbDK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbDK.TabIndex = 10;
            this.ptbDK.TabStop = false;
            this.ptbDK.Click += new System.EventHandler(this.ptbDK_Click);
            // 
            // FrmHT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ptbThoat);
            this.Controls.Add(this.ptbDN);
            this.Controls.Add(this.ptbDK);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btDK);
            this.Controls.Add(this.btDN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHT";
            this.Text = "FrmHT";
            this.Load += new System.EventHandler(this.FrmHT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbThoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbThoat;
        private System.Windows.Forms.PictureBox ptbDN;
        private System.Windows.Forms.PictureBox ptbDK;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btDK;
        private System.Windows.Forms.Button btDN;
    }
}