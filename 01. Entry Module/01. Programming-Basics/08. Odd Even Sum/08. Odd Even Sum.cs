using System;


namespace _08.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum1 = 0;
            var sum2 = 0;

            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sum2 += num;
                }

                else
                {
                    sum1 += num;
                }
            }
            if (sum1 == sum2)
            {
                Console.WriteLine("Yes Sum = " + sum1);
            } 
            
            else
            {
                Console.WriteLine("No Diff = " + Math.Abs(sum1 - sum2));
            }           
        }
    }
}
