using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DanhMucSanPhamBLL
    {
        private DanhMucSanPhamDAL danhMucSanPhamDAL = new DanhMucSanPhamDAL();

        public DataTable LayDanhSachLoaiSanPham()
        {
            return danhMucSanPhamDAL.LayDanhSachLoaiSanPham();
        }

        // Phương thức lấy danh sách sản phẩm theo tên sản phẩm
        public DataTable LayDanhSachLoaiSanPhamTheoTen(string tenNhaCungCap)
        {
            return danhMucSanPhamDAL.LayDanhSachLoaiSanPhamTheoTen(tenNhaCungCap);
        }

        public void ThemLoaiSP(string maLoai, string tenLoai)
        {
            danhMucSanPhamDAL.ThemLoaiSP(maLoai, tenLoai);
        }

        public void SuaLoaiSP(string maLoai, string tenLoai)
        {
            danhMucSanPhamDAL.SuaLoaiSP(maLoai, tenLoai);
        }

        public void XoaLoaiSanPham(string maLoai)
        {
            danhMucSanPhamDAL.XoaLoaiSanPham(maLoai);
        }
    }
}
