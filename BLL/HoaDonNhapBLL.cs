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
    public class HoaDonNhapBLL
    {
        private HoaDonNhapDAL hoaDonNhapDAL = new HoaDonNhapDAL();

        public DataTable LayDanhSachHoaDonNhap()
        {
            return hoaDonNhapDAL.LayDanhSachHoaDonNhap();
        }

        // Phương thức lấy danh sách sản phẩm theo tên sản phẩm
        public DataTable LayDanhSachHoaDonNhapTheoMa(string maHoaDon)
        {
            return hoaDonNhapDAL.LayDanhSachHoaDonNhapTheoMa(maHoaDon);
        }

        public DataTable LayDanhSachNhanVien()
        {
            return hoaDonNhapDAL.LayDanhSachNhanVien();
        }

        public DataTable LayDanhSachNhaCungCap()
        {
            return hoaDonNhapDAL.LayDanhSachNhaCungCap();
        }

        public void ThemHoaDonNhap(HoaDonNhapDTO hoaDonNhap)
        {
            hoaDonNhapDAL.ThemHoaDonNhap(hoaDonNhap.MaHoaDonNhap, hoaDonNhap.NgayNhap, hoaDonNhap.PhuongThucThanhToan, hoaDonNhap.MaNhaCungCap, hoaDonNhap.MaNhanVienLapHoaDon, hoaDonNhap.TongTienHang);
        }

        public void SuaHoaDonNhap(HoaDonNhapDTO hoaDonNhap)
        {
            hoaDonNhapDAL.SuaHoaDonNhap(hoaDonNhap.MaHoaDonNhap, hoaDonNhap.NgayNhap, hoaDonNhap.PhuongThucThanhToan, hoaDonNhap.MaNhaCungCap, hoaDonNhap.MaNhanVienLapHoaDon, hoaDonNhap.TongTienHang);
        }

        public void XoaHoaDonNhap(string maHoaDonNhap)
        {
            hoaDonNhapDAL.XoaHoaDonNhap(maHoaDonNhap);
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

        public string LayTenNhaCungCapTheoMa(string maNhaCungCap)
        {
            string tenNhaCungCap = ""; // Giá trị mặc định nếu không tìm thấy giá trị phù hợp

            // Lấy danh sách loại sản phẩm từ cơ sở dữ liệu
            DataTable dataTable = LayDanhSachNhaCungCap();

            // Tìm tên loại tương ứng với mã loại được cung cấp
            DataRow[] rows = dataTable.Select("MaNhaCungcap = '" + maNhaCungCap + "'");
            if (rows.Length > 0)
            {
                tenNhaCungCap = rows[0]["TenNhaCungcap"].ToString();
            }
            return tenNhaCungCap;
        }
        public string LayMaNhaCungcapTheoTen(string TenNhaCungCap)
        {
            string maNhaCungcap = ""; // Giá trị mặc định nếu không tìm thấy giá trị phù hợp

            // Lấy danh sách loại sản phẩm từ cơ sở dữ liệu
            DataTable dataTable = LayDanhSachNhaCungCap();

            // Tìm tên loại tương ứng với mã loại được cung cấp
            DataRow[] rows = dataTable.Select("TenNhaCungCap = '" + TenNhaCungCap + "'");
            if (rows.Length > 0)
            {
                maNhaCungcap = rows[0]["MaNhaCungCap"].ToString();
            }
            return maNhaCungcap;
        }
    }
}
