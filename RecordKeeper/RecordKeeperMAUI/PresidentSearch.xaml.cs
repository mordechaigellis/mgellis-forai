using RecordKeeperSystem;
using System.Data;

namespace RecordKeeperMAUI;

public partial class PresidentSearch : ContentPage
{
	public PresidentSearch()
	{
		InitializeComponent();
	}

	private void SearchPresidents() {
		DataTable dt = President.SearchPresidents(0, LastNameTxt.Text, 0, 0);
		PresidentLst.ItemsSource = dt.Rows;
	}

    private void SearchBtn_Clicked(object sender, EventArgs e)
    {
		SearchPresidents();
    }
}