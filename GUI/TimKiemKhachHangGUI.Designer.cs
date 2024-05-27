namespace GUI
{
    partial class TimKiemKhachHangGUI
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btLM = new System.Windows.Forms.Button();
            this.btTK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbTKKH = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgDSKH = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSKH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.btLM);
            this.groupBox3.Controls.Add(this.btTK);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 141);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox3.Size = new System.Drawing.Size(1047, 88);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            // 
            // btLM
            // 
            this.btLM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btLM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLM.Location = new System.Drawing.Point(672, 40);
            this.btLM.Margin = new System.Windows.Forms.Padding(1);
            this.btLM.Name = "btLM";
            this.btLM.Size = new System.Drawing.Size(121, 25);
            this.btLM.TabIndex = 7;
            this.btLM.Text = "Làm mới";
            this.btLM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLM.UseVisualStyleBackColor = true;
            this.btLM.Click += new System.EventHandler(this.btLM_Click);
            // 
            // btTK
            // 
            this.btTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTK.Location = new System.Drawing.Point(157, 40);
            this.btTK.Margin = new System.Windows.Forms.Padding(1);
            this.btTK.Name = "btTK";
            this.btTK.Size = new System.Drawing.Size(119, 25);
            this.btTK.TabIndex = 4;
            this.btTK.Text = "Tìm Kiếm";
            this.btTK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTK.UseVisualStyleBackColor = true;
            this.btTK.Click += new System.EventHandler(this.btTK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.cbbTKKH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(1047, 112);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tìm Kiếm";
            // 
            // cbbTKKH
            // 
            this.cbbTKKH.FormattingEnabled = true;
            this.cbbTKKH.Location = new System.Drawing.Point(212, 44);
            this.cbbTKKH.Margin = new System.Windows.Forms.Padding(1);
            this.cbbTKKH.Name = "cbbTKKH";
            this.cbbTKKH.Size = new System.Drawing.Size(732, 28);
            this.cbbTKKH.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(43, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.dtgDSKH);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 240);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox2.Size = new System.Drawing.Size(1049, 303);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Khách Hàng";
            // 
            // dtgDSKH
            // 
            this.dtgDSKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDSKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDSKH.Location = new System.Drawing.Point(1, 20);
            this.dtgDSKH.Margin = new System.Windows.Forms.Padding(1);
            this.dtgDSKH.Name = "dtgDSKH";
            this.dtgDSKH.RowHeadersWidth = 51;
            this.dtgDSKH.RowTemplate.Height = 24;
            this.dtgDSKH.Size = new System.Drawing.Size(1047, 282);
            this.dtgDSKH.TabIndex = 5;
            // 
            // TimKiemKhachHangGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TimKiemKhachHangGUI";
            this.Text = "TimKiemKhachHangGUI";
            this.Load += new System.EventHandler(this.TimKiemKhachHangGUI_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btLM;
        private System.Windows.Forms.Button btTK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbTKKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgDSKH;
    }
}