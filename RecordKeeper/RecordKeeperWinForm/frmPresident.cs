using CPUFramework;
using Microsoft.SqlServer.Server;

namespace RecordKeeperWinForm
{
    public partial class frmPresident : Form
    {
        DataTable dtpresident = new DataTable();
        BindingSource bindsource = new BindingSource();
        public frmPresident()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            this.FormClosing += FrmPresident_FormClosing;
        }

        

        public void ShowForm(int presidentid)
        {
            this.Tag = presidentid;
            dtpresident = President.Load(presidentid);
            bindsource.DataSource = dtpresident;
            if (presidentid == 0)
            {
                dtpresident.Rows.Add();
            }
            DataTable dtparties = President.GetPartyList();
            WindowsFormsUtility.SetListBinding(lstPartyName, dtparties,dtpresident, "Party");
            WindowsFormsUtility.SetControlBinding(txtNum, bindsource);
            WindowsFormsUtility.SetControlBinding(txtLastName, bindsource);
            WindowsFormsUtility.SetControlBinding(txtFirstName, bindsource);
            WindowsFormsUtility.SetControlBinding(dtpDateBorn, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateDied, bindsource);
            WindowsFormsUtility.SetControlBinding(txtTermStart, bindsource);
            WindowsFormsUtility.SetControlBinding(txtTermEnd, bindsource);
            this.Text = GetPresidentDesc();
            this.Show();
        }


        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                President.Save(dtpresident);
                b = true;
                bindsource.ResetBindings(false);
                this.Tag = SQLUtility.GetValueFromFirstRowAsInt(dtpresident, "PresidentId");
                this.Text = GetPresidentDesc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Record Keeper");
            }
            finally {
                Application.UseWaitCursor = false;
            }
            return b;
        }

        private void Delete()
        {
            if (dtpresident.Rows.Count > 0) {
                string alloweddelete = "";
                alloweddelete = dtpresident.Rows[0]["IsDeleteAllowed"].ToString();
                if (alloweddelete != "") {
                    MessageBox.Show(alloweddelete);
                    return;
                }
            }
            var response = MessageBox.Show("Are you sure you want to delete this President?", "Record Keeper", MessageBoxButtons.YesNo);
            if (response == DialogResult.No) {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                President.Delete(dtpresident);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Record Keeper");
            }
            finally {
                Application.UseWaitCursor = false;
            }

        }

        private string GetPresidentDesc() {
            string value = "New President";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtpresident, "PresidentId");
            if (pkvalue > 0) {
                value = SQLUtility.GetValueFromFirstRowAsInt(dtpresident, "Num") + " " + SQLUtility.GetValueFromFirstRowAsString(dtpresident, "LastName");
            }
            return value;
        }
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void FrmPresident_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtpresident)) {
                var res = MessageBox.Show($"Do you want to save changes to {this.Text} before closing the form?", "Record Keeper", MessageBoxButtons.YesNoCancel);
                switch (res) {
                    case DialogResult.Yes:
                        bool b = Save();
                        if (b == false) {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
        }
    }
}
