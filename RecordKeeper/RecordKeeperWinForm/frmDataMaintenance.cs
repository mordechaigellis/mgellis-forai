using RecordKeeperSystem;

namespace RecordKeeperWinForm
{
    public partial class frmDataMaintenance : Form
    {
        private enum TableTypeEnum { Country, City, OlympicMedal, Season, Sport, SportSubcategory }
        DataTable dtlist = new();
        TableTypeEnum currenttabletype = TableTypeEnum.Country;
        string deletecolname = "deletecol";
        public frmDataMaintenance()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            this.FormClosing += FrmDataMaintenance_FormClosing;
            gData.CellContentClick += GData_CellContentClick;
            SetupRadioButtons();
            BindData(currenttabletype);

        }

        private void BindData(TableTypeEnum tabletype)
        {
            currenttabletype = tabletype;
            dtlist = DataMaintenance.GetDataList(currenttabletype.ToString());
            gData.Columns.Clear();
            gData.DataSource = dtlist;
            switch (tabletype) {
                case TableTypeEnum.City:
                    WindowsFormsUtility.AddComboboxToGrid(gData, DataMaintenance.GetDataList(TableTypeEnum.Country.ToString()), "Country", "CountryName");
                    break;
                case TableTypeEnum.SportSubcategory:
                    WindowsFormsUtility.AddComboboxToGrid(gData, DataMaintenance.GetDataList(TableTypeEnum.Sport.ToString()), "Sport", "SportName");
                    break;

            }
            gData.Columns.Add(new DataGridViewButtonColumn() {Text = "X", HeaderText = "Delete", Name = deletecolname,UseColumnTextForButtonValue = true});
            WindowsFormsUtility.FormatGridForEdit(gData, currenttabletype.ToString());
        }

        private bool Save()
        {
            bool b = false;
            Cursor = Cursors.WaitCursor;
            try
            {
                DataMaintenance.SaveDataList(dtlist, currenttabletype.ToString());
                b = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally {
                Cursor = Cursors.Default;
            }
            return b;
        }

        private void Delete(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gData, rowindex, currenttabletype.ToString() + "Id");
            if (id != 0)
            {
                try
                {
                    DataMaintenance.DeleteRow(currenttabletype.ToString(), id);
                    BindData(currenttabletype);
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id == 0 && rowindex < gData.Rows.Count) {
                gData.Rows.Remove(gData.Rows[rowindex]);
            }
        }

        private void SetupRadioButtons()
        {
            foreach (Control c in pnlOptionButtons.Controls)
            {
                if (c is RadioButton)
                {
                    c.Click += C_Click;
                }
            }
            optCountry.Tag = TableTypeEnum.Country;
            optCity.Tag = TableTypeEnum.City;
            optOlympicMedal.Tag = TableTypeEnum.OlympicMedal;
            optSeason.Tag = TableTypeEnum.Season;
            optSport.Tag = TableTypeEnum.Sport;
            optSportSubcategory.Tag = TableTypeEnum.SportSubcategory;
        }

        private void C_Click(object? sender, EventArgs e)
        {
            if (sender is Control && ((Control)sender).Tag is TableTypeEnum)
            {
                BindData((TableTypeEnum)((Control)sender).Tag);
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void FrmDataMaintenance_FormClosing(object? sender, FormClosingEventArgs e)
{
            if (SQLUtility.TableHasChanges(dtlist))
            {
                var res = MessageBox.Show($"Do you want to save changes to {this.Text} before closing the form?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = Save();
                        if (b == false)
                        {
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
        private void GData_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gData.Columns[e.ColumnIndex].Name == deletecolname) {
                Delete(e.RowIndex);
            }
        }

    }
}
