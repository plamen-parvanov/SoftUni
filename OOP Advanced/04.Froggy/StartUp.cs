namespace _04.Froggy
{
    using System;
    using System.Linq;

    using Models;

    public class StartUp
    {
        public static void Main()
        {
            var lake = CreateLake();

            Print(lake);
        }

        private static void Print(Lake lake)
        {
            var result = string.Join(", ", lake);
            Console.WriteLine(result);
        }

        public static Lake CreateLake()
        {
            var inputArgs = Console.ReadLine()
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            return new Lake(inputArgs);
        }
    }
}
