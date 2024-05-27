using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class QuanLiNguoiDungGUI : Form
    {
        //[1].kết nối 
        private NguoiDungBLL bll = new NguoiDungBLL();
        public QuanLiNguoiDungGUI()
        {
            InitializeComponent();

            //[5].load dsnd
            LoadDSND();

            //[6]. load pb
            LoadLND();

            //[7].load nv
            LoadND();
        }

        private void QuanLiNguoiDungGUI_Load(object sender, EventArgs e)
        {
            cbbGT.SelectedIndex = 0; // Đây là index của phần tử đầu tiên trong ComboBox
            cbbMaLoaiND.SelectedIndex = 0; // Đây là index của phần tử đầu tiên trong ComboBox
            dtgDSND.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadDSND()
        {
            // Xóa tất cả các cột hiện có trong DataGridView
            dtgDSND.Columns.Clear();

            // Thêm các cột mới với tên tiếng Việt tương ứng
            dtgDSND.Columns.Add("TenDangNhap", "Tên đăng nhập");
            dtgDSND.Columns.Add("MatKhau", "Mật khẩu");
            dtgDSND.Columns.Add("HoTen", "Họ tên");
            dtgDSND.Columns.Add("SDT", "Số điện thoại");
            dtgDSND.Columns.Add("NgaySinh", "Ngày sinh");
            dtgDSND.Columns.Add("DiaChi", "Địa chỉ");
            dtgDSND.Columns.Add("GioiTinh", "Giới tính");
            dtgDSND.Columns.Add("Email", "Email");
            dtgDSND.Columns.Add("MaLoaiND", "Mã loại người dùng");

            // Load data from DataTable to DataGridView
            DataTable dataTable = bll.LayDanhSachNguoiDung(); // Giả sử bus.LayDanhSachNguoiDung() là phương thức để lấy dữ liệu từ bảng tbl_NguoiDung
            foreach (DataRow row in dataTable.Rows)
            {
                // Thêm dòng mới vào DataGridView và điền dữ liệu
                dtgDSND.Rows.Add(row.ItemArray);
            }
        }
        //[6].
        private void LoadLND()
        {
            // Xóa tất cả các mục trong ComboBox trước khi thêm mới
            cbbMaLoaiND.Items.Clear();

            // Lấy danh sách tên loại từ cơ sở dữ liệu, bạn có thể sử dụng một hàm trong BUS hoặc DAL để thực hiện việc này
            DataTable dataTable = bll.LayDanhSachLoaiNguoiDung(); // Giả sử hàm LayDanhSachTenLoai trả về DataTable chứa danh sách tên loại

            // Thêm danh sách tên loại vào ComboBox
            foreach (DataRow row in dataTable.Rows)
            {
                // Lấy giá trị của cột "TenLoai" từ mỗi dòng và thêm vào ComboBox
                cbbMaLoaiND.Items.Add(row["TenLoai"].ToString());
            }
            cbbMaLoaiND.SelectedIndex = 0; // Chọn mục đầu tiên làm mục mặc định

        }
        //[7].
        private void LoadND()
        {
            // Xóa tất cả các mục trong ComboBox trước khi thêm mới
            cbbTKND.Items.Clear();

            // Lấy danh sách tên loại từ cơ sở dữ liệu, bạn có thể sử dụng một hàm trong BUS hoặc DAL để thực hiện việc này
            DataTable dataTable = bll.LayDanhSachNguoiDung(); // Giả sử hàm LayDanhSachTenLoai trả về DataTable chứa danh sách tên loại

            // Thêm danh sách tên loại vào ComboBox
            foreach (DataRow row in dataTable.Rows)
            {
                // Lấy giá trị của cột "TenLoai" từ mỗi dòng và thêm vào ComboBox
                cbbTKND.Items.Add(row["HoTen"].ToString());
            }
            cbbTKND.SelectedIndex = 0; // Chọn mục đầu tiên làm mục mặc định

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            NguoiDungDTO nguoiDung = new NguoiDungDTO();
            nguoiDung.TenDangNhap = txtTK.Text; // Sử dụng tên đăng nhập thay vì mã nhân viên
            nguoiDung.MatKhau = txtMK.Text;
            nguoiDung.HoTen = txtTenND.Text;
            nguoiDung.NgaySinh = dtpNS.Text;
            nguoiDung.GioiTinh = cbbGT.Text;
            nguoiDung.DiaChi = txtDC.Text;
            nguoiDung.SDT = txtSDT.Text; // Sử dụng số điện thoại thay vì mã loại sản phẩm
            nguoiDung.Email = txtEmail.Text;
            string tenLND = cbbMaLoaiND.Text;
            string maLND = bll.LayMaLoaiNguoiDungTheoTen(tenLND); // Sử dụng mã phòng ban thay vì tên loại sản phẩm
            nguoiDung.MaLoaiND = maLND;
            var result = MessageBox.Show("Bạn có muốn lưu thông tin này không.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                bll.ThemNguoiDung(nguoiDung);
                MessageBox.Show("Đã lưu thông tin người dùng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSND(); // Load danh sách người dùng thay vì danh sách nhân viên
            }
        }

        private void btLM_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Text = "";
                }
            }
            LoadDSND();
            txtTK.Enabled = true;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            NguoiDungDTO nguoiDung = new NguoiDungDTO();
            nguoiDung.TenDangNhap = txtTK.Text;
            nguoiDung.MatKhau = txtMK.Text; // Ensure MatKhau is set
            nguoiDung.HoTen = txtTenND.Text;
            nguoiDung.NgaySinh = dtpNS.Text;
            nguoiDung.GioiTinh = cbbGT.Text;
            nguoiDung.DiaChi = txtDC.Text;
            nguoiDung.SDT = txtSDT.Text;
            nguoiDung.Email = txtEmail.Text;
            string tenLND = cbbMaLoaiND.Text;
            string maLND = bll.LayMaLoaiNguoiDungTheoTen(tenLND);
            nguoiDung.MaLoaiND = maLND;
            var result = MessageBox.Show("Bạn có muốn sửa thông tin này không.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                bll.SuaNguoiDung(nguoiDung);
                MessageBox.Show("Đã sửa thông tin người dùng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSND();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTK.Text;
            var result = MessageBox.Show("Bạn có muốn xóa thông tin này không.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                bll.XoaNguoiDung(tenDangNhap);
                MessageBox.Show("Đã xóa thông tin người dùng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSND();
            }
        }

        private void dtgDSND_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is not a header and row index is valid
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dtgDSND.Rows[e.RowIndex];

                // Check for null values and handle them accordingly
                txtTK.Text = selectedRow.Cells["TenDangNhap"].Value?.ToString();
                txtMK.Text = selectedRow.Cells["MatKhau"].Value?.ToString();
                txtTenND.Text = selectedRow.Cells["HoTen"].Value?.ToString() ;
                dtpNS.Text = selectedRow.Cells["NgaySinh"].Value.ToString();
                cbbGT.Text = selectedRow.Cells["GioiTinh"].Value?.ToString();
                txtDC.Text = selectedRow.Cells["DiaChi"].Value?.ToString() ;
                txtSDT.Text = selectedRow.Cells["SDT"].Value?.ToString() ;
                txtEmail.Text = selectedRow.Cells["Email"].Value?.ToString();
                cbbMaLoaiND.Text = selectedRow.Cells["MaLoaiND"].Value?.ToString();

                txtTK.Enabled = false;

                // Get the MaLoaiND from DataGridView
                string maLND = selectedRow.Cells["MaLoaiND"].Value?.ToString();

                // Fetch the corresponding TenLoaiND based on MaLoaiND
                if (!string.IsNullOrEmpty(maLND))
                {
                    string tenLND = bll.LayTenLoaiNguoiDungTheoMa(maLND);
                    cbbMaLoaiND.Text = tenLND;
                }
            }
        }

        private void btTKND_Click(object sender, EventArgs e)
        {
            // Lấy tên sản phẩm từ ComboBox
            string tenNhuoiDung = cbbTKND.Text;

            // Gọi phương thức LayDanhSachSanPhamTheoTen để lấy danh sách sản phẩm tương ứng với tên sản phẩm
            DataTable dataTable = bll.LayDanhSachNguoiDungTheoTen(tenNhuoiDung);

            // Clear DataGridView trước khi load dữ liệu mới
            dtgDSND.Rows.Clear();

            // Load data from DataTable to DataGridView
            foreach (DataRow row in dataTable.Rows)
            {
                // Thêm dòng mới vào DataGridView và điền dữ liệu
                dtgDSND.Rows.Add(row.ItemArray);
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
