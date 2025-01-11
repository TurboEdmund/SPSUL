namespace Ukazka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej číslo: ");
            int cislo = int.Parse(Console.ReadLine()); // uživatel zadá číslo

            if (cislo > 10) // cislo je v intervalu (∞, 10)
            {
                Console.WriteLine("Číslo je větší než 10");
            } else if (cislo > 5) // cislo je v intervalu (10, 5)
            {
                Console.WriteLine("Číslo je menší nebo rovno 10 a větší než 5");
            } else // cislo je v intervalu <5, -∞)
            {
                Console.WriteLine("Číslo je menší nebo rovno 5");
            }
        }
    }
}
