namespace _12.Test_Numbers
{

    using System;


    public class Problem12
    {

        public static void Main()
        {

            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var maxSum = int.Parse(Console.ReadLine());

            var sum = 0;
            var combinations = 0;

            for (int i = firstNum; i > 0; i--)
            {
                for (int j = 1; j < secondNum + 1; j++)
                {
                    sum += 3 * i * j;
                    combinations++;

                    if (sum >= maxSum)
                    {
                        Console.WriteLine($"{combinations} combinations\nSum: {sum} >= {maxSum}");
                        return;
                    }
                }
            }

            Console.WriteLine($"{combinations} combinations\nSum: {sum}");
            

        }
    }
}
