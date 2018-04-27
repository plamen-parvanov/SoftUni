namespace _02.Integer_Insertion
{

    using System;
    using System.Collections.Generic;

    public class Problem02
    {

        public static void Main()
        {
            var input = Console.ReadLine();
            var intList = InitializeIntList(input);

            while (true)
            {
                var currLine = Console.ReadLine();

                if (currLine.Equals("end"))
                {
                    break;
                }

                var num = int.Parse(currLine);
                var indexToInsertAt = int.Parse(currLine[0].ToString()); 
                             // ili = currLine[0] - '0';

                intList.Insert(indexToInsertAt, num);
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
