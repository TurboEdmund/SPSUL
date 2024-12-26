namespace KamenNuzkyPapir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool pokracovat = true;

            Console.ForegroundColor = ConsoleColor.Red; // Nastaví barvu Fontu v Consoli na červenou
            Console.WriteLine("Vítejte ve hře \"Kámen, nůžky, papír\"!\r");
            Console.WriteLine("-----------------------------------------");
            Console.ResetColor(); // vyresetuje barvu fontu na default

            while (pokracovat)
            {
                int uzivatel = ZiskatVyberUzivatele();

                if (uzivatel > 0 && uzivatel < 4)
                {
                    int pocitac = GenerovatVyberPocitace();

                    Console.WriteLine($"Zvolils: {ZobrazVyber(uzivatel)}");
                    Console.WriteLine($"Počítač zvolil: {ZobrazVyber(pocitac)}");
                    Console.WriteLine(VyhodnotitVysledek(uzivatel, pocitac));
                    Console.ResetColor();
                }
                else if (uzivatel == 4)
                {
                    pokracovat = false;
                    Console.WriteLine("Děkujeme za hru!");
                } else
                {
                    Console.WriteLine("Neplatná volba. Zkuste to znovu.");
                }
            }
        }

        static int ZiskatVyberUzivatele()
        {
            Console.WriteLine("1. Kámen");
            Console.WriteLine("2. Nůžky");
            Console.WriteLine("3. Papír");
            Console.WriteLine("4. Ukončit hru");
            int volba = 0;
            bool run = true;

            while(run)
            {
                try
                {
                    Console.Write("Zadejte svou volbu: ");
                    volba = int.Parse(Console.ReadLine());
                    run = false;
                } catch
                {
                    Console.WriteLine("Zadej platné číslo");
                }
            }
            return volba;
        }
        static int GenerovatVyberPocitace()
        {
            Random random = new Random();
            return random.Next(1, 4); // Náhodné číslo 1, 2 nebo 3.
        }
        static string VyhodnotitVysledek(int uzivatel, int pocitac)
        {
            if (uzivatel == pocitac)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                return "Remíza! Oba zvolili stejnou možnost.";
            } else if (
                (uzivatel == 1 && pocitac == 2) ||  // Kámen poráží nůžky.
                (uzivatel == 2 && pocitac == 3) ||  // Nůžky poráží papír.
                (uzivatel == 3 && pocitac == 1)     // Papír poráží kámen.
                )    
            {
                Console.ForegroundColor = ConsoleColor.Green;
                return "Vyhrál jsi!";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return "Počítač vyhrál!";
            }
        }
        static string ZobrazVyber(int volba)
        {
            if (volba == 1)
            {
                return "Kámen";
            } else if (volba == 2)
            {
                return "Nůžky";
            } else if (volba == 3)
            {
                return "Papír";
            } else
            {
                return "Neznámá volba";
            }
        }

    }
}
