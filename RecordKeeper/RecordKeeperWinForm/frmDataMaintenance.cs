namespace RecordKeeperWinForm
{
    public partial class frmDataMaintenance : Form
    {
        private enum TableTypeEnum { Country, City, OlympicMedal, Season, Sport, SportSubcategory }
        DataTable dtlist = new();
        TableTypeEnum currenttabletype = TableTypeEnum.Country;
        public frmDataMaintenance()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            SetupRadioButtons();
            BindData(currenttabletype);

        }

        private void BindData(TableTypeEnum tabletype)
        {
            currenttabletype = tabletype;
            dtlist = DataMaintenance.GetDataList(currenttabletype.ToString());
            gData.DataSource = dtlist;
            WindowsFormsUtility.FormatGridForEdit(gData, currenttabletype.ToString());
        }

        private void Save()
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                DataMaintenance.SaveDataList(dtlist, currenttabletype.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally {
                Cursor = Cursors.Default;
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
    }
}
