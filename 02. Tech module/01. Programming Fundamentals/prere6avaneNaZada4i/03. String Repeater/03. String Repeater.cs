using System;


namespace _03.String_Repeater
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());

            string repeatedText = RepeatString(repeat, text);
            Console.WriteLine(repeatedText);
        }

        static string RepeatString(int repeat, string text)
        {
            string result = string.Empty;

            for (int i = 0; i < repeat; i++)
            {
                result += text;
            }

            return result;
        }
    }
}
