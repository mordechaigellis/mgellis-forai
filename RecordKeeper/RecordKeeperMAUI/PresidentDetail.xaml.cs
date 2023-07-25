namespace RecordKeeperMAUI;

public partial class PresidentDetail : ContentPage
{
	public PresidentDetail(int presidentidval = 0)
	{
		InitializeComponent();
		PresidentLbl.Text = PresidentLbl.Text + " " + presidentidval;
    }
}