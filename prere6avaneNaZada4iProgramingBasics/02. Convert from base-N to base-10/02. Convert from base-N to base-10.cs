namespace _02.Convert_from_base_N_to_base_10
{

    using System;
    using System.Linq;
    using System.Numerics;


    public class Strings
    {

        public static void Main()
        {
            var inputLine = Console.ReadLine().Split().ToArray();
            var baseN = byte.Parse(inputLine[0]);
            var numberInBaseN = BigInteger.Parse(inputLine[1]);
            BigInteger result = 0;
            BigInteger power = 1;

            while (numberInBaseN > 0)
            {
                var a = numberInBaseN % 10;
                result += a * power;
                numberInBaseN /= 10;
                power *= baseN;
                
                
            }

            //for (int i = 0; i < numberInBaseN.Length; i++)
            //{
            //    var numchar = numberInBaseN[numberInBaseN.Length - 1 - i];
            //    var num = (byte)(numchar - '0');
            //    result += num * (BigInteger)Math.Pow(baseN, i);
            //}

            Console.WriteLine(result);




        }
    }
}
