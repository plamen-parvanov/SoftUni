using System;


namespace _15.Neighbour_Wars
{
    class Program
    {
        static void Main()
        {
            int damagePesho = int.Parse(Console.ReadLine());
            int damageGosho = int.Parse(Console.ReadLine());

            int healthPesho = 100;
            int healthGosho = 100;
            string attackerName = string.Empty;
            string attack = string.Empty;
            string defenderName = string.Empty;
            int defenderHealth = 0;
            int cntr = 1;

            for (int i = 1; ; i++)
            {
                if (cntr == 4)
                {
                    healthPesho += 10;
                    healthGosho += 10;
                    cntr = 1;
                }
                if (i % 2 != 0)
                {
                    attackerName = "Pesho";
                    attack = "Roundhouse kick";
                    defenderName = "Gosho";
                    healthGosho -= damagePesho;
                    defenderHealth = healthGosho;
                }
                else
                {
                    attackerName = "Gosho";
                    attack = "Thunderous fist";
                    defenderName = "Pesho";
                    healthPesho -= damageGosho;
                    defenderHealth = healthPesho;
                }
                if (defenderHealth <= 0)
                {
                    Console.WriteLine($"{attackerName} won in {i}th round.");
                    break;
                }

                cntr++;

                Console.WriteLine(
                    $"{attackerName} used {attack} and reduced {defenderName} to {defenderHealth} health.");              
            }

        }
    }
}
