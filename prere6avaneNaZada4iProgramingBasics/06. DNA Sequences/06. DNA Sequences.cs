using System;


namespace _06.DNA_Sequences
{
    class Program
    {
        static void Main()
        {
            int maxSum = int.Parse(Console.ReadLine());

            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    for (int k = 1; k < 5; k++)
                    {
                        char special = 'X';
                        if (i + j + k >= maxSum)
                        {
                            special = 'O';
                        }
                        char firstLetter = ReturnLetter(i);
                        char secondLetter = ReturnLetter(j);
                        char thirdLetter = ReturnLetter(k);

                        Console.Write("{0}{1}{2}{3}{0} ",
                            special, firstLetter, secondLetter, thirdLetter);

                        if (k % 4 == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
            

        }

        static char ReturnLetter(int digit)
        {
            char letter = 'A';

            switch (digit)
            {
                case 2:
                    letter = 'C';
                      break;
                case 3:
                    letter = 'G';
                    break;
                case 4:
                    letter = 'T';
                    break;
            }

            return letter;

        }
    }
}
