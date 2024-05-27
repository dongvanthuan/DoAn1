using BLL;
using DTO;
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
    public partial class QuanLyNhaCungCapGUI : Form
    {
        //[1].kết nối 
        private NhaCungCapBLL bll = new NhaCungCapBLL();
        public QuanLyNhaCungCapGUI()
        {
            InitializeComponent();

            //[6] load dsncc
            LoadDSNCC();

            //[7] load ncc
            LoadNCC();

        }

        private void QuanLyNhaCungCapGUI_Load(object sender, EventArgs e)
        {
            cbbHTTT.SelectedIndex = 0; // Đây là index của phần tử đầu tiên trong ComboBox
            dtgDSNCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void LoadDSNCC()
        {
            // Xóa tất cả các cột hiện có trong DataGridView
            dtgDSNCC.Columns.Clear();

            // Thêm các cột mới với tên tiếng Việt tương ứng
            dtgDSNCC.Columns.Add("MaNhaCungCap", "Mã nhà cung cấp");
            dtgDSNCC.Columns.Add("TenNhaCungCap", "Tên nhà cung cấp");
            dtgDSNCC.Columns.Add("TenNguoiDaiDien", "Tên người đại diện");
            dtgDSNCC.Columns.Add("DiaChi", "Địa chỉ");
            dtgDSNCC.Columns.Add("SoDienThoai", "Số điện thoại");
            dtgDSNCC.Columns.Add("Email", "Email");
            dtgDSNCC.Columns.Add("HinhThucThanhToan", "Hình thức thanh toán");

            // Load data from DataTable to DataGridView
            DataTable dataTable = bll.LayDanhSachNhaCungCap(); // Giả sử bus.LayDanhSachNhaCungCap() là phương thức để lấy dữ liệu từ bảng tbl_NhaCungCap
            foreach (DataRow row in dataTable.Rows)
            {
                // Thêm dòng mới vào DataGridView và điền dữ liệu
                dtgDSNCC.Rows.Add(row.ItemArray);
            }
        }
        private void LoadNCC()
        {
            // Xóa tất cả các mục trong ComboBox trước khi thêm mới
            cbbTKNCC.Items.Clear();

            // Lấy danh sách tên loại từ cơ sở dữ liệu, bạn có thể sử dụng một hàm trong BUS hoặc DAL để thực hiện việc này
            DataTable dataTable = bll.LayDanhSachNhaCungCap(); // Giả sử hàm LayDanhSachTenLoai trả về DataTable chứa danh sách tên loại

            // Thêm danh sách tên loại vào ComboBox
            foreach (DataRow row in dataTable.Rows)
            {
                // Lấy giá trị của cột "TenLoai" từ mỗi dòng và thêm vào ComboBox
                cbbTKNCC.Items.Add(row["TenNhaCungCap"].ToString());
            }
            cbbTKNCC.SelectedIndex = 0; // Chọn mục đầu tiên làm mục mặc định

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
            LoadDSNCC();
            txtMaNCC.Enabled = true;
            LoadNCC();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO nhaCungCap = new NhaCungCapDTO();
            nhaCungCap.MaNhaCungCap = txtMaNCC.Text;
            nhaCungCap.TenNhaCungCap = txtTenNCC.Text;
            nhaCungCap.TenNguoiDaiDien = txtTNDD.Text;
            nhaCungCap.DiaChi = txtDC.Text;
            nhaCungCap.SoDienThoai = txtSDT.Text;// Lấy mã loại sản phẩm từ DataGridView
            nhaCungCap.Email = txtEmail.Text;
            nhaCungCap.HinhThucThanhToan = cbbHTTT.Text;
            var result = MessageBox.Show("Bạn có muốn lưu thông tin này không.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                bll.ThemNhaCungCap(nhaCungCap);
                MessageBox.Show("Đã lưu thông tin nhà cung cấp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSNCC();
                LoadNCC();
            }

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO nhaCungCap = new NhaCungCapDTO();
            nhaCungCap.MaNhaCungCap = txtMaNCC.Text;
            nhaCungCap.TenNhaCungCap = txtTenNCC.Text;
            nhaCungCap.TenNguoiDaiDien = txtTNDD.Text;
            nhaCungCap.DiaChi = txtDC.Text;
            nhaCungCap.SoDienThoai = txtSDT.Text;// Lấy mã loại sản phẩm từ DataGridView
            nhaCungCap.Email = txtEmail.Text;
            nhaCungCap.HinhThucThanhToan = cbbHTTT.Text;
            var result = MessageBox.Show("Bạn có muốn sửa thông tin này không.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                bll.SuaNhaCungCap(nhaCungCap);
                MessageBox.Show("Đã sửa thông tin nhà cung cấp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSNCC();
                LoadNCC();
            }

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string maNhaCungCap = txtMaNCC.Text;
            var result = MessageBox.Show("Bạn có muốn xóa thông tin này không.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                bll.XoaNhaCungCap(maNhaCungCap);
                MessageBox.Show("Đã xóa thông tin nhà cung cấp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSNCC();
                LoadNCC();
                foreach (Control c in groupBox1.Controls)
                {
                    if (c is TextBox)
                    {
                        (c as TextBox).Text = "";
                    }
                }
                txtMaNCC.Enabled = true;
            }

        }

        private void dtgDSNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is not a header and row index is valid
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dtgDSNCC.Rows[e.RowIndex];

                // Điền vào các hộp văn bản hoặc các điều khiển khác với dữ liệu từ hàng đã chọn
                txtMaNCC.Text = selectedRow.Cells["MaNhaCungCap"].Value.ToString();
                txtTenNCC.Text = selectedRow.Cells["TenNhaCungCap"].Value.ToString();
                txtTNDD.Text = selectedRow.Cells["TenNguoiDaiDien"].Value.ToString(); // Chú ý tên người đại diện thay cho ngày sinh
                txtDC.Text = selectedRow.Cells["DiaChi"].Value.ToString();
                txtSDT.Text = selectedRow.Cells["SoDienThoai"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                cbbHTTT.Text = selectedRow.Cells["HinhThucThanhToan"].Value.ToString(); // Chú ý hình thức thanh toán thay cho tình trạng làm việc

                txtMaNCC.Enabled = false;

            }

        }

        private void btTKNCC_Click(object sender, EventArgs e)
        {
            // Lấy tên sản phẩm từ ComboBox
            string tenNhaCungCap = cbbTKNCC.Text;

            // Gọi phương thức LayDanhSachSanPhamTheoTen để lấy danh sách sản phẩm tương ứng với tên sản phẩm
            DataTable dataTable = bll.LayDanhSachNhaCungCapTheoTen(tenNhaCungCap);

            // Clear DataGridView trước khi load dữ liệu mới
            dtgDSNCC.Rows.Clear();

            // Load data from DataTable to DataGridView
            foreach (DataRow row in dataTable.Rows)
            {
                // Thêm dòng mới vào DataGridView và điền dữ liệu
                dtgDSNCC.Rows.Add(row.ItemArray);
            }

        }

        private void txtMaNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chuyển ký tự nhập vào thành chữ hoa nếu là chữ cái
            if (char.IsLetter(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }

        }
    }
}
