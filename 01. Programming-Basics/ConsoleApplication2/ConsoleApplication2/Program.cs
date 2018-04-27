using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);

            Console.WriteLine(x);
        }
    }
}
