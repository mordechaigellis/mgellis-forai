using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageBasics
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TabPage p;
            p = new TabPage((tabMain.TabPages.Count + 1).ToString());
            Button btn = new Button() { Text = "Hi"};
            btn.Click += Btn_Click;

            p.Controls.Add(btn);
            tabMain.TabPages.Add(p);
            tabMain.SelectedTab = p;

            //if (optBread.Checked == true)
            //{
            //    MessageBox.Show("Bread");
            //}
            //else {
            //    MessageBox.Show("Something Else");
            //}
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Text = "I was Clicked";
        }
    }
}
