namespace _01.Action_Print
{
    using System;
    using System.Linq;

    public class Problem01
    {
        public static void Main()
        {
            Action<string> printer = s => Console.WriteLine(s);

            Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(printer);
        }
    }
}
