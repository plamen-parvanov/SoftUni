using System;


namespace ConsoleApplication104.Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double heritage = double.Parse(Console.ReadLine());
            int yearDies = int.Parse(Console.ReadLine());
            int age = 18;

            for (int i = 1800; i <= yearDies; i++)
            {
                double spent = 12000;
                if (i % 2 != 0)
                {
                    spent += 50 * age;
                }
                heritage -= spent;
                age++;
            }
            if (heritage >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.",
                    heritage);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(heritage));
            }
        }
    }
}
