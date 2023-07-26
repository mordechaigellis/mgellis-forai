using RecordKeeperSystem;

namespace RecordKeeperMAUI;

public partial class OlympicsList : ContentPage
{
	public OlympicsList()
	{
		InitializeComponent();
		LoadOlympics();
	}

	private void LoadOlympics() {
		OlympicsLst.ItemsSource = new bizOlympics().GetList();
	}

    private void OlympicsBtn_Clicked(object sender, EventArgs e)
    {
		LoadOlympics();
    }
}