using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            var USD = double.Parse(Console.ReadLine());
            var BGN = 1.79549 * USD;

            Console.WriteLine(Math.Round(BGN, 2) + " BGN");
        }
    }
}
