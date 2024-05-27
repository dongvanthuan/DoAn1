namespace GUI
{
    partial class FrmHD
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
            this.btHDX = new System.Windows.Forms.Button();
            this.btHDN = new System.Windows.Forms.Button();
            this.ptbHDX = new System.Windows.Forms.PictureBox();
            this.ptbHDN = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHDX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHDN)).BeginInit();
            this.SuspendLayout();
            // 
            // btHDX
            // 
            this.btHDX.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btHDX.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHDX.Location = new System.Drawing.Point(544, 34);
            this.btHDX.Margin = new System.Windows.Forms.Padding(2);
            this.btHDX.Name = "btHDX";
            this.btHDX.Size = new System.Drawing.Size(413, 484);
            this.btHDX.TabIndex = 11;
            this.btHDX.Text = "Hóa Đơn Xuất";
            this.btHDX.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btHDX.UseVisualStyleBackColor = true;
            this.btHDX.Click += new System.EventHandler(this.btHDX_Click);
            // 
            // btHDN
            // 
            this.btHDN.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btHDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHDN.Location = new System.Drawing.Point(108, 34);
            this.btHDN.Margin = new System.Windows.Forms.Padding(2);
            this.btHDN.Name = "btHDN";
            this.btHDN.Size = new System.Drawing.Size(413, 484);
            this.btHDN.TabIndex = 9;
            this.btHDN.Text = "Hóa Đơn Nhập";
            this.btHDN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btHDN.UseVisualStyleBackColor = true;
            this.btHDN.Click += new System.EventHandler(this.btHDN_Click);
            // 
            // ptbHDX
            // 
            this.ptbHDX.BackColor = System.Drawing.Color.White;
            this.ptbHDX.Image = global::GUI.Properties.Resources.tải_xuống__7_;
            this.ptbHDX.Location = new System.Drawing.Point(554, 56);
            this.ptbHDX.Margin = new System.Windows.Forms.Padding(2);
            this.ptbHDX.Name = "ptbHDX";
            this.ptbHDX.Size = new System.Drawing.Size(384, 384);
            this.ptbHDX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbHDX.TabIndex = 12;
            this.ptbHDX.TabStop = false;
            this.ptbHDX.Click += new System.EventHandler(this.ptbHDX_Click);
            // 
            // ptbHDN
            // 
            this.ptbHDN.BackColor = System.Drawing.Color.White;
            this.ptbHDN.Image = global::GUI.Properties.Resources.tải_xuống__7_;
            this.ptbHDN.Location = new System.Drawing.Point(120, 56);
            this.ptbHDN.Margin = new System.Windows.Forms.Padding(2);
            this.ptbHDN.Name = "ptbHDN";
            this.ptbHDN.Size = new System.Drawing.Size(389, 384);
            this.ptbHDN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbHDN.TabIndex = 10;
            this.ptbHDN.TabStop = false;
            this.ptbHDN.Click += new System.EventHandler(this.ptbHDN_Click);
            // 
            // FrmHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ptbHDX);
            this.Controls.Add(this.btHDX);
            this.Controls.Add(this.ptbHDN);
            this.Controls.Add(this.btHDN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHD";
            this.Text = "FrmHD";
            ((System.ComponentModel.ISupportInitialize)(this.ptbHDX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHDN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbHDX;
        private System.Windows.Forms.Button btHDX;
        private System.Windows.Forms.PictureBox ptbHDN;
        private System.Windows.Forms.Button btHDN;
    }
}