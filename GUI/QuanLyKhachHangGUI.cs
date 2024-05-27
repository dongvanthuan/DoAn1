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
    public partial class QuanLyKhachHangGUI : Form
    {
        private KhachHangBLL bll = new KhachHangBLL();
        public QuanLyKhachHangGUI()
        {
            InitializeComponent();

            //[6].load dskh
            LoadDSKH();

            //[7].load Kh
            LoadKH();
        }

        private void QuanLyKhachHangGUI_Load(object sender, EventArgs e)
        {
            cbbGT.SelectedIndex = 0; // Đây là index của phần tử đầu tiên trong ComboBox
            dtgDSKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //[6].
        private void LoadDSKH()
        {
            // Xóa tất cả các cột hiện có trong DataGridView
            dtgDSKH.Columns.Clear();

            // Thêm các cột mới với tên tiếng Việt tương ứng
            dtgDSKH.Columns.Add("MaKhachHang", "Mã khách hàng");
            dtgDSKH.Columns.Add("TenKhachHang", "Tên khách hàng");
            dtgDSKH.Columns.Add("GioiTinh", "Giới tính");
            dtgDSKH.Columns.Add("NgaySinh", "Ngày sinh");
            dtgDSKH.Columns.Add("DiaChi", "Địa chỉ");
            dtgDSKH.Columns.Add("SoDienThoai", "Số điện thoại");
            dtgDSKH.Columns.Add("Email", "Email");

            // Load data from DataTable to DataGridView
            DataTable dataTable =bll.LayDanhSachKhachHang(); // Giả sử bus.LayDanhSachKhachHang() là phương thức để lấy dữ liệu từ bảng tbl_KhachHang
            foreach (DataRow row in dataTable.Rows)
            {
                // Thêm dòng mới vào DataGridView và điền dữ liệu
                dtgDSKH.Rows.Add(row.ItemArray);
            }
        }
        //[7].
        private void LoadKH()
        {
            // Xóa tất cả các mục trong ComboBox trước khi thêm mới
            cbbTKKH.Items.Clear();

            // Lấy danh sách tên loại từ cơ sở dữ liệu, bạn có thể sử dụng một hàm trong BUS hoặc DAL để thực hiện việc này
            DataTable dataTable = bll.LayDanhSachKhachHang(); // Giả sử hàm LayDanhSachTenLoai trả về DataTable chứa danh sách tên loại

            // Thêm danh sách tên loại vào ComboBox
            foreach (DataRow row in dataTable.Rows)
            {
                // Lấy giá trị của cột "TenLoai" từ mỗi dòng và thêm vào ComboBox
                cbbTKKH.Items.Add(row["TenKhachHang"].ToString());
            }
            cbbTKKH.SelectedIndex = 0; // Chọn mục đầu tiên làm mục mặc định

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            KhachHangDTO khachHang = new KhachHangDTO();
            khachHang.MaKhachHang = txtMaKH.Text;
            khachHang.TenKhachHang = txtTenKH.Text;
            khachHang.GioiTinh = cbbGT.Text;
            khachHang.NgaySinh = dtpNS.Text;
            khachHang.DiaChi = txtDC.Text;
            khachHang.SoDienThoai = txtSDT.Text;
            khachHang.Email = txtEmail.Text;
            var result = MessageBox.Show("Bạn có muốn lưu thông tin này không.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                bll.ThemKhachHang(khachHang);
                MessageBox.Show("Đã lưu thông tin khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSKH();
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            KhachHangDTO khachHang = new KhachHangDTO();
            khachHang.MaKhachHang = txtMaKH.Text;
            khachHang.TenKhachHang = txtTenKH.Text;
            khachHang.GioiTinh = cbbGT.Text;
            khachHang.NgaySinh = dtpNS.Text;
            khachHang.DiaChi = txtDC.Text;
            khachHang.SoDienThoai = txtSDT.Text;
            khachHang.Email = txtEmail.Text;
            var result = MessageBox.Show("Bạn có muốn sửa thông tin này không.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                bll.SuaKhachHang(khachHang);
                MessageBox.Show("Đã sửa thông tin khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSKH();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string maKhachhang = txtMaKH.Text;
            var result = MessageBox.Show("Bạn có muốn xóa thông tin này không.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                bll.XoaKhachHang(maKhachhang);
                MessageBox.Show("Đã xóa thông tin khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSKH();
                LoadKH();
                foreach (Control c in groupBox1.Controls)
                {
                    if (c is TextBox)
                    {
                        (c as TextBox).Text = "";
                    }
                }
                txtMaKH.Enabled = true;
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
            LoadDSKH();
            txtMaKH.Enabled = true;
            LoadKH();
        }

        private void dtgDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is not a header and row index is valid
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dtgDSKH.Rows[e.RowIndex];

                // Fill the text boxes or other controls with data from the selected row
                txtMaKH.Text = selectedRow.Cells["MaKhachHang"].Value.ToString();
                txtTenKH.Text = selectedRow.Cells["TenKhachHang"].Value.ToString();
                cbbGT.Text = selectedRow.Cells["GioiTinh"].Value.ToString(); // Note: Gender instead of Birth Date
                dtpNS.Text = selectedRow.Cells["NgaySinh"].Value.ToString(); // Assuming NgaySinh is a DateTime field
                txtDC.Text = selectedRow.Cells["DiaChi"].Value.ToString();
                txtSDT.Text = selectedRow.Cells["SoDienThoai"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();

                txtMaKH.Enabled = false;
            }
        }

        private void btTKKH_Click(object sender, EventArgs e)
        {
            // Lấy tên sản phẩm từ ComboBox
            string tenKhachHang = cbbTKKH.Text;

            // Gọi phương thức LayDanhSachSanPhamTheoTen để lấy danh sách sản phẩm tương ứng với tên sản phẩm
            DataTable dataTable = bll.LayDanhSachKhachHangTheoTen(tenKhachHang);

            // Clear DataGridView trước khi load dữ liệu mới
            dtgDSKH.Rows.Clear();

            // Load data from DataTable to DataGridView
            foreach (DataRow row in dataTable.Rows)
            {
                // Thêm dòng mới vào DataGridView và điền dữ liệu
                dtgDSKH.Rows.Add(row.ItemArray);
            }
        }

        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chuyển ký tự nhập vào thành chữ hoa nếu là chữ cái
            if (char.IsLetter(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }
    }
}
