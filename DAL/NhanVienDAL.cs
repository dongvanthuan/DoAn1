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
    public class NhanVienDAL
    {
        private string connectionString = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=Do_An1_l1;Integrated Security=True";

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

        // Phương thức lấy danh sách sản phẩm theo tên sản phẩm
        public DataTable LayDanhSachNhanVienTheoTen(string tenNhanVien)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM tbl_NhanVien WHERE TenNhanVien LIKE @TenNhanVien";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@TenNhanVien", "%" + tenNhanVien + "%");
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable LayDanhSachPhongBan()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM tbl_phongban";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        public void ThemNhanVien(string maNhanVien, string tenNhanVien, string ngaySinh, string gioiTinh, string diaChi, string soDienThoai, string email, string maPhongBan, string tinhTrangLamViec)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO tbl_NhanVien VALUES(@MaNhanVien, @TenNhanVien, @NgaySinh, @GioiTinh, @DiaChi, @SoDienThoai, @Email, @MaPhongBan, @TinhTrangLamViec)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                cmd.Parameters.AddWithValue("@TenNhanVien", tenNhanVien);
                cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@MaPhongBan", maPhongBan);
                cmd.Parameters.AddWithValue("@TinhTrangLamViec", tinhTrangLamViec);
                cmd.ExecuteNonQuery();
            }
        }

        public void SuaNhanVien(string maNhanVien, string tenNhanVien, string ngaySinh, string gioiTinh, string diaChi, string soDienThoai, string email, string maPhongBan, string tinhTrangLamViec)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "UPDATE tbl_NhanVien SET TenNhanVien = @TenNhanVien, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai, Email = @Email, MaPhongBan = @MaPhongBan, TinhTrangLamViec = @TinhTrangLamViec WHERE MaNhanVien = @MaNhanVien";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                cmd.Parameters.AddWithValue("@TenNhanVien", tenNhanVien);
                cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@MaPhongBan", maPhongBan);
                cmd.Parameters.AddWithValue("@TinhTrangLamViec", tinhTrangLamViec);
                cmd.ExecuteNonQuery();
            }
        }

        public void XoaNhanVien(string maNhanVien)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "DELETE FROM tbl_NhanVien WHERE MaNhanVien = @MaNhanVien";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
