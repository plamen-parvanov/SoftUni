namespace _07.Greater_of_Two_Values
{

    using System;


    public class Problem07
    {

        public static void Main()
        {

            var type = Console.ReadLine();
            var bigger = string.Empty;

            switch (type)
            {
                case "int":
                    var num1 = int.Parse(Console.ReadLine());
                    var num2 = int.Parse(Console.ReadLine());
                    bigger = GetBigger(num1, num2);
                    break;

                case "char":
                    var char1 = char.Parse(Console.ReadLine());
                    var char2 = char.Parse(Console.ReadLine());
                    bigger = GetBigger(char1, char2);
                    break;

                case "string":
                    var string1 = Console.ReadLine();
                    var string2 = Console.ReadLine();
                    bigger = GetBigger(string1, string2);
                    break;
            }

            Console.WriteLine(bigger);

        }

        public static string GetBigger(int num1, int num2)
        {
            var bigger = num2;

            if (num1 > num2)
            {
                bigger = num1;
            }

            return bigger.ToString();
        }

        public static string GetBigger(char char1, char char2)
        {
            var bigger = char2;

            if (char1 > char2)
            {
                bigger = char1;
            }

            return bigger.ToString();
        }

        public static string GetBigger(string str1, string str2)
        {
            var bigger = str2;

            if (str1.CompareTo(str2) >= 0)
            {
                bigger = str1;
            }

            return bigger;
        }

    }
}
