using System;


namespace _04.Odd_or_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
                Console.WriteLine("even");

            else
                Console.WriteLine("odd");
        }
    }
}
