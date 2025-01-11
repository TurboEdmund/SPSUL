namespace Ukazka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // vytvořit prázdný list - 0 prvků
            List<int> list = new List<int>();

            // vytvořit list s hodnotami
            List<int> listDva = new List<int>() { 4, 5, 6, 7 };

            // výpis hodnot v listě
            for (int i = 0; i < listDva.Count; i++)
            {
                Console.WriteLine(listDva[i]);
            }
            foreach (int hodnota in listDva)
            {
                Console.WriteLine(hodnota);
            }

            // Vytvoření slovníku pro studenty a jejich známky
            Dictionary<string, List<int>> studenti = new Dictionary<string, List<int>>();

            // Přidání studentů se známkami
            studenti.Add("Jan Novák", new List<int> { 1, 2, 1 });
            studenti.Add("Petr Svoboda", new List<int> { 3, 2, 4 });
            studenti.Add("Eva Dvořáková", new List<int> { 1, 1, 1 });

            // Výpis všech studentů a jejich známek
            Console.WriteLine("\nSeznam studentů a jejich známek:");
            foreach (var pair in studenti)
            {
                Console.WriteLine($"Student: {pair.Key}");
                Console.WriteLine($"Známky: {string.Join(", ", pair.Value)}");
            }
        }
    }
}
