using RecordKeeperSystem;

namespace RecordKeeperMAUI;

public partial class PresidentDetail : ContentPage
{
	bizPresident prez = new();
	public PresidentDetail(int presidentidval = 0)
	{
		InitializeComponent();
		prez.Load(presidentidval);
		this.BindingContext = prez;
    }

    private void Save() {
        MessageLbl.Text = "";
        try
        {
            prez.Save();
        }
        catch (Exception ex) {
            MessageLbl.Text = ex.Message;
        }
    }

    private async void Delete() {
        try
        {
            prez.Delete();
            await ClosePage();
        }
        catch (Exception ex){
            MessageLbl.Text = ex.Message;
        }
    }

    private async Task ClosePage() {
        await Navigation.PopAsync();
    }
    private void SaveBtn_Clicked(object sender, EventArgs e)
    {
        Save();
    }

    private void DeleteBtn_Clicked(object sender, EventArgs e)
    {
        Delete();
    }

    private async void CancelBtn_Clicked(object sender, EventArgs e)
    {
        await ClosePage();
    }
}