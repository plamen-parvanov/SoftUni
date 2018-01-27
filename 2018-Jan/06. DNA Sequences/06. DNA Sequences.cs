namespace _06.DNA_Sequences
{

    using System;


    public class Problem06
    {

        public static void Main()
        {

            var matchSum = byte.Parse(Console.ReadLine());

            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    for (int k = 1; k < 5; k++)
                    {
                        var specialSym = GetSpecialSymbol(matchSum, i, j, k);
                        var first = GetNAS(i);
                        var second = GetNAS(j);
                        var third = GetNAS(k);

                        Console.Write($"{specialSym}{first}{second}{third}{specialSym} ");
                    }
                    Console.WriteLine();
                }
                
            }

        }

        public static char GetSpecialSymbol(byte sum, int i, int j, int k)
        {
            var symbol = 'X';

            if (i + j + k >= sum)
            {
                symbol = 'O';
            }

            return symbol;
        }

        public static char GetNAS(int num)
        {
            switch (num)
            {
                case 1:
                    return 'A';
                case 2:
                    return 'C';
                case 3:
                    return 'G';
                default:
                    return 'T';
            }
        }
    }
}
