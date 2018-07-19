using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public static class LoaiSPBUS
    {
        public static List<LoaiSPDTO> layDanhSachLoaiSP(int TThai)
        {
            return LoaiSPDAO.layDanhSachLoaiSP(TThai);
        }
        public static bool themLoaiSP(LoaiSPDTO lsp)
        {
            return LoaiSPDAO.themLoaiSP(lsp);
        }
        public static bool suaLoaiSP(LoaiSPDTO lsp)
        {
            return LoaiSPDAO.suaLoaiSP(lsp);
        }
    }
}
