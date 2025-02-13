namespace Film
{
    public class Obchod
    {
        private List<Album> _nabidka;

        public Obchod(List<Album> nabidka)
        {
            this._nabidka = nabidka;
        }

        public void ZobrazNabidku()
        {
            Console.WriteLine("Nabidka:");
            foreach (Album album in _nabidka)
            {
                Console.WriteLine($"- {album.Interpret.Nazev} - {album.Name} - {album.Zanr}");
                foreach(Skladba skladba in album.Skladby)
                {
                    Console.WriteLine($"-- {skladba.Name} ({skladba.Delka}m)");
                }
            }
        }
    }
    public enum Zanr
    {
        Pop,
        Rock,
        SynthPop
    }
    public class Album
    {
        public string Name;
        public Interpret Interpret;
        public List<Skladba> Skladby;
        public Zanr Zanr;

        public Album(string name, Interpret interpret, List<Skladba> skladby, Zanr zanr)
        {
            Name = name;
            Interpret = interpret;
            Skladby = skladby;
            Zanr = zanr;
        }
    }
    public class Interpret
    {
        public string Nazev;

        public Interpret(string nazev)
        {
            this.Nazev = nazev;
        }
    } 
    public class Skladba
    {
        public string Name;
        public double Delka;

        public Skladba(string name, double delka)
        {
            Name = name;
            Delka = delka;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Obchod o = new Obchod(
                new List<Album>()
                {
                    new Album(
                        "Memento Mori",
                        new Interpret("Depeche Mode"),
                        new List<Skladba>()
                        {
                            new Skladba("My Cosmos Is Mine", 5.16),
                            new Skladba("Ghosts Again", 3.9)
                        },
                        Zanr.SynthPop
                    ),
                    new Album(
                        "Back In Black",
                        new Interpret("AC/DC"),
                        new List<Skladba>()
                        {
                            new Skladba("Hells Bells", 5.1),
                            new Skladba("Back In Black", 4.2)
                        },
                        Zanr.Rock
                    )
                } 
            );
            o.ZobrazNabidku();
        }
    }
}
