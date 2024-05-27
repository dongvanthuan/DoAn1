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
    public partial class TimKiemKhachHangGUI : Form
    {
        private KhachHangBLL bll = new KhachHangBLL();

        public TimKiemKhachHangGUI()
        {
            InitializeComponent();


            //[6].load dskh
            LoadDSKH();

            //[7].load Kh
            LoadKH();

        }

        private void TimKiemKhachHangGUI_Load(object sender, EventArgs e)
        {
            dtgDSKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
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
            DataTable dataTable = bll.LayDanhSachKhachHang(); // Giả sử bus.LayDanhSachKhachHang() là phương thức để lấy dữ liệu từ bảng tbl_KhachHang
            foreach (DataRow row in dataTable.Rows)
            {
                // Thêm dòng mới vào DataGridView và điền dữ liệu
                dtgDSKH.Rows.Add(row.ItemArray);
            }
        }
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


        private void btTK_Click(object sender, EventArgs e)
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
            LoadKH();
        }
    }
}
