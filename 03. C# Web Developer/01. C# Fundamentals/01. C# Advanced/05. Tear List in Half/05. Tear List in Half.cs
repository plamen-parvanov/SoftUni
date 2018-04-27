namespace _05.Tear_List_in_Half
{

    using System;
    using System.Collections.Generic;

    public class Problem05
    {

        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var intList = InitializeIntList(inputLine);

            var result = new List<int>();

            for (int i = 0; i < intList.Count / 2; i++)
            {
                var firstToAdd = intList[(intList.Count / 2 + i)] / 10;
                var middleToAdd = intList[i];
                var lastToAdd = intList[(intList.Count / 2 + i)] % 10;

                result.Add(firstToAdd);
                result.Add(middleToAdd);
                result.Add(lastToAdd);
            }

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
    }
}
