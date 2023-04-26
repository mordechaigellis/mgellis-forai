﻿using System.Runtime.CompilerServices;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using gnuciDictionary;

namespace LanguageBasics
{
    public partial class frmLanguageBasics : Form
    {
        int nform = 0;
        int noutputincrementer = 0;
        System.Windows.Forms.Timer tmr = new System.Windows.Forms.Timer() { Interval = 1 };
        System.Windows.Forms.Timer tmrrandomword = new();
        List<Button> lstbtn;
        List<string> lstword = new() { "apple", "boy", "candy", "dog", "egg" };
        private enum LineSeparatorEnum { NewLine = 10, TripleDash = 11, Colon = 12, TripleLine = 13 }
        private enum DBServerTypeEnum { Local, Azure }
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
            btnScope1.Click += BtnScope1_Click;
            btnSwitch.Click += BtnSwitch_Click;
            btnTernary1.Click += BtnTernary1_Click;
            btnTernary2.Click += BtnTernary2_Click;
            btnFor1.Click += BtnFor1_Click;
            btnFor2.Click += BtnFor2_Click;
            btnForEach1.Click += BtnForEach1_Click;
            btnForEach2.Click += BtnForEach2_Click;
            btnWhile1.Click += BtnWhile1_Click;
            btnWhile2.Click += BtnWhile2_Click;
            btnTimer1.Click += BtnTimer1_Click;
            btnTimer2.Click += BtnTimer2_Click;
            tmr.Tick += Tmr_Tick;
            tmrrandomword.Tick += Tmrrandomword_Tick;
            btnList1.Click += BtnList1_Click;
            btnList2.Click += BtnList2_Click;
            btnEnumerable1.Click += BtnEnumerable1_Click;
            btnEnumerable2.Click += BtnEnumerable2_Click;
            btnArray.Click += BtnArray_Click;
            lstbtn = new() { btnEnumerable1, btnEnumerable2, btnFor1, btnList1, btnRandom };
        }

        private void IncrementOutputMessageVariable()
        {
            noutputincrementer = noutputincrementer + 1;
            this.Text = "Language Basics - " + noutputincrementer;
        }

        private string ConcatMessage(string value, LineSeparatorEnum lineseparatortype = LineSeparatorEnum.NewLine)
        {
            string s = "";
            string lineseparator = "";

            switch (lineseparatortype)
            {
                case LineSeparatorEnum.Colon:
                    lineseparator = ":";
                    break;
                case LineSeparatorEnum.TripleDash:
                case LineSeparatorEnum.TripleLine:
                    lineseparator = "---";
                    break;
                default:
                    lineseparator = Environment.NewLine;
                    break;
            }

            s = value + lineseparator + txtOutput.Text;

            return s;
        }

        private void DisplayValueAndCaption(string value, [CallerArgumentExpression("value")] string valuename = "")
        {
            txtOutput.Text = ConcatMessage(valuename + " = " + value, LineSeparatorEnum.NewLine);
            IncrementOutputMessageVariable();
        }

        private void DisplayMessage(string value, bool clearbox = false)
        {
            if (clearbox == true)
            {
                txtOutput.Text = "";
            }
            txtOutput.Text = ConcatMessage(value);
            IncrementOutputMessageVariable();
        }

        private void DisplayMessage(string caption, string value, bool clearbox = false)
        {
            string s = caption + " = " + value;
            DisplayMessage(s, clearbox);
        }

        private void DisplayHeader(string caption, bool clearbox = false)
        {
            DisplayMessage("-----------" + caption + "-----------^^");
        }

