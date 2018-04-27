using System;

namespace _01.Value_of_a_String
{
    public class Problem01
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var @case = Console.ReadLine();

            var sum = Sum(text, @case);

            Console.WriteLine($"The total sum is: {sum}");
        }
        public static int Sum(string text, string @case)
        {
            var sum = 0;

            foreach (var symbol in text)
            {
                if (@case == "UPPERCASE" && char.IsUpper(symbol))
                {
                    sum += symbol;
                }
                else if (@case == "LOWERCASE" && char.IsLower(symbol))
                {
                    sum += symbol;
                }
            }

            return sum;
        }
    }
}
