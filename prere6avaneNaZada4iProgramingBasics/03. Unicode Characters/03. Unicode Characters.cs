namespace _03.Unicode_Characters
{

    using System;


    public class Strings
    {

        public static void Main()
        {
            var inputText = Console.ReadLine();

            foreach (var symbol in inputText)
            {
                var unicode = ConvertCharToBase16(symbol);

                Console.Write("\\u00{0}", unicode);
            }
            Console.WriteLine();

        }


        public static string ConvertCharToBase16( char inputChar)
        {
            var base10 = (int)inputChar;
            var result = string.Empty;

            while (base10 > 0)
            {
                var reminder = base10 % 16;
                if (reminder > 14)
                {
                    result = "f" + result;
                }
                else if (reminder > 13)
                {
                    result = "e" + result;
                }
                else if (reminder > 12)
                {
                    result = "d" + result;
                }
                else if (reminder > 11)
                {
                    result = "c" + result;
                }
                else if (reminder > 10)
                {
                    result = "b" + result;
                }
                else if (reminder > 9)
                {
                    result = "a" + result;
                }
                else
                {
                    result = reminder + result;
                }

                base10 /= 16;
            }

            return result;
        }
    }
}
