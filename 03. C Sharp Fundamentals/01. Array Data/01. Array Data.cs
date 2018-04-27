namespace _01.Array_Data
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem01
    {

        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            input = input.Where(n => n >= input.Average()).ToList();

            var command = Console.ReadLine();

            Execute(command, input);
        }

        public static void Execute(string command, List<int> list)
        {
            switch (command)
            {
                case "Min":
                    Console.WriteLine("{0}", list.Min());
                    break;
                case "Max":
                    Console.WriteLine("{0}", list.Max());
                    break;
                case "All":
                    Console.WriteLine(string.Join(" ", list.OrderBy(n => n)));
                    break;
            }
        }
    }
}
