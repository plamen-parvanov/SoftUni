using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.MaxValue;
            var b = int.MaxValue;
            var c = 10;

            long d = (long)a * b / c;

            Console.WriteLine(d);
        }
    }
}
