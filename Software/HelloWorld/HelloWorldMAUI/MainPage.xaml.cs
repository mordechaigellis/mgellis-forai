namespace HelloWorldMAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
           label1.Text = "Hi " + DateTime.Now.TimeOfDay.ToString();
        }
    }
}