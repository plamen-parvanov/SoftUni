using System;


namespace _06.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            bool isPrime = PrimeChecker(n);

            Console.WriteLine(isPrime);

        }

        static bool PrimeChecker(long number)
        {
            if (number < 2)
            {
                return false;
            }
            for (long i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;            
                }
            }
            return true;
        }
    }
}
