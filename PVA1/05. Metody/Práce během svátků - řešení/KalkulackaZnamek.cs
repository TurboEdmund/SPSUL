namespace Znamky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<int> znamky = new List<int>();
            /* 
             * Vytvoření prázdného Listu intů - List je neprimitivní datový typ
             * Narozdíl od POLE, List nemá pevnou velikost - něco jako seznam, můžeme přidávat nebo odebírat
             */

            bool pokracovat = true;
            Console.ForegroundColor = ConsoleColor.Red; // Nastaví barvu Fontu v Consoli na červenou
            Console.WriteLine("Vítejte v kalkulátoru průměrných známek!");
            Console.WriteLine("-----------------------------------------");
            Console.ResetColor(); // vyresetuje barvu fontu na default
            while (pokracovat)
            {
                Console.WriteLine("1. Přidat známku");
                Console.WriteLine("2. Zobrazit všechny známky");
                Console.WriteLine("3. Vypočítat průměr");
                Console.WriteLine("4. Vyhodnotit výsledek");
                Console.WriteLine("5. Ukončit program");
                Console.Write("Zadejte svou volbu: ");

                int volba = ParseOutput("Zadejte svou volbu: ", "Chyba: Zadejte platné číslo.");
                switch (volba)
                {
                    case 1:
                        int znamka = ParseOutput("Zadejte známku (1–5): ", "Chyba: Zadejte platné číslo.");
                        PridatZnamku(znamky, znamka);
                        break;
                    case 2:
                        ZobrazZnamky(znamky);
                        break;
                    case 3:
                        VypocitejPrumer(znamky);
                        break;
                    case 4:
                        VyhodnotitVysledek(znamky);
                        break;
                    case 5:
                        pokracovat = false;
                        Console.WriteLine("Děkujeme, že jste použili kalkulátor!");
                        break;
                    default:
                        Console.WriteLine("Neplatná volba. Zkuste to znovu.");
                        break;
                }
            }
        }

        static int ParseOutput(string question, string mistakeMessage)
        {
            int result = 0;
            bool run = true;
            while (run)
            {
                Console.Write(question);
                try
                {
                    result = int.Parse(Console.ReadLine());
                    run = false;
                } catch
                {
                    Console.WriteLine(mistakeMessage);
                }
            }
            return result;
        }

        static void PridatZnamku(List<int> znamky, int znamka)
        {
            if (znamka >= 1 && znamka <= 5)
            {
                znamky.Add(znamka);
                Console.WriteLine($"Známka {znamka} byla přidána.");
            }
            else
            {
                Console.WriteLine("Chyba: Známka musí být mezi 1 a 5.");
            }
        }

        static void ZobrazZnamky(List<int> znamky)
        {
            if (znamky.Count == 0)
            {
                Console.WriteLine("Zatím nebyly zadány žádné známky.");
            }
            else
            {
                Console.WriteLine("Vaše známky: " + string.Join(", ", znamky));
            }
        }
        static double VypocitejPrumer(List<int> znamky)
        {
            if (znamky.Count == 0)
            {
                Console.WriteLine("Zatím nebyly zadány žádné známky.");
                return 0;
            }
            double prumer = znamky.Average();
            Console.WriteLine($"Průměrná známka je: {prumer:F2}"); // {prumer:F2} to F2 zaokrouhluje číslo na 2 místa
            return prumer;
        }

        static void VyhodnotitVysledek(List<int> znamky)
        {
            if (znamky.Count == 0)
            {
                Console.WriteLine("Zatím nebyly zadány žádné známky.");
                return;
            }
            double prumer = VypocitejPrumer(znamky);
            if (prumer <= 4.0)
            {
                Console.WriteLine("Výsledek: Student prospěl.");
            }
            else
            {
                Console.WriteLine("Výsledek: Student neprospěl.");
            }
        }

    }
}
