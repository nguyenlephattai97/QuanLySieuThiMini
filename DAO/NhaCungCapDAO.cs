using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.OleDb;

namespace DAO
{
    public static class NhaCungCapDAO
    {
        public static List<NhaCungCapDTO> layDanhSachNCC(int TThai)
        {
            List<NhaCungCapDTO> KQ = new List<NhaCungCapDTO>();
            OleDbConnection conn = DataProvider.getConnection();
            try
            {

                OleDbCommand cm = new OleDbCommand("SELECT  * FROM NhaCungCap WHERE TThai=@tthai", conn);
                cm.Parameters.Add("@tthai", System.Data.OleDb.OleDbType.Integer).Value = TThai;
                OleDbDataReader dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        NhaCungCapDTO lsp = new NhaCungCapDTO();
                        lsp.Ma = dr.GetInt32(0);
                        lsp.TenNCC = dr.GetString(1);
                        lsp.DiaChi = dr.GetString(2);
                        lsp.DienThoai = dr.GetString(3);
                        KQ.Add(lsp);
                    }
                }
                dr.Close();
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return KQ;
        }

        public static bool themNCC(NhaCungCapDTO ncc)
        {
            
            string sQuery = "INSERT INTO NhaCungCap(TenNCC, DiaChi, DienThoai, TThai) VALUES (@ten, @diachi, @dienthoai, @tthai)";
            OleDbParameter[] paras = new OleDbParameter[4];
            paras[0] = new OleDbParameter("@ten", ncc.TenNCC);
            paras[1] = new OleDbParameter("@diachi", ncc.DiaChi);
            paras[2] = new OleDbParameter("@dienthoai", ncc.DienThoai);
            paras[3] = new OleDbParameter("@tthai", ncc.TThai);
            return DataProvider.executeNoneQuery(sQuery, paras);
        }
    }
}
