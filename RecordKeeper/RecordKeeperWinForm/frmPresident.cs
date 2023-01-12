using System.Data;
using CPUFramework;
namespace RecordKeeperWinForm
{
    public partial class frmPresident : Form
    {
        DataTable dtpresident;
        public frmPresident()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }


        public void ShowForm(int presidentid) {
            string sql = "select p.*, y.PartyName from president p join party y on p.PartyId = y.PartyId where p.PresidentId = " + presidentid.ToString();
            dtpresident = SQLUtility.GetDataTable(sql);
            lblParty.DataBindings.Add("Text", dtpresident, "PartyName");
            lblNum.DataBindings.Add("Text", dtpresident, "Num");
            txtLastName.DataBindings.Add("Text", dtpresident, "LastName");
            txtFirstName.DataBindings.Add("Text", dtpresident, "FirstName");
            txtDateBorn.DataBindings.Add("Text", dtpresident, "DateBorn");
            txtDateDied.DataBindings.Add("Text", dtpresident, "DateDied");
            txtTermStart.DataBindings.Add("Text", dtpresident, "TermStart");
            txtTermEnd.DataBindings.Add("Text", dtpresident, "TermEnd");
            this.Show();
        }

        private void Save() {
            SQLUtility.DebugPrintDataTable(dtpresident);
        }

        private void Delete() { 
        
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}
