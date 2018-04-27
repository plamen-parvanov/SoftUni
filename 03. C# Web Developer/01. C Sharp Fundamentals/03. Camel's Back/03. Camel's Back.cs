namespace _03.Camel_s_Back
{
    using System;
    using System.Collections.Generic;

    public class Problem03
    {

        public static void Main()
        {
            var firstInputLine = Console.ReadLine();
            var intList = InitializeIntList(firstInputLine);

            var stable = int.Parse(Console.ReadLine());
            var startIndex = (intList.Count - stable) / 2;

            var result = new List<int>();

            for (int i = startIndex; i < stable + startIndex; i++)
            {
                result.Add(intList[i]);
            }

            if (startIndex < 1)
            {
                Console.WriteLine("already stable: {0}", string.Join(" ", result));
            }
            else
            {
                Console.WriteLine("{0} rounds" + Environment.NewLine + "remaining: {1}", 
                    startIndex, string.Join(" ", result));
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
    }
}
