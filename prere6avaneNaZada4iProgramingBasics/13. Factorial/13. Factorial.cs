using System;
using System.Numerics;


namespace _13.Factorial
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());        

            BigInteger nFactorial = GetNthFactorial(n);

            Console.WriteLine(nFactorial);
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
    }
}
