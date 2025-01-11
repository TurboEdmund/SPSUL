namespace Ukazka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadPerson("Pepa", "Novák", 13); // nic nevrací - void
            int x = 5;
            int y = 10;
            double vysledek = Soucet(x, y); // vrací double

            // Přetížení funkcí - funkce může mít stejný název, ale musí mít jiné parametry - základně funkce zdraví česky, ale je také možnost vložit vlastní pozdrav jako parametr
            Pozdrav();
            Pozdrav("Hello!");
            Pozdrav("Ola!");

            Console.WriteLine();

            int[] poleJedna = { 4, 8, 12, 13, 5, 1};
            int[] poleDva = { 32, 1, 8};

            // díky funkcím, nemusíme psát dvakrát cyklus pro výpis prvního a následně druhého pole - neopakuje se kód
            VypisPole(poleJedna);
            Console.WriteLine();
            VypisPole(poleDva);

            Console.WriteLine();


            // upravování parametrů
            string jmeno = "Bára";
            Console.WriteLine($"Před funkcí {jmeno}");
            ZmenaJmena(jmeno);
            Console.WriteLine($"Výsledek {jmeno}"); // jméno se nezměnilo, protože do funkce se posílá pouze kopie hodnoty, tímto způsobem nelze měnit proměnné, kterou jsou jako parametr funkce

            Console.WriteLine();

            Console.WriteLine($"Před funkcí {jmeno}");
            ZmenaJmenaFunkcni(ref jmeno); // musíme použít REF, které z parametru udělá referenci, kterou následně lze změnit
            Console.WriteLine($"Výsledek {jmeno}");

        }

        // funkce je void (nic nevrací) a má 3 parametry
        static void ReadPerson(string firstname, string lastname, int age)
        {
            Console.WriteLine(firstname + " " + lastname + age);
        }

        // funkce vrací double
        static double Soucet(int i, int j)
        {
            return i + j;
        }

        static void Pozdrav()
        {
            Console.WriteLine("Ahoj");
        }

        static void Pozdrav(string pozdrav)
        {
            Console.WriteLine(pozdrav);
        }

        static void VypisPole(int[] pole)
        {
            for(int i = 0; i < pole.Length; i++)
            {
                Console.WriteLine(pole[i]);
            }
        }
        static void ZmenaJmena(string jmeno)
        {
            Console.WriteLine(jmeno);
            jmeno = "Klára";
            Console.WriteLine(jmeno);
        }
        static void ZmenaJmenaFunkcni(ref string jmeno)
        {
            Console.WriteLine(jmeno);
            jmeno = "Jana";
            Console.WriteLine(jmeno);
        }
    }
}
