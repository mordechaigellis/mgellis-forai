using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordKeeperSystem
{
    public class President
    {
        public static DataTable SearchPresidents(string lastname) {
            DataTable dt = new();

            SqlConnection conn = new SqlConnection(SQLUtility.ConnectionString);
            SqlCommand cmd = new SqlCommand("PresidentGet", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();
            SqlCommandBuilder.DeriveParameters(cmd);

            cmd.Parameters["@LastName"].Value = lastname;

            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }

        public static DataTable Load(int presidentid) {
            DataTable dt = new();

            SqlConnection conn = new SqlConnection(SQLUtility.ConnectionString);
            SqlCommand cmd = new SqlCommand("PresidentGet", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();
            SqlCommandBuilder.DeriveParameters(cmd);

            cmd.Parameters["@PresidentId"].Value = presidentid;

            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }

        public static DataTable GetPartyList() {
            DataTable dt = new();
            SqlConnection conn = new SqlConnection(SQLUtility.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PartyGet";

            conn.Open();
            SqlCommandBuilder.DeriveParameters(cmd);

            cmd.Parameters["@All"].Value = 1;

            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);

            return dt;
        }

        public static void Save(DataTable dtpresident)
        {
            SQLUtility.DebugPrintDataTable(dtpresident);
            DataRow r = dtpresident.Rows[0];
            int id = (int)r["PresidentId"];
            string sql = "";

            if (id > 0)
            {
                sql = string.Join(Environment.NewLine, $"update president set",
                    $"PartyId = '{r["PartyId"]}',",
                    $"Num = '{r["Num"]}',",
                    $"FirstName = '{r["FirstName"]}',",
                    $"LastName = '{r["LastName"]}',",
                    $"DateBorn = '{r["DateBorn"]}',",
                    $"TermStart = '{r["TermStart"]}'",
                    $"where PresidentId = {r["PresidentId"]}");
            }
            else
            {
                sql = "insert president(PartyId, Num, FirstName, LastName, DateBorn, TermStart) ";
                sql += $"select '{r["PartyId"]}', {r["Num"]}, '{r["FirstName"]}', '{r["LastName"]}', '{r["DateBorn"]}', {r["TermStart"]}";
            }

            Debug.Print("--------------");

            SQLUtility.ExecuteSQL(sql);
        }

        public static void Delete(DataTable dtpresident)
        {
            int id = (int)dtpresident.Rows[0]["PresidentId"];
            string sql = "delete president where PresidentId = " + id;
            SQLUtility.ExecuteSQL(sql);
        }
    }
}
