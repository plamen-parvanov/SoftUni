namespace _06.Stuck_Zipper
{

    using System;
    using System.Collections.Generic;

    public class Problem06
    {

        public static void Main()
        {
            var firstInputLine = Console.ReadLine();
            var firstIntList = InitializeIntList(firstInputLine);

            var secondInputLine = Console.ReadLine();
            var secondIntList = InitializeIntList(secondInputLine);

            var smallestDigitNum = GetSmallestDigitNum(firstIntList, secondIntList);

            firstIntList = RemoveBigDigits(firstIntList, smallestDigitNum);
            secondIntList = RemoveBigDigits(secondIntList, smallestDigitNum);

            var result = ZipFirstAndSecondList(firstIntList, secondIntList);

            Console.WriteLine(string.Join(" ", result));
        }

        public static List<int> InitializeIntList(string input)
        {
            var inputArr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var list = new List<int>();

            foreach (var str in inputArr)
            {
                list.Add(int.Parse(str));
            }

            return list;
        }

        public static int GetSmallestDigitNum(List<int> list1, List<int> list2)
        {
            var minNum = Math.Min(GetAbsMinNum(list1), GetAbsMinNum(list2));

            var digitNumbers = GetNumberOfDigits(minNum);

            return digitNumbers;
        }

        public static int GetAbsMinNum(List<int> list)
        {
            var minNum = int.MaxValue;

            foreach (var num in list)
            {
                var currNum = Math.Abs(num);

                if (currNum < minNum)
                {
                    minNum = currNum;
                }
            }

            return minNum;
        }

        public static int GetNumberOfDigits(int num)
        {
            var digitNums = 0;

            while (num > 0)
            {
                num /= 10;
                digitNums++;
            }

            return digitNums;
        }

        public static List<int> RemoveBigDigits(List<int> list, int maxDigitCnt)
        {
            

            var result = new List<int>();

            foreach (var num in list)
            {
                var currNumDigits = GetNumberOfDigits(Math.Abs(num));
                if (currNumDigits <= maxDigitCnt)
                {
                    result.Add(num);
                }
            }

            return result;
        }

        public static List<int> ZipFirstAndSecondList(List<int> list1, List<int> list2)
        {
            var largerList = Math.Max(list1.Count, list2.Count);
            var result = new List<int>();

            for (int i = 0; i < largerList; i++)
            {
                if (i < list2.Count)
                {
                    result.Add(list2[i]);
                }
                if (i < list1.Count)
                {
                    result.Add(list1[i]);
                }
            }

            return result;
        }
    }
}
