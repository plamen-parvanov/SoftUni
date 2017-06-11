using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var point = int.Parse(Console.ReadLine());

            if (first >= point && point >= second ||
                second >= point && point >= first)
            {
                Console.WriteLine("in");
            }

            else
            {
                Console.WriteLine("out");
            }

            var firstMinusPoint = Math.Abs(first - point);
            var secondMinusPoint = Math.Abs(second - point);

            if (firstMinusPoint >= secondMinusPoint)
            {
                Console.WriteLine(secondMinusPoint);
            }

            else
            {
                Console.WriteLine(firstMinusPoint);
            }
        }
    }
}
