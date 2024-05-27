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
    public partial class TimKiemSanPhamGUI : Form
    {
        //[1].kết nối 
        private SanPhamBLL bll = new SanPhamBLL();
        public TimKiemSanPhamGUI()
        {
            InitializeComponent();

            //[4] load dssp
            LoadDSSP();

            //[5] load sp
            LoadSP();
        }
        private void TimKiemSanPhamGUI_Load(object sender, EventArgs e)
        {
            dtgDSSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadDSSP()
        {
            // Xóa tất cả các cột hiện có trong DataGridView
            dtgDSSP.Columns.Clear();

            // Thêm các cột mới với tên tiếng Việt tương ứng
            dtgDSSP.Columns.Add("MaSanPham", "Mã sản phẩm");
            dtgDSSP.Columns.Add("TenSanPham", "Tên sản phẩm");
            dtgDSSP.Columns.Add("MaLoai", "Mã loại");
            dtgDSSP.Columns.Add("MoTa", "Mô tả");
            dtgDSSP.Columns.Add("GiaBan", "Giá bán");
            dtgDSSP.Columns.Add("SoLuongTon", "Số lượng tồn");
            dtgDSSP.Columns.Add("NhaSanXuat", "Nhà sản xuất");

            // Định dạng cột "GiaBan"
            dtgDSSP.Columns["GiaBan"].DefaultCellStyle.Format = "#,###";
            dtgDSSP.Columns["SoLuongTon"].DefaultCellStyle.Format = "#,###";

            // Load data from DataTable to DataGridView
            DataTable dataTable = bll.LayDanhSachSanPham();
            foreach (DataRow row in dataTable.Rows)
            {
                // Thêm dòng mới vào DataGridView và điền dữ liệu
                dtgDSSP.Rows.Add(row.ItemArray);
            }
        }
        private void LoadSP()
        {
            // Xóa tất cả các mục trong ComboBox trước khi thêm mới
            cbbTKSP.Items.Clear();

            // Lấy danh sách tên loại từ cơ sở dữ liệu, bạn có thể sử dụng một hàm trong BUS hoặc DAL để thực hiện việc này
            DataTable dataTable = bll.LayDanhSachSanPham(); // Giả sử hàm LayDanhSachTenLoai trả về DataTable chứa danh sách tên loại

            // Thêm danh sách tên loại vào ComboBox
            foreach (DataRow row in dataTable.Rows)
            {
                // Lấy giá trị của cột "TenLoai" từ mỗi dòng và thêm vào ComboBox
                cbbTKSP.Items.Add(row["TenSanPham"].ToString());
            }
            cbbTKSP.SelectedIndex = 0; // Chọn mục đầu tiên làm mục mặc định

        }

        private void btTK_Click(object sender, EventArgs e)
        {
            // Lấy tên sản phẩm từ ComboBox
            string tenSanPham = cbbTKSP.Text;

            // Gọi phương thức LayDanhSachSanPhamTheoTen để lấy danh sách sản phẩm tương ứng với tên sản phẩm
            DataTable dataTable = bll.LayDanhSachSanPhamTheoTen(tenSanPham);

            // Clear DataGridView trước khi load dữ liệu mới
            dtgDSSP.Rows.Clear();

            // Load data from DataTable to DataGridView
            foreach (DataRow row in dataTable.Rows)
            {
                // Thêm dòng mới vào DataGridView và điền dữ liệu
                dtgDSSP.Rows.Add(row.ItemArray);
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
            LoadDSSP();
            LoadSP();
        }
    }
}
