namespace _07.Count_Numbers
{

    using System;
    using System.Collections.Generic;

    public class Problem07
    {

        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var intList = InitializeIntList(inputLine);
            var countArr = new int[1001];

            intList.Sort();

            CountNumbers(intList, countArr);

            PrintResult(countArr);

        }

        public static List<int> InitializeIntList(string input)
        {
            var inputArr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var list = new List<int>();

            foreach (var num  in inputArr)
            {
                list.Add(int.Parse(num));
            }

            return list;
        }

        public static void CountNumbers(List<int> intList, int[] countArr)
        {
            foreach (var num in intList)
            {
                countArr[num]++;
            }

        }

        public static void PrintResult(int[] countArr)
        {
            for (int i = 0; i < countArr.Length; i++)
            {
                var count = countArr[i];
                var currNum = i; 
                 
                if (count > 0)
                {
                    Console.WriteLine($"{currNum} -> {count}");
                }
            }
        }
    }
}
