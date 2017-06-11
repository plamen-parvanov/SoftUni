using System;


namespace _10.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int nextNum = int.Parse(Console.ReadLine());
                if (nextNum > maxNum)
                {
                    maxNum = nextNum;
                }
                sum += nextNum;
            }
            if (maxNum == sum - maxNum)
            {
                Console.WriteLine("Yes sum {0}", maxNum);
            }
            else
            {
                Console.WriteLine("No diff {0}", Math.Abs(sum - 2 * maxNum));
            }
        }
    }
}
