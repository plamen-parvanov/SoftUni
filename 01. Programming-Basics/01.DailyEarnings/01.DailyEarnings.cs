using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DailyEarnings
{
    class Program
    {
        static void Main(string[] args)
        {
            var workDaysInMonth = double.Parse(Console.ReadLine());
            var workDayPaymentInUSD = double.Parse(Console.ReadLine());
            var USDfixing = double.Parse(Console.ReadLine());

            var eyarlyEarningInUSD = workDaysInMonth * workDayPaymentInUSD * 14.5;
            var taxes = 0.25 * eyarlyEarningInUSD;
            var clearYearlyPaymentInLV = (eyarlyEarningInUSD - taxes) * USDfixing;
            var dailyEaernings = clearYearlyPaymentInLV / 365;

            Console.WriteLine(Math.Round(dailyEaernings , 2));
        }
    }
}
