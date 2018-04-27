using System;


namespace _11.Odd_Number
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            while (number % 2 == 0)
            {
                Console.WriteLine("Please write an odd number.");
                number = int.Parse(Console.ReadLine());
            }

            number = Math.Abs(number);
            Console.WriteLine($"The number is: {number}");
        }
    }
}
