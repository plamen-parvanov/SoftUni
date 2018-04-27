namespace _03.Softuni_Numerals
{
    using System;
    using System.Text;
    using System.Numerics;

    public class Problem03
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var numBaseFive = ConvertStringToBaseFive(input);

            var baseTen = ConvertToBaseTen(numBaseFive);

            Console.WriteLine(baseTen);
        }

        private static BigInteger ConvertToBaseTen(string numBaseFive)
        {
            BigInteger result = 0;
            var length = numBaseFive.Length;

            for (int i = length - 1; i >= 0 ; i--)
            {
                
                var currSymbol = numBaseFive[i];
                var power = length - 1 - i ;
                var curNum = BigInteger.Pow(5, power) * (currSymbol - '0');
                result += curNum;
                
            }

            return result;
        }

        private static string ConvertStringToBaseFive(string input)
        {
            var sb = new StringBuilder();
            var index = 0;

            while (index < input.Length - 1)
            {
                var currSymbol = input[index];
                var secondSymbol = input[index + 1];

                if (currSymbol == secondSymbol)
                {
                    index += 2;

                    if (currSymbol == 'a')
                    {
                        sb.Append(0);
                        continue;
                    }
                    sb.Append(3);
                    continue;
                }

                index += 3;

                switch (currSymbol)
                {
                    case 'a':
                        sb.Append(1);
                        break;
                    case 'b':
                        sb.Append(2);
                        break;
                    case 'c':
                        sb.Append(4);
                        break;
                }

            }

            return sb.ToString();
        }
    }
}
