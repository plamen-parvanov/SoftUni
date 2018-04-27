using System;
using System.Numerics;

namespace _14.Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger nFactorial = GetNthFactorial(n);

            int trailingZerosNthFactorial = GetTrailingZeroesNthFactorial(nFactorial);

            Console.WriteLine(trailingZerosNthFactorial); 
        }

        private static BigInteger GetNthFactorial(int n)
        {
            BigInteger nFactorial = 1;

            for (int i = 2; i <= n; i++)
            {
                nFactorial *= i;
            }

            return nFactorial;
        }

        private static int GetTrailingZeroesNthFactorial(BigInteger number)
        {
            int cntr = 0;

            while (number % 10 == 0)
            {
                cntr++;
                number /= 10;
            }

            return cntr;
        }
    }
}
