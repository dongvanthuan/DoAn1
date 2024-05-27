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
    public partial class TimKiemNhaCungCapGUI : Form
    {
        private NhaCungCapBLL bll = new NhaCungCapBLL();
        public TimKiemNhaCungCapGUI()
        {
            InitializeComponent();

            //[6] load dsncc
            LoadDSNCC();

            //[7] load ncc
            LoadNCC();
        }

        private void TimKiemNhaCungCapGUI_Load(object sender, EventArgs e)
        {
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

        private void btTK_Click(object sender, EventArgs e)
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
            LoadNCC();
        }
    }
}
