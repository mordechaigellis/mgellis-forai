using System.Data;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using CPUFramework;
using CPUWindowsFormFramework;
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


        public void ShowForm(int presidentid)
        {
            string sql = "select p.*, y.PartyName from president p join party y on p.PartyId = y.PartyId where p.PresidentId = " + presidentid.ToString();
            dtpresident = SQLUtility.GetDataTable(sql);
            if (presidentid == 0)
            {
                dtpresident.Rows.Add();
            }
            DataTable dtparties = SQLUtility.GetDataTable("select PartyId, PartyName from party");
            WindowsFormsUtility.SetListBinding(lstPartyName, dtparties, "Party");
            WindowsFormsUtility.SetControlBinding(txtNum, dtpresident);
            WindowsFormsUtility.SetControlBinding(txtLastName, dtpresident);
            WindowsFormsUtility.SetControlBinding(txtFirstName, dtpresident);
            WindowsFormsUtility.SetControlBinding(dtpDateBorn, dtpresident);
            WindowsFormsUtility.SetControlBinding(txtDateDied, dtpresident);
            WindowsFormsUtility.SetControlBinding(txtTermStart, dtpresident);
            WindowsFormsUtility.SetControlBinding(txtTermEnd, dtpresident);
            this.Show();
        }

   
        private void Save()
        {
            SQLUtility.DebugPrintDataTable(dtpresident);
            DataRow r = dtpresident.Rows[0];
            int id = (int)r["PresidentId"];
            string sql = "";

            if (id > 0)
            {
                sql = string.Join(Environment.NewLine, $"update president set",
                    $"PartyId = '{r["PartyId"]}',",
                    $"Num = '{r["Num"]}',",
                    $"FirstName = '{r["FirstName"]}',",
                    $"LastName = '{r["LastName"]}',",
                    $"DateBorn = '{r["DateBorn"]}',",
                    $"TermStart = '{r["TermStart"]}'",
                    $"where PresidentId = {r["PresidentId"]}");
            }
            else
            {
                sql = "insert president(PartyId, Num, FirstName, LastName, DateBorn, TermStart) ";
                sql += $"select '{r["PartyId"]}', {r["Num"]}, '{r["FirstName"]}', '{r["LastName"]}', '{r["DateBorn"]}', {r["TermStart"]}";
            }

            Debug.Print("--------------");

            SQLUtility.ExecuteSQL(sql);
        }

        private void Delete()
        {
            int id = (int)dtpresident.Rows[0]["PresidentId"];
            string sql = "delete president where PresidentId = " + id;
            SQLUtility.ExecuteSQL(sql);
            this.Close();
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
