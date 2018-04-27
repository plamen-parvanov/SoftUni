using System;
using System.Linq;

namespace _07.Capitalize_Words
{
    public class Problem07
    {
        public static void Main()
        {
            ReadInput();
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

                ReadLineAndPrintCapitalized(inputLine);
            }
        }

        public static void ReadLineAndPrintCapitalized(string input)
        {
            var tokens = SplitToSentances(input).Select(w => CapitalizeWord(w));

            Console.WriteLine(string.Join(", ", tokens));

        }

        public static string[] SplitToSentances(string input)
        {
            return input.Split(new[] { ' ', ',', '.', '!', '?', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+', ';', ':' },
                 StringSplitOptions.RemoveEmptyEntries);
        }

        public static string CapitalizeWord(string word)
        {
            return word.First().ToString().ToUpper() + word.ToLower().Substring(1);
        }
    }
}
