using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SanPhamBLL
    {
        private SanPhamDAL sanPhamDAL = new SanPhamDAL();

        public DataTable LayDanhSachSanPham()
        {
            return sanPhamDAL.LayDanhSachSanPham();
        }

        // Phương thức lấy danh sách sản phẩm theo tên sản phẩm
        public DataTable LayDanhSachSanPhamTheoTen(string tenSanPham)
        {
            return sanPhamDAL.LayDanhSachSanPhamTheoTen(tenSanPham);
        }

        public DataTable LayDanhSachLoaiSanPham()
        {
            return sanPhamDAL.LayDanhSachLoaiSanPham();
        }

        public void ThemSanPham(SanPhamDTO sanPham)
        {
            sanPhamDAL.ThemSanPham(sanPham.MaSanPham, sanPham.TenSanPham, sanPham.MaLoai, sanPham.MoTa, sanPham.GiaBan, sanPham.SoLuongTon, sanPham.NhaSanXuat);
        }

        public void SuaSanPham(SanPhamDTO sanPham)
        {
            sanPhamDAL.SuaSanPham(sanPham.MaSanPham, sanPham.TenSanPham, sanPham.MaLoai, sanPham.MoTa, sanPham.GiaBan, sanPham.SoLuongTon, sanPham.NhaSanXuat);
        }

        public void XoaSanPham(string maSanPham)
        {
            sanPhamDAL.XoaSanPham(maSanPham);
        }

        public string LayTenLoaiTheoMa(string maLoai)
        {
            string tenLoai = ""; // Giá trị mặc định nếu không tìm thấy giá trị phù hợp

            // Lấy danh sách loại sản phẩm từ cơ sở dữ liệu
            DataTable dataTable = LayDanhSachLoaiSanPham();

            // Tìm tên loại tương ứng với mã loại được cung cấp
            DataRow[] rows = dataTable.Select("MaLoai = '" + maLoai + "'");
            if (rows.Length > 0)
            {
                tenLoai = rows[0]["TenLoai"].ToString();
            }

            return tenLoai;
        }
        public string LayMaLoaiTheoTen(string tenLoai)
        {
            string MaLoai = ""; // Giá trị mặc định nếu không tìm thấy giá trị phù hợp

            // Lấy danh sách loại sản phẩm từ cơ sở dữ liệu
            DataTable dataTable = LayDanhSachLoaiSanPham();

            // Tìm tên loại tương ứng với mã loại được cung cấp
            DataRow[] rows = dataTable.Select("TenLoai = '" + tenLoai + "'");
            if (rows.Length > 0)
            {
                MaLoai = rows[0]["MaLoai"].ToString();
            }

            return MaLoai;
        }
    }
}
