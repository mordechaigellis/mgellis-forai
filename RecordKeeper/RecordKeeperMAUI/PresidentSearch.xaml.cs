using RecordKeeperSystem;
using System.Data;

namespace RecordKeeperMAUI;

public partial class PresidentSearch : ContentPage
{
    public PresidentSearch()
    {
        InitializeComponent();
    }

    private void SearchPresidents()
    {
        bizPresident prez = new();
        var lstprez = prez.Search(0, LastNameTxt.Text, 0, 0);
        PresidentLst.ItemsSource = lstprez;
    }

    private void SearchBtn_Clicked(object sender, EventArgs e)
    {
        SearchPresidents();
    }

    private async void PresidentLst_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        bizPresident prez = (bizPresident)e.Item;
        await Navigation.PushAsync(new PresidentDetail(prez.PresidentId));
    }
}