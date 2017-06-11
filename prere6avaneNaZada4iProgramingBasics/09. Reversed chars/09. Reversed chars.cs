using System;


namespace _09.Reversed_chars
{
    class Program
    {
        static void Main()
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());

            char temp = firstLetter;
            firstLetter = thirdLetter;
            thirdLetter = temp;

            Console.WriteLine("{0}{1}{2}", firstLetter, secondLetter, thirdLetter);

        }
    }
}
