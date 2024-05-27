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
    public class SanPhamDAL
    {
        private string connectionString = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=Do_An1_l1;Integrated Security=True";
        public DataTable LayDanhSachSanPham()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM tbl_SanPham";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        // Phương thức lấy danh sách sản phẩm theo tên sản phẩm
        public DataTable LayDanhSachSanPhamTheoTen(string tenSanPham)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM tbl_SanPham WHERE TenSanPham LIKE @TenSanPham";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@TenSanPham", "%" + tenSanPham + "%");
                da.Fill(dt);
            }
            return dt;
        }
        public DataTable LayDanhSachLoaiSanPham()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM tbl_LoaiSP";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }
        public void ThemSanPham(string maSanPham, string tenSanPham, string maLoai, string moTa, int giaBan, int soLuongTon, string nhaSanXuat)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO tbl_SanPham VALUES(@MaSanPham, @TenSanPham, @MaLoai, @MoTa, @GiaBan, @SoLuongTon, @NhaSanXuat)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MaSanPham", maSanPham);
                cmd.Parameters.AddWithValue("@TenSanPham", tenSanPham);
                cmd.Parameters.AddWithValue("@MaLoai", maLoai);
                cmd.Parameters.AddWithValue("@MoTa", moTa);
                cmd.Parameters.AddWithValue("@GiaBan", giaBan);
                cmd.Parameters.AddWithValue("@SoLuongTon", soLuongTon);
                cmd.Parameters.AddWithValue("@NhaSanXuat", nhaSanXuat);
                cmd.ExecuteNonQuery();
            }
        }
        public void SuaSanPham(string maSanPham, string tenSanPham, string maLoai, string moTa, int giaBan, int soLuongTon, string nhaSanXuat)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "UPDATE tbl_SanPham SET TenSanPham = @TenSanPham, MaLoai = @MaLoai, MoTa = @MoTa, GiaBan = @GiaBan, SoLuongTon = @SoLuongTon, NhaSanXuat = @NhaSanXuat WHERE MaSanPham = @MaSanPham";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MaSanPham", maSanPham);
                cmd.Parameters.AddWithValue("@TenSanPham", tenSanPham);
                cmd.Parameters.AddWithValue("@MaLoai", maLoai);
                cmd.Parameters.AddWithValue("@MoTa", moTa);
                cmd.Parameters.AddWithValue("@GiaBan", giaBan);
                cmd.Parameters.AddWithValue("@SoLuongTon", soLuongTon);
                cmd.Parameters.AddWithValue("@NhaSanXuat", nhaSanXuat);
                cmd.ExecuteNonQuery();
            }
        }
        public void XoaSanPham(string maSanPham)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "DELETE FROM tbl_SanPham WHERE MaSanPham = @MaSanPham";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MaSanPham", maSanPham);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
