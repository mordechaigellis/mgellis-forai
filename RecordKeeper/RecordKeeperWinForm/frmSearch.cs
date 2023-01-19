using System.Data;
using System.Diagnostics;

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
            WindowsFormsUtility.FormatGridForSearchResults(gPresident);
        }


        private void SearchForPresident(string lastname)
        {
            DataTable dt = President.SearchPresidents(lastname);
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
