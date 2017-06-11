using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var z = int.Parse(Console.ReadLine());
            var w = int.Parse(Console.ReadLine());

            var totalGrapes = x * y;
            var wine = 0.4 * totalGrapes / 2.5;

            if (wine > z)
            {
                var moreWine = wine - z;
                var winePerPerson = moreWine / w;

                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(moreWine),
                    Math.Ceiling(winePerPerson));
            }

            else
            {
                var lessWine = z - wine;

                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",
                    Math.Floor(lessWine));
            } 


        }
    }
}
