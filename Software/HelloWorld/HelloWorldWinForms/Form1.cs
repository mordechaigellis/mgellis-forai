namespace HelloWorldWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello my name is Michael Gellis. The current time is " + DateTime.Now.TimeOfDay.ToString();
        }

       
    }
}