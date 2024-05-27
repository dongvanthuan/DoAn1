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
    public class HoaDonXuatBLL
    {
        private HoaDonXuatDAL hoaDonXuatDAL = new HoaDonXuatDAL();

        public DataTable LayDanhSachHoaDonXuat()
        {
            return hoaDonXuatDAL.LayDanhSachHoaDonXuat();
        }

        // Phương thức lấy danh sách hóa đơn xuất theo mã hóa đơn xuất
        public DataTable LayDanhSachHoaDonXuatTheoMa(string maHoaDon)
        {
            return hoaDonXuatDAL.LayDanhSachHoaDonXuatTheoMa(maHoaDon);
        }

        public DataTable LayDanhSachNhanVien()
        {
            return hoaDonXuatDAL.LayDanhSachNhanVien();
        }

        public DataTable LayDanhSachKhachHang()
        {
            return hoaDonXuatDAL.LayDanhSachKhachHang();
        }

        public void ThemHoaDonXuat(HoaDonXuatDTO hoaDonXuat)
        {
            hoaDonXuatDAL.ThemHoaDonXuat(hoaDonXuat.MaHoaDonXuat, hoaDonXuat.NgayXuat, hoaDonXuat.PhuongThucThanhToan, hoaDonXuat.MaKhachHang, hoaDonXuat.MaNhanVienLapHoaDon, hoaDonXuat.TongTienHang);
        }

        public void SuaHoaDonXuat(HoaDonXuatDTO hoaDonXuat)
        {
            hoaDonXuatDAL.SuaHoaDonXuat(hoaDonXuat.MaHoaDonXuat, hoaDonXuat.NgayXuat, hoaDonXuat.PhuongThucThanhToan, hoaDonXuat.MaKhachHang, hoaDonXuat.MaNhanVienLapHoaDon, hoaDonXuat.TongTienHang);
        }

        public void XoaHoaDonXuat(string maHoaDonXuat)
        {
            hoaDonXuatDAL.XoaHoaDonXuat(maHoaDonXuat);
        }

        public string LayTenNhanVienTheoMa(string maNhanVien)
        {
            string tenNhanVien = ""; // Giá trị mặc định nếu không tìm thấy giá trị phù hợp

            // Lấy danh sách loại sản phẩm từ cơ sở dữ liệu
            DataTable dataTable = LayDanhSachNhanVien();

            // Tìm tên loại tương ứng với mã loại được cung cấp
            DataRow[] rows = dataTable.Select("MaNhanVien = '" + maNhanVien + "'");
            if (rows.Length > 0)
            {
                tenNhanVien = rows[0]["TenNhanVien"].ToString();
            }

            return tenNhanVien;
        }

        public string LayMaNhanVienTheoTen(string tenNhanVien)
        {
            string maNhanVien = ""; // Giá trị mặc định nếu không tìm thấy giá trị phù hợp

            // Lấy danh sách loại sản phẩm từ cơ sở dữ liệu
            DataTable dataTable = LayDanhSachNhanVien();

            // Tìm tên loại tương ứng với mã loại được cung cấp
            DataRow[] rows = dataTable.Select("TenNhanVien = '" + tenNhanVien + "'");
            if (rows.Length > 0)
            {
                maNhanVien = rows[0]["MaNhanVien"].ToString();
            }

            return maNhanVien;
        }

        public string LayTenKhachHangTheoMa(string maKhachHang)
        {
            string tenKhachHang = ""; // Giá trị mặc định nếu không tìm thấy giá trị phù hợp

            // Lấy danh sách loại sản phẩm từ cơ sở dữ liệu
            DataTable dataTable = LayDanhSachKhachHang();

            // Tìm tên loại tương ứng với mã loại được cung cấp
            DataRow[] rows = dataTable.Select("MaKhachHang = '" + maKhachHang + "'");
            if (rows.Length > 0)
            {
                tenKhachHang = rows[0]["TenKhachHang"].ToString();
            }
            return tenKhachHang;
        }

        public string LayMaKhachHangTheoTen(string tenKhachHang)
        {
            string maKhachHang = ""; // Giá trị mặc định nếu không tìm thấy giá trị phù hợp

            // Lấy danh sách loại sản phẩm từ cơ sở dữ liệu
            DataTable dataTable = LayDanhSachKhachHang();

            // Tìm tên loại tương ứng với mã loại được cung cấp
            DataRow[] rows = dataTable.Select("TenKhachHang = '" + tenKhachHang + "'");
            if (rows.Length > 0)
            {
                maKhachHang = rows[0]["MaKhachHang"].ToString();
            }
            return maKhachHang;
        }
    }
}
