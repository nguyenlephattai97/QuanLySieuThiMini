using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public static class NhanVienBUS
    {
        public static bool kiemTraDangNhap(string TenDN, string MatKhau)
        {
            return NhanVienDAO.kiemTraDangNhap(TenDN, MatKhau);
        }
        public static NhanVienDTO layThongTinNV(string TenDN)
        {
            return NhanVienDAO.layThongTinNV(TenDN);
        }
    }
}
