using System;


namespace _03.Excellent_or_Not
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = double.Parse(Console.ReadLine());

            if (result >= 5.50)
                Console.WriteLine("Excellent!");

            else
                Console.WriteLine("Not Excellent.");
        }
    }
}
