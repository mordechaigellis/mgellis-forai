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
    public partial class frmLanguageBasics : Form
    {
        //variables go here
        public frmLanguageBasics()
        {
            InitializeComponent();
            //event subscription goes here
            btnEventHandler1.Click += BtnEventHandler1_Click;
            //btnEventHandler2.MouseMove += BtnEventHandler2_MouseMove;
            //btnEventHandler2.MouseLeave += BtnEventHandler2_MouseLeave;
            btnVariable1.Click += BtnVariable1_Click;
            btnVariable2.Click += BtnVariable2_Click;
            btnDataConversion1.Click += BtnDataConversion1_Click;
            btnDataConversion2.Click += BtnDataConversion2_Click;
        }

        private void BtnDataConversion2_Click(object? sender, EventArgs e)
        {
            int n = 0;
            string s = txtOutput.Text;
            bool b = int.TryParse(s, out n);
            txtOutput.Text = "s = " + s + ", conversion worked = " + b + ", n = " + n + Environment.NewLine;
        }

        private void BtnDataConversion1_Click(object? sender, EventArgs e)
        {
            decimal d = 1.99m; int n = 0;string s = "100";
            n = (int)d;
            txtOutput.Text = "";
            txtOutput.Text = "d = " + d + ", n = " + n + Environment.NewLine;

            bool b = int.TryParse(s, out n);
            txtOutput.Text += "s = " + s + ", b = " + b + ", n = " + n + Environment.NewLine;


        }

        private void BtnVariable2_Click(object? sender, EventArgs e)
        {
            //string bool color
            string s = "hello "; bool b = false; Color c = Color.DeepSkyBlue;
            txtOutput.Text += "s = " + s + ", b = " + b + ", c = " + c + Environment.NewLine;
            txtOutput.BackColor = c;
            s += s;
            b = !b;
            c = Color.FromArgb(100, 50, 25);
            txtOutput.Text += "s = " + s + ", b = " + b + ", c = " + c + Environment.NewLine;
            txtOutput.BackColor = c;

        }

        private void BtnVariable1_Click(object? sender, EventArgs e)
        {
            int n = 10; decimal d = .99m; DateTime dt = new DateTime(1989, 4, 25);
            txtOutput.Text = "";
            txtOutput.Text += "n = " + n + ", d = " + d + ", dt = " + dt + Environment.NewLine;
            n = n * 10000;
            d += d;
            dt = dt.AddDays(10000);
            txtOutput.Text += "n = " + n + ", d = " + d + ", dt = " + dt + Environment.NewLine;

        }

        private void BtnEventHandler2_MouseLeave(object? sender, EventArgs e)
        {
            btnEventHandler2.BackColor = SystemColors.Control;
            btnEventHandler2.ForeColor = SystemColors.ControlText;
        }

        private void BtnEventHandler2_MouseMove(object? sender, MouseEventArgs e)
        {
            txtOutput.Text = txtOutput.Text + "Mouse moved over BtnEventHandler2 " + DateTime.Now.TimeOfDay.ToString() + Environment.NewLine;
            btnEventHandler2.BackColor = Color.DodgerBlue;
            btnEventHandler2.ForeColor = Color.OrangeRed;
        }

        private void BtnEventHandler1_Click(object? sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + "BtnEventHandler1 was clicked " + DateTime.Now.TimeOfDay.ToString() + Environment.NewLine;
        }

        //code goes here
    }

}
