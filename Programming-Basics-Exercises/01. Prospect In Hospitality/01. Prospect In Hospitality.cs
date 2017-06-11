using System;

namespace _01.Prospect_In_Hospitality
{
    class Program
    {
        static void Main(string[] args)
        {
            uint builders = uint.Parse(Console.ReadLine());
            uint reception = uint.Parse(Console.ReadLine());
            uint maids = uint.Parse(Console.ReadLine());
            uint technics = uint.Parse(Console.ReadLine());
            uint others = uint.Parse(Console.ReadLine());
            decimal niki = decimal.Parse(Console.ReadLine());
            decimal usdRate = decimal.Parse(Console.ReadLine());
            decimal mine = decimal.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());

            var buildersSalary = builders * 1500.04m;
            var receptSalary = reception * 2102.10m;
            var madsSalary = maids * 1465.46m;
            var techSalary = technics * 2053.33m;
            var otherSalary = others * 3010.98m;

            decimal allSalary = buildersSalary + receptSalary + madsSalary + techSalary + otherSalary
                + niki * usdRate + mine;
            Console.WriteLine("The amount is: {0:f2} lv.", allSalary);
            var diff = Math.Abs(allSalary - budget);
            if (budget >= allSalary)
            {
                Console.WriteLine("YES \\ Left: {0:f2} lv.", diff);
            }
            else
            {
                Console.WriteLine("NO \\ Need more: {0:f2} lv.", diff);

            }
            // ili   Console.WriteLine("{0} \\ {1}: {2:f2} lv.",
            //       allSallary <= budget ? "YES" : "NO",
            //       allSalary <= budget ? "Left" : "Need more",
            //       diff);

        }
    }
}
