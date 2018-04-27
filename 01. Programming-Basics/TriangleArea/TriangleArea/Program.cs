using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var side = double.Parse(Console.ReadLine());
            var heigth = double.Parse(Console.ReadLine());

            var Area = side * heigth / 2 ;

            Console.WriteLine($"Triangle area = { Math.Round(Area, 2)}");
        }
    }
}
