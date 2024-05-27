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
    public class NguoiDungDAL
    {
        private string connectionString = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=Do_An1_l1;Integrated Security=True";

        public DataTable LayDanhSachNguoiDung()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM tbl_NguoiDung";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        // Phương thức lấy danh sách sản phẩm theo tên sản phẩm
        public DataTable LayDanhSachNguoiDungTheoTen(string hoTen)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM tbl_NguoiDung WHERE HoTen LIKE @HoTen";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@HoTen", "%" + hoTen + "%");
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable LayDanhSachLoaiNguoiDung()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM tbl_LoaiND";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        public void ThemNguoiDung(string tenDangNhap, string hoTen, string sdt, string ngaySinh, string diaChi, string matKhau, string gioiTinh, string email, string maLoaiND)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO tbl_NguoiDung VALUES(@TenDangNhap, @HoTen, @SDT, @NgaySinh, @DiaChi, @MatKhau, @GioiTinh, @Email, @MaLoaiND)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                cmd.Parameters.AddWithValue("@HoTen", hoTen);
                cmd.Parameters.AddWithValue("@SDT", sdt);
                cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@MaLoaiND", maLoaiND);
                cmd.ExecuteNonQuery();
            }
        }


        public void SuaNguoiDung(string tenDangNhap, string hoTen, string sdt, string ngaySinh, string diaChi, string matKhau, string gioiTinh, string email, string maLoaiND)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "UPDATE tbl_NguoiDung SET HoTen = @HoTen, SDT = @SDT, NgaySinh = @NgaySinh, DiaChi = @DiaChi, MatKhau = @MatKhau, GioiTinh = @GioiTinh, Email = @Email, MaLoaiND = @MaLoaiND WHERE TenDangNhap = @TenDangNhap";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                cmd.Parameters.AddWithValue("@HoTen", hoTen);
                cmd.Parameters.AddWithValue("@SDT", sdt);
                cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau); // Ensure this is not null
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@MaLoaiND", maLoaiND);
                cmd.ExecuteNonQuery();
            }
        }

        public void XoaNguoiDung(string tenDangNhap)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "DELETE FROM tbl_NguoiDung WHERE TenDangNhap = @TenDangNhap";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
