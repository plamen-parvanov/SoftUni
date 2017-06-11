using System;


namespace _04.Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            var heritage = double.Parse(Console.ReadLine());
            var yearDies = int.Parse(Console.ReadLine());
            var spendsPerYear = 12000d;
            var age = 18;
            

            for (int year = 1800; year <= yearDies; year++, age++)
            {
                if (year % 2 != 0)
                {
                    spendsPerYear += 50 * age;   
                }

                heritage -= spendsPerYear;
                spendsPerYear = 12000d;
            }

            if (heritage >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", heritage);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(heritage));
            }
        }
    }
}
