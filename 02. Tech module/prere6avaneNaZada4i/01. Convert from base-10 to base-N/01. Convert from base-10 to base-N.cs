namespace _01.Convert_from_base_10_to_base_N
{

    using System;
    using System.Linq;
    using System.Numerics;


    public class Strings
    {

        public static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split().ToArray();
            var baseN =  byte.Parse(inputLine[0]);
            var base10 = BigInteger.Parse(inputLine[1]);

            var result = ConvertBase10ToBaseN(baseN, base10);

            Console.WriteLine(result);

        }

        public static string ConvertBase10ToBaseN(byte baseN, BigInteger base10)
        {
            var result = string.Empty;

            while (base10 > 0)
            {
                var reminder = base10 % baseN;
                result = reminder + result;
                base10 /= baseN;
            }

            return result;
        }
    }
}
