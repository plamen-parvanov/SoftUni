using System;

namespace _06.Sentence_Split
{
    public class Problem05
    {
        public static void Main()
        {
            var sentence = Console.ReadLine();
            var delimeter = Console.ReadLine();

            var result = sentence
                .Split(new[] { delimeter }, StringSplitOptions.None);

            Console.WriteLine("[" + string.Join(", ", result) + "]");

        }
    }
}