        private Color GetRandomColor(int minr, int maxr, int ming, int maxg, int minb, int maxb)
        {
            Random rnd = new();
            var c = Color.FromArgb(rnd.Next(minr, maxr), rnd.Next(ming, maxg), rnd.Next(minb, maxb));
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

        private string GetConnectionString(DBServerTypeEnum dbservertype = DBServerTypeEnum.Local)
        {
            var s = "Server=.\\SQLExpress;Database=RecordKeeperDB;Trusted_Connection=true";
            if (dbservertype == DBServerTypeEnum.Azure)
            {
                s = "Server=tcp:dev-charliecpu.database.windows.net,1433;Initial Catalog=RecordKeeperDB;Persist Security Info=False;User ID=cpuadmin;Password=CPU123!@#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            }
            return s;
        }

        private DataTable GetDataTable(string sqlstatement)  //- take a SQL statement and return a DataTable
        {
            DataTable dt = new();
            SqlConnection conn = new();
            conn.ConnectionString = GetConnectionString(DBServerTypeEnum.Azure);
            conn.Open();
            //DisplayMessage("Conn Status", conn.State.ToString());
            var cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sqlstatement;
            var dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }
        private void ShowDataInGrid()
        {
            DataTable dt = GetDataTable("select Num, FirstName, LastName from president");
            gOutput.DataSource = dt;
        }

        private string GenerateRandomWord()
        {
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();
            for (int i = 1; i < 11; i++)
            {
                int n = rnd.Next(65, 91);
                sb.Append((char)n);
            }
            return sb.ToString();
        }

        private void ShowCurrentTime()
        {
            DisplayMessage(DateTime.Now.ToString("HH:mm:ss:fff"));
        }

        private void Tmrrandomword_Tick(object? sender, EventArgs e)
        {
            DisplayMessage(GenerateRandomWord());
        }
        private void Tmr_Tick(object? sender, EventArgs e)
        {
            ShowCurrentTime();
        }

        private void BtnTimer2_Click(object? sender, EventArgs e)
        {
            tmrrandomword.Enabled = !tmrrandomword.Enabled;
        }

        private void BtnTimer1_Click(object? sender, EventArgs e)
        {
            tmr.Enabled = !tmr.Enabled;
        }
        private void BtnWhile2_Click(object? sender, EventArgs e)
        {
            DateTime starttime = DateTime.Now;
            while ((DateTime.Now - starttime).TotalSeconds <= 20)
            {
                DisplayMessage(GenerateRandomWord());
                Application.DoEvents();
            }
        }

        private void BtnWhile1_Click(object? sender, EventArgs e)
        {
            DateTime starttime = DateTime.Now;
            while ((DateTime.Now - starttime).TotalSeconds <= 15)
            {
                ShowCurrentTime();
                Application.DoEvents();
            }
        }

        private void BtnForEach2_Click(object? sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                c.BackColor = GetRandomColor();
            }

            foreach (Control c in tblMain.Controls)
            {
                c.BackColor = GetRandomColor();
            }

            foreach (Control c in tblOutput.Controls)
            {
                c.BackColor = GetRandomColor();
            }

        }

        private void BtnForEach1_Click(object? sender, EventArgs e)
        {
            DataTable dt = GetDataTable("select recordname from worldrecord");
            foreach (DataRow dr in dt.Rows)
            {
                DisplayValueAndCaption(dr[0].ToString());
            }
        }

        private void BtnFor2_Click(object? sender, EventArgs e)
        {
            DisplayValueAndCaption(GenerateRandomWord());
        }

        private void BtnFor1_Click(object? sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                string s = "";
                s = "Loop Variable: " + i;
                DisplayValueAndCaption(s);
            }
        }
        private void BtnTernary2_Click(object? sender, EventArgs e)
        {
            Random rnd = new();
            int n = rnd.Next(1, 3);
            txtOutput.Text = n == 1 ? "Heads" : "Tails";

        }

        private void BtnTernary1_Click(object? sender, EventArgs e)
        {
            DisplayValueAndCaption(DateTime.Now.Second.ToString());
            tblMain.BackColor = DateTime.Now.Second < 30 ? Color.Yellow : Color.Blue;
        }
        private void BtnSwitch_Click(object? sender, EventArgs e)
        {
            /*
            Generate and display a random number from 1 to 7.
            If 7 then display 1st prize
            If between 3 and 6 then 2nd prize
            All other cases display “Try again”
             */
            Random rnd = new();
            int n = rnd.Next(1, 8);
            DisplayValueAndCaption(n.ToString());
            string msg = "";

            switch (n)
            {
                case 7:
                    msg = "1st Prize";
                    break;
                case 3:
                case 4:
                case 5:
                case 6:
                    msg = "2nd Prize";
                    break;
                default:
                    msg = "Try Again";
                    break;
            }


            DisplayValueAndCaption(msg);
        }
        private void BtnScope1_Click(object? sender, EventArgs e)
        {
            int nlocal = 0;
            nlocal = nlocal + 1;
            nform = nform + 1;

            DisplayValueAndCaption(nlocal.ToString());
            DisplayValueAndCaption(nform.ToString());

        }

