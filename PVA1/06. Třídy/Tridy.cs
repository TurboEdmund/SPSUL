namespace Tridy
{
    public class Person
    {
        public readonly string FirstName; // proměnná readonly lze pouze nastavit v konstruktoru, pak ji nelze změnit
        public string LastName; // public proměnné je PascalCase
        private int _age; // privátní proménně se píšou _camelCase
        private double _weight;

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this._age = 0;
        }
        public Person(string firstName, string lastName, double weight)
            : this(firstName, lastName)
        {
            this._weight = weight;
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"Hello, I am {this.FirstName} {this.LastName} and I am {this._age} years old and weigh {this._weight}kg.");
        }

        private void Walk()
        {
            // ... some code
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Jakub", "Doležal", 5);
            p.IntroduceYourself();
        }
    }
}


