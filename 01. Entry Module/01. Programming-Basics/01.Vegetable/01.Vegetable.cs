using System;

namespace _01.Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = double.Parse(Console.ReadLine());
            var M = double.Parse(Console.ReadLine());
            var kgV = double.Parse(Console.ReadLine());
            var kgF = double.Parse(Console.ReadLine());

            var totalLv = (N * kgV) + (M * kgF);
            var totalEu = totalLv * 100 / 194;

            Console.WriteLine(totalEu);
        }
    }
}
