namespace OOPBasics;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void PersonBtn_Clicked(object sender, EventArgs e)
    {
		Person p = new();
		p.FirstName = "John";
		p.LastName = "Smith";
		p.Gender = Person.GenderEnum.Male;
		p.DOB = DateTime.Now.AddYears(-20);

        Person p2 = new();
        p2.FirstName = "Sue";
        p2.LastName = "Jones";
        p2.Gender = Person.GenderEnum.Female;
		p2.DOB = DateTime.Now.AddYears(-50);

		DisplayPerson(p);
		DisplayPerson(p2);
    }

	private void DisplayPerson(Person person) {
		DisplayValue(person.Description);
	}
	private void DisplayValue(string value) {
		DisplayLbl.Text = DisplayLbl.Text + Environment.NewLine + "--------" + Environment.NewLine + value;
	}

}

