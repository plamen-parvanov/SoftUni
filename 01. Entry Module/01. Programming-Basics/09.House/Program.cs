using System;


namespace _09.House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < (n +1) / 2; i++)
            //{
            //    Console.Write(new string('-', (n - 1) / 2 - i));
            //    if (n % 2 == 0)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine(new string ('*', 1 + 2 * i )
            //        + new string ('-', (n - 1) / 2 - i ));

            //}

            //for (int i = 0; i < n / 2; i++)
            //{
            //    Console.WriteLine("|" + new string ('*', n - 2) + "|");
            //}

            for (int i = 0; i < (n + n % 2) / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('-',(n - 1) / 2 - i), new string('*', 2 - n % 2 + 2 * i));
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("|{0}|", new string('*', n - 2));
            }
        }
    }
}
