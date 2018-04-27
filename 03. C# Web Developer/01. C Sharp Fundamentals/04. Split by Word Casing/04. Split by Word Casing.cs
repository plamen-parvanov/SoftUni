namespace _04.Split_by_Word_Casing
{

    using System;
    using System.Collections.Generic;

    public class Problem04
    {

        public static void Main()
        {
            var input = Console.ReadLine();
            var strArr = InitializeStrArr(input);

            var lowerLetters = new List<string>();
            var mixedLetters = new List<string>();
            var upperLetters = new List<string>();

            foreach (var str in strArr)
            {
                if (StringIsLowerCase(str))
                {
                    lowerLetters.Add(str);
                }
                else if (StringIsUpperCase(str))
                {
                    upperLetters.Add(str);
                }
                else
                {
                    mixedLetters.Add(str);
                }
            }

            PrintResult(lowerLetters, mixedLetters, upperLetters);

        }

        public static string[] InitializeStrArr(string input)
        {
            var splitBy = new[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' };
            var inputArr = input.Split(splitBy, StringSplitOptions.RemoveEmptyEntries);
            return inputArr;
        }

        public static bool StringIsLowerCase(string str)
        {
            foreach (var letter in str)
            {
                if (letter < 'a' || letter > 'z')
                {
                    return false;
                }
            }
            return true;
        }

        public static bool StringIsUpperCase(string str)
        {
            foreach (var letter in str)
            {
                if (letter < 'A' || letter > 'Z')
                {
                    return false;
                }
            }

            return true;
        }

        public static void PrintResult(
            List<string> lowerLetters, List<string> mixedLetters, List<string> upperLetters)
        {
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerLetters));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedLetters));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperLetters));
        }
    }
}
