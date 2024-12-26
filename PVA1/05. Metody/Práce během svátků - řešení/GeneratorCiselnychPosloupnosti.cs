namespace GeneratorCiselnychPosloupnosti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool pokracovat = true;
            Console.ForegroundColor = ConsoleColor.Red; // Nastaví barvu Fontu v Consoli na červenou
            Console.WriteLine("Vítejte v generátoru číselných posloupností!");
            Console.WriteLine("-----------------------------------------");
            Console.ResetColor(); // vyresetuje barvu fontu na default
            while (pokracovat)
            {
                Console.WriteLine("1. Generovat sudá čísla");
                Console.WriteLine("2. Generovat lichá čísla");
                Console.WriteLine("3. Generovat Fibonacciho posloupnost");
                Console.WriteLine("4. Ukončit program");
                Console.Write("Zadejte svou volbu: ");

                /*
                 * int.TryParse(Console.ReadLine(), out volba) je alternativní způsob jak zjistit, jestli uživatel zadal číslo
                 * nebo ne. Tato funkce vrací bool - true/Jedná se o číslo - false/není to číslo
                 * zároven také pomocí OUT vrátí číselnou hodnotu do proměnné volba (pouze v případě, pokud se jedná o číslo)
                 */
                int volba;
                if (int.TryParse(Console.ReadLine(), out volba))
                {
                    if (volba >= 1 && volba <= 3)
                    {
                        Console.Write("Zadejte počet čísel: ");
                        int pocet;
                        if (int.TryParse(Console.ReadLine(), out pocet) && pocet > 0) // funkce zase vrátí true/false, ale tady výsledné číslo dáme do proměnné pocet
                        {
                            List<int> posloupnost = new List<int>();
                            switch (volba)
                            {
                                case 1:
                                    posloupnost = GenerovatSudaCisla(pocet);
                                    break;
                                case 2:
                                    posloupnost = GenerovatLichaCisla(pocet);
                                    break;
                                case 3:
                                    posloupnost = GenerovatFibonacci(pocet);
                                    break;
                            }
                            Console.WriteLine("Výsledek: " + string.Join(", ", posloupnost));
                            /*
                             * funkce string.join(separator, IEnumarable) - pracuje tak, že ji zadáte:
                             * 1. separátor mezi hodnotami
                             * 2. List hodnot (IEnumarable - něco, co má nějakou posloupnost hodnot, například List)
                             * tato funkce pak následně vypíše hodnoty a dá mezi ně vámi specifikovaný separátor
                             * - takže například string.Join(", ", new List<int>() {3, 5, 5}) vypíše
                             * 3, 5, 5
                             */
                        }
                        else
                        {
                            Console.WriteLine("Chyba: Počet čísel musí být kladné číslo.");
                        }
                    }
                    else if (volba == 4)
                    {
                        pokracovat = false;
                        Console.WriteLine("Děkujeme za použití generátoru!");
                    }
                    else
                    {
                        Console.WriteLine("Neplatná volba. Zkuste to znovu.");
                    }
                }
                else
                {
                    Console.WriteLine("Chyba: Zadejte platné číslo.");
                }
            }
        }

        static List<int> GenerovatSudaCisla(int pocet) // funkce GenerovatSudaCisla vrací List intů a vstupuje do ní int počet
        {
            List<int> posloupnost = new List<int>();
            /* 
             * Vytvoření prázdného Listu intů - List je neprimitivní datový typ
             * Narozdíl od POLE, List nemá pevnou velikost - něco jako seznam, můžeme přidávat nebo odebírat
             */
                            for (int i = 0; i < pocet; i++)
            {
                posloupnost.Add(i * 2); // funkce add přidá do listu další hodnotu
            }
            return posloupnost;
        }
        static List<int> GenerovatLichaCisla(int pocet)
        {
            List<int> posloupnost = new List<int>();
            /* 
             * Vytvoření prázdného Listu intů - List je neprimitivní datový typ
             * Narozdíl od POLE, List nemá pevnou velikost - něco jako seznam, můžeme přidávat nebo odebírat
             */
            for (int i = 0; i < pocet; i++)
            {
                posloupnost.Add(i * 2 + 1);
            }
            return posloupnost;
        }
        static List<int> GenerovatFibonacci(int pocet)
        {
            List<int> posloupnost = new List<int>();
            /* 
             * Vytvoření prázdného Listu intů - List je neprimitivní datový typ
             * Narozdíl od POLE, List nemá pevnou velikost - něco jako seznam, můžeme přidávat nebo odebírat
             */
            if (pocet > 0) posloupnost.Add(0);
            if (pocet > 1) posloupnost.Add(1);

            for (int i = 2; i < pocet; i++)
            {
                int noveCislo = posloupnost[i - 1] + posloupnost[i - 2];
                posloupnost.Add(noveCislo);
            }
            return posloupnost;
        }

    }
}
