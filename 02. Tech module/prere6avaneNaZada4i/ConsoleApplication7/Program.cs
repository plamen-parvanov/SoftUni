namespace ConsoleApplication7
{

    using System;
    using System.Linq;


    public class Strings
    {

        public static void Main()
        {
            var input = Console.ReadLine()
                .Split()
                .Select(x => x.ToArray().Distinct().ToArray())
                .ToArray();

            var firstLength = input.First().Length;

            Console.WriteLine(input.All(x => x.Length == firstLength).ToString().ToLower());


        }
    }
}
