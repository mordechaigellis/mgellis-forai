using RecordKeeperSystem;

namespace RecordKeeperMAUI;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
        this.Loaded += Home_Loaded;
        this.Appearing += Home_Appearing;
	}

    private async void Home_Loaded(object sender, EventArgs e)
    {
        if (App.LoggedIn == false) {
            await Navigation.PushModalAsync(new Login());
        }
    }

    private void Home_Appearing(object sender, EventArgs e)
    {
        if (App.LoggedIn == true) {
            BindableLayout.SetItemsSource(DashboardLst, new bizDashboard().GetList());
        }
    }

    private async void DashboardBtn_Clicked(object sender, EventArgs e)
    {
        bizDashboard d = (bizDashboard)((Button)sender).BindingContext;
        switch (d.DashboardType.ToLower()) {
            case "president":
                await Shell.Current.GoToAsync("//PresidentSearch");
                break;
            case "olympics":
                await Shell.Current.GoToAsync("//OlympicsList");
                break;
        }
    }
}