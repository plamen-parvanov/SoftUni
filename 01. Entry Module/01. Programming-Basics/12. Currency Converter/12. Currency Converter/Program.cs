using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = double.Parse(Console.ReadLine());
            var firstCurrency = Console.ReadLine();
            var secondCurrency = Console.ReadLine();


            if (firstCurrency == "BGN")
            {
                if (secondCurrency == "USA")
                {
                    var c = value * 1 / 1.79549;
                    Console.WriteLine(Math.Round(c, 2) +" "+ secondCurrency);
                }

                else if (secondCurrency == "EUR")
                {
                    var c = value * 1 / 1.95583;
                    Console.WriteLine(Math.Round(c, 2) + " " + secondCurrency);
                }

                else if (secondCurrency == "GBP")
                {
                    var c = value * 1 / 2.53405;
                    Console.WriteLine(Math.Round(c, 2) + " " + secondCurrency);
                }
            }

            if (firstCurrency == "USD")
            {
                if (secondCurrency == "BGN")
                {
                    var c = value * 1.79549 / 1;
                    Console.WriteLine(Math.Round(c, 2) + " " + secondCurrency);
                }

                else if (secondCurrency == "EUR")
                {
                    var c = value * 1.79549 / 1.95583;
                    Console.WriteLine(Math.Round(c, 2) + " " + secondCurrency);
                }

                else if (secondCurrency == "GBP")
                {
                    var c = value * 1.79549 / 2.53405;
                    Console.WriteLine(Math.Round(c, 2) + " " + secondCurrency);
                }
            }

            if (firstCurrency == "EUR")
            {
                if (secondCurrency == "BGN")
                {
                    var c = value * 1.95583 / 1;
                    Console.WriteLine(Math.Round(c, 2) + " " + secondCurrency);
                }

                else if (secondCurrency == "USD")
                {
                    var c = value * 1.95583 / 1.79549;
                    Console.WriteLine(Math.Round(c, 2) + " " + secondCurrency);
                }

                else if (secondCurrency == "GBP")
                {
                    var c = value * 1.95583 / 2.53405;
                    Console.WriteLine(Math.Round(c, 2) + " " + secondCurrency);
                }
            }
                if (firstCurrency == "GBP")
                {
                    if (secondCurrency == "BGN")
                    {
                        var c = value * 2.53405 / 1;
                        Console.WriteLine(Math.Round(c, 2) + " " + secondCurrency);
                    }

                    else if (secondCurrency == "USD")
                    {
                        var c = value * 2.53405 / 1.79549;
                        Console.WriteLine(Math.Round(c, 2) + " " + secondCurrency);
                    }

                    else if (secondCurrency == "EUR")
                    {
                        var c = value * 2.53405 / 1.95583;
                        Console.WriteLine(Math.Round(c, 2) + " " + secondCurrency);
                    }
                }
        }
    }


}
