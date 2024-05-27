using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmHT : Form
    {
        public FrmHT()
        {
            InitializeComponent();
            //[4]
            // Đăng ký sự kiện MouseEnter và MouseLeave cho cả Button và PictureBox
            btDN.MouseEnter += ChangeColorOnHover;
            btDN.MouseLeave += RestoreColorOnLeave;
            ptbDN.MouseEnter += ChangeColorOnHover;
            ptbDN.MouseLeave += RestoreColorOnLeave;
            btDK.MouseEnter += ChangeColorOnHover1;
            btDK.MouseLeave += RestoreColorOnLeave1;
            ptbDK.MouseEnter += ChangeColorOnHover1;
            ptbDK.MouseLeave += RestoreColorOnLeave1;
            btThoat.MouseEnter += ChangeColorOnHover2;
            btThoat.MouseLeave += RestoreColorOnLeave2;
            ptbThoat.MouseEnter += ChangeColorOnHover2;
            ptbThoat.MouseLeave += RestoreColorOnLeave2;
        }

        private void FrmHT_Load(object sender, EventArgs e)
        {
        }

        private void ptbDN_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhapGUI dn = new DangNhapGUI();
            dn.Show();
        }

        private void btDK_Click(object sender, EventArgs e)
        {
            this.Close();
            DangKyGUI dk = new DangKyGUI();
            dk.Show();
        }

        private void ptbDK_Click(object sender, EventArgs e)
        {
            this.Close();
            DangKyGUI dk = new DangKyGUI();
            dk.Show();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ptbThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void ChangeColorOnHover(object sender, EventArgs e)
        {
            // Đổi màu nền của Button và PictureBox thành màu xanh lấp biển nhạt khi di chuột vào
            btDN.BackColor = Color.LightSkyBlue;
            ptbDN.BackColor = Color.LightSkyBlue;
        }
        private void RestoreColorOnLeave(object sender, EventArgs e)
        {
            // Khôi phục màu nền ban đầu của Button và PictureBox khi chuột rời khỏi
            btDN.BackColor = SystemColors.Control;
            ptbDN.BackColor = SystemColors.Control;
        }
        private void ChangeColorOnHover1(object sender, EventArgs e)
        {
            // Đổi màu nền của Button và PictureBox thành màu xanh lấp biển nhạt khi di chuột vào
            btDK.BackColor = Color.LightSkyBlue;
            ptbDK.BackColor = Color.LightSkyBlue;
        }
        private void RestoreColorOnLeave1(object sender, EventArgs e)
        {
            // Khôi phục màu nền ban đầu của Button và PictureBox khi chuột rời khỏi
            btDK.BackColor = SystemColors.Control;
            ptbDK.BackColor = SystemColors.Control;
        }
        private void ChangeColorOnHover2(object sender, EventArgs e)
        {
            // Đổi màu nền của Button và PictureBox thành màu xanh lấp biển nhạt khi di chuột vào
            btThoat.BackColor = Color.LightSkyBlue;
            ptbThoat.BackColor = Color.LightSkyBlue;
        }
        private void RestoreColorOnLeave2(object sender, EventArgs e)
        {
            // Khôi phục màu nền ban đầu của Button và PictureBox khi chuột rời khỏi
            btThoat.BackColor = SystemColors.Control;
            ptbThoat.BackColor = SystemColors.Control;
        }
    }
}
