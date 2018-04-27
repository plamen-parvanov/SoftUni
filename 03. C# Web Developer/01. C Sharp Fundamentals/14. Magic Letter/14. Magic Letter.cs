namespace _14.Magic_Letter
{

    using System;


    public class Problem14
    {

        public static void Main()
        {

            var firstChar = char.Parse(Console.ReadLine());
            var lastChar = char.Parse(Console.ReadLine());
            var exceptChar = char.Parse(Console.ReadLine());

            for (char i = firstChar; i <= lastChar; i++)
            {
                if (i == exceptChar)
                {
                    continue;
                }

                for (char j = firstChar; j <= lastChar; j++)
                {
                    if (j == exceptChar)
                    {
                        continue;
                    }

                    for (char k = firstChar; k <= lastChar; k++)
                    {
                        if (k == exceptChar)
                        {
                            continue;
                        }

                        Console.Write($"{i}{j}{k} ");
                    }
                }
            }

            Console.WriteLine();

        }
    }
}
