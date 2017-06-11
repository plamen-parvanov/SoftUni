using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var dayOrNight = Console.ReadLine();
            
            if (n >= 100)
                n = n * 0.06;

            else if (n >= 20)
                n = n * 0.09;

            else if (dayOrNight == "day")
                n = 0.70 + 0.79 * n;

            else if (dayOrNight == "night")
                n = 0.70 + 0.9 * n;

            Console.WriteLine(n);


        }
    }
}
