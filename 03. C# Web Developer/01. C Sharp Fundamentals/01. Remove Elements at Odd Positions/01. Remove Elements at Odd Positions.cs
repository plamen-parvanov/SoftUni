namespace _01.Remove_Elements_at_Odd_Positions
{

    using System;
    using System.Collections.Generic;

    public class Problem01
    {

        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var strList = InitializeStringList(inputLine);

            var resultList = new List<string>();

            for (int i = 0; i < strList.Count; i++)
            {
                if (i % 2 != 0)
                {
                    resultList.Add(strList[i]);
                }
            }

            Console.WriteLine(string.Join("", resultList));
        }

        public static List<string> InitializeStringList(string input)
        {
            var inputArr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var list = new List<string>();

            foreach (var str in inputArr)
            {
                list.Add(str);
            }

            return list;
        }
    }
}
