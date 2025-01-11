namespace Ukazka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x; // deklarace
            x = 2; // inicializace

            int y = 4; // deklarace a inicializace

            // číselné
            int z = 5;
            double d = 5.4;

            // operace s čísly
            Console.WriteLine(z); // výpis
            int vysledek = z + x; // součet
            Console.WriteLine(vysledek);
            vysledek = z - x;
            Console.WriteLine(vysledek);
            vysledek = z * x;
            Console.WriteLine(vysledek);
            vysledek = z / x; // tady vznikne problém, protože int je celočíslený a 5/2 se nerovná celému číslu a zaokrouhlí se na 2 = pro přesný výsledek použijeme neceločíselný double
            Console.WriteLine(vysledek);
            double deleni = (double) z / x; // jelikož se ale jedná o inty, musíme před ně dát ještě (double) - pokud víme, že budeme dělit, je zkrátka lepší pracovat rovnou s double, takže změnit z a x na double pro lepší počítání
            Console.WriteLine(deleni);

            vysledek = z % x; // % - module slouží k tomu, že získáme kolik nám zbude po dělení, takže 5 / 2 nám zbude 1 - můžeme to použít například k zjištění jestli je to sudé číslo nebo ne - sudé číslo má po dělení dvojkou vždycky zbytek 0, liché pak 1
            Console.WriteLine(vysledek);

            // řetězce
            string s = "Ahoj, jak se máš?";
            char c = 'a';

            // operace se řetězci
            string r = "Haha, jojo.";

            Console.WriteLine(s + r); // tzv. zřetězení - spojení dvou řetězců k sobě

            int cisloJedna = 4;
            int cisloDva = 5;
            Console.WriteLine("Vysledek souctu je " + cisloJedna + cisloDva); // stejně jako v matice jdeme zleva a jelikož zleva je string, tak se + chová jako zřetězení, protože to píše výsledek 45
            Console.WriteLine("Vysledek souctu je " + (cisloJedna + cisloDva)); // stejně jako v matice, tak závorky mají přednost a stejně tak vyřešíme tento problém, nyní je výsledek 9

            string veta = "Ahoj, jak se máš? já celkem dobře";
            // string má spoustu vlastností a funkcí, např:
            Console.WriteLine(veta.Length); // velikost řetězce (počet znaků, včetně mezer)
            Console.WriteLine(veta.ToLower()); // funkce ToLower() vrátí stejný řetězec, jen bude mít všechny písmena z abecedy v malém casu
            Console.WriteLine(veta.ToUpper()); // funkce ToUpper() vrátí stejný řetězec, jen bude mít všechny písmena z abecedy ve velkém casu
            Console.WriteLine(veta.Contains("já")); // funkce Contains(string value) vrací jestli se v řetězci nachází value nebo ne - bool - true/false

            // logické
            bool b = true;
            bool p = false;
        }
    }
}
