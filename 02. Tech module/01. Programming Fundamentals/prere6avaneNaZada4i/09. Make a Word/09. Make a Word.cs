using System;


namespace _09.Make_a_Word
{
    class MakeAWord

    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string word = string.Empty;

            for (int i = 0; i < n; i++)
            {
                char nextLetter = char.Parse(Console.ReadLine());
                word += nextLetter;
            }

            Console.WriteLine($"The word is: {word}");
        }
    }
}
