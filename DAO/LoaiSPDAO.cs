using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.OleDb;

namespace DAO
{
    public static class LoaiSPDAO
    {
        public static List<LoaiSPDTO> layDanhSachLoaiSP(int TThai)
        {
            List<LoaiSPDTO> KQ = new List<LoaiSPDTO>();
            OleDbConnection conn = DataProvider.getConnection();
            try
            {

                OleDbCommand cm = new OleDbCommand("SELECT  * FROM LoaiSP WHERE TThai=@tthai", conn);
                cm.Parameters.Add("@tthai", System.Data.OleDb.OleDbType.Integer).Value = TThai;
                OleDbDataReader dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        LoaiSPDTO lsp = new LoaiSPDTO();
                        lsp.Ma = dr.GetInt32(0);
                        lsp.Ten = dr.GetString(1);
                        lsp.TThai = dr.GetInt32(2);
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

        public static bool themLoaiSP(LoaiSPDTO lsp)
        {
           
            string sQuery = "INSERT INTO LoaiSP(Ten, TThai) VALUES (@ten, @tthai)";
            OleDbParameter[] paras = new OleDbParameter[2];
            paras[0] = new OleDbParameter("@ten", lsp.Ten);
            paras[1] = new OleDbParameter("@tthai", lsp.TThai);
            return DataProvider.executeNoneQuery(sQuery, paras);
            
        }

        public static bool suaLoaiSP(LoaiSPDTO lsp)
        {

            string sQuery = "UPDATE LoaiSP SET Ten=@ten, TThai=@tthai WHERE Ma=@ma";
            OleDbParameter[] paras = new OleDbParameter[3];
            paras[0] = new OleDbParameter("@ten", lsp.Ten);
            paras[1] = new OleDbParameter("@tthai", lsp.TThai);
            paras[2] = new OleDbParameter("@ma", lsp.Ma);

            return DataProvider.executeNoneQuery(sQuery, paras);
               

        }

    }
}
