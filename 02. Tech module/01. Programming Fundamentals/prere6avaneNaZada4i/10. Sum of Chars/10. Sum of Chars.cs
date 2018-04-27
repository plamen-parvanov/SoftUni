using System;


namespace _10.Sum_of_Chars
{
    class SumOfChars

    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                char nextLetter = char.Parse(Console.ReadLine());
                sum += nextLetter;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
