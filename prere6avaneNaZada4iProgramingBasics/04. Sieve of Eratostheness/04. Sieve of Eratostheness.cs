namespace _04.Sieve_of_Eratostheness
{
    using System;


    public class Program
    {

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            bool[] primes = new bool[n + 1];

            for (int i = 2; i < primes.Length; i++)
            {
                primes[i] = true;
            }

            primes[0] = false;
            primes[1] = false;


            for (int i = 2; i < n + 1; i++)
            {
                if (primes[i] == true)
                {
                    Console.WriteLine(i);

                    for (int p = 2; p * i <= n; p++)
                    {
                        primes[i * p] = false;
                    }
                }

            }

        }
    }
}
