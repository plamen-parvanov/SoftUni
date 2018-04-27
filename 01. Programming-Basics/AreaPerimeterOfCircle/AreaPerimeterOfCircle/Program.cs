using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaPerimeterOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

             var sideX = Math.Abs(x2 - x1);
             var sideY = Math.Abs(y2 - y1);

              var Area = sideX * sideY ;
              var Perimeter = 2 * (sideX + sideY) ;

            Console.WriteLine(Area);
            Console.WriteLine(Perimeter);
        }
    }
}
