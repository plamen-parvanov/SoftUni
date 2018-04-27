namespace _01.Distinct_List
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem01
    {

        public static void Main()
        {
            //Console.WriteLine(string.Join(" ",
            //    Console.ReadLine()
            //    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToList()
            //    .Distinct()));

            var input = Console.ReadLine();
            var intList = InitializeIntList(input);

            var result = new List<int>();

            foreach (var num in intList)
            {
                if (!result.Contains(num))
                {
                    result.Add(num);
                }
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
