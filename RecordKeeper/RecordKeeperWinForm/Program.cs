using RecordKeeperSystem;
using System.Configuration;

namespace RecordKeeperWinForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            try
            {
                string connstring = ConfigurationManager.ConnectionStrings["devconn"].ConnectionString;
                DBManager.SetConnectionString(connstring);
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
            Application.Run(new frmMain());
        }
    }
}