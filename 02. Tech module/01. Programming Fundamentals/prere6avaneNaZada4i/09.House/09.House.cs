using System;


namespace _09.House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < (n + 1) / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{0}", new string('-', (n - 1) / 2 - i),
                    new string('*', 2 - n % 2), new string ('*', 2 * i));
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("|{0}|", new string('*', n - 2));
            }
        }
    }
}
