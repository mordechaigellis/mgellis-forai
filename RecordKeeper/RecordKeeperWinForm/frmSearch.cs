using System.Data;
using System.Diagnostics;
using CPUFramework;
namespace RecordKeeperWinForm
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            gPresident.CellDoubleClick += GPresident_CellDoubleClick;
            btnNew.Click += BtnNew_Click;
            FormatGrid();
        }

        private void SearchForPresident(string lastname)
        {
            string sql = "select PresidentId, Num, LastName, FirstName from president p where p.lastname like '%" + lastname + "%'";
            
            DataTable dt = SQLUtility.GetDataTable(sql);
            gPresident.DataSource = dt;
            gPresident.Columns["PresidentId"].Visible = false;
        }

        private void ShowPresidentForm(int rowindex) {
            int id = 0;
            if (rowindex > -1)
            {
                id = (int)gPresident.Rows[rowindex].Cells["PresidentId"].Value;
            }
            frmPresident frm = new frmPresident();
            frm.ShowForm(id);
        }

        private void FormatGrid() {
            gPresident.AllowUserToAddRows = false;
            gPresident.ReadOnly = true;
            gPresident.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gPresident.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void GPresident_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowPresidentForm(e.RowIndex);
        }


        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchForPresident(txtLastName.Text);
        }
        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowPresidentForm(-1);
        }

    }
}
