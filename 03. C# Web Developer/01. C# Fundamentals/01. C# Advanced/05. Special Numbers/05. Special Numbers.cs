namespace _05.Special_Numbers
{

    using System;


    public class Problem05
    {

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                var sum = GetSum(i);
                var isEqual = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine("{0} -> {1}", i, isEqual);
            }
        }

        public static int GetSum(int currentNumber)
        {
            var sum = 0;

            while (currentNumber > 0)
            {
                sum += currentNumber % 10;
                currentNumber /= 10;
            }
            return sum;
        }
    }
}
