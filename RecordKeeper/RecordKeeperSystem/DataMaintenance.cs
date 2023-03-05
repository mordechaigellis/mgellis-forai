namespace RecordKeeperSystem
{
    public static class DataMaintenance
    {
        public static DataTable GetDataList(string tablename)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand(tablename + "Get");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

      

    }
}
