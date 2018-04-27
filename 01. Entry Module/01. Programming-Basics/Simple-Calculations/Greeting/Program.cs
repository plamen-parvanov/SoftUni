using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());

            int firstSideLength = Math.Abs(x2 - x1);
            int secondSideLength = Math.Abs(y2 - y1);

            Console.WriteLine(firstSideLength * secondSideLength);
            Console.WriteLine(2 * (firstSideLength + secondSideLength));

        }
    }
}
