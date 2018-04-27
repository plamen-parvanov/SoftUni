using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            GetSquared(num);
        }
        static void GetSquared(double number)
        {
            var result = number * number;
            Console.WriteLine(result);
        }
    }
}
