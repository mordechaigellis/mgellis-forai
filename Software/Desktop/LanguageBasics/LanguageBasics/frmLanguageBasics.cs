﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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
            btnEventHandler2.MouseMove += BtnEventHandler2_MouseMove;
            btnEventHandler2.MouseLeave += BtnEventHandler2_MouseLeave;
            btnVariable1.Click += BtnVariable1_Click;
            btnVariable2.Click += BtnVariable2_Click;
            btnDataConversion1.Click += BtnDataConversion1_Click;
            btnDataConversion2.Click += BtnDataConversion2_Click;
            btnRandom.Click += BtnRandom_Click;
            btnIf1.Click += BtnIf1_Click;
            btnIf2.Click += BtnIf2_Click;
            btnAddControl1.Click += BtnAddControl1_Click;
            btnAddControl2.Click += BtnAddControl2_Click;
            btnData.Click += BtnData_Click;
            btnObject.Click += BtnObject_Click;
            btnNull.Click += BtnNull_Click;
            btnNew.Click += BtnNew_Click;
            btnString.Click += BtnString_Click;
            btnValueRefType.Click += BtnValueRefType_Click;
        }

     

        private string ConcatMessage(string value)
        {
            string s = "";
            s = txtOutput.Text + value + Environment.NewLine;
            return s;
        }
        private void DisplayMessage(string value, bool clearbox = false)
        {
            if (clearbox == true)
            {
                txtOutput.Text = "";
            }
            txtOutput.Text = ConcatMessage(value);
        }

        private void DisplayMessage(string caption, string value, bool clearbox = false)
        {
            string s = caption + " = " + value;
            DisplayMessage(s, clearbox);
        }

        private Color GetRandomColor(int minr, int maxr, int ming, int maxg, int minb, int maxb)
        {
            Random rnd = new Random();
            Color c = Color.FromArgb(rnd.Next(minr, maxr), rnd.Next(ming, maxg), rnd.Next(minb, maxb));
            return c;
        }

        private Color GetRandomColor()
        {
            return GetRandomColor(0, 256, 0, 256, 0, 256);
        }

        private Label GetRandomLabel(Form f)
        {
            Random rnd = new Random();
            Label lbl = new Label();
            lbl.AutoSize = false;
            lbl.BackColor = GetRandomColor();
            lbl.Location = new Point(rnd.Next(0, f.Width - 100), rnd.Next(0, f.Height - 100));
            lbl.Size = new Size(rnd.Next(f.Width / 10, f.Width - 100), rnd.Next(f.Height / 10, f.Height - 100));
            return lbl;
        }

        private string GetConnectionString(bool localdb = true)
        {
            string s = "Server=.\\SQLExpress;Database=RecordKeeperDB;Trusted_Connection=true";
            if (localdb == false) {
                s = "Server=tcp:dev-charliecpu.database.windows.net,1433;Initial Catalog=RecordKeeperDB;Persist Security Info=False;User ID=cpuadmin;Password=CPU123!@#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            }
            return s;
        }

        private DataTable GetDataTable(string sqlstatement)  //- take a SQL statement and return a DataTable
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = GetConnectionString(true);
            conn.Open();
            //DisplayMessage("Conn Status", conn.State.ToString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sqlstatement;
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }
        private void ShowDataInGrid()
        {
            DataTable dt = GetDataTable("select Num, FirstName, LastName from president");
            gOutput.DataSource = dt;
        }

        private void BtnValueRefType_Click(object? sender, EventArgs e)
        {

        }

        private void BtnString_Click(object? sender, EventArgs e)
        {

        }

        private void BtnNew_Click(object? sender, EventArgs e)
        {

        }

        private void BtnNull_Click(object? sender, EventArgs e)
        {

        }

        private void BtnObject_Click(object? sender, EventArgs e)
        {

        }
        private void BtnData_Click(object? sender, EventArgs e)
        {
            ShowDataInGrid();
        }

        private void BtnAddControl2_Click(object? sender, EventArgs e)
        {
            Label lbl = new Label() { Text = "Vacant. For Rent", Dock = DockStyle.Fill, BackColor = GetRandomColor() };
            tblMain.Controls.Add(lbl, 3, 2);
            //////////
            Form f = new Form();
            f.BackColor = Color.Black;
            f.Height = this.Height - 100;
            f.Width = this.Width - 100;

            f.MouseMove += F_MouseMove;
            f.DoubleClick += F_DoubleClick;
            f.Show();

        }

        private void F_DoubleClick(object? sender, EventArgs e)
        {
            Form f = (Form)sender;
            f.Controls.Clear();
        }

        private void F_MouseMove(object? sender, MouseEventArgs e)
        {
            Form f = (Form)sender;
            if (e.Button != MouseButtons.None)
            {
                Color c = Color.Blue;
                if (e.Button == MouseButtons.Left)
                {
                    c = GetRandomColor();
                }
                Label lbl = new Label() { BackColor = c, Height = 10, Width = 10, AutoSize = false };
                lbl.Location = e.Location;
                f.Controls.Add(lbl);

            }
        }

        private void BtnAddControl1_Click(object? sender, EventArgs e)
        {
            Button btn = new Button() { BackColor = GetRandomColor(), Dock = DockStyle.Fill, Text = "New Button - Click Me" };
            tblOutput.Controls.Add(btn, 2, 0);
            btn.Click += Btn_Click;
            //modern art form
            Form f = new Form();
            f.BackColor = Color.Black;
            f.Height = this.Height - 100;
            f.Width = this.Width - 100;
            f.StartPosition = FormStartPosition.CenterParent;
            f.Show();
            Label lbl1 = GetRandomLabel(f);
            lbl1.Click += RandomLabel_Click;
            f.Controls.Add(lbl1);

            Label lbl2 = GetRandomLabel(f);
            f.Controls.Add(lbl2);
            lbl2.Click += RandomLabel_Click;

            Label lbl3 = GetRandomLabel(f);
            f.Controls.Add(lbl3);
            lbl3.Click += RandomLabel_Click;
        }



        private void RandomLabel_Click(object? sender, EventArgs e)
        {
            Label l = (Label)sender;
            l.BackColor = GetRandomColor();
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            DisplayMessage("New Button", "Hi there! :)");
        }

        private void BtnIf2_Click(object? sender, EventArgs e)
        {
            //has red > 128 then forecolor blue
            //else has blue > 128 then forecolor red
            //else has green > 128 then forecolor yellow
            //all other cases black
            Color c = GetRandomColor();
            Color fc = Color.Black;

            txtOutput.BackColor = c;
            if (c.R > 128)
            {
                fc = Color.Blue;
            }
            else if (c.B > 128)
            {
                fc = Color.Red;
            }
            else if (c.G > 128)
            {
                fc = Color.Yellow;
            }

            txtOutput.ForeColor = fc;
            DisplayMessage("Backcolor", c.ToString(), true);
            DisplayMessage("Forecolor", fc.ToString());
        }

        private void BtnIf1_Click(object? sender, EventArgs e)
        {
            Random rnd = new Random();
            int n = rnd.Next(1, 8);
            string msg = "";
            DisplayMessage(n.ToString(), true);
            if (n == 7)
            {
                msg = "1st Prize";
            }
            else if (n > 2 && n < 7)
            {
                if (DateTime.Now.TimeOfDay.Seconds >= 1 && DateTime.Now.TimeOfDay.Seconds <= 20)
                {
                    msg = "1st Prize";
                }
                else
                {
                    msg = "2nd Prize";
                }
            }
            else
            {
                msg = "Try Again";

            }
            DisplayMessage(msg);
            msg = msg.Substring(4);
            DisplayMessage(msg);
        }

        private void BtnRandom_Click(object? sender, EventArgs e)
        {
            Random rnd = new Random();
            int n = rnd.Next(0, 256);
            txtOutput.Text = "";
            txtOutput.Text = n.ToString();
            Color c = GetRandomColor();
            txtOutput.BackColor = c;
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
            decimal d = 1.99m; int n = 0; string s = "100";
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
            c = GetRandomColor(230, 256, 100, 250, 0, 256);
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
            DisplayMessage("MouseMove", "Button = " + e.Button.ToString() + " Location = " + e.Location.ToString());
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
