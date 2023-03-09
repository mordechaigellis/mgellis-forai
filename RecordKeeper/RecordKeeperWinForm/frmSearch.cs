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
            txtLastName.KeyDown += TxtLastName_KeyDown;
            gPresident.KeyDown += GPresident_KeyDown;

        }


        private void SearchForPresident(string lastname)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                DataTable dt = President.SearchPresidents(lastname);
                gPresident.DataSource = dt;
                WindowsFormsUtility.FormatGridForSearchResults(gPresident, "President");
                if (gPresident.Rows.Count > 0)
                {
                    gPresident.Focus();
                    gPresident.Rows[0].Selected = true;
                }
            }
            catch 
            {
                throw;
            }
            finally {
                this.Cursor = Cursors.Default;
            }
        }

        private void ShowPresidentForm(int rowindex) {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gPresident,rowindex,"PresidentId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain) {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmPresident), id);
            }
        }

        private void DoSearch() {
            SearchForPresident(txtLastName.Text);
        }
       

        private void GPresident_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowPresidentForm(e.RowIndex);
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            DoSearch();   
        }

        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowPresidentForm(-1);
        }
        private void TxtLastName_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                DoSearch();
            }
        }
        private void GPresident_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gPresident.SelectedRows.Count > 0) {
                ShowPresidentForm(gPresident.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }

    }
}
