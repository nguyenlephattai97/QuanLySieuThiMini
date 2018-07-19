using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using DTO;
using System.Data;

namespace DAO
{
    public static class NhanVienDAO
    {
        public static bool kiemTraDangNhap(string TenDN, string MatKhau)
        {
            string sQuery = "select * from NhanVien where TenDN=@tendn and MatKhau=@matkhau and TThai=1";
            OleDbParameter[] paras = new OleDbParameter[2];
            paras[0] = new OleDbParameter("@tendn", TenDN);
            paras[1] = new OleDbParameter("@matkhau", MatKhau);
            return (DataProvider.countDataQuery(sQuery, paras) > 0);

        }

        public static NhanVienDTO layThongTinNV(string TenDN)
        {
            NhanVienDTO nv = new NhanVienDTO();
            string sQuery = "select * from NhanVien where TenDN=@tendn";
            OleDbParameter[] paras = new OleDbParameter[1];
            paras[0] = new OleDbParameter("@tendn", TenDN);
            DataTable dt = DataProvider.selectAll(sQuery, paras);

            nv.Ma = Convert.ToInt32(dt.Rows[0]["Ma"]);
            nv.TenNV = dt.Rows[0]["TenNV"].ToString();
            nv.TenDN = dt.Rows[0]["TenDN"].ToString();

            return nv;
        }
    }
}
