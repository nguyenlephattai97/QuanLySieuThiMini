using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public static class SanPhamDAO
    {
        public static List<SanPhamDTO> layDanhSachSP(int TThai)
        {

            List<SanPhamDTO> result = new List<SanPhamDTO>();
            OleDbConnection conn = DataProvider.getConnection();
            try
            {

                OleDbCommand cm = new OleDbCommand("SELECT  * FROM SanPham WHERE TThai=@tthai", conn);
                cm.Parameters.Add("@tthai", System.Data.OleDb.OleDbType.Integer).Value = TThai;
                OleDbDataReader dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        SanPhamDTO sp = new SanPhamDTO();
                        sp.Ma = dr.GetInt32(0);
                        sp.Ten = dr.GetString(1);
                        sp.Gia = dr.GetInt32(2);
                        sp.MoTa = dr.GetString(3);
                        sp.HSD = dr.GetDateTime(4).ToString();
                        sp.LoaiSP = dr.GetInt32(5);
                        sp.NCC = dr.GetInt32(6);
                        sp.Hinh = dr.GetString(7);
                        sp.TThai = dr.GetInt32(8);
                        result.Add(sp);
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
            return result;
        }

        public static int themSanPham(SanPhamDTO sp)
        {
            int result = -1;

            string sQuery = "INSERT INTO SanPham(Ten, Gia, Mota, HSD, LoaiSP, NCC, Hinh, TThai) VALUES (@ten, @gia, @mota, @hsd, @loaisp, @ncc, @hinh, @tthai)";
            OleDbParameter[] paras = new OleDbParameter[8];
            paras[0] = new OleDbParameter("@ten", sp.Ten);
            paras[1] = new OleDbParameter("@gia", sp.Gia);
            paras[2] = new OleDbParameter("@mota", sp.MoTa);
            paras[3] = new OleDbParameter("@hsd", sp.HSD);
            paras[4] = new OleDbParameter("@loaisp", sp.LoaiSP);
            paras[5] = new OleDbParameter("@ncc", sp.NCC);
            paras[6] = new OleDbParameter("@hinh", "0.jpg");
            paras[7] = new OleDbParameter("@tthai", sp.TThai);


            result = DataProvider.executeScalar(sQuery, paras);
            return result;
        }

        public static bool capNhatAnhSP(int id, string img)
        {
            string sQuery = "update SanPham set Hinh=@hinh where Ma=@id";
            OleDbParameter[] paras = new OleDbParameter[2];
            paras[0] = new OleDbParameter("@hinh", img);
            paras[1] = new OleDbParameter("@id", id);
           
            return DataProvider.executeNoneQuery(sQuery,paras);            
        }

        public static Boolean suaSanPham(SanPhamDTO sp)
        {
            string sQuery = "UPDATE SanPham SET Ten=@ten, Gia=@gia, MoTa=@mota, HSD=@hsd, LoaiSP=@loaisp, NCC=@ncc, Hinh=@hinh, TThai=@tthai WHERE Ma=@ma ";
            OleDbParameter[] paras = new OleDbParameter[9];
            paras[0] = new OleDbParameter("@ten", sp.Ten);
            paras[1] = new OleDbParameter("@gia", sp.Gia);
            paras[2] = new OleDbParameter("@mota", sp.MoTa);
            paras[3] = new OleDbParameter("@hsd", sp.HSD);
            paras[4] = new OleDbParameter("@loaisp", sp.LoaiSP);
            paras[5] = new OleDbParameter("@ncc", sp.NCC);
            paras[6] = new OleDbParameter("@hinh", sp.Hinh);
            paras[7] = new OleDbParameter("@tthai", sp.TThai);
            paras[8] = new OleDbParameter("@ma", sp.Ma);


            return DataProvider.executeNoneQuery(sQuery,paras);
        }

        public static List<SanPhamDTO> laySPTheoLoaiSP(int LoaiSP)
        {
            List<SanPhamDTO> result = new List<SanPhamDTO>();
            OleDbConnection conn = DataProvider.getConnection();
            try
            {

                OleDbCommand cm = new OleDbCommand("SELECT  * FROM SanPham WHERE LoaiSP=@loaisp and TThai=1", conn);
                cm.Parameters.Add("@loaisp", System.Data.OleDb.OleDbType.Integer).Value = LoaiSP;
                OleDbDataReader dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        SanPhamDTO sp = new SanPhamDTO();
                        sp.Ma = dr.GetInt32(0);
                        sp.Ten = dr.GetString(1);
                        sp.Gia = dr.GetInt32(2);
                        sp.MoTa = dr.GetString(3);
                        sp.HSD = dr.GetDateTime(4).ToString();
                        sp.LoaiSP = dr.GetInt32(5);
                        sp.NCC = dr.GetInt32(6);
                        sp.Hinh = dr.GetString(7);
                        sp.TThai = dr.GetInt32(8);
                        result.Add(sp);
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
            return result;
        }

        public static List<SanPhamDTO> timTheoTenVaLoaiSP(string Ten,int Loai, int TThai=1)
        {
            List<SanPhamDTO> result = new List<SanPhamDTO>();
            OleDbConnection conn = DataProvider.getConnection();
            try
            {
                string sQuery = "SELECT  * FROM SanPham WHERE TThai=@tthai ";
                string s = "";
                if (Loai > 0)
                {
                    s += " AND LoaiSP=@loai";
                    sQuery += s;
                }
                if (Ten != null)
                {
                    s += "AND Ten=@ten";
                }


                OleDbCommand cm = new OleDbCommand(sQuery, conn);
                cm.Parameters.Add("@tthai", System.Data.OleDb.OleDbType.Integer).Value = TThai;

                if (Loai > 0)
                {
                    cm.Parameters.Add("@loai", System.Data.OleDb.OleDbType.Integer).Value = Loai;
                }
                if (Ten != null)
                {
                    cm.Parameters.Add("@ten", System.Data.OleDb.OleDbType.Integer).Value = Ten;
                }

                OleDbDataReader dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        SanPhamDTO sp = new SanPhamDTO();
                        sp.Ma = dr.GetInt32(0);
                        sp.Ten = dr.GetString(1);
                        sp.Gia = dr.GetInt32(2);
                        sp.MoTa = dr.GetString(3);
                        sp.HSD = dr.GetDateTime(4).ToString();
                        sp.LoaiSP = dr.GetInt32(5);
                        sp.NCC = dr.GetInt32(6);
                        sp.Hinh = dr.GetString(7);
                        sp.TThai = dr.GetInt32(8);
                        result.Add(sp);
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

            return result;
        }

        public static List<SanPhamDTO> timTheoGiaSP(int giaTu, int giaDen, int Loai, int tthai=1)
        {
            List<SanPhamDTO> result = new List<SanPhamDTO>();
            OleDbConnection conn = DataProvider.getConnection();
            
            try
            {
                string sQuery = "SELECT  * FROM SanPham WHERE TThai=@tthai ";
                string s = "";
                if(Loai > 0)
                {
                    s += " AND LoaiSP=@loai";
                    sQuery += s;
                }

                if (giaTu > 0)
                {
                    s += " AND Gia>=@giatu";
                    sQuery += s;
                }

                if (giaDen > 0)
                {
                    s += " AND Gia<=@giaden";
                    sQuery += s;
                }

                OleDbCommand cm = new OleDbCommand(sQuery, conn);
                cm.Parameters.Add("@tthai", System.Data.OleDb.OleDbType.Integer).Value = tthai;

                if (Loai > 0)
                {
                    cm.Parameters.Add("@loai", System.Data.OleDb.OleDbType.Integer).Value = Loai;
                }
                if (giaTu > 0)
                {
                    cm.Parameters.Add("@giatu", System.Data.OleDb.OleDbType.Integer).Value = giaTu;
                }

                if (giaDen > 0)
                {
                    cm.Parameters.Add("@giaden", System.Data.OleDb.OleDbType.Integer).Value = giaDen;
                }

                OleDbDataReader dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        SanPhamDTO sp = new SanPhamDTO();
                        sp.Ma = dr.GetInt32(0);
                        sp.Ten = dr.GetString(1);
                        sp.Gia = dr.GetInt32(2);
                        sp.MoTa = dr.GetString(3);
                        sp.HSD = dr.GetDateTime(4).ToString();
                        sp.LoaiSP = dr.GetInt32(5);
                        sp.NCC = dr.GetInt32(6);
                        sp.Hinh = dr.GetString(7);
                        sp.TThai = dr.GetInt32(8);
                        result.Add(sp);
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

            return result;
        }
    }
}
