using System;


namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int fibonaciNthNumber = GetFibonaciNthNumber(n);
            Console.WriteLine(fibonaciNthNumber);
        }

        static int GetFibonaciNthNumber(int n)
        {
            int f0 = 1;
            int f1 = 1;

            for (int i = 1; i < n; i++)
            {
                int fn = f0 + f1;
                f0 = f1;
                f1 = fn;
            }

            return f1;
        }
    }
}
