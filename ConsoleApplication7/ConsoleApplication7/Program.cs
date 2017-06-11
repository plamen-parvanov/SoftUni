using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            var hh = int.Parse(Console.ReadLine());
            var mm = int.Parse(Console.ReadLine());

            var totalMinutes = 60 * hh + mm +15;

            int hours = totalMinutes / 60;
            if (hours == 24)
                hours = 0;
            var minutes = totalMinutes - hours * 60;

            Console.WriteLine("{0:00}:{0:00}",
                hours, minutes);
        }
    }
}
