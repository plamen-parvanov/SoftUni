using System;


namespace Problem01_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int workDays = int.Parse(Console.ReadLine());
            double daySalary = double.Parse(Console.ReadLine());
            double usdFixinf = double.Parse(Console.ReadLine());

            double yearSalary = 14.5 * workDays * daySalary;
            double profitInLeva = yearSalary * 0.75 * usdFixinf;

            Console.WriteLine("{0:f2}", profitInLeva / 365); 
        }
    }
}
