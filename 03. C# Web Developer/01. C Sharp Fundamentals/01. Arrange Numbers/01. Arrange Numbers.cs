namespace _01.Arrange_Numbers
{
    using System;
    using System.Linq;
    using System.Text;

    public class Problem01
    {
        public static void Main()
        {
            Func<string, string> convertToString = x =>
            {
                var result = new StringBuilder();

                for (int i = 0; i < x.Length; i++)
                {
                    var converted = ConvertDigitToStringWithArr(x[i]);
                    result.Append(converted);

                    if (i != x.Length - 1)
                    {
                        result.Append("-");
                    }
                }

                return result.ToString();
            };

            var input = Console.ReadLine()
                           .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                           .OrderBy(convertToString)
                           .ToArray();

            Console.WriteLine(string.Join(", ", input));
        }

        private static string ConvertDigitToString(char digit)
        {
            var result = string.Empty;

            switch (digit)
            {
                case '1':
                    result = "one";
                    break;
                case '2':
                    result = "two";
                    break;
                case '3':
                    result = "three";
                    break;
                case '4':
                    result = "four";
                    break;
                case '5':
                    result = "five";
                    break;
                case '6':
                    result = "six";
                    break;
                case '7':
                    result = "seven";
                    break;
                case '8':
                    result = "eight";
                    break;
                case '9':
                    result = "nine";
                    break;
                case '0':
                    result = "zero";
                    break;
            }

            return result;  
        }

        private static string ConvertDigitToStringWithArr(char digit)
        {
            var arr = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            return arr[digit - '0'];
        }
    }
}
