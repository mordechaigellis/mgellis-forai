using System.Xml.Linq;

namespace RecordKeeperWinForm
{
    public partial class frmPresident : Form
    {
        DataTable dtpresident = new DataTable();
        DataTable dtpresidentmedal = new DataTable();
        BindingSource bindsource = new BindingSource();
        string deletecolname = "deletecol";
        int presidentid = 0;
        public frmPresident()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            this.FormClosing += FrmPresident_FormClosing;
            btnSaveMedal.Click += BtnSaveMedal_Click;
            gMedal.CellContentClick += GMedal_CellContentClick;
        }


        public void ShowForm(int presidentidval)
        {
            presidentid = presidentidval;
            this.Tag = presidentid;
            dtpresident = President.Load(presidentid);
            bindsource.DataSource = dtpresident;
            if (presidentid == 0)
            {
                dtpresident.Rows.Add();
            }
            DataTable dtparties = President.GetPartyList();
            WindowsFormsUtility.SetListBinding(lstPartyName, dtparties, dtpresident, "Party");
            WindowsFormsUtility.SetControlBinding(txtNum, bindsource);
            WindowsFormsUtility.SetControlBinding(txtLastName, bindsource);
            WindowsFormsUtility.SetControlBinding(txtFirstName, bindsource);
            WindowsFormsUtility.SetControlBinding(dtpDateBorn, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateDied, bindsource);
            WindowsFormsUtility.SetControlBinding(txtTermStart, bindsource);
            WindowsFormsUtility.SetControlBinding(txtTermEnd, bindsource);
            this.Text = GetPresidentDesc();
            LoadPresidentMedals();
            this.Show();
        }

        private void LoadPresidentMedals()
        {
            dtpresidentmedal = PresidentMedal.LoadByPresidentId(presidentid);
            gMedal.Columns.Clear();
            gMedal.DataSource = dtpresidentmedal;
            WindowsFormsUtility.AddComboboxToGrid(gMedal, DataMaintenance.GetDataList("Medal"), "Medal", "MedalName");
            WindowsFormsUtility.AddDeleteButtonToGrid(gMedal, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gMedal, "PresidentMedal");
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
            string alloweddelete = SQLUtility.GetValueFromFirstRowAsString(dtpresident, "IsDeleteAllowed");
            if (alloweddelete != "") {
                MessageBox.Show(alloweddelete, Application.ProductName);
                return;
            }
            
            var response = MessageBox.Show("Are you sure you want to delete this President?", Application.ProductName, MessageBoxButtons.YesNo);
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
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally {
                Application.UseWaitCursor = false;
            }
        }

        private void SavePresidentMedal()
        {
            try
            {
                PresidentMedal.SaveTable(dtpresidentmedal, presidentid);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            
        }

        private void DeletePresidentMedal(int rowIndex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gMedal, rowIndex, "PresidentMedalId");
            if (id > 0)
            {
                try
                {
                    PresidentMedal.Delete(id);
                    LoadPresidentMedals();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gMedal.Rows.Count) {
                gMedal.Rows.RemoveAt(rowIndex);
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
                var res = MessageBox.Show($"Do you want to save changes to {this.Text} before closing the form?", Application.ProductName, MessageBoxButtons.YesNoCancel);
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

        private void BtnSaveMedal_Click(object? sender, EventArgs e)
        {
            SavePresidentMedal();
        }
        private void GMedal_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeletePresidentMedal(e.RowIndex);
        }

    }
}
