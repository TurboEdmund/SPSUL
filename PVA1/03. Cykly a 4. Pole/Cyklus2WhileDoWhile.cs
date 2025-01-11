namespace Ukazka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // využití while cyklus stejně jako for-cyklu
            // Výpis čísel od 1 do 10
            int index = 1;
            while (index <= 10)
            {
                Console.WriteLine(index);
                index++;
            }

            Console.WriteLine();

            // zadej číslo větší než 15 - nemá pevný počet opakování, protože nevíme, kdy uživatel zadá správnou hodnotu (for-cyklus má pevný počet opakovaní)
            bool run = true;
            while (run)
            {
                Console.Write("Zadej číslo, které bude větší než 15: ");
                int cislo = int.Parse(Console.ReadLine());

                if (cislo == 15)
                {
                    Console.WriteLine("Zadal jsi 15, ale máš zadat číslo, které je větší než 15.");
                } else if (cislo > 15)
                {
                    Console.WriteLine($"Správně, číslo {cislo} je větší než 15.");
                    run = false; // vypnutí cyklu - podmínka už není true, takže další iterace neproběhne
                } else
                {
                    Console.WriteLine($"Číslo {cislo} je menší než 15.");
                }
            }

            // rozdíl mezi while a do-while je kdy se "ptáme" na to, jestli se má cyklus opakovat nebo ne
            // while se nejdříve zeptá a pak provede "Mám se provést? ano, provede se a následně "mám se provést?...
            // do-while se provede a zeptá "mám se provést? ano, provede se, mám se provést?...
            // do-while se tak provede vždycky aspoň jednou, while se nemusí provést ani jednou

            bool running = true;

            do
            {
                running = false;
            } while (running);

            // rozdíl v praxi

            bool runLoop = false;

            while (runLoop)
            {
                // neprovede se ani jednou, proto6e je runLoop false
            }

            do
            {
                // provede se pouze jednou, protože se ptá až po provedení, ne před provedením jako while
            } while (runLoop);

        }
    }
}
