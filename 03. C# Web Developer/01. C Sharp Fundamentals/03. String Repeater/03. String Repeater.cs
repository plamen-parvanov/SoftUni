namespace _03.String_Repeater
{

    using System;

    public class Problem03
    {

        public static void Main()
        {
            var str = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());

            var result = PrintStringNtimes(str, n);

            Console.WriteLine(result);
        }

        public static string PrintStringNtimes(string str, int n)
        {
            var result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                result += str;
            }

            return result;
        }
    }
}
