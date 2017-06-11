using System;


namespace _14.Magic_Letter
{
    class Program
    {
        static void Main()
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char specialLetter = char.Parse(Console.ReadLine());

            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char j = firstLetter; j <= secondLetter; j++)
                {
                    for (char k = firstLetter; k <= secondLetter; k++)
                    {
                        if (i != specialLetter && j != specialLetter && k != specialLetter)
                        {
                            Console.Write($"{i}{j}{k} ");
                        }
                    }
                    
                }
            }
            Console.WriteLine();
        }
    }
}
