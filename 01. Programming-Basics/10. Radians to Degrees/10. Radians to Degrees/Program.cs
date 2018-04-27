using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var Radians = double.Parse(Console.ReadLine());
            var Degrees = 180 * Radians/ Math.PI;

            Console.WriteLine("Degrees=" + Math.Round(Degrees, 1));
        }
    }
}
