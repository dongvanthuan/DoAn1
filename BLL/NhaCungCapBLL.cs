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
    public class NhaCungCapBLL
    {
        private NhaCungCapDAL nhaCungCapDAL = new NhaCungCapDAL();

        public DataTable LayDanhSachNhaCungCap()
        {
            return nhaCungCapDAL.LayDanhSachNhaCungCap();
        }

        // Phương thức lấy danh sách sản phẩm theo tên sản phẩm
        public DataTable LayDanhSachNhaCungCapTheoTen(string tenNhaCungCap)
        {
            return nhaCungCapDAL.LayDanhSachNhaCungCapTheoTen(tenNhaCungCap);
        }

        public void ThemNhaCungCap(NhaCungCapDTO nhaCungCap)
        {
            nhaCungCapDAL.ThemNhaCungCap(nhaCungCap.MaNhaCungCap, nhaCungCap.TenNhaCungCap, nhaCungCap.TenNguoiDaiDien, nhaCungCap.DiaChi, nhaCungCap.SoDienThoai, nhaCungCap.Email, nhaCungCap.HinhThucThanhToan);
        }

        public void SuaNhaCungCap(NhaCungCapDTO nhaCungCap)
        {
            nhaCungCapDAL.SuaNhaCungCap(nhaCungCap.MaNhaCungCap, nhaCungCap.TenNhaCungCap, nhaCungCap.TenNguoiDaiDien, nhaCungCap.DiaChi, nhaCungCap.SoDienThoai, nhaCungCap.Email, nhaCungCap.HinhThucThanhToan);
        }

        public void XoaNhaCungCap(string maNhaCungCap)
        {
            nhaCungCapDAL.XoaNhaCungCap(maNhaCungCap);
        }
    }
}
