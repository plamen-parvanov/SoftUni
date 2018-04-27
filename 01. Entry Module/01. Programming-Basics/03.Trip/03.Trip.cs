using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");

                if (season == "summer")
               
                    Console.WriteLine("Camp - {0:F2}", Math.Round((0.3 * budget), 2));
               
                else

                    Console.WriteLine("Hotel - {0:F2}", Math.Round((0.7 * budget), 2));

            }

            else if (budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");

                if (season == "summer")

                    Console.WriteLine("Camp - {0:F2}", Math.Round((0.4 * budget), 2));

                else

                    Console.WriteLine("Hotel - {0:F2}", Math.Round((0.8 * budget), 2));
            }

            else
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:F2}", Math.Round((0.9 * budget), 2));
            }     
        }
    }
}
