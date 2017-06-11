using System;


namespace Problem_3___Ace_of_Diamonds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('*', n));

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("*{0}{1}{0}*", new string('-', (n - 3) / 2 - i), new string('@', 1 + 2 * i));
            }

            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("*{0}{1}{0}*", new string('-', 1 + i), new string('@', n - 4 - 2 * i));
            }
            Console.WriteLine(new string('*', n));

        }
    }
}
