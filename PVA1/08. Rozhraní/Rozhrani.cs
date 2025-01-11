namespace Tridy
{
    public interface IVehicle
    {
        string Brand { get; } // jedná se o READONLY vlastnost
        string Color { get; set; } // vlastnost, kterou lze i měnit (má setter)
        void Drive(int kilometers); // metoda
    }

    public class Car : IVehicle
    {
        public string Brand { get; }

        public string Color { get; set; }

        public Car(string brand, string color)
        {
            this.Brand = brand;
            this.Color = color;
        }

        public void Drive(int kilometers)
        {
            Console.WriteLine($"Drive with steering wheel {kilometers}km.");
        }
    }
    public class Motorcycle : IVehicle
    {
        public string Brand { get; }

        public string Color { get; set; }

        public Motorcycle(string brand, string color)
        {
            this.Brand = brand;
            this.Color = color;
        }

        public void Drive(int kilometers)
        {
            Console.WriteLine($"Drive with handlebars {kilometers}km.");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            IVehicle vehicle = new Car("Skoda", "blue");
            vehicle.Drive(15);

            vehicle = new Motorcycle("Ducati", "red");
            vehicle.Drive(10);
        }
    }
}