        private void BtnValueRefType_Click(object? sender, EventArgs e)
        {
            int n = 100;
            int x = n;
            n = n * 100;
            DisplayValueAndCaption(n.ToString());
            DisplayValueAndCaption(x.ToString());

            Button btn = btnValueRefType;
            Button btn2 = btn;
            btn.Text = "I was changed";
            btn2.BackColor = Color.LightYellow;
            btnValueRefType.FlatStyle = FlatStyle.Popup;
            n = 1;
            x = 1;
            int y;

            DoubleIt(n, out y, btn);
            DisplayValueAndCaption(n.ToString());
            DisplayValueAndCaption(y.ToString());
        }

        private void DoubleIt(int n, out int x, Button btn)
        {
            n = n * 2;
            DisplayMessage("n inside DoubleIt", n.ToString());
            x = 1;
            x = x * 2;
            btn.Text += btn.Text;
        }
        private void BtnString_Click(object? sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Hi ");
            sb.Append("How are you? ");
            sb.Append(DateTime.Now.TimeOfDay);
            DisplayValueAndCaption(sb.ToString());
        }

        private void BtnNew_Click(object? sender, EventArgs e)
        {
            int n = new int();
            DisplayValueAndCaption(n.ToString());
            DateTime dt = new DateTime();
            DisplayValueAndCaption(dt.ToString());
            string s = new string("hello");
            bool b = s.Contains("x");
            string val = string.Join("-", "a", "b");
            DisplayValueAndCaption(val);
        }

        private void BtnNull_Click(object? sender, EventArgs e)
        {
            object o = null;
            if (o != null)
            {
                DisplayValueAndCaption(o.ToString());
            }
            else
            {
                DisplayMessage("o is null");
            }
            int? n = null;
            DisplayValueAndCaption(n.ToString());

            string s = null;
            DisplayValueAndCaption(s);
        }

        private void BtnObject_Click(object? sender, EventArgs e)
        {
            object o = new object();
            DisplayValueAndCaption(o.ToString());
            int x = 100;
            o = x;
            DisplayValueAndCaption(o.ToString());
            o = btnObject;
            DisplayValueAndCaption(o.ToString());
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
            DisplayValueAndCaption(n.ToString());
            Color c = GetRandomColor();
            txtOutput.BackColor = c;
        }

        private void BtnDataConversion2_Click(object? sender, EventArgs e)
        {
            int n = 0;
            string s = txtOutput.Text;
            bool b = int.TryParse(s, out n);
            txtOutput.Text = "s = " + s + ", conversion worked = " + b + ", n = " + n + Environment.NewLine;
            IncrementOutputMessageVariable();
        }

        private void BtnDataConversion1_Click(object? sender, EventArgs e)
        {
            decimal d = 1.99m; int n = 0; string s = "100";
            n = (int)d;
            txtOutput.Text = "";
            txtOutput.Text = "d = " + d + ", n = " + n + Environment.NewLine;
            IncrementOutputMessageVariable();
            bool b = int.TryParse(s, out n);
            txtOutput.Text += "s = " + s + ", b = " + b + ", n = " + n + Environment.NewLine;
            IncrementOutputMessageVariable();

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
            DisplayValueAndCaption(n.ToString());
            DisplayValueAndCaption(d.ToString());
            DisplayValueAndCaption(dt.ToString());
            n = n * 10000;
            d += d;
            dt = dt.AddDays(10000);
            DisplayValueAndCaption(n.ToString());
            DisplayValueAndCaption(d.ToString());
            DisplayValueAndCaption(dt.ToString());

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
            IncrementOutputMessageVariable();
        }


        private void BtnEnumerable2_Click(object? sender, EventArgs e)
        {
            DisplayHeader("Display all items in the list");
            lstword.ForEach(s => DisplayValueAndCaption(s));
            DisplayHeader("Display the count items with that letter");
            DisplayValueAndCaption(lstword.Count(s => s.ToLower().Contains("e")).ToString());
            DisplayHeader("Display true / false if any items contain that letter uppercase");
            DisplayValueAndCaption(lstword.Exists(s => s.Contains("E")).ToString());
            DisplayHeader("In one line of code change the all items that contain that letter.");
            lstword.
                Where(s => s.ToLower().Contains("e"))
                .ToList()
                .ForEach(s => DisplayValueAndCaption(s.Replace("e", "8")));
            DisplayHeader("Create a function that takes a button as a parameter and have that function change the button in 3 ways.Call that function in a for each using the shorthand method.");
            lstword.ForEach(ChangeWord);
        }

