namespace _06.Square_Numbers
{

    using System;
    using System.Collections.Generic;

    public class Problem06
    {

        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var listInt = InitializeList(inputLine);
            var listResult = new List<int>();

            foreach (var num in listInt)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    listResult.Add(num);
                }
            }
            
            listResult.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", listResult));
        }

        public static List<int> InitializeList(string inputLine)
        {
            var list = new List<int>();
            var inputArr = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var num in inputArr)
            {
                list.Add(int.Parse(num));
            }

            return list;
        }
    }
}
