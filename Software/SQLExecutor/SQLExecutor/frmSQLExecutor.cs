using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLExecutor
{
    public partial class frmSQLExecutor : Form
    {
        public frmSQLExecutor()
        {
            InitializeComponent();
            btnRunQuery.Click += btnRunQuery_Click;
        }

        private string GetConnectionString()
        {
            string db = "RecordKeeperDB";
            if (optRecipe.Checked == true)
            {
                db = "RecipeDB";
            }
            string s = "Server=.\\SQLExpress;Database=" + db + ";Trusted_Connection=true";
            if (optAzure.Checked == true)
            {
                s = "Server=tcp:dev-charliecpu.database.windows.net,1433;Initial Catalog=" + db + ";Persist Security Info=False;User ID=cpuadmin;Password=CPU123!@#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            }
            return s;
        }

        private DataTable GetDataTable()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = GetConnectionString();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = txtQuery.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }
        private void ShowData()
        {
            TabPage p;
            p = new TabPage((tabMain.TabPages.Count + 1).ToString());
            DataGridView grid = new DataGridView() { Dock = DockStyle.Fill };
            p.Controls.Add(grid);
            tabMain.TabPages.Add(p);
            tabMain.SelectedTab = p;
            DataTable dt = GetDataTable();
            grid.DataSource = dt;
        }

        private void btnRunQuery_Click(object? sender, EventArgs e)
        {
            ShowData();
        }
    }
}
