namespace _13.Increasing_Sequence_of_Elements
{

    using System;

    public class Problem13
    {

        public static void Main()
        {
            var input = Console.ReadLine();
            var strArr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var intArr = new int[strArr.Length];

            for (int i = 0; i < strArr.Length; i++)
            {
                intArr[i] = int.Parse(strArr[i]);
            }

            var isIncreasing = CheckIsItIncreasing(intArr);

            PrintIsItIncreasingOrNot(isIncreasing);
        }

        public static void PrintIsItIncreasingOrNot(bool isIncreasing)
        {
            if (isIncreasing)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }

        public static bool CheckIsItIncreasing(int[] intArr)
        {
            var lastNum = int.MinValue;
            var isIncreasing = true;

            foreach (var num in intArr)
            {
                if (num < lastNum)
                {
                    isIncreasing = false;
                    break;
                }

                lastNum = num;
            }
            return isIncreasing;
        }

    }
}
