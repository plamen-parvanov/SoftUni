using System;


namespace _12.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int oldSum = 0;
            int maxDiff = 0;
            int cntr = 0;
            for (int i = 0; i < n; i++)
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());
                sum = firstNum + secondNum;
                maxDiff = Math.Abs(sum - oldSum);
                if (maxDiff != 0)
                {
                    cntr += 1;
                }
                oldSum = sum;

            }
            if (cntr > 1)
            {
                Console.WriteLine("No, maxdiff={0}", maxDiff);
            }
            else
            {
                Console.WriteLine("Yes, value={0}", oldSum);
            }
        }
    }
}
