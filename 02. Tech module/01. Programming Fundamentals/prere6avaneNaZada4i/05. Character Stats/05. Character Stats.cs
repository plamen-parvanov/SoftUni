using System;


namespace _05.Character_Stats
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int currHelth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}", name);
            Console.Write("Health: ");
            PrintsCurrFromMax(currHelth, maxHealth);
            Console.Write("Energy: ");
            PrintsCurrFromMax(currEnergy, maxEnergy);


        }

        private static void PrintsCurrFromMax(int current, int max)
        {
            Console.WriteLine("|" + new string('|', current) + new string('.', max - current) + "|");
           
        }
    }
}
