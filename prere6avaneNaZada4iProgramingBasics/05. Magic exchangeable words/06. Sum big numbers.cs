namespace _05.Magic_exchangeable_words
{
    using System;


    public class Strings
    {

        public static void Main()
        {
            var firstString = Console.ReadLine().TrimStart(new[] {'0'});
            var secondString = Console.ReadLine().TrimStart(new[] {'0'});

            var resultString = string.Empty;

            var result = 0;
            var temp = 0;

            var maxLength = Math.Max(firstString.Length, secondString.Length);
            var cntr = 0;

            while (cntr < maxLength || temp > 0)
            {
                int num1 = TryParse(firstString, cntr);

                int num2 = TryParse(secondString, cntr);


                result = num1 + num2 + temp;

                if (result > 9)
                {
                    temp = 1;
                    result -= 10;
                }
                else
                {
                    temp = 0;
                }

                resultString = result + resultString;
                cntr++;

            }

            Console.WriteLine(resultString);
        }

        public static int TryParse(string str, int cntr)
        {
            int num = 0;
            try
            {
                num = int.Parse($"{str[str.Length - cntr - 1]}");
            }
            catch (Exception)
            {

                num = 0;
            }

            return num;
        }
    }
}
