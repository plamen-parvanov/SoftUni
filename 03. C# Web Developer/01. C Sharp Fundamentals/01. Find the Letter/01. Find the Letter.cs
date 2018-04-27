namespace _01.Find_the_Letter
{
    using System;

    public class Problem01
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            var result = FindNthOccurrenceOfLetterIn(text);

            Console.WriteLine(result < 0 ? "Find the letter yourself!" : $"{result}");
        }

        public static int FindNthOccurrenceOfLetterIn(string text)
        {
            var arr = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var letter = arr[0];
            var occurrence = int.Parse(arr[1]);
            var index = 0;

            while (occurrence > 0)
            {
                index = text.IndexOf(letter, index) + 1;
                if (index == 0)
                {
                    break;
                }

                occurrence--;
            }

            return index - 1;
        }
    }
}
