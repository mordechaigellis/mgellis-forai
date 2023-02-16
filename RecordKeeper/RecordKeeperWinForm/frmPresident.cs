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
        }


        public void ShowForm(int presidentid)
        {
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
            this.Show();
        }


        private void Save()
        {
            Application.UseWaitCursor = true;
            try
            {
                President.Save(dtpresident);
                bindsource.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Record Keeper");
            }
            finally {
                Application.UseWaitCursor = false;
            }
            
        }

        private void Delete()
        {
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
