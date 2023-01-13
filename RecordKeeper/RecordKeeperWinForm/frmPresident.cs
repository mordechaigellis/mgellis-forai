using System.Data;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Transactions;
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
            SetListBinding(lstPartyName, dtparties, "Party");
            SetControlBinding(lblNum, dtpresident);
            SetControlBinding(txtLastName, dtpresident);
            SetControlBinding(txtFirstName, dtpresident);
            SetControlBinding(txtDateBorn, dtpresident);
            SetControlBinding(txtDateDied, dtpresident);
            SetControlBinding(txtTermStart, dtpresident);
            SetControlBinding(txtTermEnd, dtpresident);
            this.Show();
        }

        public void SetListBinding(ComboBox lst, DataTable dt, string tablename)
        {
            lst.DataSource = dt;
            lst.ValueMember = tablename + "Id";
            lst.DisplayMember = lst.Name.Substring(3);
            lst.DataBindings.Add("SelectedValue", dtpresident, lst.ValueMember, false, DataSourceUpdateMode.OnPropertyChanged);
        }
        public void SetControlBinding(Control ctrl, DataTable dt)
        {
            string propertyname = "";
            string columnname = "";
            string controlname = ctrl.Name.ToLower();

            if (controlname.StartsWith("txt") || controlname.StartsWith("lbl"))
            {
                propertyname = "Text";
                columnname = controlname.Substring(3);
            }

            if (propertyname != "" && columnname != "")
            {
                ctrl.DataBindings.Add(propertyname, dt, columnname, true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        private void Save()
        {
            SQLUtility.DebugPrintDataTable(dtpresident);
            string sql = "";
            if (dtpresident.Rows.Count > 0)
            {
                DataRow r = dtpresident.Rows[0];
                int id = (int)r["PresidentId"];
                if (id > 0)
                {
                    sql = string.Join(Environment.NewLine, $"update president set",
                                       $"PartyId = '{r["PartyId"]}',",
                                       $"FirstName = '{r["FirstName"]}',",
                                       $"LastName = '{r["LastName"]}',",
                                       $"DateBorn = '{r["DateBorn"]}',",
                                       $"TermStart = '{r["TermStart"]}'",
                                       $"where PresidentId = {r["PresidentId"]}");
                }
                else
                {
                   
                }


                Debug.Print("--------------");

                SQLUtility.GetDataTable(sql);
            }
            else
            {
                MessageBox.Show("President table has zero rows, cannot save.", "Record Keeper", MessageBoxButtons.OK);
            }
        }

        private void Delete()
        {

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
