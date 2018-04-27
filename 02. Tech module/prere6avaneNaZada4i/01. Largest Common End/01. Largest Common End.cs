namespace _01.Largest_Common_End
{
    using System;


    public class Array
    {

        public static void Main()
        {
            string firstInput = Console.ReadLine();
            string[] firstArr = firstInput.Split(' ');

            string secondInput = Console.ReadLine();
            string[] secondArr = secondInput.Split(' ');

            int cntrLeftToRight = FindCommonWordLeftToRight(firstArr, secondArr);

            int cntrRightToLeft = FindCommonWordRightToLeft(firstArr, secondArr);

            Console.WriteLine(Math.Max(cntrLeftToRight, cntrRightToLeft));


        }

        private static int FindCommonWordLeftToRight(string[] firstArr, string[] secondArr)
        {
            int shorterArr = Math.Min(firstArr.Length, secondArr.Length);
            int cntr = 0;

            for (int i = 0; i < shorterArr; i++)
            {

                if (firstArr[i] == secondArr[i])
                {
                    cntr++;
                }
            }

            return cntr;
        }

        private static int FindCommonWordRightToLeft(string[] firstArr, string[] secondArr)
        {
            int shorterArr = Math.Min(firstArr.Length, secondArr.Length);
            int cntr = 0;

            for (int i = 0; i < shorterArr; i++)
            {
                var wordFirstArr = firstArr[shorterArr + firstArr.Length % shorterArr - 1 - i];
                var wordSecondArr = secondArr[shorterArr + secondArr.Length % shorterArr - 1 - i];

                if (wordFirstArr == wordSecondArr)
                {
                    cntr++;
                }
            }

            return cntr;
        }
    }
}
