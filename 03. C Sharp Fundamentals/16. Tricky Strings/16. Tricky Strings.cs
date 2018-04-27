namespace _16.Tricky_Strings
{

    using System;


    public class Problem16
    {

        public static void Main()
        {

            var delimiter = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(Console.ReadLine() + delimiter);
            }

            Console.WriteLine(Console.ReadLine());

        }
    }
}
