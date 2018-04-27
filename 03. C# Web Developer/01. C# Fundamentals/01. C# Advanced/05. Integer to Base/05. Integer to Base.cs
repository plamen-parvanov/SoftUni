namespace _05.Integer_to_Base
{

    using System;

    public class Problem05
    {

        public static void Main()
        {
            var num = long.Parse(Console.ReadLine());
            var toBase = byte.Parse(Console.ReadLine());

            var result = ConvertToBase(num, toBase);

            Console.WriteLine(result);
        }

        public static long ConvertToBase(long num, byte toBase)
        {
            var reminders = string.Empty;

            while (num > 0)
            {
                reminders = num % toBase + reminders;
                num /= toBase;
            }

            var convertedNum = long.Parse(reminders);
            return convertedNum;
        }
    }
}
