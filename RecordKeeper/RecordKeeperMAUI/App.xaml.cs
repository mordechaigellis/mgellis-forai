namespace RecordKeeperMAUI
{
    public partial class App : Application
    {
        public static bool LoggedIn = false;
        public static string ConnStringSetting = "Server=.\\SQLExpress;Database=RecordKeeperDB";
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

    }
}