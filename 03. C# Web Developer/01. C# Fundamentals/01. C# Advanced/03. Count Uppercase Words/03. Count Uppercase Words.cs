namespace _03.Count_Uppercase_Words
{
    using System;
    using System.Linq;

    public class Problem03
    {
        public static void Main()
        {
            Func<string, bool> FilterUpperWords = w => char.IsUpper(w[0]);
            Action<string> PrintWord = w => Console.WriteLine(w);

            Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(FilterUpperWords)
                .ToList()
                .ForEach(PrintWord);
        }
    }
}
