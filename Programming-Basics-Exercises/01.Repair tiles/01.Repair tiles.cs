using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Repair_tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = double.Parse(Console.ReadLine());
            var W = double.Parse(Console.ReadLine());
            var L = double.Parse(Console.ReadLine());
            var M = double.Parse(Console.ReadLine());
            var O = double.Parse(Console.ReadLine());

            var SplGround = N * N;
            var Stiles = W * L;
            var Sbench = M * O;
            var TotalTiles = (SplGround - Sbench) / Stiles;
            var time = TotalTiles * 0.2;

            Console.WriteLine(TotalTiles);
            Console.WriteLine(time);
        }
    }
}
