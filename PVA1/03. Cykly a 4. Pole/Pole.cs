namespace Ukazka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pole = new int[4]; // pole intů o velikosti 4
            Console.WriteLine(pole[0]); // k jednotlivým intům v poli přistoupíme přes hranaté závorky pole[index] - indexování začíná od 0 do velikost-1
            // pole[0] je nyní rovno 0, protože jsme vytvořili pole a do pole se dali defaultní hodnoty - string má prázný řetězec "", bool má false

            int[] poleDva = { 4, 5, 6, 8 }; // pole intů o velikost 4, které je již naplněno hodnotami
            int[] poleTri = new int[] { 4, 5 , 6, 8 }; // další zápis, který funguje stejně jako zápis nad

            // výpis pole
            Console.WriteLine(pole); // nefunkční, protože pole není primitivní datový typ (string, int, double, bool, ...)

            // musíme tak přistoupit k jednolivým intům, které už jsou primitvní datový typ a ty jednotlivě vypsat
            for (int i = 0; i < poleDva.Length; i++) // začínáme od 0 do velikost-1 (protože tam je < Lenght, tak je to stejné jako <= Lenghth-1)
            {
                Console.WriteLine(pole[i]); // i se nám postupně mění ve všechny indexy pole a tak každý cyklus postupně vypíšeme jednotlivé hodnoty - pole[0], pole[1], pole[2] a pole[3]
            }
        }
    }
}
