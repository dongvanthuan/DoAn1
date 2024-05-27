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
    public class KhachHangBLL
    {
        private KhachHangDAL khachHangDAL = new KhachHangDAL();

        public DataTable LayDanhSachKhachHang()
        {
            return khachHangDAL.LayDanhSachKhachHang();
        }

        // Phương thức lấy danh sách sản phẩm theo tên sản phẩm
        public DataTable LayDanhSachKhachHangTheoTen(string tenNhaCungCap)
        {
            return khachHangDAL.LayDanhSachKhachHangTheoTen(tenNhaCungCap);
        }

        public void ThemKhachHang(KhachHangDTO khachHang)
        {
            khachHangDAL.ThemKhachHang(khachHang.MaKhachHang, khachHang.TenKhachHang, khachHang.GioiTinh, khachHang.NgaySinh, khachHang.DiaChi, khachHang.SoDienThoai, khachHang.Email);
        }

        public void SuaKhachHang(KhachHangDTO khachHang)
        {
            khachHangDAL.SuaKhachHang(khachHang.MaKhachHang, khachHang.TenKhachHang, khachHang.GioiTinh, khachHang.NgaySinh, khachHang.DiaChi, khachHang.SoDienThoai, khachHang.Email);
        }

        public void XoaKhachHang(string maKhachHang)
        {
            khachHangDAL.XoaKhachHang(maKhachHang);
        }
    }
}
