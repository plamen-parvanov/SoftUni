namespace _04.Flip_List_Sides
{
    using System;
    using System.Collections.Generic;

    public class Problem04
    {

        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var intList = InitializeIntList(inputLine);

            for (int i = 1; i < intList.Count / 2; i++)
            {
                var temp = intList[i];
                intList[i] = intList[intList.Count - 1 - i];
                intList[intList.Count - 1 - i] = temp;
            }

            Console.WriteLine(string.Join(" ", intList));
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
