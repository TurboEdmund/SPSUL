namespace Film
{
    public class Kino
    {
        private List<Film> filmy;

        public Kino(List<Film> filmy)
        {
            this.filmy = filmy;
        }

        public void ZobrazNabidku()
        {
            Console.WriteLine("Filmy:");
            foreach (Film film in filmy)
            {
                Console.WriteLine($"- {film.Name}, {film.Delka}h");
                Console.WriteLine($"-- Reziser: {film.Reziser.FirstName} {film.Reziser.LastName}");
                Console.WriteLine($"-- Zanry: {string.Join(", ", film.Zanry)}");
                Console.WriteLine("-- Herci:");
                foreach(Clovek herec in film.Herci)
                {
                    Console.WriteLine($"--- {herec.FirstName} {herec.LastName} {herec.Age}");
                }
            }
        }
    }
    public class Film
    {
        public string Name;
        public List<Clovek> Herci;
        public Clovek Reziser;
        public double Delka;
        public List<Zanr> Zanry;

        public Film(string name, List<Clovek> herci,Clovek reziser, double delka, List<Zanr> zanry)
        {
            this.Name = name;
            this.Herci = herci;
            this.Reziser = reziser;
            this.Delka = delka;
            this.Zanry = zanry;
        }
    }
    public class Clovek
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public Clovek(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
    public enum Zanr
    {
        Action,
        Comedy,
        Horror,
        Thriller,
        SciFi
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kino kino = new Kino(
                new List<Film>()
                {
                    new Film(
                        "Top Gun: Maverick",
                        new List<Clovek>()
                        {
                            new Clovek(
                                "Tom",
                                "Cruise",
                                62
                            ),
                            new Clovek(
                                "Miles",
                                "Teller",
                                37
                            )
                        },
                        new Clovek(
                            "Joseph",
                            "Kosinski",
                            50
                        ),
                        2.5,
                        new List<Zanr>()
                        {
                            Zanr.Action,
                            Zanr.Comedy
                        }
                    ),
                    new Film(
                        "Avatar: The Way of Water",
                        new List<Clovek>()
                        {
                            new Clovek(
                                "Sam",
                                "Worthington",
                                48
                            ),
                            new Clovek(
                                "Zoe",
                                "Saldana",
                                46
                            ),
                            new Clovek(
                                "Sigourney",
                                "Weaver",
                                75
                            )
                        },
                        new Clovek(
                            "James",
                            "Cameron",
                            70
                        ),
                        3.2,
                        new List<Zanr>()
                        {
                            Zanr.Action,
                            Zanr.SciFi
                        }
                    )
                }
            );
            kino.ZobrazNabidku();
        }
    }
}
