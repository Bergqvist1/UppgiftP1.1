using System;
namespace Uppgift_P_1_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Random lyckohjultal = new Random();

            Console.WriteLine("Välkommen till lyckohjulet, skriv in ett heltal mellan 1 - 10");
            Console.WriteLine("Om ditt tal stämmer över med lyckohjulets tal vinner du");
            Console.WriteLine("Skriv ditt tal här under:");

            int dittTal = int.Parse(Console.ReadLine());

            int lyckohjultal1 = lyckohjultal.Next(11);

            Console.WriteLine("Du valde" + " " + dittTal);
            Console.WriteLine("Datorn valde" + " " + lyckohjultal1);

            if( dittTal == lyckohjultal1)
            {
                Console.WriteLine(lyckohjultal1);
                Console.WriteLine("Du valde samma tal som datorn, grattis du har vunnit");
            }

            else
            {
                Console.WriteLine("Tyvärr du valde inte samma tal som datorn, du har förlorat ");
            }

            Console.WriteLine("Tryck på valfri knapp för att avsluta programmet");
            Console.ReadKey();
        }
    }
}
