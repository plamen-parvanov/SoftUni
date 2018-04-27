namespace _08.Sum_of_Odd_Numbers
{

    using System;


    public class Problem08
    {

        public static void Main()
        {

            var n = byte.Parse(Console.ReadLine());

            var sumOfOddNums = 0;

            for (int i = 0, currNum = 1; i < n; i++, currNum += 2)
            {
                Console.WriteLine(currNum);
                sumOfOddNums += currNum;
            }

            Console.WriteLine($"Sum: {sumOfOddNums}");
        }
    }
}
