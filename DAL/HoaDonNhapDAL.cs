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
    public class HoaDonNhapDAL
    {
        private string connectionString = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=Do_An1_l1;Integrated Security=True";

        public DataTable LayDanhSachHoaDonNhap()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM tbl_HoaDonNhap";
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

        public DataTable LayDanhSachNhaCungCap()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM tbl_NhaCungCap";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }
        // Phương thức lấy danh sách sản phẩm theo tên sản phẩm
        public DataTable LayDanhSachHoaDonNhapTheoMa(string maHoaDonNhap)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM tbl_HoaDonNhap WHERE MaHoaDonNhap LIKE @MaHoaDonNhap";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@MaHoaDonNhap", "%" + maHoaDonNhap + "%");
                da.Fill(dt);
            }
            return dt;
        }

        public void ThemHoaDonNhap(string maHoaDonNhap, string ngayNhap, string phuongThucThanhToan, string maNhaCungCap, string maNhanVienLapHoaDon, int tongTienHang)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO tbl_HoaDonNhap (MaHoaDonNhap, NgayNhap, PhuongThucThanhToan, MaNhaCungCap, MaNhanVienLapHoaDon, TongTienHang) VALUES(@MaHoaDonNhap, @NgayNhap, @PhuongThucThanhToan, @MaNhaCungCap, @MaNhanVienLapHoaDon, @TongTienHang)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MaHoaDonNhap", maHoaDonNhap);
                        cmd.Parameters.AddWithValue("@NgayNhap", ngayNhap);
                        cmd.Parameters.AddWithValue("@PhuongThucThanhToan", phuongThucThanhToan);
                        cmd.Parameters.AddWithValue("@MaNhaCungCap", maNhaCungCap);
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

        public void SuaHoaDonNhap(string maHoaDonNhap, string ngayNhap, string phuongThucThanhToan, string maNhaCungCap, string maNhanVienLapHoaDon, int tongTienHang)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "UPDATE tbl_HoaDonNhap SET NgayNhap = @NgayNhap, PhuongThucThanhToan = @PhuongThucThanhToan, MaNhaCungCap = @MaNhaCungCap, MaNhanVienLapHoaDon = @MaNhanVienLapHoaDon, TongTienHang = @TongTienHang WHERE MaHoaDonNhap = @MaHoaDonNhap";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MaHoaDonNhap", maHoaDonNhap);
                        cmd.Parameters.AddWithValue("@NgayNhap", ngayNhap);
                        cmd.Parameters.AddWithValue("@PhuongThucThanhToan", phuongThucThanhToan);
                        cmd.Parameters.AddWithValue("@MaNhaCungCap", maNhaCungCap);
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

        public void XoaHoaDonNhap(string maHoaDonNhap)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM tbl_HoaDonNhap WHERE MaHoaDonNhap = @MaHoaDonNhap";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MaHoaDonNhap", maHoaDonNhap);
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
