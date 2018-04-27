using System;


namespace _06.KombatPokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlayer = int.Parse(Console.ReadLine());
            int secondPlayer = int.Parse(Console.ReadLine());
            int maxKombat = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 1; i <= firstPlayer; i++)
            {
                for (int j = 1; j <= secondPlayer; j++)
                {
                    if (counter == maxKombat)
                    {
                        return;
                    }
                    Console.Write("({0} <-> {1}) ", i, j);
                    counter++;
                }
            }
            Console.WriteLine();
        }
    }
}
