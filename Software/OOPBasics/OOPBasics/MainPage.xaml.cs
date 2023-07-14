namespace OOPBasics;

public partial class MainPage : ContentPage
{
    Family family = new Family();
	Person person = new Person();
	Animal animal = new();
	Alien alien = new();
    public MainPage()
	{
		InitializeComponent();
        family.FamilyChanged += Family_FamilyChanged;
		person.FirstName = "Amy";
		this.BindingContext = person;
		AnimalLbl.BindingContext = animal;
		AlienLbl.BindingContext = alien;
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
		DisplayPopulation();
	}

	private void DisplayPopulation() {
		StaticLbl.Text = "Population: " + Person.Population;
	}
    private void FamilyBtn_Clicked(object sender, EventArgs e)
    {
		family.Father = new Person("Jones") { FirstName = "John", MiddleName = "Jack", Gender = Person.GenderEnum.Male, DOB = DateTime.Now.AddYears(-35)};
        family.Mother = new Person() { FirstName = "Sue", LastName = "Smith", Gender = Person.GenderEnum.Female, DOB = DateTime.Now.AddYears(-30) };
		family.AddChild(new Person() { FirstName = "Adam", LastName = "Smith", Gender = Person.GenderEnum.Male, Age = 1});
        family.AddChild(new Person() { FirstName = "Jane", LastName = "Smith", Gender = Person.GenderEnum.Female});
		family.AddPet(new Animal() { AnimalType = Animal.AnimalTypeEnum.Dog });
    }

    private void BindBtn_Clicked(object sender, EventArgs e)
    {
		person.FirstName = "John" + DateTime.Now.Millisecond;
		person.LastName = "Smith" + DateTime.Now.Millisecond;
		animal.Age = 3;
		animal.Gender = Animal.GenderEnum.Female;
		animal.AnimalType = animal.AnimalType == Animal.AnimalTypeEnum.Cat ? Animal.AnimalTypeEnum.Dog : Animal.AnimalTypeEnum.Cat;

		alien.Age = 200;
		alien.Planet = alien.Planet == Alien.PlanetEnum.Mars ? Alien.PlanetEnum.Venus : Alien.PlanetEnum.Mars;
    }

    private void InheritanceBtn_Clicked(object sender, EventArgs e)
    {
		Animal a = new();
		a.AnimalType = Animal.AnimalTypeEnum.Cat;
		a.Gender = Animal.GenderEnum.Female;
		a.Age = 3;
		DisplayLbl.Text = "";
		DisplayValue(a.Description);

		Alien i = new();
		i.Planet = Alien.PlanetEnum.Venus;
		i.Gender = Alien.GenderEnum.Male;
		i.Age = 400;
		DisplayValue(i.Description);
    }

    private void RefectionBtn_Clicked(object sender, EventArgs e)
    {
		Creature<Animal> c = new();
		//c = new Person() {LastName= "Jones", Gender = Creature.GenderEnum.Female, Age = 10 };
		c = new Animal() { Age = 5, AnimalType = Animal.AnimalTypeEnum.Cat };
		DisplayLbl.Text = "";
		DisplayValue(c.ReflectionInfo);


    }

    private void GenericsBtn_Clicked(object sender, EventArgs e)
    {
		DisplayLbl.Text = "";
		var a = new Animal() { Age = 5, AnimalType = Animal.AnimalTypeEnum.Cat };

		a.Children.Add(new Animal() { AnimalType = Animal.AnimalTypeEnum.Cat });
        a.Children.Add(new Animal() { AnimalType = Animal.AnimalTypeEnum.Dog });
		a.AddChild();
		a.AddChild();

        a.Children.ForEach(c => {
			DisplayValue(a.GetType().Name + " " + c.AnimalType.ToString());
		});

  //      var p  = new Person() { LastName = "Jones", Gender = Person.GenderEnum.Female, Age = 10 };
		//p.Children.Add(new Person());
		

    }
}

