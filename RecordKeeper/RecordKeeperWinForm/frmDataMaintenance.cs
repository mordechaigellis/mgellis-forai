namespace RecordKeeperWinForm
{
    public partial class frmDataMaintenance : Form
    {
        private enum TableTypeEnum { Country, City, OlympicMedal, Season, Sport, SportSubcategory }
        public frmDataMaintenance()
        {
            InitializeComponent();
            SetupRadioButtons();
            BindData(TableTypeEnum.Country);

        }

        private void BindData(TableTypeEnum tabletype)
        {
            DataTable dt = DataMaintenance.GetDataList(tabletype.ToString());
            gData.DataSource = dt;
            WindowsFormsUtility.FormatGridForEdit(gData, tabletype.ToString());
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
    }
}
