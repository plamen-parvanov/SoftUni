using System;


namespace _06.Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlayer = int.Parse(Console.ReadLine());
            int secondPlayer = int.Parse(Console.ReadLine());
            int maxCombats = int.Parse(Console.ReadLine());
            int cntr = 0;

            for (int i = 1; i <= firstPlayer; i++)
            {
                for (int j = 1; j <= secondPlayer; j++)
                {
                    if (cntr == maxCombats)
                    {
                        break;
                    }
                    Console.Write("({0} <-> {1}) ", i, j);
                    cntr++;
                }
            }

        }
    }
}
