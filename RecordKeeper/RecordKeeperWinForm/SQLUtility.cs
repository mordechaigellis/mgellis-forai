using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordKeeperWinForm
{
    internal class SQLUtility
    {
        private static string GetConnectionString()
        {
            var s = "Server=.\\SQLExpress;Database=RecordKeeperDB;Trusted_Connection=true";

            return s;
        }

        internal static DataTable GetDataTable(string sqlstatement)  //- take a SQL statement and return a DataTable
        {
            DataTable dt = new();
            SqlConnection conn = new();
            conn.ConnectionString = GetConnectionString();
            conn.Open();

            var cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sqlstatement;
            var dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }
    }
}
