namespace _07.Multiply_big_number
{
    using System;


    public class Strings
    {

        public static void Main()
        {
            var firstString = Console.ReadLine();
            var num2 = int.Parse(Console.ReadLine());

            var resultString = string.Empty;

            var result = 0;
            var temp = 0;           
            var cntr = 0;

            while (cntr < firstString.Length || temp > 0)
            {
                firstString = firstString.TrimStart(new[] { '0' });
                int num1 = TryParse(firstString, cntr);             

                result = num1 * num2 + temp;

                if (result > 9)
                {
                    temp = result / 10;
                    result -= temp * 10;
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
