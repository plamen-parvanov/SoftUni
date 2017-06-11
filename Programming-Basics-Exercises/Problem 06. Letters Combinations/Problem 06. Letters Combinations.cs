using System;


namespace Problem_06.Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char lastLetter = char.Parse(Console.ReadLine());
            char exception = char.Parse(Console.ReadLine());
            int counter = 0;

            for (char i = firstLetter; i <= lastLetter; i++)
            {
               
                for (char j = firstLetter; j <= lastLetter; j++)
                {
                    
                    for (char k = firstLetter; k <= lastLetter; k++)
                    {

                        if (i != exception && j != exception && k != exception)
                        {
                            counter++;
                            Console.Write("{0}{1}{2} ", i, j, k);
                        }
                    }
                }
                
            }

                Console.WriteLine(counter);
        }
    }
}
