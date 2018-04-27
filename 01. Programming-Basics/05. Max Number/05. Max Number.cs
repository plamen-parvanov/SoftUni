using System;

namespace _05.Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var biggerNumber = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number > biggerNumber)
                {
                    biggerNumber = number;
                }

            }

            Console.WriteLine(biggerNumber);

        }
    }
}
