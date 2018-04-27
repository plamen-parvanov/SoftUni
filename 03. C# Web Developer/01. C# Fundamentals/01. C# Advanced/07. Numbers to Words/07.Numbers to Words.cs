namespace _07.Numbers_to_Words
{

    using System;

    public class Problem07
    {

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var resuslt = string.Empty;

            for (int i = 0; i < n; i++)
            {
                var currChar = char.Parse(Console.ReadLine());

                resuslt += EncryptTheChar(currChar);
            }

            Console.WriteLine(resuslt);
        }

        public static string EncryptTheChar(char currChar)
        {
            var result = string.Empty;
            var lastDigit = currChar % 10;
            var firstDigit = GetFirstDigitOfChar(currChar);

            result += (char)((int)currChar + lastDigit);
            result += firstDigit;
            result += lastDigit;
            result += (char)((int)currChar - firstDigit);

            return result;
        }

        public static int GetFirstDigitOfChar(char currChar)
        {
            var firstDigit = 0;
            var temp = (int)currChar;

            while (temp > 0)
            {
                firstDigit = temp % 10;
                temp /= 10;
            }
            return firstDigit;
        }
    }
}
