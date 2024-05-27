using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class QuanlyNhanVienGUI : Form
    {
        //[1].kết nối 
        private NhanVienBLL bll = new NhanVienBLL();
        public QuanlyNhanVienGUI()
        {
            InitializeComponent();

            //[5].load dsnv
            LoadDSNV();

            //[6]. load pb
            LoadPB();

            //[7].load nv
            LoadNV();
        }

        private void QuanlyNhanVienGUI_Load(object sender, EventArgs e)
        {
            cbbGT.SelectedIndex = 0; // Đây là index của phần tử đầu tiên trong ComboBox
            cbbTTLV.SelectedIndex = 0; // Đây là index của phần tử đầu tiên trong ComboBox
            dtgDSNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        //[5] 
        private void LoadDSNV()
        {
            // Xóa tất cả các cột hiện có trong DataGridView
            dtgDSNV.Columns.Clear();

            // Thêm các cột mới với tên tiếng Việt tương ứng
            dtgDSNV.Columns.Add("MaNhanVien", "Mã nhân viên");
            dtgDSNV.Columns.Add("TenNhanVien", "Tên nhân viên");
            dtgDSNV.Columns.Add("NgaySinh", "Ngày sinh");
            dtgDSNV.Columns.Add("GioiTinh", "Giới tính");
            dtgDSNV.Columns.Add("DiaChi", "Địa chỉ");
            dtgDSNV.Columns.Add("SoDienThoai", "Số điện thoại");
            dtgDSNV.Columns.Add("Email", "Email");
            dtgDSNV.Columns.Add("MaPhongBan", "Mã phòng ban");
            dtgDSNV.Columns.Add("TinhTrangLamViec", "Tình trạng làm việc");

            // Load data from DataTable to DataGridView
            DataTable dataTable = bll.LayDanhSachNhanVien(); // Giả sử bus.LayDanhSachNhanVien() là phương thức để lấy dữ liệu từ bảng tbl_NhanVien
            foreach (DataRow row in dataTable.Rows)
            {
                // Thêm dòng mới vào DataGridView và điền dữ liệu
                dtgDSNV.Rows.Add(row.ItemArray);
            }
        }
        private void LoadPB()
        {
            // Xóa tất cả các mục trong ComboBox trước khi thêm mới
            cbbPB.Items.Clear();

            // Lấy danh sách tên loại từ cơ sở dữ liệu, bạn có thể sử dụng một hàm trong BUS hoặc DAL để thực hiện việc này
            DataTable dataTable = bll.LayDanhSachPhongBan(); // Giả sử hàm LayDanhSachTenLoai trả về DataTable chứa danh sách tên loại

            // Thêm danh sách tên loại vào ComboBox
            foreach (DataRow row in dataTable.Rows)
            {
                // Lấy giá trị của cột "TenLoai" từ mỗi dòng và thêm vào ComboBox
                cbbPB.Items.Add(row["TenPhongBan"].ToString());
            }
            cbbPB.SelectedIndex = 0; // Chọn mục đầu tiên làm mục mặc định

        }
        //[7].
        private void LoadNV()
        {
            // Xóa tất cả các mục trong ComboBox trước khi thêm mới
            cbbTKNV.Items.Clear();

            // Lấy danh sách tên loại từ cơ sở dữ liệu, bạn có thể sử dụng một hàm trong BUS hoặc DAL để thực hiện việc này
            DataTable dataTable = bll.LayDanhSachNhanVien(); // Giả sử hàm LayDanhSachTenLoai trả về DataTable chứa danh sách tên loại

            // Thêm danh sách tên loại vào ComboBox
            foreach (DataRow row in dataTable.Rows)
            {
                // Lấy giá trị của cột "TenLoai" từ mỗi dòng và thêm vào ComboBox
                cbbTKNV.Items.Add(row["TenNhanVien"].ToString());
            }
            cbbTKNV.SelectedIndex = 0; // Chọn mục đầu tiên làm mục mặc định

        }

        //[11].làm mới 

        private void btLM_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Text = "";
                }
            }
            LoadDSNV();
            txtMaNV.Enabled = true;
            LoadNV();
            LoadPB();
        }

        //[10].thêm 
        private void btThem_Click(object sender, EventArgs e)
        {
            NhanVienDTO nhanVien = new NhanVienDTO();
            nhanVien.MaNhanVien = txtMaNV.Text;
            nhanVien.TenNhanVien = txtTenNV.Text;
            nhanVien.NgaySinh = dtpNS.Text;
            nhanVien.GioiTinh = cbbGT.Text;
            nhanVien.DiaChi = txtDC.Text;
            nhanVien.SoDienThoai = txtSDT.Text;// Lấy mã loại sản phẩm từ DataGridView
            nhanVien.Email = txtEmail.Text;
            string tenPB = cbbPB.Text;
            // Thực hiện truy vấn để lấy tên loại sản phẩm dựa trên mã loại
            string MaPB = bll.LayMaPhongBanTheoTen(tenPB);
            // Đặt giá trị cho ComboBox
            nhanVien.MaPhongBan = MaPB;
            nhanVien.TinhTrangLamViec = cbbTTLV.Text;
            var result = MessageBox.Show("Bạn có muốn lưu thông tin này không.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                bll.ThemNhanVien(nhanVien);
                MessageBox.Show("Đã lưu thông tin nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSNV();
                LoadNV();
            }
        }

        //[8].sửa
        private void btSua_Click(object sender, EventArgs e)
        {
            NhanVienDTO nhanVien = new NhanVienDTO();
            nhanVien.MaNhanVien = txtMaNV.Text;
            nhanVien.TenNhanVien = txtTenNV.Text;
            nhanVien.NgaySinh = dtpNS.Text;
            nhanVien.GioiTinh = cbbGT.Text;
            nhanVien.DiaChi = txtDC.Text;
            nhanVien.SoDienThoai = txtSDT.Text;// Lấy mã loại sản phẩm từ DataGridView
            nhanVien.Email = txtEmail.Text;
            string tenPB = cbbPB.Text;
            // Thực hiện truy vấn để lấy tên loại sản phẩm dựa trên mã loại
            string MaPB = bll.LayMaPhongBanTheoTen(tenPB);
            // Đặt giá trị cho ComboBox
            nhanVien.MaPhongBan = MaPB;
            nhanVien.TinhTrangLamViec = cbbTTLV.Text;
            var result = MessageBox.Show("Bạn có muốn sửa thông tin này không.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                bll.SuaNhanVien(nhanVien);
                MessageBox.Show("Đã sửa thông tin nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSNV();
                LoadNV();
            }
        }

        //[10].xóa
        private void btXoa_Click(object sender, EventArgs e)
        {
            string maNhanVien = txtMaNV.Text;
            var result = MessageBox.Show("Bạn có muốn xóa thông tin này không.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                bll.XoaNhanVien(maNhanVien);
                MessageBox.Show("Đã xóa thông tin nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSNV();
                LoadNV();
                LoadPB();
            }
        }

        private void dtgDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is not a header and row index is valid
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dtgDSNV.Rows[e.RowIndex];

                // Điền vào các hộp văn bản hoặc các điều khiển khác với dữ liệu từ hàng đã chọn
                txtMaNV.Text = selectedRow.Cells["MaNhanVien"].Value.ToString();
                txtTenNV.Text = selectedRow.Cells["TenNhanVien"].Value.ToString();
                dtpNS.Text = selectedRow.Cells["NgaySinh"].Value.ToString();
                cbbGT.Text = selectedRow.Cells["GioiTinh"].Value.ToString();
                txtDC.Text = selectedRow.Cells["DiaChi"].Value.ToString();
                txtSDT.Text = selectedRow.Cells["SoDienThoai"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                cbbTTLV.Text = selectedRow.Cells["TinhTrangLamViec"].Value.ToString();

                txtMaNV.Enabled = false;
                // Lấy mã loại sản phẩm từ DataGridView
                string maPB = selectedRow.Cells["MaPhongBan"].Value.ToString();

                // Thực hiện truy vấn để lấy tên loại sản phẩm dựa trên mã loại
                string tenPB = bll.LayTenPhongBanTheoMa(maPB);

                // Đặt giá trị cho ComboBox
                cbbPB.Text = tenPB;
            }
        }

        private void btTKNV_Click(object sender, EventArgs e)
        {
            // Lấy tên sản phẩm từ ComboBox
            string tenNhanVien = cbbTKNV.Text;

            // Gọi phương thức LayDanhSachSanPhamTheoTen để lấy danh sách sản phẩm tương ứng với tên sản phẩm
            DataTable dataTable = bll.LayDanhSachNhanVienTheoTen(tenNhanVien);

            // Clear DataGridView trước khi load dữ liệu mới
            dtgDSNV.Rows.Clear();

            // Load data from DataTable to DataGridView
            foreach (DataRow row in dataTable.Rows)
            {
                // Thêm dòng mới vào DataGridView và điền dữ liệu
                dtgDSNV.Rows.Add(row.ItemArray);
            }
        }

        private void txtMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chuyển ký tự nhập vào thành chữ hoa nếu là chữ cái
            if (char.IsLetter(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
