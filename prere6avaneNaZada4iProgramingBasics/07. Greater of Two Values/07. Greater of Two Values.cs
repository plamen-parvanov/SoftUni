using System;


namespace _07.Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {

            GetMaxNumber();

        }
        static void GetMaxNumber()
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                int bigger = GetMaxInt(firstNumber, secondNumber);
                Console.WriteLine(bigger);
            }
            else if (type == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                char bigger = GetMaxChar(firstChar, secondChar);
                Console.WriteLine(bigger);

            }
            else if (type == "string")
            {
                
                string bigger = GetBiggerString();
                Console.WriteLine(bigger);
            }

        }
        static int GetMaxInt(int num1, int num2)
        {
            int result = Math.Max(num1, num2);
            return result;
        }
        static char GetMaxChar(char char1, char char2)
        {
            char result = char1;
            if (char1 - char2 < 0)
            {
                result = char2;
            }
            return result;
        }

        static string GetBiggerString()
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();
            string result = secondString;
            if (firstString.CompareTo(secondString) > 0)
            {
                result = firstString;
            }
            return result;
        }
    }
}
