using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public static class SanPhamBUS
    {
        public static List<SanPhamDTO> layDanhSachSP(int TThai)
        {
            return SanPhamDAO.layDanhSachSP(TThai);
        }
        public static int themSanPham(SanPhamDTO sp)
        {
            return SanPhamDAO.themSanPham(sp);
        }
        public static bool capNhatAnhSP(int id, string img)
        {
            return SanPhamDAO.capNhatAnhSP(id, img);
        }
        public static Boolean suaSanPham(SanPhamDTO sp)
        {
            return SanPhamDAO.suaSanPham(sp);
        }
        public static List<SanPhamDTO> laySPTheoLoaiSP(int LoaiSP)
        {
            return SanPhamDAO.laySPTheoLoaiSP(LoaiSP);
        }
        //public static List<SanPhamDTO> timTheoTenVaLoaiSP(string Ten, int Loai)
        //{
        //    return SanPhamDAO.timTheoTenVaLoaiSP();
        //}

        public static List<SanPhamDTO> timTheoGiaSP(int giaTu, int giaDen, int Loai)
        {
            return SanPhamDAO.timTheoGiaSP(giaTu, giaDen, Loai);
        }
    }
}
