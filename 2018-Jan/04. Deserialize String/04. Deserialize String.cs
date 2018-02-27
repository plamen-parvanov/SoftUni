namespace _04.Deserialize_String
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem04
    {
        public static SortedDictionary<int, char> dict;
        public static void Main()
        {
            dict = new SortedDictionary<int, char>();

            ReadInput();

            PrintDict();
        }

        public static void ReadInput()
        {
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "end")
                {
                    break;
                }

                AddInDict(inputLine);

            }
        }

        public static void AddInDict(string input)
        {
            var arr = input.Split(new[] { ':', '/' }, StringSplitOptions.RemoveEmptyEntries);
            var letter = char.Parse(arr[0]);
            var indexes = arr.Skip(1).Select(int.Parse).ToArray();

            foreach (var index in indexes)
            {
                dict[index] = letter;
            }
        }

        public static void PrintDict()
        {
            Console.WriteLine(dict.Values.ToArray());
        }
    }
}
