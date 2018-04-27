namespace _03.Crypto_Blockchain
{
    using System;
    using System.Text.RegularExpressions;

    public class Problem03
    {
        public static void Main()
        {
            var blockchain = InitializeBlockchain();

            var decripted = DectriptAll(blockchain);

            Console.WriteLine(decripted);
        }

        private static string InitializeBlockchain()
        {
            var blockchain = string.Empty;
            var numberLines = int.Parse(Console.ReadLine());

            for (int line = 0; line < numberLines; line++)
            {
                var currLine = Console.ReadLine();
                blockchain += currLine;
            }

            return blockchain;
        }

        private static string DectriptAll(string blockchain)
        {
            var result = string.Empty;
            var pattern = @"(?<open>[[{]).*?(?<nums>[0-9]+).*?(?<close>[}\]])";
            var regex = new Regex(pattern);
            var matches = regex.Matches(blockchain);

            foreach (Match match in matches)
            {
                if (IsNotCryptoBlock(match))
                {
                    continue;
                }

                 result += Dectript(match);
            }

            return result;
        }

        private static string Dectript(Match match)
        {
            var blockLength = match.Length;
            var result = string.Empty;

            for (int i = 0; i < match.Groups["nums"].Value.Length; i += 3)
            {
                var first = match.Groups["nums"].Value[i].ToString();
                var second = match.Groups["nums"].Value[i + 1].ToString();
                var third = match.Groups["nums"].Value[i + 2].ToString();
                var currNum = int.Parse(string.Join("", first + second + third));
                result += (char)(currNum - blockLength);
            }

            return result;
        }

        private static bool IsNotCryptoBlock(Match match)
        {
            var openBracket = match.Groups["open"].Value;
            var closeBracket = match.Groups["close"].Value;
            var numsLength = match.Groups["nums"].Value.Length;

            if ((openBracket == "{" && closeBracket != "}") ||
                (openBracket == "[" && closeBracket != "]") ||
                numsLength % 3 != 0)
            {
                return true;
            }

            return false;
        }
    }
}
