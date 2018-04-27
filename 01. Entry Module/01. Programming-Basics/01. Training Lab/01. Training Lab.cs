using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());

            
              
                var row = Math.Floor(h * 100d / 120d);
                var deskPerRow = Math.Floor((w - 1d) / 0.7);
                var number = row * deskPerRow - 3d;
            Console.WriteLine(number);
              

            
        }
    }
}
