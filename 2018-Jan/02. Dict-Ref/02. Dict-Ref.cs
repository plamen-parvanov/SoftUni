namespace _02.Dict_Ref
{

    using System;
    using System.Collections.Generic;

    public class Problem02
    {

        public static void Main()
        {
            var dict = new Dictionary<string, int>();

            while (true)
            {
                var inputArr = Console.ReadLine()
                    .Split(new[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (inputArr[0] == "end")
                {
                    break;
                }

                var name = inputArr[0];
                var value = 0;

                if (int.TryParse(inputArr[1], out value))
                {
                    dict[name] = value;
                }
                else if (dict.ContainsKey(inputArr[1]))
                {
                    dict[name] = dict[inputArr[1]];
                }
            }

            PrintDict(dict);

        }

        public static void PrintDict(Dictionary<string, int> dict)
        {
            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} === {kvp.Value}");
            }
        }
    }
}
