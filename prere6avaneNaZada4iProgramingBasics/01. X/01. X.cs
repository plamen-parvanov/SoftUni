using System;


namespace _01.X
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}x{1}x{0}", new string(' ', i), new string(' ', n - 2 - 2 * i));
            }

            Console.WriteLine("{0}x{0}", new string(' ', n /2));

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}x{1}x{0}", new string(' ', n / 2 - 1 - i), new string(' ', 1 + 2 * i));
            }


        }
    }
}
