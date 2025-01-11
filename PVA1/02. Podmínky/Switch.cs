namespace Ukazka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej hlavní město ČR: ");
            string mesto = Console.ReadLine(); // uživatel zadá město

            switch (mesto) // do switche vstupuje hodnota, která je následně porovnáváná - switch funguje na bázi rovnosti (==)
            {
                case "Praha":
                    Console.WriteLine("Správná odpověď!");
                    break;
                case "Brno":
                case "Ostrava":
                case "Plzeň":
                    Console.WriteLine("Jsi blízko, toto město je velké, ale není hlavním městem ČR");
                    // jelikož u Brna, Ostavy a Plzně bude stejná odpověď, napíšeme je za sebe a dáme jim stejnou odpověď - nebudeme zbytečně psát pro každé město svůj vlastní case, odpověď a break
                    break;
                case "Ústí nad Labem":
                    Console.WriteLine("To si děláš srandu ne? tohle určitě není hlavní město");
                    break;
                default:
                    Console.WriteLine("Špatná odpověď");
                    // default je takový ELSE ve switche, pokud žádná z možností není splněna, vykoná se default
                    break;
            }
        }
    }
}
