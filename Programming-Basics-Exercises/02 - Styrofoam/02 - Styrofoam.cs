using System;

namespace _02___Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var houseS = double.Parse(Console.ReadLine());
            var windows = double.Parse(Console.ReadLine());
            var styPerPack = double.Parse(Console.ReadLine());
            var styPrice = double.Parse(Console.ReadLine());
            var s = houseS - windows * 2.4;
            s *= 1.1;
            var bill = styPrice * Math.Ceiling(s / styPerPack);

            if (budget >= bill)
            {
                Console.WriteLine("Spent: {0:f2}\nLeft: {1:f2}", bill, budget - bill);
            }
            else
            {
                Console.WriteLine("Need more: {0:f2}", bill - budget);
            }

        }
    }
}
