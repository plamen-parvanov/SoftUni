using System;

namespace _03.Serialize_String
{
    public class Problem03
    {
        public static void Main()
        {
            var inputStr = Console.ReadLine();

            Serialize(inputStr);
        }

        public static void Serialize(string input)
        {
            var removed = input;
            do
            {
                var currLetter = removed[0];
                removed = RemoveAllLetters(currLetter, input, removed);

            } while (removed.Length > 0);

        }

        public static string RemoveAllLetters(char letter, string input, string removed)
        {
            var indexOfLetter = input.LastIndexOf(letter);
            var indexToRemove = removed.LastIndexOf(letter);
            var result = string.Empty;

            while (indexToRemove != -1)
            {
                result = "/" + indexOfLetter + result;
                input = input.Remove(indexOfLetter, 1);
                removed = removed.Remove(indexToRemove, 1);
                indexOfLetter = input.LastIndexOf(letter);
                indexToRemove = removed.LastIndexOf(letter);
            }

            result = letter + ":" + result.TrimStart('/');

            Console.WriteLine(result);

            return removed;
        }
    }
}
