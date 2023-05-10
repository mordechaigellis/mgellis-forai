namespace MAUIBasics;

public partial class BasicControls : ContentPage
{
	public BasicControls()
	{
		InitializeComponent();
        slHeight.ValueChanged += SlHeight_ValueChanged;
	}

    private void SlHeight_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        lblMessage.Text = slHeight.Value.ToString();
    }

    private void btnSave_Clicked(object sender, EventArgs e)
    {
        lblMessage.Text = "Record Saved - " + txtLastName.Text; 
    }
}