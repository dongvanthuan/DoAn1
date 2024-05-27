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
    public class NhaCungCapDAL
    {
        private string connectionString = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=Do_An1_l1;Integrated Security=True";

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
        public DataTable LayDanhSachNhaCungCapTheoTen(string tenNhaCungCap)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM tbl_NhaCungCap WHERE TenNhaCungCap LIKE @TenNhaCungCap";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@TenNhaCungCap", "%" + tenNhaCungCap + "%");
                da.Fill(dt);
            }
            return dt;
        }

        public void ThemNhaCungCap(string maNhaCungCap, string tenNhaCungCap, string tenNguoiDaiDien, string diaChi, string soDienThoai, string email, string hinhThucThanhToan)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO tbl_NhaCungCap VALUES(@MaNhaCungCap, @TenNhaCungCap, @TenNguoiDaiDien, @DiaChi, @SoDienThoai, @Email, @HinhThucThanhToan)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MaNhaCungCap", maNhaCungCap);
                cmd.Parameters.AddWithValue("@TenNhaCungCap", tenNhaCungCap);
                cmd.Parameters.AddWithValue("@TenNguoiDaiDien", tenNguoiDaiDien);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@HinhThucThanhToan", hinhThucThanhToan);
                cmd.ExecuteNonQuery();
            }
        }


        public void SuaNhaCungCap(string maNhaCungCap, string tenNhaCungCap, string tenNguoiDaiDien, string diaChi, string soDienThoai, string email, string hinhThucThanhToan)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "UPDATE tbl_NhaCungCap SET TenNhaCungCap = @TenNhaCungCap, TenNguoiDaiDien = @TenNguoiDaiDien, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai, Email = @Email, HinhThucThanhToan = @HinhThucThanhToan WHERE MaNhaCungCap = @MaNhaCungCap";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MaNhaCungCap", maNhaCungCap);
                cmd.Parameters.AddWithValue("@TenNhaCungCap", tenNhaCungCap);
                cmd.Parameters.AddWithValue("@TenNguoiDaiDien", tenNguoiDaiDien);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@HinhThucThanhToan", hinhThucThanhToan);
                cmd.ExecuteNonQuery();
            }
        }


        public void XoaNhaCungCap(string maNhaCungCap)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "DELETE FROM tbl_NhaCungCap WHERE MaNhaCungCap = @MaNhaCungCap";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MaNhaCungCap", maNhaCungCap);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
