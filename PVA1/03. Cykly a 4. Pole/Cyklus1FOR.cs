namespace Ukazka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Výpis čísel od 1 do 10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            // Součet čísel od 1 do 9
            int soucet = 0;
            for (int i = 1; i < 10; i++)
            {
                soucet += i;
            }
            Console.WriteLine($"Součet čísel od 1 do 9 je {soucet}");

            Console.WriteLine();

            // Vypsat všechny sudé čísla od 1 do 18
            Console.Write("Sudá čísla od 1 do 18: ");
            for (int i = 1; i <= 18; i++)
            {
                if (i % 2 == 0) // pokud vydělím i číslem 2 a zbude 0, tak je sudé
                {
                    Console.Write($"{i}, ");
                }
            }
        }
    }
}
