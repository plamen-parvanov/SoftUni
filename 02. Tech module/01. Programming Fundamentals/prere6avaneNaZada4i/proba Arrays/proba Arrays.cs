using System;


namespace proba_Arrays
{
    class Program
    {
        static void Main()
        {
            int[] nums = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine(string.Join(" - ", nums));

            int[] num2 = { 2, 2, 2, 2 };

            Console.WriteLine(string.Join(" + ", num2));

            nums = num2;

            Console.WriteLine(string.Join(" - ", nums));
            Console.WriteLine(string.Join(" + ", num2));

        }
    }
}
