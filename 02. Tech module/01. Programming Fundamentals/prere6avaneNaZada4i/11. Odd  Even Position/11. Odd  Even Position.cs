using System;


namespace _11.Odd__Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0d;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0d;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double nextNum = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    if (nextNum > evenMax)
                    {
                        evenMax = nextNum;       
                    }
                    if (nextNum < evenMin)
                    {
                        evenMin = nextNum;
                    }
                    evenSum += nextNum;
                }
                else
                {
                    if (nextNum > oddMax)
                    {
                        oddMax = nextNum;
                    }
                    if (nextNum < oddMin)
                    {
                        oddMin = nextNum;
                    }
                    oddSum += nextNum;                   
                }
            }
            if (n == 0)
            {
                Console.WriteLine("OddSum=0,\nOddMin=No,\nOddMax=No,\nEvenSum=0,\nEvenMin=No,\nEvenMax=No");
            }
            else if (n == 1)
            {
                Console.WriteLine("OddSum={0},\nOddMin={0},\nOddMax={0},\nEvenSum=0,\nEvenMin=No,\nEvenMax=No", oddMin);

            }
            else
            {
                Console.WriteLine("OddSum={0},\nOddMin={1},\nOddMax={2},\nEvenSum={3},\nEvenMin={4},\nEvenMax={5}",
                    oddSum, oddMin, oddMax, evenSum, evenMin, evenMax);
            }
        }
    }
}
