namespace GUI
{
    partial class FrmTG
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
            this.btTK1 = new System.Windows.Forms.Button();
            this.rtbTL = new System.Windows.Forms.RichTextBox();
            this.cbbCH = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btTK1
            // 
            this.btTK1.BackColor = System.Drawing.Color.White;
            this.btTK1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTK1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTK1.Location = new System.Drawing.Point(607, 23);
            this.btTK1.Margin = new System.Windows.Forms.Padding(1);
            this.btTK1.Name = "btTK1";
            this.btTK1.Size = new System.Drawing.Size(83, 28);
            this.btTK1.TabIndex = 39;
            this.btTK1.Text = "Tìm Kiếm";
            this.btTK1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTK1.UseVisualStyleBackColor = false;
            // 
            // rtbTL
            // 
            this.rtbTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTL.Location = new System.Drawing.Point(10, 75);
            this.rtbTL.Margin = new System.Windows.Forms.Padding(1);
            this.rtbTL.Name = "rtbTL";
            this.rtbTL.Size = new System.Drawing.Size(680, 347);
            this.rtbTL.TabIndex = 38;
            this.rtbTL.Text = "";
            // 
            // cbbCH
            // 
            this.cbbCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCH.FormattingEnabled = true;
            this.cbbCH.Location = new System.Drawing.Point(10, 24);
            this.cbbCH.Margin = new System.Windows.Forms.Padding(1);
            this.cbbCH.Name = "cbbCH";
            this.cbbCH.Size = new System.Drawing.Size(577, 28);
            this.cbbCH.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.tải_xuống__7_1;
            this.pictureBox1.Location = new System.Drawing.Point(719, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 398);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // FrmTG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btTK1);
            this.Controls.Add(this.rtbTL);
            this.Controls.Add(this.cbbCH);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmTG";
            this.Text = "FrmTG";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btTK1;
        private System.Windows.Forms.RichTextBox rtbTL;
        private System.Windows.Forms.ComboBox cbbCH;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}