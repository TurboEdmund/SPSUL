namespace Ukazka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej číslo: ");
            try
            {
                int x = int.Parse(Console.ReadLine()); // pokud uživatel nezadá číslo, tak se vyvolá FormatException
                Console.WriteLine($"Zadal jsi číslo {x}"); // pokud řáde nad vyvolá výjimku, tento řádek se už neprovede
            }
            catch
            {
                Console.WriteLine("Nezadal jsi číslo!"); // tento řádek se provede pouze pokud uživatel nezadá číslo
            }
            finally
            {
                // Tento blok se provede vždy, i pokud došlo k výjimce
                Console.WriteLine("Děkujeme za použití programu.");
            }

            Console.WriteLine();

            Console.Write("Zadej číslo: ");
            try
            {
                int x = int.Parse(Console.ReadLine()); // pokud uživatel nezadá číslo, tak se vyvolá FormatException
                Console.WriteLine($"Zadal jsi číslo {x}"); // pokud řáde nad vyvolá výjimku, tento řádek se už neprovede
            }
            catch (Exception e)
            {
                Console.WriteLine($"Program selhal z důvodu: {e.Message}"); // můžeme si vypsat důvod, proč program selhal
            }
            finally
            {
                // Tento blok se provede vždy, i pokud došlo k výjimce
                Console.WriteLine("Děkujeme za použití programu.");
            }
        }
    }
}
