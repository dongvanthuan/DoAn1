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
    public class KhachHangDAL
    {
        private string connectionString = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=Do_An1_l1;Integrated Security=True";

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

        // Phương thức lấy danh sách sản phẩm theo tên sản phẩm
        public DataTable LayDanhSachKhachHangTheoTen(string tenKhachHang)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM tbl_KhachHang WHERE TenKhachHang LIKE @TenKhachHang";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@TenKhachHang", "%" + tenKhachHang + "%");
                da.Fill(dt);
            }
            return dt;
        }

        public void ThemKhachHang(string maKhachHang, string tenKhachHang, string gioiTinh, string ngaySinh, string diaChi, string soDienThoai, string email)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO tbl_KhachHang (MaKhachHang, TenKhachHang, GioiTinh, NgaySinh, DiaChi, SoDienThoai, Email) VALUES(@MaKhachHang, @TenKhachHang, @GioiTinh, @NgaySinh, @DiaChi, @SoDienThoai, @Email)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                cmd.Parameters.AddWithValue("@TenKhachHang", tenKhachHang);
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.ExecuteNonQuery();
            }
        }

        public void SuaKhachHang(string maKhachHang, string tenKhachHang, string gioiTinh, string ngaySinh, string diaChi, string soDienThoai, string email)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "UPDATE tbl_KhachHang SET TenKhachHang = @TenKhachHang, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai, Email = @Email WHERE MaKhachHang = @MaKhachHang";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                cmd.Parameters.AddWithValue("@TenKhachHang", tenKhachHang);
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.ExecuteNonQuery();
            }
        }

        public void XoaKhachHang(string maKhachHang)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "DELETE FROM tbl_KhachHang WHERE MaKhachHang = @MaKhachHang";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
