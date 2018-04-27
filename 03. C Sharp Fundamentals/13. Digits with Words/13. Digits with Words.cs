namespace _13.Digits_with_Words
{

    using System;


    public class Problem13
    {

        public static void Main()
        {

            var inputWord = Console.ReadLine();
            short number = 9;

            switch (inputWord)
            {
                case "zero":
                    number = 0;
                    break;

                case "one":
                    number = 1;
                    break;

                case "two":
                    number = 2;
                    break;

                case "three":
                    number = 3;
                    break;

                case "four":
                    number = 4;
                    break;

                case "five":
                    number = 5;
                    break;

                case "six":
                    number = 6;
                    break;

                case "seven":
                    number = 7;
                    break;

                case "eight":
                    number = 8;
                    break;

                case "nine":
                    number = 9;
                    break;
       
            }
            Console.WriteLine(number);            
        }
    }
}
