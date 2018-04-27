namespace _03.String_Repeater
{

    using System;


    public class Arrays
    {

        public static void Main()
        {
            var inputStr = Console.ReadLine();
            var count = int.Parse(Console.ReadLine());

            RepetString(inputStr, count);
        }

        public static void RepetString(string inputStr, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(inputStr);
            }
            Console.WriteLine();
        }
    }
}
