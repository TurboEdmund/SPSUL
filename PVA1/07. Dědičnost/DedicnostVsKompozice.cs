namespace Tridy
{
    public class Savec
    {
        public Savec() { }

        public void Dychat()
        {
            Console.WriteLine("Dýchám plícemi");
        }
    }
    public class Pes : Savec
    {
        public void Stekat()
        {
            Console.WriteLine("haf haf");
        }
    }

    public class Motor
    {
        public void Startuj()
        {
            Console.WriteLine("Motor nastartován.");
        }
    }

    public class Auto
    {
        private Motor _motor;

        public Auto(Motor motor)
        {
            _motor = motor;
        }

        public void StartujAuto()
        {
            _motor.Startuj();
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            // Dědičnost
            Pes pes = new Pes();
            pes.Dychat();
            pes.Stekat();

            // Kompozice
            Motor motor = new Motor();
            Auto auto = new Auto(motor);
            auto.StartujAuto(); // Auto používá Motor
        }
    }
}


