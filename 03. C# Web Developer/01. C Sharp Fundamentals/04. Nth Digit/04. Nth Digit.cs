namespace _04.Nth_Digit
{

    using System;

    public class Problem04
    {

        public static void Main()
        {
            var num = long.Parse(Console.ReadLine());
            var index = int.Parse(Console.ReadLine());

            var nThDigit = GetNthDigit(num, index);

            Console.WriteLine(nThDigit);
        }

        public static byte GetNthDigit(long num, int index)
        {
            byte result = 0;

            for (int i = 0; i < index; i++)
            {
                result = (byte)(num % 10);
                num /= 10;
            }
            return result;
        }
    }
}
