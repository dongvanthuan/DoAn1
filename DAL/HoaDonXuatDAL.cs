using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace DAL
{
    public class HoaDonXuatDAL
    {
        private string connectionString = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=Do_An1_l1;Integrated Security=True";

        public DataTable LayDanhSachHoaDonXuat()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM tbl_HoaDonXuat";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable LayDanhSachNhanVien()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM tbl_NhanVien";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable LayDanhSachKhachHang()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM tbl_KhachHang";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        // Phương thức lấy danh sách hóa đơn xuất theo mã hóa đơn xuất
        public DataTable LayDanhSachHoaDonXuatTheoMa(string maHoaDonXuat)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM tbl_HoaDonXuat WHERE MaHoaDonXuat LIKE @MaHoaDonXuat";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@MaHoaDonXuat", "%" + maHoaDonXuat + "%");
                da.Fill(dt);
            }
            return dt;
        }

        public void ThemHoaDonXuat(string maHoaDonXuat, string ngayXuat, string phuongThucThanhToan, string maKhachHang, string maNhanVienLapHoaDon, int tongTienHang)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO tbl_HoaDonXuat (MaHoaDonXuat, NgayXuat, PhuongThucThanhToan, MaKhachHang, MaNhanVienLapHoaDon, TongTienHang) VALUES(@MaHoaDonXuat, @NgayXuat, @PhuongThucThanhToan, @MaKhachHang, @MaNhanVienLapHoaDon, @TongTienHang)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MaHoaDonXuat", maHoaDonXuat);
                        cmd.Parameters.AddWithValue("@NgayXuat", ngayXuat);
                        cmd.Parameters.AddWithValue("@PhuongThucThanhToan", phuongThucThanhToan);
                        cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                        cmd.Parameters.AddWithValue("@MaNhanVienLapHoaDon", maNhanVienLapHoaDon);
                        cmd.Parameters.AddWithValue("@TongTienHang", tongTienHang);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log the error)
                throw new ApplicationException("An error occurred while adding an invoice.", ex);
            }
        }

        public void SuaHoaDonXuat(string maHoaDonXuat, string ngayXuat, string phuongThucThanhToan, string maKhachHang, string maNhanVienLapHoaDon, int tongTienHang)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "UPDATE tbl_HoaDonXuat SET NgayXuat = @NgayXuat, PhuongThucThanhToan = @PhuongThucThanhToan, MaKhachHang = @MaKhachHang, MaNhanVienLapHoaDon = @MaNhanVienLapHoaDon, TongTienHang = @TongTienHang WHERE MaHoaDonXuat = @MaHoaDonXuat";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MaHoaDonXuat", maHoaDonXuat);
                        cmd.Parameters.AddWithValue("@NgayXuat", ngayXuat);
                        cmd.Parameters.AddWithValue("@PhuongThucThanhToan", phuongThucThanhToan);
                        cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                        cmd.Parameters.AddWithValue("@MaNhanVienLapHoaDon", maNhanVienLapHoaDon);
                        cmd.Parameters.AddWithValue("@TongTienHang", tongTienHang);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log the error)
                throw new ApplicationException("An error occurred while updating an invoice.", ex);
            }
        }

        public void XoaHoaDonXuat(string maHoaDonXuat)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM tbl_HoaDonXuat WHERE MaHoaDonXuat = @MaHoaDonXuat";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MaHoaDonXuat", maHoaDonXuat);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log the error)
                throw new ApplicationException("An error occurred while deleting an invoice.", ex);
            }
        }
    }
}
