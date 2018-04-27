namespace _02.String_Decryption
{

    using System;
    using System.Linq;

    public class Problem02
    {

        public static void Main()
        {
            var skipTake = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var skip = skipTake[0];
            var take = skipTake[1];

            var intArr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var filteredArr = intArr.Where(n => n >= (int)'A' && n <= (int)'Z')
                .Skip(skip)
                .Take(take)
                .Select(n => (char)n)
                .ToArray();

            Console.WriteLine(string.Join("", filteredArr));
        }
    }
}
