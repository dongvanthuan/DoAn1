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
    public partial class HoaDonNhapGUI : Form
    {
        //[1].kết nối 
        private HoaDonNhapBLL bll = new HoaDonNhapBLL();
        public HoaDonNhapGUI()
        {
            InitializeComponent();

            //[4] load dshdn
            LoadDSHDN();

            //[5].load nv
            LoadNV();

            //[6].load ncc
            LoadNCC();

            //[7] load mhd
            LoadHDN();
        }

        private void HoaDonNhapGUI_Load(object sender, EventArgs e)
        {
            dtgDSHDN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cbbPTTT.SelectedIndex = 0; // Chọn mục đầu tiên làm mục mặc định
        }

        //[4].
        private void LoadDSHDN()
        {
            // Xóa tất cả các cột hiện có trong DataGridView
            dtgDSHDN.Columns.Clear();

            // Thêm các cột mới với tên tiếng Việt tương ứng
            dtgDSHDN.Columns.Add("MaHoaDonNhap", "Mã hóa đơn nhập");
            dtgDSHDN.Columns.Add("NgayNhap", "Ngày nhập");
            dtgDSHDN.Columns.Add("PhuongThucThanhToan", "Phương thức thanh toán");
            dtgDSHDN.Columns.Add("MaNhaCungCap", "Mã nhà cung cấp");
            dtgDSHDN.Columns.Add("MaNhanVienLapHoaDon", "Mã nhân viên lập hóa đơn");
            dtgDSHDN.Columns.Add("TongTienHang", "Tổng tiền hàng");

            // Định dạng cột "TongTienHang"
            dtgDSHDN.Columns["TongTienHang"].DefaultCellStyle.Format = "#,###";

            // Load data from DataTable to DataGridView
            DataTable dataTable = bll.LayDanhSachHoaDonNhap();
            foreach (DataRow row in dataTable.Rows)
            {
                // Thêm dòng mới vào DataGridView và điền dữ liệu
                dtgDSHDN.Rows.Add(row.ItemArray);
            }
        }
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
        //[6].
        private void LoadNCC()
        {
            // Xóa tất cả các mục trong ComboBox trước khi thêm mới
            cbbTenNCC.Items.Clear();

            // Lấy danh sách tên loại từ cơ sở dữ liệu, bạn có thể sử dụng một hàm trong BUS hoặc DAL để thực hiện việc này
            DataTable dataTable = bll.LayDanhSachNhaCungCap(); // Giả sử hàm LayDanhSachTenLoai trả về DataTable chứa danh sách tên loại

            // Thêm danh sách tên loại vào ComboBox
            foreach (DataRow row in dataTable.Rows)
            {
                // Lấy giá trị của cột "TenLoai" từ mỗi dòng và thêm vào ComboBox
                cbbTenNCC.Items.Add(row["TenNhaCungCap"].ToString());
            }
            cbbTenNCC.SelectedIndex = 0; // Chọn mục đầu tiên làm mục mặc định

        }
        //[7].
        private void LoadHDN()
        {
            // Xóa tất cả các mục trong ComboBox trước khi thêm mới
            cbbTHDN.Items.Clear();

            // Lấy danh sách tên loại từ cơ sở dữ liệu, bạn có thể sử dụng một hàm trong BUS hoặc DAL để thực hiện việc này
            DataTable dataTable = bll.LayDanhSachHoaDonNhap(); // Giả sử hàm LayDanhSachTenLoai trả về DataTable chứa danh sách tên loại

            // Thêm danh sách tên loại vào ComboBox
            foreach (DataRow row in dataTable.Rows)
            {
                // Lấy giá trị của cột "TenLoai" từ mỗi dòng và thêm vào ComboBox
                cbbTHDN.Items.Add(row["MaHoaDonNhap"].ToString());
            }
            cbbTHDN.SelectedIndex = 0; // Chọn mục đầu tiên làm mục mặc định

        }
        // KIỂM TRA SỰ ĐĂNG KÝ CỦA SỰ KIỆN
        //protected virtual void OnClicked(string formName)
        //{
        // Kiểm tra xem sự kiện đã được đăng ký hay không và gửi tham số formName cùng với sự kiện
        //ButtonClicked?.Invoke(this, formName);
        //}

        //[3]. Chuyển form CTHDN
        //private void btTHD_Click(object sender, EventArgs e)
        //{
        // Khi button được nhấn, kích hoạt sự kiện Clicked với tham số "CTHDN"
        //OnClicked("CTHDN");
        //}

        private void btLM_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Text = "";
                }
            }
            LoadDSHDN();
            LoadHDN();
            LoadNV();
            LoadNCC();
            txtMaHDN.Enabled = true;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            HoaDonNhapDTO hoaDonNhap = new HoaDonNhapDTO();
            hoaDonNhap.MaHoaDonNhap = txtMaHDN.Text;
            hoaDonNhap.NgayNhap = dtpNN.Text;
            hoaDonNhap.PhuongThucThanhToan = cbbPTTT.Text;
            // Lấy mã loại sản phẩm từ DataGridView
            string tenNhaCungCap = cbbTenNCC.Text;
            // Thực hiện truy vấn để lấy tên loại sản phẩm dựa trên mã loại
            string maNhaCungCap = bll.LayMaNhaCungcapTheoTen(tenNhaCungCap);
            // Đặt giá trị cho ComboBox
            hoaDonNhap.MaNhaCungCap = maNhaCungCap;
            hoaDonNhap.MaNhanVienLapHoaDon = cbbTenNV.Text;
            // Lấy mã loại sản phẩm từ DataGridView
            string TenNhanVien = cbbTenNV.Text;
            // Thực hiện truy vấn để lấy tên loại sản phẩm dựa trên mã loại
            string maNhanVien = bll.LayMaNhanVienTheoTen(TenNhanVien);
            // Đặt giá trị cho ComboBox
            hoaDonNhap.MaNhanVienLapHoaDon = maNhanVien;
            hoaDonNhap.TongTienHang = int.Parse(txtTTH.Text);
            var result = MessageBox.Show("Bạn có muốn lưu thông tin này không.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                bll.ThemHoaDonNhap(hoaDonNhap);
                MessageBox.Show("Đã lưu hóa đơn nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSHDN();
                // Load lại sản phẩm sau khi thêm hóa đơn nhập
                LoadNV();
                LoadNCC();
                LoadHDN();
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {

            HoaDonNhapDTO hoaDonNhap = new HoaDonNhapDTO();
            hoaDonNhap.MaHoaDonNhap = txtMaHDN.Text;
            hoaDonNhap.NgayNhap = dtpNN.Text;
            hoaDonNhap.PhuongThucThanhToan = cbbPTTT.Text;
            // Lấy mã loại sản phẩm từ DataGridView
            string tenNhaCungCap = cbbTenNCC.Text;
            // Thực hiện truy vấn để lấy tên loại sản phẩm dựa trên mã loại
            string maNhaCungCap = bll.LayMaNhaCungcapTheoTen(tenNhaCungCap);
            // Đặt giá trị cho ComboBox
            hoaDonNhap.MaNhaCungCap = maNhaCungCap;
            hoaDonNhap.MaNhanVienLapHoaDon = cbbTenNV.Text;
            // Lấy mã loại sản phẩm từ DataGridView
            string TenNhanVien = cbbTenNV.Text;
            // Thực hiện truy vấn để lấy tên loại sản phẩm dựa trên mã loại
            string maNhanVien = bll.LayMaNhanVienTheoTen(TenNhanVien);
            // Đặt giá trị cho ComboBox
            hoaDonNhap.MaNhanVienLapHoaDon = maNhanVien;
            hoaDonNhap.TongTienHang = int.Parse(txtTTH.Text);

            var result = MessageBox.Show("Bạn có muốn sửa thông tin này không.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                bll.SuaHoaDonNhap(hoaDonNhap);
                MessageBox.Show("Đã sửa hóa đơn nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSHDN();
                // Load lại sản phẩm sau khi thêm hóa đơn nhập
                LoadNV();
                LoadNCC();
                LoadHDN();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string maHoaDon = txtMaHDN.Text;
            var result = MessageBox.Show("Bạn có muốn xóa thông tin này không.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                bll.XoaHoaDonNhap(maHoaDon);
                MessageBox.Show("Đã xóa hóa đơn nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSHDN();
                LoadHDN();
                LoadNV();
                LoadNCC();
            }
        }

        private void dtgDSHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is not a header and row index is valid
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dtgDSHDN.Rows[e.RowIndex];

                // Điền vào các hộp văn bản hoặc các điều khiển khác với dữ liệu từ hàng đã chọn
                txtMaHDN.Text = selectedRow.Cells["MaHoaDonNhap"].Value.ToString();
                dtpNN.Text = selectedRow.Cells["NgayNhap"].Value.ToString();
                cbbPTTT.Text = selectedRow.Cells["PhuongThucThanhToan"].Value.ToString();
                cbbTenNCC.Text = selectedRow.Cells["MaNhaCungCap"].Value.ToString();
                txtTTH.Text = selectedRow.Cells["TongTienHang"].Value.ToString();
                // Lấy mã loại sản phẩm từ DataGridView
                string maNhanVien = selectedRow.Cells["MaNhanVienLapHoaDon"].Value.ToString();
                // Thực hiện truy vấn để lấy tên loại sản phẩm dựa trên mã loại
                string tenNhanVien = bll.LayTenNhanVienTheoMa(maNhanVien);
                // Đặt giá trị cho ComboBox
                cbbTenNV.Text = tenNhanVien;
                string maNhaCungCap = selectedRow.Cells["MaNhaCungCap"].Value.ToString();
                // Thực hiện truy vấn để lấy tên loại sản phẩm dựa trên mã loại
                string tenNhaCungCap = bll.LayTenNhaCungCapTheoMa(maNhaCungCap);
                // Đặt giá trị cho ComboBox
                cbbTenNCC.Text = tenNhaCungCap;
            }
        }

        private void btTKHDN_Click(object sender, EventArgs e)
        {
            // Lấy tên sản phẩm từ ComboBox
            string maHoaDon = cbbTHDN.Text;

            // Gọi phương thức LayDanhSachSanPhamTheoTen để lấy danh sách sản phẩm tương ứng với tên sản phẩm
            DataTable dataTable = bll.LayDanhSachHoaDonNhapTheoMa(maHoaDon);

            // Clear DataGridView trước khi load dữ liệu mới
            dtgDSHDN.Rows.Clear();

            // Load data from DataTable to DataGridView
            foreach (DataRow row in dataTable.Rows)
            {
                // Thêm dòng mới vào DataGridView và điền dữ liệu
                dtgDSHDN.Rows.Add(row.ItemArray);
            }
        }
    }
}
