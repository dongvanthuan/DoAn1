using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string MaLoai { get; set; }
        public string MoTa { get; set; }
        public int GiaBan { get; set; }
        public int SoLuongTon { get; set; }
        public string NhaSanXuat { get; set; }
    }
}
