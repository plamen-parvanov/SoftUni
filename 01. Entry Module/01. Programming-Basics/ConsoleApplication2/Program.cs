using System;


namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstWord = Console.ReadLine();
            var secondWord = Console.ReadLine();
            firstWord = firstWord.ToLower();
            secondWord = secondWord.ToLower();

            if (firstWord == secondWord)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");



        }
    }
}
