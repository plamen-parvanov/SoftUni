using System;


namespace _07.Sums_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
          

            for (int i = 0, counter = 1; i < n; i++, counter++)
            {
                int num = int.Parse(Console.ReadLine());
                if (counter == 1)
                {
                    sum1 += num;
                }
                else if (counter == 2)
                {
                    sum2 += num;
                }
                else
                {
                    sum3 += num;
                    counter = 0;
                }
            }
            Console.WriteLine("sum1 = {0}\nsum2 = {1}\nsum3 = {2}", sum1, sum2, sum3);
        }
    }
}
