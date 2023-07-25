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
}