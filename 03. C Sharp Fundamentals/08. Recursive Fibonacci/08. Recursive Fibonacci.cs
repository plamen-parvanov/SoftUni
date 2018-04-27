namespace _08.Recursive_Fibonacci
{
    using System;
    using System.Collections.Generic;

    public class Problem08
    {
        private static Dictionary<int, long> fibonaci;
        public static void Main()
        {
            var wantedFibonaciNum = int.Parse(Console.ReadLine());

             var result = Find(wantedFibonaciNum);

            Console.WriteLine(result);
        }

        private static long Find(int wantedFibonaciNum)
        {
            fibonaci = new Dictionary<int, long>();
            fibonaci[1] = 1;
            fibonaci[2] = 1;

            for (int i = 3; i <= wantedFibonaciNum; i++)
            {
                var prevOneNum = i - 1;
                var prevTwoNum = i - 2;
                var prevOneSum = fibonaci[prevOneNum];
                var prevTwoSum = fibonaci[prevTwoNum];

                var currNumSum = prevOneSum + prevTwoSum;
                fibonaci[i] = currNumSum;

            }

            return fibonaci[wantedFibonaciNum];
        }
    }
}
