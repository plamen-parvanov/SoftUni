namespace _03.Equal_Sum_After_Extraction
{

    using System;
    using System.Collections.Generic;

    public class Problem03
    {

        public static void Main()
        {
            var firstLine = Console.ReadLine();
            var firstList = InitializeIntList(firstLine);

            var secondLine = Console.ReadLine();
            var secondList = InitializeIntList(secondLine);

            secondList = RemoveNumsFromFirstList(firstList, secondList);

            var sumFirstList = GetSumOfListNums(firstList);
            var sumSecondList = GetSumOfListNums(secondList);

            if (sumFirstList == sumSecondList)
            {
                Console.WriteLine($"Yes. Sum: {sumFirstList}");
            }
            else
            {
                Console.WriteLine("No. Diff: {0}", Math.Abs(sumFirstList - sumSecondList));
            }
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

        public static List<int> RemoveNumsFromFirstList(
            List<int> firstList, List<int> secondList)
        {
            var result = new List<int>();
            

            foreach (var num2 in secondList)
            {
                var isEqual = false;

                foreach (var num1 in firstList)
                {
                    if (num2 == num1)
                    {
                        isEqual = true;
                        break;
                    }
                }

                if (!isEqual)
                {
                    result.Add(num2);
                }
            }

            return result;
        }

        public static int GetSumOfListNums(List<int> list)
        {
            var sum = 0;

            foreach (var num in list)
            {
                sum += num;
            }

            return sum;
        }
    }
}
