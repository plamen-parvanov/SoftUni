namespace _02.Append_Lists
{

    using System;
    using System.Collections.Generic;

    public class Problem02
    {

        public static void Main()
        {
            var inputArr = Console.ReadLine()
                .Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            var list = new List<string>();

            foreach (var str in inputArr)
            {
                list.Add(str);
            }

            for (int i = list.Count - 1; i >= 0; i--)
            {
                var currentStr = list[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Console.Write(string.Join(" ", currentStr) + " ");
            }

            Console.WriteLine();
             
        }
    }
}
