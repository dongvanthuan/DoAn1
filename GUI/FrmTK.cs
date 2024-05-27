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
    public partial class FrmTK : Form
    {
        public FrmTK()
        {
            InitializeComponent();

            //[4]
            // Đăng ký sự kiện MouseEnter và MouseLeave cho cả Button và PictureBox
            btTKSP.MouseEnter += ChangeColorOnHover;
            btTKSP.MouseLeave += RestoreColorOnLeave;
            ptbTKSP.MouseEnter += ChangeColorOnHover;
            ptbTKSP.MouseLeave += RestoreColorOnLeave;
            btTKKH.MouseEnter += ChangeColorOnHover1;
            btTKKH.MouseLeave += RestoreColorOnLeave1;
            ptbTKKH.MouseEnter += ChangeColorOnHover1;
            ptbTKKH.MouseLeave += RestoreColorOnLeave1;
            btTKNV.MouseEnter += ChangeColorOnHover2;
            btTKNV.MouseLeave += RestoreColorOnLeave2;
            ptbTKNV.MouseEnter += ChangeColorOnHover2;
            ptbTKNV.MouseLeave += RestoreColorOnLeave2;
            btTKNCC.MouseEnter += ChangeColorOnHover3;
            btTKNCC.MouseLeave += RestoreColorOnLeave3;
            ptbTKNCC.MouseEnter += ChangeColorOnHover3;
            ptbTKNCC.MouseLeave += RestoreColorOnLeave3;
        }
        //[4]bt+pt đổi màu
        private void ChangeColorOnHover(object sender, EventArgs e)
        {
            // Đổi màu nền của Button và PictureBox thành màu xanh lấp biển nhạt khi di chuột vào
            btTKSP.BackColor = Color.LightSkyBlue;
            ptbTKSP.BackColor = Color.LightSkyBlue;
        }
        private void RestoreColorOnLeave(object sender, EventArgs e)
        {
            // Khôi phục màu nền ban đầu của Button và PictureBox khi chuột rời khỏi
            btTKSP.BackColor = SystemColors.Control;
            ptbTKSP.BackColor = SystemColors.Control;
        }
        private void ChangeColorOnHover1(object sender, EventArgs e)
        {
            // Đổi màu nền của Button và PictureBox thành màu xanh lấp biển nhạt khi di chuột vào
            btTKKH.BackColor = Color.LightSkyBlue;
            ptbTKKH.BackColor = Color.LightSkyBlue;
        }
        private void RestoreColorOnLeave1(object sender, EventArgs e)
        {
            // Khôi phục màu nền ban đầu của Button và PictureBox khi chuột rời khỏi
            btTKKH.BackColor = SystemColors.Control;
            ptbTKKH.BackColor = SystemColors.Control;
        }
        private void ChangeColorOnHover2(object sender, EventArgs e)
        {
            // Đổi màu nền của Button và PictureBox thành màu xanh lấp biển nhạt khi di chuột vào
            btTKNV.BackColor = Color.LightSkyBlue;
            ptbTKNV.BackColor = Color.LightSkyBlue;
        }
        private void RestoreColorOnLeave2(object sender, EventArgs e)
        {
            // Khôi phục màu nền ban đầu của Button và PictureBox khi chuột rời khỏi
            btTKNV.BackColor = SystemColors.Control;
            ptbTKNV.BackColor = SystemColors.Control;
        }
        private void ChangeColorOnHover3(object sender, EventArgs e)
        {
            // Đổi màu nền của Button và PictureBox thành màu xanh lấp biển nhạt khi di chuột vào
            btTKNCC.BackColor = Color.LightSkyBlue;
            ptbTKNCC.BackColor = Color.LightSkyBlue;
        }
        private void RestoreColorOnLeave3(object sender, EventArgs e)
        {
            // Khôi phục màu nền ban đầu của Button và PictureBox khi chuột rời khỏi
            btTKNCC.BackColor = SystemColors.Control;
            ptbTKNCC.BackColor = SystemColors.Control;
        }
        private void btTKSP_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem FrmMENU có đang mở không
            MenuGUI menuForm = Application.OpenForms["MenuGUI"] as MenuGUI;
            if (menuForm != null)
            {
                // Thay đổi label1 của FrmMENU thành "Hóa Đơn Nhập"
                menuForm.ChangeLabel("Tìm Kiếm Sản Phẩm");

                // Ẩn FrmHD và hiển thị FrmHDN trong panel3 của FrmMENU
                this.Hide();
                TimKiemSanPhamGUI tkspForm = new TimKiemSanPhamGUI();
                menuForm.ShowFormInPanel(tkspForm);
            }
        }

        private void ptbTKSP_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem FrmMENU có đang mở không
            MenuGUI menuForm = Application.OpenForms["MenuGUI"] as MenuGUI;
            if (menuForm != null)
            {
                // Thay đổi label1 của FrmMENU thành "Hóa Đơn Nhập"
                menuForm.ChangeLabel("Tìm Kiếm Sản Phẩm");

                // Ẩn FrmHD và hiển thị FrmHDN trong panel3 của FrmMENU
                this.Hide();
                TimKiemSanPhamGUI tkspForm = new TimKiemSanPhamGUI();
                menuForm.ShowFormInPanel(tkspForm);
            }
        }

        private void btTKNV_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem FrmMENU có đang mở không
            MenuGUI menuForm = Application.OpenForms["MenuGUI"] as MenuGUI;
            if (menuForm != null)
            {
                // Thay đổi label1 của FrmMENU thành "Hóa Đơn Nhập"
                menuForm.ChangeLabel("Tìm Kiếm Nhân Viên");

                // Ẩn FrmHD và hiển thị FrmHDN trong panel3 của FrmMENU
                this.Hide();
                TimKiemNhanVienGUI tknvForm = new TimKiemNhanVienGUI();
                menuForm.ShowFormInPanel(tknvForm);
            }
        }

        private void ptbTKNV_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem FrmMENU có đang mở không
            MenuGUI menuForm = Application.OpenForms["MenuGUI"] as MenuGUI;
            if (menuForm != null)
            {
                // Thay đổi label1 của FrmMENU thành "Hóa Đơn Nhập"
                menuForm.ChangeLabel("Tìm Kiếm Nhân Viên");

                // Ẩn FrmHD và hiển thị FrmHDN trong panel3 của FrmMENU
                this.Hide();
                TimKiemNhanVienGUI tknvForm = new TimKiemNhanVienGUI();
                menuForm.ShowFormInPanel(tknvForm);
            }
        }

        private void btTKNCC_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem FrmMENU có đang mở không
            MenuGUI menuForm = Application.OpenForms["MenuGUI"] as MenuGUI;
            if (menuForm != null)
            {
                // Thay đổi label1 của FrmMENU thành "Hóa Đơn Nhập"
                menuForm.ChangeLabel("Tìm Kiếm Nhà Cung Cấp");

                // Ẩn FrmHD và hiển thị FrmHDN trong panel3 của FrmMENU
                this.Hide();
                TimKiemNhaCungCapGUI tknccForm = new TimKiemNhaCungCapGUI();
                menuForm.ShowFormInPanel(tknccForm);
            }
        }

        private void ptbTKNCC_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem FrmMENU có đang mở không
            MenuGUI menuForm = Application.OpenForms["MenuGUI"] as MenuGUI;
            if (menuForm != null)
            {
                // Thay đổi label1 của FrmMENU thành "Hóa Đơn Nhập"
                menuForm.ChangeLabel("Tìm Kiếm Nhà Cung Cấp");

                // Ẩn FrmHD và hiển thị FrmHDN trong panel3 của FrmMENU
                this.Hide();
                TimKiemNhaCungCapGUI tknccForm = new TimKiemNhaCungCapGUI();
                menuForm.ShowFormInPanel(tknccForm);
            }
        }

        private void btTKKH_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem FrmMENU có đang mở không
            MenuGUI menuForm = Application.OpenForms["MenuGUI"] as MenuGUI;
            if (menuForm != null)
            {
                // Thay đổi label1 của FrmMENU thành "Hóa Đơn Nhập"
                menuForm.ChangeLabel("Tìm Kiếm Khách Hàng");

                // Ẩn FrmHD và hiển thị FrmHDN trong panel3 của FrmMENU
                this.Hide();
                TimKiemKhachHangGUI tkkhForm = new TimKiemKhachHangGUI();
                menuForm.ShowFormInPanel(tkkhForm);
            }
        }

        private void ptbTKKH_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem FrmMENU có đang mở không
            MenuGUI menuForm = Application.OpenForms["MenuGUI"] as MenuGUI;
            if (menuForm != null)
            {
                // Thay đổi label1 của FrmMENU thành "Hóa Đơn Nhập"
                menuForm.ChangeLabel("Tìm Kiếm Khách Hàng");

                // Ẩn FrmHD và hiển thị FrmHDN trong panel3 của FrmMENU
                this.Hide();
                TimKiemKhachHangGUI tkkhForm = new TimKiemKhachHangGUI();
                menuForm.ShowFormInPanel(tkkhForm);
            }
        }
    }
}
