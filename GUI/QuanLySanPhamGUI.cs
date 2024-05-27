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
    public partial class QuanLySanPhamGUI : Form
    {
        //[1].kết nối 
        private SanPhamBLL bll = new SanPhamBLL();
        public QuanLySanPhamGUI()
        {
            InitializeComponent();

            //[4].load dssp
            LoadDSSP();

            //[5].load dslsp
            LoadLSP();

            //[6].load sp
            LoadSP();

        }

        private void QuanLySanPhamGUI_Load(object sender, EventArgs e)
        {
            dtgDSSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        //[4].
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
        //[5].
        private void LoadLSP()
        {
            // Xóa tất cả các mục trong ComboBox trước khi thêm mới
            cbbML.Items.Clear();

            // Lấy danh sách tên loại từ cơ sở dữ liệu, bạn có thể sử dụng một hàm trong BUS hoặc DAL để thực hiện việc này
            DataTable dataTable = bll.LayDanhSachLoaiSanPham(); // Giả sử hàm LayDanhSachTenLoai trả về DataTable chứa danh sách tên loại

            // Thêm danh sách tên loại vào ComboBox
            foreach (DataRow row in dataTable.Rows)
            {
                // Lấy giá trị của cột "TenLoai" từ mỗi dòng và thêm vào ComboBox
                cbbML.Items.Add(row["TenLoai"].ToString());
            }
            cbbML.SelectedIndex = 0; // Chọn mục đầu tiên làm mục mặc định

        }
        //[6].
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

        //[3].Thêm
        private void btThem_Click(object sender, EventArgs e)
        {
            SanPhamDTO sanPham = new SanPhamDTO();
            sanPham.MaSanPham = txtMaSP.Text;
            sanPham.TenSanPham = txtTenSP.Text;
            // Lấy mã loại sản phẩm từ DataGridView
            string tenLoai = cbbML.Text;
            // Thực hiện truy vấn để lấy tên loại sản phẩm dựa trên mã loại
            string MaLoai = bll.LayMaLoaiTheoTen(tenLoai);
            // Đặt giá trị cho ComboBox
            sanPham.MaLoai = MaLoai;
            sanPham.MoTa = txtMoTa.Text;
            sanPham.GiaBan = int.Parse(txtGiaBan.Text);
            sanPham.SoLuongTon = int.Parse(txtSoLuongTon.Text);
            sanPham.NhaSanXuat = txtNSX.Text;
            var result = MessageBox.Show("Bạn có muốn lưu thông tin này không.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                bll.ThemSanPham(sanPham);
                MessageBox.Show("Đã lưu sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSSP();
                LoadSP();
            }
        }

        //[3].Sửa
        private void btSua_Click(object sender, EventArgs e)
        {
            SanPhamDTO sanPham = new SanPhamDTO();
            sanPham.MaSanPham = txtMaSP.Text;
            sanPham.TenSanPham = txtTenSP.Text;
            // Lấy mã loại sản phẩm từ DataGridView
            string tenLoai = cbbML.Text;
            // Thực hiện truy vấn để lấy tên loại sản phẩm dựa trên mã loại
            string MaLoai = bll.LayMaLoaiTheoTen(tenLoai);
            // Đặt giá trị cho ComboBox
            sanPham.MaLoai = MaLoai;
            sanPham.MoTa = txtMoTa.Text;
            sanPham.GiaBan = int.Parse(txtGiaBan.Text);
            sanPham.SoLuongTon = int.Parse(txtSoLuongTon.Text);
            sanPham.NhaSanXuat = txtNSX.Text;
            var result = MessageBox.Show("Bạn có muốn sửa thông tin này không.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                bll.SuaSanPham(sanPham);
                MessageBox.Show("Đã sửa sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSSP();
                LoadSP();
            }
        }

        //[4].xóa
        private void btXoa_Click(object sender, EventArgs e)
        {
            string maSanPham = txtMaSP.Text;
            var result = MessageBox.Show("Bạn có muốn xóa thông tin này không.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                bll.XoaSanPham(maSanPham);
                MessageBox.Show("Đã xóa sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSSP();
                LoadSP();
            }
        }

        //[5].Làm mới 
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
            txtMaSP.Enabled = true;
            LoadLSP();
        }

        private void dtgDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is not a header and row index is valid
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dtgDSSP.Rows[e.RowIndex];

                // Điền vào các hộp văn bản hoặc các điều khiển khác với dữ liệu từ hàng đã chọn
                txtMaSP.Text = selectedRow.Cells["MaSanPham"].Value.ToString();
                txtTenSP.Text = selectedRow.Cells["TenSanPham"].Value.ToString();
                txtMoTa.Text = selectedRow.Cells["MoTa"].Value.ToString();
                txtGiaBan.Text = selectedRow.Cells["GiaBan"].Value.ToString();
                txtSoLuongTon.Text = selectedRow.Cells["SoLuongTon"].Value.ToString();
                txtNSX.Text = selectedRow.Cells["NhaSanXuat"].Value.ToString();
                txtMaSP.Enabled = false;
                // Lấy mã loại sản phẩm từ DataGridView
                string maLoai = selectedRow.Cells["MaLoai"].Value.ToString();

                // Thực hiện truy vấn để lấy tên loại sản phẩm dựa trên mã loại
                string tenLoai = bll.LayTenLoaiTheoMa(maLoai);

                // Đặt giá trị cho ComboBox
                cbbML.Text = tenLoai;
            }
        }

        private void btTKSP_Click(object sender, EventArgs e)
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

        private void txtMaSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chuyển ký tự nhập vào thành chữ hoa nếu là chữ cái
            if (char.IsLetter(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }
    } 
}
