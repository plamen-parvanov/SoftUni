namespace _04.Find_Evens_or_Odds
{
    using System;
    using System.Linq;

    public class Problem04
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var startNum = input[0];
            var endNum = input[1];

            Predicate<int> findEvenOrOdd = CreatePredicate();

            PrintResult(startNum, endNum, findEvenOrOdd);
        }

        private static void PrintResult(int startNum, int endNum, Predicate<int> findEvenOrOdd)
        {
            for (int i = startNum; i < endNum; i++)
            {
                if (findEvenOrOdd.Invoke(i))
                {
                    Console.Write($"{i} ");
                }
            }

            if (findEvenOrOdd.Invoke(endNum))
            {
                Console.Write(endNum);
            }

            Console.WriteLine();
        }

        private static Predicate<int> CreatePredicate()
        {
            var predicate = Console.ReadLine();

            if (predicate == "even")
            {
                return n => n % 2 == 0;
            }
            else
            {
                return n => n % 2 != 0;
            }
        }
    }
}
