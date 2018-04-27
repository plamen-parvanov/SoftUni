using System;


namespace _07.Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
          

            for (int i = 0; i < 2 * n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i < n)
                {
                    sum1 += num;
                }
                else
                {
                    sum2 += num;
                }
            }
            if (sum1 == sum2)
            {
                Console.WriteLine("Yes, sum = {0}", sum2);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(sum2 - sum1));
            }

        }
    }
}
