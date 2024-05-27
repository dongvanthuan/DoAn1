using BLL;
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
    public partial class TimKiemNhanVienGUI : Form
    {
        //[1].kết nối 
        private NhanVienBLL bll = new NhanVienBLL();
        public TimKiemNhanVienGUI()
        {
            InitializeComponent();

            //[5].load dsnv
            LoadDSNV();

            //[7].load nv
            LoadNV();
        }

        private void TimKiemNhanVienGUI_Load(object sender, EventArgs e)
        {
            dtgDSNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
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

        private void btTK_Click(object sender, EventArgs e)
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
            LoadNV();
        }
    }
}
