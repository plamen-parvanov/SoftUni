namespace _03.Phoenix_Grid
{
    using System;
    using System.Text.RegularExpressions;

    public class Problem03
    {
        public static void Main()
        {
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "ReadMe")
                {
                    break;
                }

                Read(inputLine);
            }
        }

        private static void Read(string input)
        {
            var pattern = @"^[^\s_]{3}(\.[^\s_]{3})*$";
            var match = Regex.Match(input, pattern).Value;

            if (match != string.Empty && IsPalindrome(match))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        private static bool IsPalindrome(string input)
        {
            var firstHalf = input.Substring(0, input.Length / 2);
            var lastHalf = input.Substring(input.Length / 2 + 1, input.Length - firstHalf.Length - 1);
            
            if (firstHalf == Reversed(lastHalf))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static string Reversed(string str)
        {
            var arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
