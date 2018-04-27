namespace _07.Primes_in_Given_Range
{
    using System;
    using System.Collections.Generic;


    class Methods
    {

        static void Main()
        {
            int strat = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
           

            var primeList = AddPrimeToList(strat, end);
            Console.WriteLine(string.Join(", ", primeList));
        }

        private static List<int> AddPrimeToList(int strat, int end)
        {
            var primeList = new List<int>();

            for (int i = strat; i < end + 1; i++)
            {
                if (PrimeNumCheck(i))
                {
                    primeList.Add(i);
                }
            }
            return primeList;
        }

        static bool PrimeNumCheck(int num)
        {
            if (num < 2)
            {
                return false;
            }

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
