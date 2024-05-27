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
    public partial class FrmQL : Form
    {
        public FrmQL()
        {
            InitializeComponent();

            //[4]
            // Đăng ký sự kiện MouseEnter và MouseLeave cho cả Button và PictureBox
            btQLSP.MouseEnter += ChangeColorOnHover;
            btQLSP.MouseLeave += RestoreColorOnLeave;
            ptbQLSP.MouseEnter += ChangeColorOnHover;
            ptbQLSP.MouseLeave += RestoreColorOnLeave;
            btQLKH.MouseEnter += ChangeColorOnHover1;
            btQLKH.MouseLeave += RestoreColorOnLeave1;
            ptbQLKH.MouseEnter += ChangeColorOnHover1;
            ptbQLKH.MouseLeave += RestoreColorOnLeave1;
            btQLNV.MouseEnter += ChangeColorOnHover2;
            btQLNV.MouseLeave += RestoreColorOnLeave2;
            ptbQLNV.MouseEnter += ChangeColorOnHover2;
            ptbQLNV.MouseLeave += RestoreColorOnLeave2;
            btQLNCC.MouseEnter += ChangeColorOnHover3;
            btQLNCC.MouseLeave += RestoreColorOnLeave3;
            ptbQLNCC.MouseEnter += ChangeColorOnHover3;
            ptbQLNCC.MouseLeave += RestoreColorOnLeave3;
            btQLDMSP.MouseEnter += ChangeColorOnHover4;
            btQLDMSP.MouseLeave += RestoreColorOnLeave4;
            ptbQLDMSP.MouseEnter += ChangeColorOnHover4;
            ptbQLDMSP.MouseLeave += RestoreColorOnLeave4;
            btQLND.MouseEnter += ChangeColorOnHover5;
            btQLND.MouseLeave += RestoreColorOnLeave5;
            ptbQLND.MouseEnter += ChangeColorOnHover5;
            ptbQLND.MouseLeave += RestoreColorOnLeave5;
        }
        //[4]bt+pt đổi màu
        private void ChangeColorOnHover(object sender, EventArgs e)
        {
            // Đổi màu nền của Button và PictureBox thành màu xanh lấp biển nhạt khi di chuột vào
            btQLSP.BackColor = Color.LightSkyBlue;
            ptbQLSP.BackColor = Color.LightSkyBlue;
        }
        private void RestoreColorOnLeave(object sender, EventArgs e)
        {
            // Khôi phục màu nền ban đầu của Button và PictureBox khi chuột rời khỏi
            btQLSP.BackColor = SystemColors.Control;
            ptbQLSP.BackColor = SystemColors.Control;
        }
        private void ChangeColorOnHover1(object sender, EventArgs e)
        {
            // Đổi màu nền của Button và PictureBox thành màu xanh lấp biển nhạt khi di chuột vào
            btQLKH.BackColor = Color.LightSkyBlue;
            ptbQLKH.BackColor = Color.LightSkyBlue;
        }
        private void RestoreColorOnLeave1(object sender, EventArgs e)
        {
            // Khôi phục màu nền ban đầu của Button và PictureBox khi chuột rời khỏi
            btQLKH.BackColor = SystemColors.Control;
            ptbQLKH.BackColor = SystemColors.Control;
        }
        private void ChangeColorOnHover2(object sender, EventArgs e)
        {
            // Đổi màu nền của Button và PictureBox thành màu xanh lấp biển nhạt khi di chuột vào
            btQLNV.BackColor = Color.LightSkyBlue;
            ptbQLNV.BackColor = Color.LightSkyBlue;
        }
        private void RestoreColorOnLeave2(object sender, EventArgs e)
        {
            // Khôi phục màu nền ban đầu của Button và PictureBox khi chuột rời khỏi
            btQLNV.BackColor = SystemColors.Control;
            ptbQLNV.BackColor = SystemColors.Control;
        }
        private void ChangeColorOnHover3(object sender, EventArgs e)
        {
            // Đổi màu nền của Button và PictureBox thành màu xanh lấp biển nhạt khi di chuột vào
            btQLNCC.BackColor = Color.LightSkyBlue;
            ptbQLNCC.BackColor = Color.LightSkyBlue;
        }
        private void RestoreColorOnLeave3(object sender, EventArgs e)
        {
            // Khôi phục màu nền ban đầu của Button và PictureBox khi chuột rời khỏi
            btQLNCC.BackColor = SystemColors.Control;
            ptbQLNCC.BackColor = SystemColors.Control;
        }
        private void ChangeColorOnHover4(object sender, EventArgs e)
        {
            // Đổi màu nền của Button và PictureBox thành màu xanh lấp biển nhạt khi di chuột vào
            btQLDMSP.BackColor = Color.LightSkyBlue;
            ptbQLDMSP.BackColor = Color.LightSkyBlue;
        }
        private void RestoreColorOnLeave4(object sender, EventArgs e)
        {
            // Khôi phục màu nền ban đầu của Button và PictureBox khi chuột rời khỏi
            btQLDMSP.BackColor = SystemColors.Control;
            ptbQLDMSP.BackColor = SystemColors.Control;
        }
        private void ChangeColorOnHover5(object sender, EventArgs e)
        {
            // Đổi màu nền của Button và PictureBox thành màu xanh lấp biển nhạt khi di chuột vào
            btQLND.BackColor = Color.LightSkyBlue;
            ptbQLND.BackColor = Color.LightSkyBlue;
        }
        private void RestoreColorOnLeave5(object sender, EventArgs e)
        {
            // Khôi phục màu nền ban đầu của Button và PictureBox khi chuột rời khỏi
            btQLND.BackColor = SystemColors.Control;
            ptbQLND.BackColor = SystemColors.Control;
        }

        private void btQLSP_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem FrmMENU có đang mở không
            MenuGUI menuForm = Application.OpenForms["MenuGUI"] as MenuGUI;
            if (menuForm != null)
            {
                // Thay đổi label1 của FrmMENU thành "Hóa Đơn Nhập"
                menuForm.ChangeLabel("Quản Lý Sản Phẩm");

                // Ẩn FrmHD và hiển thị FrmHDN trong panel3 của FrmMENU
                this.Hide();
                QuanLySanPhamGUI qlspForm = new QuanLySanPhamGUI();
                menuForm.ShowFormInPanel(qlspForm);
            }
        }

        private void ptbQLSP_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem FrmMENU có đang mở không
            MenuGUI menuForm = Application.OpenForms["MenuGUI"] as MenuGUI;
            if (menuForm != null)
            {
                // Thay đổi label1 của FrmMENU thành "Hóa Đơn Nhập"
                menuForm.ChangeLabel("Quản Lý Sản Phẩm");

                // Ẩn FrmHD và hiển thị FrmHDN trong panel3 của FrmMENU
                this.Hide();
                QuanLySanPhamGUI qlspForm = new QuanLySanPhamGUI();
                menuForm.ShowFormInPanel(qlspForm);
            }
        }

        private void btQLNV_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem FrmMENU có đang mở không
            MenuGUI menuForm = Application.OpenForms["MenuGUI"] as MenuGUI;
            if (menuForm != null)
            {
                // Thay đổi label1 của FrmMENU thành "Hóa Đơn Nhập"
                menuForm.ChangeLabel("Quản Lý Nhân Viên");

                // Ẩn FrmHD và hiển thị FrmHDN trong panel3 của FrmMENU
                this.Hide();
                QuanlyNhanVienGUI qlnvForm = new QuanlyNhanVienGUI();
                menuForm.ShowFormInPanel(qlnvForm);
            }
        }

        private void ptbQLNV_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem FrmMENU có đang mở không
            MenuGUI menuForm = Application.OpenForms["MenuGUI"] as MenuGUI;
            if (menuForm != null)
            {
                // Thay đổi label1 của FrmMENU thành "Hóa Đơn Nhập"
                menuForm.ChangeLabel("Quản Lý Nhân Viên");

                // Ẩn FrmHD và hiển thị FrmHDN trong panel3 của FrmMENU
                this.Hide();
                QuanlyNhanVienGUI qlnvForm = new QuanlyNhanVienGUI();
                menuForm.ShowFormInPanel(qlnvForm);
            }
        }

        private void btQLKH_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem FrmMENU có đang mở không
            MenuGUI menuForm = Application.OpenForms["MenuGUI"] as MenuGUI;
            if (menuForm != null)
            {
                // Thay đổi label1 của FrmMENU thành "Hóa Đơn Nhập"
                menuForm.ChangeLabel("Quản Lý Khách Hàng");

                // Ẩn FrmHD và hiển thị FrmHDN trong panel3 của FrmMENU
                this.Hide();
                QuanLyKhachHangGUI qlkhForm = new QuanLyKhachHangGUI();
                menuForm.ShowFormInPanel(qlkhForm);
            }
        }

        private void ptbQLKH_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem FrmMENU có đang mở không
            MenuGUI menuForm = Application.OpenForms["MenuGUI"] as MenuGUI;
            if (menuForm != null)
            {
                // Thay đổi label1 của FrmMENU thành "Hóa Đơn Nhập"
                menuForm.ChangeLabel("Quản Lý Khách Hàng");

                // Ẩn FrmHD và hiển thị FrmHDN trong panel3 của FrmMENU
                this.Hide();
                QuanLyKhachHangGUI qlkhForm = new QuanLyKhachHangGUI();
                menuForm.ShowFormInPanel(qlkhForm);
            }
        }

        private void btQLNCC_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem FrmMENU có đang mở không
            MenuGUI menuForm = Application.OpenForms["MenuGUI"] as MenuGUI;
            if (menuForm != null)
            {
                // Thay đổi label1 của FrmMENU thành "Hóa Đơn Nhập"
                menuForm.ChangeLabel("Quản Lý Nhà Cung Cấp");

                // Ẩn FrmHD và hiển thị FrmHDN trong panel3 của FrmMENU
                this.Hide();
                QuanLyNhaCungCapGUI qlnccForm = new QuanLyNhaCungCapGUI();
                menuForm.ShowFormInPanel(qlnccForm);
            }
        }

        private void ptbQLNCC_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem FrmMENU có đang mở không
            MenuGUI menuForm = Application.OpenForms["MenuGUI"] as MenuGUI;
            if (menuForm != null)
            {
                // Thay đổi label1 của FrmMENU thành "Hóa Đơn Nhập"
                menuForm.ChangeLabel("Quản Lý Nhà Cung Cấp");

                // Ẩn FrmHD và hiển thị FrmHDN trong panel3 của FrmMENU
                this.Hide();
                QuanLyNhaCungCapGUI qlnccForm = new QuanLyNhaCungCapGUI();
                menuForm.ShowFormInPanel(qlnccForm);
            }
        }

        private void btQLDMSP_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem FrmMENU có đang mở không
            MenuGUI menuForm = Application.OpenForms["MenuGUI"] as MenuGUI;
            if (menuForm != null)
            {
                // Thay đổi label1 của FrmMENU thành "Hóa Đơn Nhập"
                menuForm.ChangeLabel("Quản Lý Danh Mục Sản Phẩm");

                // Ẩn FrmHD và hiển thị FrmHDN trong panel3 của FrmMENU
                this.Hide();
                QuanLyDanhMucSanPhamGUI qldmspForm = new QuanLyDanhMucSanPhamGUI();
                menuForm.ShowFormInPanel(qldmspForm);
            }
        }

        private void ptbQLDMSP_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem FrmMENU có đang mở không
            MenuGUI menuForm = Application.OpenForms["MenuGUI"] as MenuGUI;
            if (menuForm != null)
            {
                // Thay đổi label1 của FrmMENU thành "Hóa Đơn Nhập"
                menuForm.ChangeLabel("Quản Lý Danh Mục Sản Phẩm");

                // Ẩn FrmHD và hiển thị FrmHDN trong panel3 của FrmMENU
                this.Hide();
                QuanLyDanhMucSanPhamGUI qldmspForm = new QuanLyDanhMucSanPhamGUI();
                menuForm.ShowFormInPanel(qldmspForm);
            }
        }

        private void btQLND_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem FrmMENU có đang mở không
            MenuGUI menuForm = Application.OpenForms["MenuGUI"] as MenuGUI;
            if (menuForm != null)
            {
                // Thay đổi label1 của FrmMENU thành "Hóa Đơn Nhập"
                menuForm.ChangeLabel("Quản Lý Người Dùng");

                // Ẩn FrmHD và hiển thị FrmHDN trong panel3 của FrmMENU
                this.Hide();
                QuanLiNguoiDungGUI qlndForm = new QuanLiNguoiDungGUI();
                menuForm.ShowFormInPanel(qlndForm);
            }
        }

        private void ptbQLND_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem FrmMENU có đang mở không
            MenuGUI menuForm = Application.OpenForms["MenuGUI"] as MenuGUI;
            if (menuForm != null)
            {
                // Thay đổi label1 của FrmMENU thành "Hóa Đơn Nhập"
                menuForm.ChangeLabel("Quản Lý Người Dùng");

                // Ẩn FrmHD và hiển thị FrmHDN trong panel3 của FrmMENU
                this.Hide();
                QuanLiNguoiDungGUI qlndForm = new QuanLiNguoiDungGUI();
                menuForm.ShowFormInPanel(qlndForm);
            }
        }
    }
}
