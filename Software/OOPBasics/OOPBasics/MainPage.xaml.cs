namespace OOPBasics;

public partial class MainPage : ContentPage
{
    Family family = new Family();
    public MainPage()
	{
		InitializeComponent();
        family.FamilyChanged += Family_FamilyChanged;
	}

    private void Family_FamilyChanged(object sender, EventArgs e)
    {
		DisplayValue(family.Description);
    }

    private void PersonBtn_Clicked(object sender, EventArgs e)
    {
		Person p = new();
		//p.FirstName = "John";
		p.LastName = "Smith";
		p.Gender = Person.GenderEnum.Male;

		//DisplayValue(p.FirstName.Length.ToString());

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

    private void FamilyBtn_Clicked(object sender, EventArgs e)
    {
		family.Father = new Person("Jones") { FirstName = "John", MiddleName = "Jack", Gender = Person.GenderEnum.Male, DOB = DateTime.Now.AddYears(-35)};
        family.Mother = new Person() { FirstName = "Sue", LastName = "Smith", Gender = Person.GenderEnum.Female, DOB = DateTime.Now.AddYears(-30) };
		family.AddChild(new Person() { FirstName = "Adam", LastName = "Smith", Gender = Person.GenderEnum.Male, Age = 1});
        family.AddChild(new Person() { FirstName = "Jane", LastName = "Smith", Gender = Person.GenderEnum.Female});
		family.AddPet(new Animal() { AnimalType = Animal.AnimalTypeEnum.Dog });
    }
}

