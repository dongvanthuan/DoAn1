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
    public class DanhMucSanPhamDAL
    {
        private string connectionString = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=Do_An1_l1;Integrated Security=True";

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

        // Phương thức lấy danh sách sản phẩm theo tên sản phẩm
        public DataTable LayDanhSachLoaiSanPhamTheoTen(string tenLoai)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM tbl_LoaiSP WHERE TenLoai LIKE @TenLoai";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@TenLoai", "%" + tenLoai + "%");
                da.Fill(dt);
            }
            return dt;
        }

        public void ThemLoaiSP(string maLoai, string tenLoai)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO tbl_LoaiSP (MaLoai, TenLoai) VALUES (@MaLoai, @TenLoai)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MaLoai", maLoai);
                cmd.Parameters.AddWithValue("@TenLoai", tenLoai);
                cmd.ExecuteNonQuery();
            }
        }

        public void SuaLoaiSP(string maLoai, string tenLoai)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "UPDATE tbl_LoaiSP SET TenLoai = @TenLoai WHERE MaLoai = @MaLoai";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MaLoai", maLoai);
                cmd.Parameters.AddWithValue("@TenLoai", tenLoai);
                cmd.ExecuteNonQuery();
            }
        }


        public void XoaLoaiSanPham(string maLoai)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "DELETE FROM tbl_LoaiSP WHERE MaLoai = @MaLoai";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MaLoai", maLoai);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
