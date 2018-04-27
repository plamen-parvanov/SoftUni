namespace _15.Neighbour_Wars
{

    using System;


    public class Problem15
    {

        public static void Main()
        {

            var damagePesho = int.Parse(Console.ReadLine());
            var damageGosho = int.Parse(Console.ReadLine());

            var healthPesho = 100;
            var healthGosho = 100;
            var round = 1;
            var winner = string.Empty;

            while (true)
            {
                // hit

                if (round % 2 == 1)
                {
                    healthGosho -= damagePesho;

                    if (healthGosho <= 0)
                    {
                        winner = "Pesho";
                        break;
                    }

                    Console.WriteLine(
                        $"Pesho used Roundhouse kick and reduced Gosho to {healthGosho} health.");
                }
                else
                {
                    healthPesho -= damageGosho;

                    if (healthPesho <= 0)
                    {
                        winner = "Gosho";
                        break;
                    }

                    Console.WriteLine(
                        $"Gosho used Thunderous fist and reduced Pesho to {healthPesho} health.");
                }
                     
                //add health if round % 3 == 0

                if (round % 3 == 0)
                {
                    healthPesho += 10;
                    healthGosho += 10;
                }

                //round++
                round++;
            }

            Console.WriteLine($"{winner} won in {round}th round.");

        }
    }
}
