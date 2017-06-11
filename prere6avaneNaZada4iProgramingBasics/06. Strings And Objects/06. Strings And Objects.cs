using System;


namespace _06.Strings_And_Objects
{
    class Program
    {
        static void Main()
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();

            object concatTwoStrings = firstWord + " " + secondWord;
            string textFromObj = (string)concatTwoStrings;

            Console.WriteLine(textFromObj);
        }
    }
}
