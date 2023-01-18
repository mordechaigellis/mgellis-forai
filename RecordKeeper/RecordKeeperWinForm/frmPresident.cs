using System.Data;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Transactions;
using CPUFramework;
using CPUWindowsFormFramework;
using RecordKeeperSystem;

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
            dtpresident = President.Load(presidentid);
            if (presidentid == 0)
            {
                dtpresident.Rows.Add();
            }
            DataTable dtparties = President.GetPartyList();
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
            President.Save(dtpresident);
        }

        private void Delete()
        {
            President.Delete(dtpresident);
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
