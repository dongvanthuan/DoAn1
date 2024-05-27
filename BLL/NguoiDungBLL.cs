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
    public class NguoiDungBLL
    {
        private NguoiDungDAL nguoiDungDAL = new NguoiDungDAL();

        public DataTable LayDanhSachNguoiDung()
        {
            return nguoiDungDAL.LayDanhSachNguoiDung();
        }

        // Phương thức lấy danh sách sản phẩm theo tên sản phẩm
        public DataTable LayDanhSachNguoiDungTheoTen(string hoTen)
        {
            return nguoiDungDAL.LayDanhSachNguoiDungTheoTen(hoTen);
        }

        public DataTable LayDanhSachLoaiNguoiDung()
        {
            return nguoiDungDAL.LayDanhSachLoaiNguoiDung();
        }

        public void ThemNguoiDung(NguoiDungDTO nguoiDung)
        {
            nguoiDungDAL.ThemNguoiDung(nguoiDung.TenDangNhap, nguoiDung.HoTen, nguoiDung.SDT, nguoiDung.NgaySinh, nguoiDung.DiaChi, nguoiDung.MatKhau, nguoiDung.GioiTinh, nguoiDung.Email, nguoiDung.MaLoaiND);
        }

        public void SuaNguoiDung(NguoiDungDTO nguoiDung)
        {
            nguoiDungDAL.SuaNguoiDung(nguoiDung.TenDangNhap, nguoiDung.HoTen, nguoiDung.SDT, nguoiDung.NgaySinh, nguoiDung.DiaChi, nguoiDung.MatKhau, nguoiDung.GioiTinh, nguoiDung.Email, nguoiDung.MaLoaiND);
        }


        public void XoaNguoiDung(string tenDangNhap)
        {
            nguoiDungDAL.XoaNguoiDung(tenDangNhap);
        }

        public string LayTenLoaiNguoiDungTheoMa(string maLoaiND)
        {
            string tenLoaiNguoiDung = ""; // Giá trị mặc định nếu không tìm thấy giá trị phù hợp

            // Lấy danh sách loại sản phẩm từ cơ sở dữ liệu
            DataTable dataTable = LayDanhSachLoaiNguoiDung();

            // Tìm tên loại tương ứng với mã loại được cung cấp
            DataRow[] rows = dataTable.Select("MaLoaiND = '" + maLoaiND + "'");
            if (rows.Length > 0)
            {
                tenLoaiNguoiDung = rows[0]["TenLoai"].ToString();
            }

            return tenLoaiNguoiDung;
        }
        public string LayMaLoaiNguoiDungTheoTen(string tenLoaiND)
        {
            string maLoaiND = ""; // Giá trị mặc định nếu không tìm thấy giá trị phù hợp

            // Lấy danh sách loại sản phẩm từ cơ sở dữ liệu
            DataTable dataTable = LayDanhSachLoaiNguoiDung();

            // Tìm tên loại tương ứng với mã loại được cung cấp
            DataRow[] rows = dataTable.Select("TenLoai = '" + tenLoaiND + "'");
            if (rows.Length > 0)
            {
                maLoaiND = rows[0]["MaLoaiND"].ToString();
            }

            return maLoaiND;
        }
    }
}
