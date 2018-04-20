namespace _02.Knights_of_Honor
{
    using System;
    using System.Linq;

    public class Problem02
    {
        public static void Main()
        {
            Action<string> modifyAndPrint = s => Console.WriteLine($"Sir {s}");

            Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(modifyAndPrint);
        }
    }
}