        private void ChangeWord(string word)
        {
            DisplayValueAndCaption(string.Concat(word.ToUpper().Replace("E", "0").Reverse()));
        }
        private void BtnEnumerable1_Click(object? sender, EventArgs e)
        {
            DisplayHeader("Display all items in the list");
            lstbtn.ForEach(btn => DisplayValueAndCaption(btn.Text));

            DisplayHeader("Display the count items with that letter");
            DisplayValueAndCaption(lstbtn.Count(btn => btn.Text.ToLower().Contains("o")).ToString());
            DisplayHeader("Display true / false if any items contain that letter uppercase");
            DisplayValueAndCaption(lstbtn.Exists(btn => btn.Text.Contains("O")).ToString());
            DisplayHeader("In one line of code change the all items that contain that letter.");
            lstbtn.Where(btn => btn.Text.Contains("o")).ToList().ForEach(btn => btn.BackColor = Color.Orange);
            DisplayHeader("Create a function that takes a button as a parameter and have that function change the button in 3 ways.Call that function in a for each using the shorthand method.");
            lstbtn.ForEach(ChangeButton);
        }

        private void ChangeButton(Button btn)
        {
            btn.BackColor = GetRandomColor();
            btn.ForeColor = GetRandomColor();
            btn.Dock = DockStyle.None;
            //btn.Height = btn.Height - 5;
            btn.Text = String.Concat(btn.Text.Reverse());

        }
        private void ShowWordList(List<string> lst)
        {
            foreach (var s in lst)
            {
                DisplayValueAndCaption(s);
            }
        }

        private void BtnList2_Click(object? sender, EventArgs e)
        {

            DisplayHeader("Enumerate through the list");
            ShowWordList(lstword);
            DisplayHeader("Add another word");
            lstword.Add("frog");
            ShowWordList(lstword);
            DisplayHeader("Remove a word");
            lstword.Remove("apple");
            ShowWordList(lstword);
            DisplayHeader("Get a word by index");
            string s = lstword[1];
            DisplayValueAndCaption(s);
            DisplayHeader("Count the items in list");
            DisplayValueAndCaption(lstword.Count().ToString());
            DisplayHeader("Clear the list");
            lstword.Clear();
            ShowWordList(lstword);

        }


        private void ShowButtonList(List<Button> lst, Color colorval)
        {
            foreach (Button btn in lst)
            {
                DisplayValueAndCaption(btn.Text);
                btn.BackColor = colorval;
            }

        }
        private void BtnList1_Click(object? sender, EventArgs e)
        {


            //Enumerate through the list
            DisplayHeader("Enumerate through the list");
            ShowButtonList(lstbtn, Color.Red);
            //Add another button
            DisplayHeader("Add another button");
            lstbtn.Add(btnAddControl1);
            ShowButtonList(lstbtn, Color.Green);
            //Remove a button
            DisplayHeader("Remove a button");
            lstbtn.Remove(btnEnumerable1);
            ShowButtonList(lstbtn, Color.Purple);
            //Get a button by index
            DisplayHeader("Get a button by index");
            Button btn = lstbtn[0];
            DisplayValueAndCaption(btn.Text);
            btn.BackColor = Color.Yellow;
            //Count the items in list
            DisplayHeader("Count the items in list");
            DisplayValueAndCaption(lstbtn.Count().ToString());
            //Clear the list
            DisplayHeader("Clear the list");
            lstbtn.Clear();
            ShowButtonList(lstbtn, Color.Beige);
            ////
            List<Word> lstw = gnuciDictionary.EnglishDictionary.GetAllWords().ToList();
            DisplayValueAndCaption(lstw.Count().ToString());
            DisplayValueAndCaption(lstw[101].Value);
            DisplayValueAndCaption(lstw[101].Definition);
        }
        private void BtnArray_Click(object? sender, EventArgs e)
        {
            Button[] btns = { btnArray, btnData };
            DisplayValueAndCaption(btns.Length.ToString());
            btns[0] = btnScope1;
            foreach (var btn in btns) {
                DisplayValueAndCaption(btn.Name);
            }
            var lst = btns.ToList<Button>();
            lst.Add(btnSwitch);
            lst.ForEach(b => DisplayValueAndCaption(b.Name));

            Button[] btns2 = new Button[3];
            btns2[0] = btnScope1;
            btns2[1] = btnString;
        }

    }

}
