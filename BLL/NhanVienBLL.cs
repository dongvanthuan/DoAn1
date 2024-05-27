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
    public class NhanVienBLL
    {
        private NhanVienDAL nhanVienDAL = new NhanVienDAL();

        public DataTable LayDanhSachNhanVien()
        {
            return nhanVienDAL.LayDanhSachNhanVien();
        }

        // Phương thức lấy danh sách sản phẩm theo tên sản phẩm
        public DataTable LayDanhSachNhanVienTheoTen(string tenNhanVien)
        {
            return nhanVienDAL.LayDanhSachNhanVienTheoTen(tenNhanVien);
        }

        public DataTable LayDanhSachPhongBan()
        {
            return nhanVienDAL.LayDanhSachPhongBan();
        }

        public void ThemNhanVien(NhanVienDTO nhanVien)
        {
            nhanVienDAL.ThemNhanVien(nhanVien.MaNhanVien, nhanVien.TenNhanVien, nhanVien.NgaySinh, nhanVien.GioiTinh, nhanVien.DiaChi, nhanVien.SoDienThoai, nhanVien.Email, nhanVien.MaPhongBan, nhanVien.TinhTrangLamViec);
        }

        public void SuaNhanVien(NhanVienDTO nhanVien)
        {
            nhanVienDAL.SuaNhanVien(nhanVien.MaNhanVien, nhanVien.TenNhanVien, nhanVien.NgaySinh, nhanVien.GioiTinh, nhanVien.DiaChi, nhanVien.SoDienThoai, nhanVien.Email, nhanVien.MaPhongBan, nhanVien.TinhTrangLamViec);
        }

        public void XoaNhanVien(string manhanVien)
        {
            nhanVienDAL.XoaNhanVien(manhanVien);
        }

        public string LayTenPhongBanTheoMa(string maPhongBan)
        {
            string tenPhongBan = ""; // Giá trị mặc định nếu không tìm thấy giá trị phù hợp

            // Lấy danh sách loại sản phẩm từ cơ sở dữ liệu
            DataTable dataTable = LayDanhSachPhongBan();

            // Tìm tên loại tương ứng với mã loại được cung cấp
            DataRow[] rows = dataTable.Select("MaPhongBan = '" + maPhongBan + "'");
            if (rows.Length > 0)
            {
                tenPhongBan = rows[0]["TenPhongBan"].ToString();
            }

            return tenPhongBan;
        }
        public string LayMaPhongBanTheoTen(string tenPhongBan)
        {
            string maPhongBan = ""; // Giá trị mặc định nếu không tìm thấy giá trị phù hợp

            // Lấy danh sách loại sản phẩm từ cơ sở dữ liệu
            DataTable dataTable = LayDanhSachPhongBan();

            // Tìm tên loại tương ứng với mã loại được cung cấp
            DataRow[] rows = dataTable.Select("TenPhongBan = '" + tenPhongBan + "'");
            if (rows.Length > 0)
            {
                maPhongBan = rows[0]["MaPhongBan"].ToString();
            }

            return maPhongBan;
        }
    }
}
