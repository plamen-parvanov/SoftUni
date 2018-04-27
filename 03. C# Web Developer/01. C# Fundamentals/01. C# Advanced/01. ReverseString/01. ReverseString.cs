using System;

namespace _01.ReverseString
{
    public class Problem01
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var result = string.Empty;

            for (int i = text.Length - 1; i >= 0; i--)
            {
                result += text[i];
            }

            Console.WriteLine(result);
        }
    }
}
