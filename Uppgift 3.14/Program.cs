using System;
namespace Uppgift_3._16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Låten du anger måste vara minst 2 min och 45 sek, och max 4 min 20 sek");
            int tid = int.Parse(Console.ReadLine());
            if (tid >= 245 && tid <= 420)
            {
                Console.WriteLine("Din låt skickas nu till P3 Radio");
            }
            else
            {
                Console.WriteLine("Din låt uppphör inte kraven för att spelas upp");
            }
        }
    }
}