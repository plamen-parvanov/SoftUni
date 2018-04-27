using System;


namespace _12.Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 BGN	1.79549	1.95583	2.53405  	BGN    USD	 EUR 	GBP

            double n = double.Parse(Console.ReadLine());
            string firstCurency = Console.ReadLine();
            string secondCurancy = Console.ReadLine();
            double koef1 = 0;
            double koef2 = 0;

            if (firstCurency == "BGN")
            {
                koef1 = 1;
            }
            else if (firstCurency == "USD")
            {
                koef1 = 1.79549;
            }
            else if (firstCurency == "EUR")
            {
                koef1 = 1.95583;
            }
            else if (firstCurency == "GBP")
            {
                koef1 = 2.53405;
            }

            if (secondCurancy == "BGN")
            {
                koef2 = 1;
            }
            else if (secondCurancy == "USD")
            {
                koef2 = 1.79549;
            }
            else if (secondCurancy == "EUR")
            {
                koef2 = 1.95583;
            }
            else if (secondCurancy == "GBP")
            {
                koef2 = 2.53405;
            }

            Console.WriteLine(Math.Round( n * koef1 / koef2, 2));

            

        }
    }
}
