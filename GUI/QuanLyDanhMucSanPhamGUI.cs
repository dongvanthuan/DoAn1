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
    public partial class QuanLyDanhMucSanPhamGUI : Form
    {
        private DanhMucSanPhamBLL bll = new DanhMucSanPhamBLL();
        public QuanLyDanhMucSanPhamGUI()
        {
            InitializeComponent();

            //[6].load dslsp
            LoadDSLSP();

            //[7].load lsp
            LoadLSP();
        }

        private void QuanLyDanhMucSanPhamGUI_Load(object sender, EventArgs e)
        {
            dtgDSLSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadDSLSP()
        {
            // Xóa tất cả các cột hiện có trong DataGridView
            dtgDSLSP.Columns.Clear();
            // Thêm các cột mới với tên tiếng Việt tương ứng
            dtgDSLSP.Columns.Add("MaLoai", "Mã Loại");
            dtgDSLSP.Columns.Add("TenLoai", "Tên Loại");
            // Load data from DataTable to DataGridView
            DataTable dataTable = bll.LayDanhSachLoaiSanPham(); // Giả sử bus.LayDanhSachKhachHang() là phương thức để lấy dữ liệu từ bảng tbl_KhachHang
            foreach (DataRow row in dataTable.Rows)
            {
                // Thêm dòng mới vào DataGridView và điền dữ liệu
                dtgDSLSP.Rows.Add(row.ItemArray);
            }
        }
        private void LoadLSP()
        {
            // Xóa tất cả các mục trong ComboBox trước khi thêm mới
            cbbTKLSP.Items.Clear();

            // Lấy danh sách tên loại từ cơ sở dữ liệu, bạn có thể sử dụng một hàm trong BUS hoặc DAL để thực hiện việc này
            DataTable dataTable = bll.LayDanhSachLoaiSanPham(); // Giả sử hàm LayDanhSachTenLoai trả về DataTable chứa danh sách tên loại

            // Thêm danh sách tên loại vào ComboBox
            foreach (DataRow row in dataTable.Rows)
            {
                // Lấy giá trị của cột "TenLoai" từ mỗi dòng và thêm vào ComboBox
                cbbTKLSP.Items.Add(row["TenLoai"].ToString());
            }
            cbbTKLSP.SelectedIndex = 0; // Chọn mục đầu tiên làm mục mặc định

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
            LoadDSLSP();
            txtMaLoai.Enabled = true;
            LoadLSP();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            LoaiSanPhamDTO loaiSp = new LoaiSanPhamDTO();
            loaiSp.MaLoai = txtMaLoai.Text;
            loaiSp.TenLoai = txtTenLoai.Text;
            var result = MessageBox.Show("Bạn có muốn lưu thông tin này không.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                bll.ThemLoaiSP(loaiSp.MaLoai, loaiSp.TenLoai); // Pass both parameters to the method
                MessageBox.Show("Đã lưu thông tin loại sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSLSP();
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            LoaiSanPhamDTO loaiSp = new LoaiSanPhamDTO();
            loaiSp.MaLoai = txtMaLoai.Text;
            loaiSp.TenLoai = txtTenLoai.Text;
            var result = MessageBox.Show("Bạn có muốn sửa thông tin này không.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                bll.SuaLoaiSP(loaiSp.MaLoai, loaiSp.TenLoai); // Pass both parameters to the method
                MessageBox.Show("Đã sửa thông tin loại sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSLSP();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string maloai = txtMaLoai.Text;
            var result = MessageBox.Show("Bạn có muốn xóa thông tin này không.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                bll.XoaLoaiSanPham(maloai);
                MessageBox.Show("Đã xóa thông tin khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSLSP();
                LoadLSP();
                foreach (Control c in groupBox1.Controls)
                {
                    if (c is TextBox)
                    {
                        (c as TextBox).Text = "";
                    }
                }
                txtMaLoai.Enabled = true;
            }
        }

        private void btTKLSP_Click(object sender, EventArgs e)
        {
            // Lấy tên sản phẩm từ ComboBox
            string tenLoai = cbbTKLSP.Text;

            // Gọi phương thức LayDanhSachSanPhamTheoTen để lấy danh sách sản phẩm tương ứng với tên sản phẩm
            DataTable dataTable = bll.LayDanhSachLoaiSanPhamTheoTen(tenLoai);

            // Clear DataGridView trước khi load dữ liệu mới
            dtgDSLSP.Rows.Clear();

            // Load data from DataTable to DataGridView
            foreach (DataRow row in dataTable.Rows)
            {
                // Thêm dòng mới vào DataGridView và điền dữ liệu
                dtgDSLSP.Rows.Add(row.ItemArray);
            }
        }

        private void dtgDSLSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is not a header and row index is valid
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dtgDSLSP.Rows[e.RowIndex];
                // Fill the text boxes or other controls with data from the selected row
                txtMaLoai.Text = selectedRow.Cells["MaLoai"].Value.ToString();
                txtTenLoai.Text = selectedRow.Cells["TenLoai"].Value.ToString();
                txtMaLoai.Enabled = false;
            }
        }

        private void txtMaLoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chuyển ký tự nhập vào thành chữ hoa nếu là chữ cái
            if (char.IsLetter(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }
    }
}
