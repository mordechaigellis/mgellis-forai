using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace OOPBasics
{
    public class Person : Creature<Person>
    {
        private string _middlname = "";
        private string _firstname = "";
        private string _lastname = "";
       
        public event EventHandler? PersonAdded;


        public Person() { }
        public Person(string lastnamevalue = "")
        {
            Population++;
            this.DOB = DateTime.Now;
            this.LastName = lastnamevalue;
            PersonAdded?.Invoke(this, new EventArgs());
        }

        public static int Population { get; private set; }

        public string FirstName { get => _firstname;
            set {
                _firstname = value;
                InvokePropertyChanged();
                InvokePropertyChanged("Description");
            } 
        }
        public string LastName { get => _lastname;
            set {
                _lastname = value;
                InvokePropertyChanged();
                InvokePropertyChanged("Description");
            } }
        public string MiddleName
        {
            get { return _middlname; }
            set { _middlname = value; }
        }

        public string Description
        {
            get
            {
                string desc = $"{this.FirstName} {this.MiddleName} {this.LastName} {this.Gender.ToString()} {this.Age} years old";

                return desc;
            }
        }
    }
}
