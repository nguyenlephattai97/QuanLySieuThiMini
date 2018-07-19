using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public static class DataProvider
    {
        public static OleDbConnection getConnection()
        {
            string sQuery = @"Provider=Microsoft.Jet.OleDb.4.0;Data Source=|DataDirectory|data\db.mdb";
            OleDbConnection conn = new OleDbConnection(sQuery);

            conn.Open();
            return conn;
        }

        public static bool executeNoneQuery(string query, OleDbParameter[] paras)
        {
            OleDbConnection conn = getConnection();
            OleDbCommand cm = new OleDbCommand(query, conn);
            for (int i = 0; i < paras.Length; i++)
            {
                cm.Parameters.Add(paras[i]);
            }

            bool result = cm.ExecuteNonQuery() > 0;
            conn.Close();
            return result;
        }

        public static int executeScalar(string sQuery, OleDbParameter[] paras)
        {
            OleDbConnection conn = getConnection();
            try
            {
                OleDbCommand cm = new OleDbCommand(sQuery, conn);
                for (int i = 0; i < paras.Length; i++)
                {
                    cm.Parameters.Add(paras[i]);
                }
                cm.ExecuteNonQuery();
                sQuery = "select @@Identity";
                cm = new OleDbCommand(sQuery, conn);
                int ID = (int)cm.ExecuteScalar();
                return ID;
            }
            catch
            {
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }

        public static int countDataQuery(string query, OleDbParameter[] paras)
        {
            OleDbConnection conn = getConnection();
            OleDbCommand cm = new OleDbCommand(query, conn);
            for (int i = 0; i < paras.Length; i++)
            {
                cm.Parameters.Add(paras[i]);
            }

            OleDbDataReader dr = cm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            int result = dt.Rows.Count;
            conn.Close();
            return result;
        }

        public static DataTable selectAll(string query, OleDbParameter[] paras)
        {
            OleDbConnection conn = getConnection();
            OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
            for (int i = 0; i < paras.Length; i++)
            {
                da.SelectCommand.Parameters.Add(paras[i]);
            }

            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

    }
}
