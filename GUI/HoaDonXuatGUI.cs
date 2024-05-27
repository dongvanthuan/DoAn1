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
    public partial class HoaDonXuatGUI : Form
    {
        //[1].kết nối 
        private HoaDonXuatBLL bll = new HoaDonXuatBLL();
        public HoaDonXuatGUI()
        {
            InitializeComponent();


            //[4].load dshd
            LoadDSHDX();

            //[5].load nv
            LoadNV();

            //[6].load kh
            LoadKH();

            //[7].load Hdx
            LoadHDX();
        }

        private void HoaDonXuatGUI_Load(object sender, EventArgs e)
        {
            dtgDSHDX.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cbbPTTT.SelectedIndex = 0; // Chọn mục đầu tiên làm mục mặc định
        }
        private void LoadDSHDX()
        {
            // Xóa tất cả các cột hiện có trong DataGridView
            dtgDSHDX.Columns.Clear();

            // Thêm các cột mới với tên tiếng Việt tương ứng
            dtgDSHDX.Columns.Add("MaHoaDonXuat", "Mã hóa đơn xuất");
            dtgDSHDX.Columns.Add("NgayXuat", "Ngày xuất");
            dtgDSHDX.Columns.Add("MaKhachHang", "Mã khách hàng");
            dtgDSHDX.Columns.Add("MaNhanVienLapHoaDon", "Mã nhân viên lập hóa đơn");
            dtgDSHDX.Columns.Add("PhuongThucThanhToan", "Phương thức thanh toán");
            dtgDSHDX.Columns.Add("TongTienHang", "Tổng tiền hàng");

            // Định dạng cột "TongTienHang"
            dtgDSHDX.Columns["TongTienHang"].DefaultCellStyle.Format = "#,###";

            // Load data from DataTable to DataGridView
            DataTable dataTable = bll.LayDanhSachHoaDonXuat();
            foreach (DataRow row in dataTable.Rows)
            {
                // Thêm dòng mới vào DataGridView và điền dữ liệu
                dtgDSHDX.Rows.Add(row.ItemArray);
            }
        }
        //[5].
        private void LoadNV()
        {
            // Xóa tất cả các mục trong ComboBox trước khi thêm mới
            cbbTenNV.Items.Clear();

            // Lấy danh sách tên loại từ cơ sở dữ liệu, bạn có thể sử dụng một hàm trong BUS hoặc DAL để thực hiện việc này
            DataTable dataTable = bll.LayDanhSachNhanVien(); // Giả sử hàm LayDanhSachTenLoai trả về DataTable chứa danh sách tên loại

            // Thêm danh sách tên loại vào ComboBox
            foreach (DataRow row in dataTable.Rows)
            {
                // Lấy giá trị của cột "TenLoai" từ mỗi dòng và thêm vào ComboBox
                cbbTenNV.Items.Add(row["TenNhanVien"].ToString());
            }
            cbbTenNV.SelectedIndex = 0; // Chọn mục đầu tiên làm mục mặc định
        }
        private void LoadKH()
        {
            // Xóa tất cả các mục trong ComboBox trước khi thêm mới
            cbbTenKH.Items.Clear();

            // Lấy danh sách tên loại từ cơ sở dữ liệu, bạn có thể sử dụng một hàm trong BUS hoặc DAL để thực hiện việc này
            DataTable dataTable = bll.LayDanhSachKhachHang(); // Giả sử hàm LayDanhSachTenLoai trả về DataTable chứa danh sách tên loại

            // Thêm danh sách tên loại vào ComboBox
            foreach (DataRow row in dataTable.Rows)
            {
                // Lấy giá trị của cột "TenLoai" từ mỗi dòng và thêm vào ComboBox
                cbbTenKH.Items.Add(row["TenKhachHang"].ToString());
            }
            cbbTenKH.SelectedIndex = 0; // Chọn mục đầu tiên làm mục mặc định

        }
        //[7].
        private void LoadHDX()
        {
            // Xóa tất cả các mục trong ComboBox trước khi thêm mới
            cbbMaHDX.Items.Clear();

            // Lấy danh sách tên loại từ cơ sở dữ liệu, bạn có thể sử dụng một hàm trong BUS hoặc DAL để thực hiện việc này
            DataTable dataTable = bll.LayDanhSachHoaDonXuat(); // Giả sử hàm LayDanhSachTenLoai trả về DataTable chứa danh sách tên loại

            // Thêm danh sách tên loại vào ComboBox
            foreach (DataRow row in dataTable.Rows)
            {
                // Lấy giá trị của cột "TenLoai" từ mỗi dòng và thêm vào ComboBox
                cbbMaHDX.Items.Add(row["MaHoaDonXuat"].ToString());
            }
            cbbMaHDX.SelectedIndex = 0; // Chọn mục đầu tiên làm mục mặc định
        }

        //private void btTHDX_Click(object sender, EventArgs e)
        //{
            // Kích hoạt sự kiện `ButtonClicked` với tham số "CTHDN"
            //OnButtonClicked("CTHDX");
        //}
        //protected virtual void OnButtonClicked(string formName)
        //{
            //ButtonClicked?.Invoke(this, formName);
        //}

        private void btThem_Click(object sender, EventArgs e)
        {
            HoaDonXuatDTO hoaDonXuat = new HoaDonXuatDTO();
            hoaDonXuat.MaHoaDonXuat = txtMaHDX.Text;
            hoaDonXuat.NgayXuat = dtpNX.Text;
            hoaDonXuat.PhuongThucThanhToan = cbbPTTT.Text;

            // Lấy tên khách hàng từ ComboBox
            string tenKhachHang = cbbTenKH.Text;
            // Thực hiện truy vấn để lấy mã khách hàng dựa trên tên khách hàng
            string maKhachHang = bll.LayMaKhachHangTheoTen(tenKhachHang);
            // Đặt giá trị cho ComboBox
            hoaDonXuat.MaKhachHang = maKhachHang;

            // Lấy tên nhân viên từ ComboBox
            string tenNhanVien = cbbTenNV.Text;
            // Thực hiện truy vấn để lấy mã nhân viên dựa trên tên nhân viên
            string maNhanVien = bll.LayMaNhanVienTheoTen(tenNhanVien);
            // Đặt giá trị cho ComboBox
            hoaDonXuat.MaNhanVienLapHoaDon = maNhanVien;

            hoaDonXuat.TongTienHang = int.Parse(txtTTH.Text);

            var result = MessageBox.Show("Bạn có muốn lưu thông tin này không.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                bll.ThemHoaDonXuat(hoaDonXuat);
                MessageBox.Show("Đã lưu hóa đơn xuất thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSHDX();
                // Load lại các danh sách sau khi thêm hóa đơn xuất
                LoadNV();
                LoadKH();
                LoadHDX();
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            HoaDonXuatDTO hoaDonXuat = new HoaDonXuatDTO();
            hoaDonXuat.MaHoaDonXuat = txtMaHDX.Text;
            hoaDonXuat.NgayXuat = dtpNX.Text;
            hoaDonXuat.PhuongThucThanhToan = cbbPTTT.Text;

            // Lấy tên khách hàng từ ComboBox
            string tenKhachHang = cbbTenKH.Text;
            // Thực hiện truy vấn để lấy mã khách hàng dựa trên tên khách hàng
            string maKhachHang = bll.LayMaKhachHangTheoTen(tenKhachHang);
            // Đặt giá trị cho ComboBox
            hoaDonXuat.MaKhachHang = maKhachHang;

            // Lấy tên nhân viên từ ComboBox
            string tenNhanVien = cbbTenNV.Text;
            // Thực hiện truy vấn để lấy mã nhân viên dựa trên tên nhân viên
            string maNhanVien = bll.LayMaNhanVienTheoTen(tenNhanVien);
            // Đặt giá trị cho ComboBox
            hoaDonXuat.MaNhanVienLapHoaDon = maNhanVien;

            hoaDonXuat.TongTienHang = int.Parse(txtTTH.Text);

            var result = MessageBox.Show("Bạn có muốn lưu thông tin này không.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                bll.SuaHoaDonXuat(hoaDonXuat);
                MessageBox.Show("Đã sửa hóa đơn xuất thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSHDX();
                // Load lại các danh sách sau khi thêm hóa đơn xuất
                LoadNV();
                LoadKH();
                LoadHDX();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string maHoaDon = txtMaHDX.Text;
            var result = MessageBox.Show("Bạn có muốn xóa thông tin này không.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                bll.XoaHoaDonXuat(maHoaDon);
                MessageBox.Show("Đã xóa hóa đơn xuất thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSHDX();
                // Load lại các danh sách sau khi thêm hóa đơn xuất
                LoadNV();
                LoadKH();
                LoadHDX();
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
            LoadDSHDX();
            // Load lại các danh sách sau khi thêm hóa đơn xuất
            LoadNV();
            LoadKH();
            LoadHDX();
            txtMaHDX.Enabled = true;
        }

        private void dtgDSHDX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is not a header and row index is valid
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dtgDSHDX.Rows[e.RowIndex];

                // Điền vào các hộp văn bản hoặc các điều khiển khác với dữ liệu từ hàng đã chọn
                txtMaHDX.Text = selectedRow.Cells["MaHoaDonXuat"].Value.ToString();
                dtpNX.Text = selectedRow.Cells["NgayXuat"].Value.ToString();
                cbbPTTT.Text = selectedRow.Cells["PhuongThucThanhToan"].Value.ToString();
                txtTTH.Text = selectedRow.Cells["TongTienHang"].Value.ToString();

                // Lấy mã khách hàng từ DataGridView
                string maKhachHang = selectedRow.Cells["MaKhachHang"].Value.ToString();
                // Thực hiện truy vấn để lấy tên khách hàng dựa trên mã khách hàng
                string tenKhachHang = bll.LayTenKhachHangTheoMa(maKhachHang);
                // Đặt giá trị cho ComboBox
                cbbTenKH.Text = tenKhachHang;

                // Lấy mã nhân viên từ DataGridView
                string maNhanVien = selectedRow.Cells["MaNhanVienLapHoaDon"].Value.ToString();
                // Thực hiện truy vấn để lấy tên nhân viên dựa trên mã nhân viên
                string tenNhanVien = bll.LayTenNhanVienTheoMa(maNhanVien);
                // Đặt giá trị cho ComboBox
                cbbTenNV.Text = tenNhanVien;
            }
        }

        private void btTKHDX_Click(object sender, EventArgs e)
        {
            // Lấy tên sản phẩm từ ComboBox
            string maHoaDon = cbbMaHDX.Text;

            // Gọi phương thức LayDanhSachSanPhamTheoTen để lấy danh sách sản phẩm tương ứng với tên sản phẩm
            DataTable dataTable = bll.LayDanhSachHoaDonXuatTheoMa(maHoaDon);

            // Clear DataGridView trước khi load dữ liệu mới
            dtgDSHDX.Rows.Clear();

            // Load data from DataTable to DataGridView
            foreach (DataRow row in dataTable.Rows)
            {
                // Thêm dòng mới vào DataGridView và điền dữ liệu
                dtgDSHDX.Rows.Add(row.ItemArray);
            }
        }

        private void txtMaHDX_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chuyển ký tự nhập vào thành chữ hoa nếu là chữ cái
            if (char.IsLetter(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }
    }
}
