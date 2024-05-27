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
    public partial class FrmHD : Form
    {
        public FrmHD()
        {
            InitializeComponent();

            // Đăng ký sự kiện MouseEnter và MouseLeave cho cả Button và PictureBox
            btHDN.MouseEnter += ChangeColorOnHover;
            btHDN.MouseLeave += RestoreColorOnLeave;
            ptbHDN.MouseEnter += ChangeColorOnHover;
            ptbHDN.MouseLeave += RestoreColorOnLeave;
            btHDX.MouseEnter += ChangeColorOnHover1;
            btHDX.MouseLeave += RestoreColorOnLeave1;
            ptbHDX.MouseEnter += ChangeColorOnHover1;
            ptbHDX.MouseLeave += RestoreColorOnLeave1;
        }
        //[4] bt+pt đổi màu riêng
        private void ChangeColorOnHover(object sender, EventArgs e)
        {
            // Đổi màu nền của Button và PictureBox thành màu xanh đậm biển nhạt khi di chuột vào
            btHDN.BackColor = Color.LightSkyBlue;
            ptbHDN.BackColor = Color.LightSkyBlue;
        }
        private void RestoreColorOnLeave(object sender, EventArgs e)
        {
            // Khôi phục màu nền ban đầu của Button và PictureBox khi chuột rời khỏi
            btHDN.BackColor = SystemColors.Control;
            ptbHDN.BackColor = SystemColors.Control;
        }
        private void ChangeColorOnHover1(object sender, EventArgs e)
        {
            // Đổi màu nền của Button và PictureBox thành màu xanh đậm biển nhạt khi di chuột vào
            btHDX.BackColor = Color.LightSkyBlue;
            ptbHDX.BackColor = Color.LightSkyBlue;
        }
        private void RestoreColorOnLeave1(object sender, EventArgs e)
        {
            // Khôi phục màu nền ban đầu của Button và PictureBox khi chuột rời khỏi
            btHDX.BackColor = SystemColors.Control;
            ptbHDX.BackColor = SystemColors.Control;
        }
        private void btHDN_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem FrmMENU đang mở không
            MenuGUI menuForm = Application.OpenForms["MenuGUI"] as MenuGUI;
            if (menuForm != null)
            {
                // Thay đổi label1 của FrmMENU thành "Hóa Đơn Nhập"
                menuForm.ChangeLabel("Hóa Đơn Nhập");
                // Ẩn FrmHD và hiển thị FrmHDN trong panel3 của FrmMENU
                this.Hide();
                HoaDonNhapGUI hdnForm = new HoaDonNhapGUI();
                menuForm.ShowFormInPanel(hdnForm);
            }
        }

        private void ptbHDN_Click(object sender, EventArgs e)
        {
              // Kiểm tra xem FrmMENU đang mở không
            MenuGUI menuForm = Application.OpenForms["MenuGUI"] as MenuGUI;
            if (menuForm != null)
            {
                // Thay đổi label1 của FrmMENU thành "Hóa Đơn Nhập"
                menuForm.ChangeLabel("Hóa Đơn Nhập");
                // Ẩn FrmHD và hiển thị FrmHDN trong panel3 của FrmMENU
                this.Hide();
                HoaDonNhapGUI hdnForm = new HoaDonNhapGUI();
                menuForm.ShowFormInPanel(hdnForm);
            }
        }

        private void btHDX_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem FrmMENU đang mở không
            MenuGUI menuForm = Application.OpenForms["MenuGUI"] as MenuGUI;
            if (menuForm != null)
            {
                // Thay đổi label1 của FrmMENU thành "Hóa Đơn Xuất"
                menuForm.ChangeLabel("Hóa Đơn Xuất");
                // Ẩn FrmHD và hiển thị FrmHDN trong panel3 của FrmMENU
                this.Hide();
                HoaDonXuatGUI hdxForm = new HoaDonXuatGUI();
                menuForm.ShowFormInPanel(hdxForm);
            }
        }

        private void ptbHDX_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem FrmMENU đang mở không
            MenuGUI menuForm = Application.OpenForms["MenuGUI"] as MenuGUI;
            if (menuForm != null)
            {
                // Thay đổi label1 của FrmMENU thành "Hóa Đơn Xuất"
                menuForm.ChangeLabel("Hóa Đơn Xuất");
                // Ẩn FrmHD và hiển thị FrmHDN trong panel3 của FrmMENU
                this.Hide();
                HoaDonXuatGUI hdxForm = new HoaDonXuatGUI();
                menuForm.ShowFormInPanel(hdxForm);
            }
        }
    }
}
