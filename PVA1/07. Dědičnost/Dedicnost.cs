namespace Tridy
{
    public class Zamestnanec
    {
        public string Jmeno;
        public string Pozice;

        public Zamestnanec(string jmeno, string pozice)
        {
            Jmeno = jmeno;
            Pozice = pozice;
        }

        // Virtuální metoda, kterou lze přepsat v potomcích
        public virtual void Pracuj()
        {
            Console.WriteLine($"{Jmeno} pracuje na obecných úkolech.");
        }

        // Metoda není virtual, takže ji potomoci pouze zdědí, ale nemůžou ji změnit
        public void Info()
        {
            Console.WriteLine($"Jméno: {Jmeno}, Pozice: {Pozice}");
        }
    }

    public class Programator : Zamestnanec
    {
        public string ProgramovaciJazyk;

        public Programator(string jmeno, string jazyk) : base(jmeno, "Programátor") // : base(jmeno, "Programátor") volá konstruktor předka
        {
            ProgramovaciJazyk = jazyk;
        }

        // Přepis metody Pracuj
        public override void Pracuj()
        {
            Console.WriteLine($"{Jmeno} píše kód v jazyce {ProgramovaciJazyk}.");
        }
    }

    public class Manager : Zamestnanec
    {
        public int PocetPodrizenych;

        public Manager(string jmeno, int pocetPodrizenych) : base(jmeno, "Manažer") // : base(jmeno, "Manažer") volá konstruktor předka
        {
            PocetPodrizenych = pocetPodrizenych;
        }

        // Přepis metody Pracuj a použití base pro volání původní metody
        public override void Pracuj()
        {
            base.Pracuj(); // zavolá se metoda Pracuj z rodiče
            Console.WriteLine($"{Jmeno} také řídí tým o {PocetPodrizenych} lidech.");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Zamestnanec zamestnanec = new Zamestnanec("Jan Novák", "Asistent");
            Programator programator = new Programator("Petr Dvořák", "C#");
            Manager manager = new Manager("Eva Svobodová", 5);

            // Ukázka obecných informací
            zamestnanec.Info();
            programator.Info();
            manager.Info();

            Console.WriteLine();

            // Ukázka přepisu a volání metod
            zamestnanec.Pracuj();
            programator.Pracuj();
            manager.Pracuj();
        }
    }
}


